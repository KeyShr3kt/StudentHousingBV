using Microsoft.VisualBasic.ApplicationServices;
using StudentHousingBV.controllers;
using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using User = StudentHousingBV.models.User;

namespace StudentHousingBV.repositories
{
    public class RoomRepository
    {
        #region Helper Functions
        public static T ConvertFromDBVal<T>(object obj) // https://stackoverflow.com/questions/870697/unable-to-cast-object-of-type-system-dbnull-to-type-system-string
        {
            if (obj == null || obj == DBNull.Value)
            {
                return default(T); // returns the default value for the type
            }
            else
            {
                return (T)obj;
            }
        }

        #endregion

        private List<Room> ToListOfRooms(SqlDataReader reader)
        {
            List<Room> result = new();
            while (reader.Read())
            {
                Room room = new Room();
                for (int inc = 0; inc < reader.FieldCount; inc++)
                {
                    if (inc == 2)
                    {
                        if (int.TryParse(ConvertFromDBVal<string>(reader.GetValue(inc)), out int userId))
                        {
                            room.GetType().GetProperty(reader.GetName(inc)).SetValue(room, userId, null);
                        }
                        else
                        {
                            room.GetType().GetProperty(reader.GetName(inc)).SetValue(room, null, null);
                        }
                    }
                    else
                    {
                        room.GetType().GetProperty(reader.GetName(inc)).SetValue(room, reader.GetValue(inc), null);
                    }
                }
                result.Add(room);
            }
            return result;
        }

        private List<Room> ExecuteReader(string sql, Dictionary<string, string?> parameters)
        {
            List<Room> rooms = new();
            try
            {
                using (SqlConnection conn = new SqlConnection(UnitOfWork.CONNECTION_STRING))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    foreach (KeyValuePair<string, string?> entry in parameters)
                    {
                        cmd.Parameters.AddWithValue(entry.Key, entry.Value);
                    }
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        rooms.AddRange(ToListOfRooms(reader));
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"The connection is no longer available!\n + {ex.Message}");
            }
            return rooms;
        }

        private int ExecuteNonQuery(string sql, Dictionary<string, string?> parameters)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(UnitOfWork.CONNECTION_STRING))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    foreach (KeyValuePair<string, string?> entry in parameters)
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

        public List<Room> GetAll() 
        {
            string sql = "SELECT * FROM [ROOM];";
            return ExecuteReader(sql, new());
        }

        public Room Get(int id)
        {
            string sql = "SELECT * FROM [ROOM] WHERE [ROOM].Id = @id;";
            Dictionary<string, string> parameters = new()
            {
                { "@id", id.ToString() }
            };
            return ExecuteReader(sql, parameters).First();
        }

        public int Insert(string type, int userId, string name, int buildingId)
        {
            string sql = "INSERT INTO [ROOM] (Type, UserId, Name, BuildingId)" +
                " VALUES (@type, @userId, @name, @buildingId)";
            Dictionary<string, string?> parameters = new()
            {
                { "@type", type },
                { "@userId", userId.ToString() },
                { "@name", name },
                { "@buildingId", buildingId.ToString() }
            };
            return ExecuteNonQuery(sql, parameters);
        }

        public int Update(Room room)
        {
            string sql = "UPDATE [ROOM]" +
                            " SET Type = @type, UserId = @userId, Name = @name, BuildingId = @buildingId" +
                            " WHERE Id = @id;";
            Dictionary<string, string?> parameters = new()
            {
                { "@id", room.Id.ToString() },
                { "@type", room.Type },
                { "@userId", room.UserId.ToString() },
                { "@name", room.Name },
                { "@buildingId", room.BuildingId.ToString() }
            };
            return ExecuteNonQuery(sql, parameters);
        }

        public int Delete(Room room)
        {
            string sql = "DELETE FROM [ROOM]" +
                            " WHERE Id = @id;";
            Dictionary<string, string?> parameters = new()
            {
                { "@id", room.Id.ToString() }
            };
            return ExecuteNonQuery(sql, parameters);
        }

        public Room GetForUser(User user)
        {
            string sql = "SELECT [ROOM].* " +
                " FROM [ROOM] INNER JOIN [USER] ON [ROOM].UserId = [USER].Id " +
                " WHERE [USER].Id = @userId;";
            Dictionary<string, string> parameters = new()
            {
                { "@userId", user.Id.ToString() }
            };
            return ExecuteReader(sql, parameters).First();
        }

        public List<Room> GetAvailableBedroomsForBuildingId(int id) 
        {
            string sql = "SELECT [ROOM].*" +
                " FROM [ROOM] INNER JOIN [BUILDING] ON [ROOM].BuildingId = [BUILDING].Id" +
                " WHERE CONVERT(varchar, [ROOM].Type) = @type AND [ROOM].UserId IS NULL AND [BUILDING].Id = @id;";
            Dictionary<string, string> parameters = new()
            {
                { "@type", "Bedroom" },
                { "@id", id.ToString() }
            };
            return ExecuteReader(sql, parameters);
        }

        public int SetRoomToUserId(int roomId, int userId) 
        {
            string sql = "UPDATE [ROOM]" +
                            " SET UserId = @userId" +
                            " WHERE Id = @roomId;";
            Dictionary<string, string?> parameters = new()
            {
                { "@userId", userId.ToString() },
                { "@roomId", roomId.ToString() }
            };
            return ExecuteNonQuery(sql, parameters);
        }
    }
}
