using Microsoft.VisualBasic.ApplicationServices;
using StudentHousingBV.controllers;
using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.repositories
{
    public class BuildingRepository
    {
        private List<Building> ToListOfBuildings(SqlDataReader reader)
        {
            List<Building> result = new();
            while (reader.Read())
            {
                Building building = new Building();
                for (int inc = 0; inc < reader.FieldCount; inc++)
                {
                    building.GetType().GetProperty(reader.GetName(inc)).SetValue(building, reader.GetValue(inc), null);
                }
                result.Add(building);
            }
            return result;
        }

        private List<Building> ExecuteReader(string sql, Dictionary<string, string> parameters)
        {
            List<Building> buildings = new();
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
                        buildings.AddRange(ToListOfBuildings(reader));
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"The connection is no longer available!\n + {ex.Message}");
            }
            return buildings;
        }

        private int ExecuteNonQuery(string sql, Dictionary<string, string> parameters)
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
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"The connection is no longer available!\n + {ex.Message}");
                return -1;
            }
        }

        private int ExecuteScalar(string sql, Dictionary<string, string> parameters)
        {
            int result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(UnitOfWork.CONNECTION_STRING))
                {

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        result = (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"The connection is no longer available!\n + {ex.Message}");
            }
            return result;
        }

        public List<Building> GetAll() 
        {
            string sql = "SELECT * FROM [BUILDING];";
            return ExecuteReader(sql, new());
        }

        public Building Get(int id)
        {
            string sql = "SELECT * FROM [BUILDING] WHERE [BUILDING].Id = @id;";
            Dictionary<string, string> parameters = new()
            {
                { "@id", id.ToString() }
            };
            return ExecuteReader(sql, parameters).First();
        }

        public int Insert(string address)
        {
            string sql = "INSERT INTO [BUILDING] (Address)" +
                "VALUES (@address)";
            Dictionary<string, string> parameters = new()
            {
                { "@address", address }
            };
            return ExecuteNonQuery(sql, parameters);
        }

        public int Update(Building building)
        {
            string sql = "UPDATE [BUILDING] SET Address = @address" +
                            "WHERE Id = @id;";
            Dictionary<string, string> parameters = new()
            {
                { "@id", building.Id.ToString() },
                { "@address", building.Address }
            };
            return ExecuteNonQuery(sql, parameters);
        }

        public int Delete(Building building)
        {
            string sql = "DELETE FROM [BUILDING]" +
                            "WHERE Id = @id AND Address = @address;";
            Dictionary<string, string> parameters = new()
            {
                { "@id", building.Id.ToString() },
                { "@address", building.Address }
            };
            return ExecuteNonQuery(sql, parameters);
        }

        public Building GetForUser(models.User user)
        {
            string sql = "SELECT[BUILDING].Id, [BUILDING].Address" +
                            "FROM[BUILDING] INNER JOIN[ROOM] ON[BUILDING].Id = [ROOM].BuildingId" +
                            "INNER JOIN[USER] ON[USER].Id = [ROOM].UserId" +
                            "WHERE[USER].Id = @userId;";
            Dictionary<string, string> parameters = new()
            {
                { "@userId", user.Id.ToString() }
            };
            return ExecuteReader(sql, parameters).First();
        }
    }
}
