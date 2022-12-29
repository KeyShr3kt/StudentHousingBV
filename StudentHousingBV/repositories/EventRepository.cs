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
                using SqlConnection conn = new(_connectionString);
                using SqlCommand cmd = conn.CreateCommand();
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
                    t.GetType().GetProperty(reader.GetName(i))!.SetValue(t, reader.GetValue(i));
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
            return sqlQueryHelper(sql, parameters, defaultCtor).First();
        }


        public Event? Get(int id)
        {
            Event? evt = sqlOneHelper<Event>("SELECT * FROM [EVENT] WHERE [EVENT].[Id] = @id LIMIT 1",
                new { id },
                () => new());
            return evt;
        }

        public User? GetCreatorOfEventId(int id)
        {
            return sqlOneHelper<User>("SELECT [USER].* FROM [EVENT] WHERE [EVENT].[Id] = @id JOIN [USER] ON [USER].[Id] = [EVENT].[CreatorId] LIMIT 1",
                new { id },
                () => new());
        }
    }
}
