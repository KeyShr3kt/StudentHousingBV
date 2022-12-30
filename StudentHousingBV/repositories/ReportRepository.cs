using StudentHousingBV.controllers;
using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.repositories
{
    public class ReportRepository
    {
        private List<Report> ToListOfReports(SqlDataReader reader)
        {
            List<Report> result = new();
            while (reader.Read())
            {
                Report report = new Report();
                for (int inc = 0; inc < reader.FieldCount; inc++)
                {
                    report.GetType().GetProperty(reader.GetName(inc)).SetValue(report, reader.GetValue(inc), null);
                }
                result.Add(report);
            }
            return result;
        }

        private List<Report> ExecuteReader(string sql, Dictionary<string, string> parameters)
        {
            List<Report> reports = new();
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
                        reports.AddRange(ToListOfReports(reader));
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"The connection is no longer available!\n + {ex.Message}");
            }
            return reports;
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

        public List<Report> GetAll()
        {
            string sql = "SELECT * FROM [REPORT];";
            return ExecuteReader(sql, new());
        }

        public Report Get(int id)
        {
            string sql = "SELECT * FROM [REPORT] WHERE [REPORT].Id = @id;";
            Dictionary<string, string> parameters = new()
            {
                { "@id", id.ToString() }
            };
            return ExecuteReader(sql, parameters).First();
        }

        public int Insert(string type, int userId, string name, int buildingId)
        {
            string sql = "INSERT INTO [ROOM] (Type, UserId, Name, BuildingId)" +
                "VALUES (@type, @userId, @name, @buildingId)";
            Dictionary<string, string?> parameters = new()
            {
                { "@type", type },
                { "@userId", userId.ToString() },
                { "@name", name },
                { "@buildingId", buildingId.ToString() }
            };
            return ExecuteNonQuery(sql, parameters);
        }

        public int Update(Report report)
        {
            string sql = "UPDATE [REPORT]" +
                            "SET Title = @title, Description = @description, CreatedAt = GETDATE(), CreatorId = @creatorId, BuildingId = @buildingId, TargetedToEventId = @targetedToEventId" +
                            "WHERE Id = @id;";
            Dictionary<string, string> parameters = new()
            {
                { "@id", report.Id.ToString() },
                { "@title", report.Title },
                { "@description", report.Description },
                { "@creatorId", report.CreatorId.ToString() },
                { "@buildingId", report.BuildingId.ToString() },
                { "@targetedToEventId", report.TargetedToEventId.ToString() }
            };
            return ExecuteNonQuery(sql, parameters);
        }

        public int Delete(Report report)
        {
            string sql = "DELETE FROM [REPORT]" +
                            "WHERE Id = @id;";
            Dictionary<string, string?> parameters = new()
            {
                { "@id", report.Id.ToString() }
            };
            return ExecuteNonQuery(sql, parameters);
        }

        public void MarkAsReviewed(int id)
        {
            // report.isReviewed = true;
        }

        public List<Report> GetAllInBuildingId(int id)
        {
            string sql = "SELECT [REPORT].*" +
                "FROM [REPORT] INNER JOIN [BUILDING] ON [REPORT].BuildingId = [BUILDING].Id" +
                "WHERE [REPORT].BuildingId = @id";
            Dictionary<string, string?> parameters = new()
            {
                { "@id", id.ToString() }
            };
            return ExecuteReader(sql, parameters);
        }

        public List<Report> GetAllInBuildingIdForReview(int id)
        {
            return new List<Report>();
        }

        public List<Report> GetAllForReview()
        {
            // isReviewd == false
            return new List<Report>();
        }
    }
}
