using StudentHousingBV.models;
using System.Data.SqlClient;
using System.Runtime.Serialization;

namespace StudentHousingBV.repositories
{
    public class ReactionRepository
    {
        private string _connectionString;

        public ReactionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #region Helpers

        private List<T>? sqlCommandHelper<T>(string sql, object parameters, Func<T> defaultCtor, bool nonQuery, Func<int, bool> nonQueryPredicate)
            where T : notnull
        {
            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            foreach (var prop in parameters.GetType().GetProperties())
            {
                cmd.Parameters.AddWithValue($"@{prop.Name}", prop.GetValue(parameters));
            }
            conn.Open();
            if (nonQuery)
            {
                int affectedRows = cmd.ExecuteNonQuery();
                if (!nonQueryPredicate(affectedRows))
                {
                    throw new NonQueryPredicateException("Non-query predicate failed");
                }
                return null;
            }
            using var reader = cmd.ExecuteReader();
            List<T> result = new();
            while (reader.Read())
            {
                T? t = defaultCtor();
                if (t.GetType().IsValueType)
                {
                    if (reader.FieldCount > 1)
                    {
                        throw new Exception("cannot assign result from query with more than one column to a value type");
                    }
                    if (reader.IsDBNull(0))
                    {
                        t = default;
                    } else
                    {
                        t = (T)reader.GetValue(0);
                    }
                }
                else
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var prop = t.GetType().GetProperty(reader.GetName(i));
                        if (prop == null)
                        {
                            throw new Exception($"field {reader.GetName(i)} does not exist in {t.GetType().Name}");
                        }
                        if (reader.IsDBNull(i))
                        {
                            prop!.SetValue(t, null);
                        }
                        else if (prop?.PropertyType.Name == "Boolean")
                        {
                            prop!.SetValue(t, (short)reader.GetValue(i) != 0);
                        }
                        else
                        {
                            prop!.SetValue(t, reader.GetValue(i));
                        }
                    }
                }
                result.Add(t);
            }
            return result;
        }

        private List<T> sqlQueryHelper<T>(string sql, object parameters, Func<T> defaultCtor)
            where T : notnull
        {
            return sqlCommandHelper(sql, parameters, defaultCtor, false, _ => true)!;
        }

        private bool sqlNonQueryHelper(string sql, object parameters, Func<int, bool> predicate)
        {
            try
            {
                sqlCommandHelper<object>(sql, parameters, () => default!, true, predicate);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private T? sqlOneHelper<T>(string sql, object parameters, Func<T> defaultCtor)
            where T : notnull
        {
            return sqlQueryHelper(sql, parameters, defaultCtor).FirstOrDefault();
        }

        [Serializable]
        private class NonQueryPredicateException : Exception
        {
            public NonQueryPredicateException()
            {
            }

            public NonQueryPredicateException(string? message) : base(message)
            {
            }

            public NonQueryPredicateException(string? message, Exception? innerException) : base(message, innerException)
            {
            }

            protected NonQueryPredicateException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        #endregion

        public Reaction? Get(int id)
        {
            try
            {
                return sqlOneHelper<Reaction>("SELECT * FROM [REACTION] WHERE [REACTION].[Id] = @id", new { id }, () => new());
            }
            catch
            {
                return null;
            }
        }

        public bool Update(Reaction reaction) => sqlNonQueryHelper("UPDATE [REACTION]" +
            " SET [CreatorId] = @creatorId, [AgreementId] = @agreementId, [IsPositive] = @isPositive" +
            " WHERE [Id] = @id;" +
            "UPDATE [USER]" +
            " SET [PositiveVotes] += 1" +
            " WHERE [Id] = @creatorId AND @isPositive = 1;" +
            "UPDATE [USER]" +
            " SET [NegativeVotes] += 1" +
            " WHERE [Id] = @creatorId AND @isPositive = 0;",
            new { creatorId = reaction.CreatorId, agreementId = reaction.AgreementId, isPositive = reaction.IsPositive ? 1 : 0, id = reaction.Id },
            affectedRows => affectedRows == 1);

        public bool Delete(Reaction reaction) => sqlNonQueryHelper("DELETE FROM [REACTION]" +
            " WHERE [Id] = @id;" +
            "UPDATE [USER]" +
            " SET [PositiveVotes] -= 1" +
            " WHERE [Id] = @creatorId AND @isPositive = 1;" +
            "UPDATE [USER]" +
            " SET [NegativeVotes] -= 1" +
            " WHERE [Id] = @creatorId AND @isPositive = 0;",
            new { id = reaction.Id, creatorId = reaction.CreatorId, isPositive = reaction.IsPositive ? 1 : 0 },
            affectedRows => affectedRows == 2);

        public Reaction? GetUserReactionOnAgreement(int userId, int agreementId) => sqlOneHelper<Reaction>("SELECT TOP 1 * FROM [REACTION]" +
            " WHERE [CreatorId] = @creatorId AND [Agreementid] = @agreementId",
            new { creatorId = userId, agreementId },
            () => new());

        /// <summary>
        ///  Inserts a reaction only if no other reaction with the same creator and agreement exists
        /// </summary>
        public bool InsertUnique(Reaction reaction)
        {
            try
            {
                int id = sqlOneHelper<int>("INSERT INTO [REACTION]" +
                    " ([CreatorId], [AgreementId], [IsPositive])" +
                    " OUTPUT Inserted.[Id]" +
                    " SELECT" +
                    " @creatorId, @agreementId, @isPositive" +
                    " WHERE NOT EXISTS" +
                    " (SELECT * FROM [REACTION]" +
                    " WHERE [CreatorId] = @creatorId AND [AgreementId] = @agreementId);" +
                    "UPDATE [USER]" +
                    " SET [PositiveVotes] += 1" +
                    " WHERE [Id] = @creatorId AND @isPositive = 1 AND SCOPE_IDENTITY() IS NOT NULL;" +
                    "UPDATE [USER]" +
                    " SET [NegativeVotes] += 1" +
                    " WHERE [Id] = @creatorId AND @isPositive = 0 AND SCOPE_IDENTITY() IS NOT NULL;",
                    new { creatorId = reaction.CreatorId, agreementId = reaction.AgreementId, isPositive = reaction.IsPositive ? 1 : 0 },
                    () => default);
                reaction.Id = id;
                try
                {
                    sqlNonQueryHelper("UPDATE [AGREEMENT]" +
                        " SET [AGREEMENT].[IsAccepted] = 1" +
                        " WHERE" +
                        "   [AGREEMENT].[EventId] = @agreementId" +
                        "   AND" +
                        "   (SELECT COUNT([REACTION].[Id]) FROM [REACTION]" +
                        "       WHERE [REACTION].[AgreementId] = @agreementId" +
                        "       AND [REACTION].[IsPositive] = 1)" +
                        "   /" +
                        "   CAST((SELECT COUNT([USER].[Id]) FROM [AGREEMENT]" +
                        "       JOIN [EVENT] ON [EVENT].[Id] = [AGREEMENT].[EventId]" +
                        "       JOIN [BUILDING] ON [BUILDING].[Id] = [EVENT].[BuildingId]" +
                        "       JOIN [ROOM] ON [ROOM].[BuildingId] = [Building].[Id]" +
                        "       JOIN [USER] ON [USER].[Id] = [ROOM].[UserId]" +
                        "       WHERE [AGREEMENT].[EventId] = @agreementId) AS REAL)" +
                        "   > 0.7;",
                        new { agreementId = reaction.AgreementId },
                        _rowsAffected => true);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int? CountReactionsForAgreement(int agreementId, bool isPositive)
        {
            try
            {
                return sqlOneHelper<int>("SELECT COUNT(*) FROM [REACTION]" +
                    " WHERE [AgreementId] = @agreementId AND [IsPositive] = @isPositive" +
                    " GROUP BY [AgreementId]",
                    new { agreementId, isPositive = isPositive ? 1 : 0 },
                    () => default);
            }
            catch
            {
                return null;
            }
        }
    }
}
