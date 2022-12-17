using StudentHousingBV.controllers;
using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.repositories
{
    public class UserRepository
    {


        private List<User> toListOfUsers(SqlDataReader reader)
        {
            List<User> result = new();
            while (reader.Read())
            {
                User user = new User();
                for (int inc = 0; inc < reader.FieldCount; inc++)
                {
                    user.GetType().GetProperty(reader.GetName(inc)).SetValue(user, reader.GetValue(inc), null);
                }
                result.Add(user);
            }
            return result;
        }

        private List<User> ExecuteReaderUsers(string sql, Dictionary<string, string> parameters)
        {
            List<User> users = new();
            try
            {
                using (SqlConnection conn = new SqlConnection(UnitOfWork.CONNECTION_STRING))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    foreach (KeyValuePair<string, string> entry in parameters)
                    {
                        cmd.Parameters.AddWithValue(entry.Key, entry.Value);
                    }
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        users.AddRange(toListOfUsers(reader));
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"The connection is no longer available! + {ex.Message}");
            }

            return users;
        }

        private void ExecuteNonQuery(string sql, Dictionary<string, string> parameters)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(UnitOfWork.CONNECTION_STRING))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    foreach (KeyValuePair<string, string> entry in parameters)
                    {
                        cmd.Parameters.AddWithValue(entry.Key, entry.Value);
                    }
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"The connection is no longer available!\n + {ex.Message}");
            }
        }


        public List<User> GetAll() 
        {
          //  string sql = "SELECT * FROM USER;";
          //  return ExecuteReaderUsers(sql, new());

            return new List<User> {
                new User(1, "Nela", "Geraldo", "nela@mail.com", "password", "+3165123", 10, 99, false, DateTime.UtcNow, "NL71ABNA2405012723"),
                new User(2, "Quanna", "Cevdet", "quanna@mail.com", "password", "+31434342", 7, 1, false, DateTime.UtcNow, "NL78ABNA3470416656"),
                new User(3, "Kalina", "Ravi", "admin", "admin", "+3154i2o", 90, 37, true, null, "NL23INGB4666097791")
            }; 
        }
        public User Get(int id) 
        {
           /* string sql = "SELECT * FROM USER WHERE USER.userId = @id;";
            Dictionary<string, string> parameters = new()
            {
                { "@name", id.ToString() }
            };
            return ExecuteReaderUsers(sql, parameters).First(); */
           return new User(1, "firstName", "LastName", "email", "password", "phonenumber", 1, 0, true, DateTime.UtcNow, "NL75ABNA4887467303"); 
        }
        public void Delete(User user) { return; }
        public int Insert(string firstName, string lastName, string email, string phoneNumber, bool isAdmin) { return 1; }
        public void Update(User user) { return;  }

        public List<User> GetAdminsInBuildingId(int buildingId)
        {
            return new List<User>();
        }

        public List<User> GetAllUsersInBuildingId(int buildingId)
        {
            return new List<User>();
        }

        public List<User> GetAllAdmins()
        {
           // string sql = "SELECT * FROM USER WHERE USER.isAdmin = 1;";
           // return ExecuteReaderUsers(sql, new());
            return new List<User>();
        }

        public int CountInBuildingId(int id)
        {
            return 3;
        }
    }
}
