using StudentHousingBV.models;
using System.Data.SqlClient;
using Task = StudentHousingBV.models.Task;

namespace StudentHousingBV.repositories
{
    public partial class EventRepository
    {
        private string _connectionString;

        public EventRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Delete(int id)
        {
            try
            {
                string sql = "DELETE FROM [TASK] WHERE [TASK].[Id] = @id;";
                sql += "DELETE FROM [RULE] WHERE [RULE].[Id] = @id";
                sql += "DELETE FROM [AGREEMENT] WHERE [AGREEMENT].[Id] = @id;";
                sql += "DELETE FROM [EVENT] WHERE [EVENT].[Id] = @id";
                sqlNonQueryHelper(sql, new { id });
            } catch
            {
                // nothing
            }
        }

        private List<T>? sqlCommandHelper<T>(string sql, object parameters, Func<T> defaultCtor, bool nonQuery)
            where T: notnull
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
                cmd.ExecuteNonQuery();
                return null;
            }
            using var reader = cmd.ExecuteReader();
            List<T> result = new();
            while (reader.Read())
            {
                T t = defaultCtor();
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
                result.Add(t);
            }
            return result;
        }

        private List<T> sqlQueryHelper<T>(string sql, object parameters, Func<T> defaultCtor)
            where T: notnull
        {
            return sqlCommandHelper(sql, parameters, defaultCtor, false)!;
        }
        
        private void sqlNonQueryHelper(string sql, object parameters)
        {
            sqlCommandHelper<object>(sql, parameters, () => default!, true);
        }

        private T? sqlOneHelper<T>(string sql, object parameters, Func<T> defaultCtor)
            where T: notnull
        {
            return sqlQueryHelper(sql, parameters, defaultCtor).FirstOrDefault();
        }


        public Event? Get(int id)
        {
            Event? evt = sqlOneHelper<Event>("SELECT TOP 1 * FROM [EVENT] WHERE [EVENT].[Id] = @id",
                new { id },
                () => new());
            return evt;
        }
    }
}
