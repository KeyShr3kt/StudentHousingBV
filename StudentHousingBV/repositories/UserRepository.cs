using StudentHousingBV.controllers;
using StudentHousingBV.models;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using User = StudentHousingBV.models.User;

namespace StudentHousingBV.repositories
{
    public class UserRepository
    {
        private void sendMail(string email, string passwordToSend)
        {
            // Set the sender's email, password and recipient's email addresses
            string sender = "studenthousing404@outlook.com";
            string password = "Studenthousingbv404";
            string recipient = email;

            string subject = "Student Housing BV - Temporary Passsword";
            string body = $"Your temporary password for the Student Housing BV Panel is: {passwordToSend}. \n" +
                $"After the first login, you will be prompted to change it to your intended one! \n" +
                $"\n" +
                $"Kind regards, \n" +
                $"Student Housing BV Team \n" +
                $"\n" +
                $"Please be aware that this is email was sent automatically and no replies should be sent to this address!";

            // Create a new MailMessage object
            MailMessage message = new MailMessage(sender, recipient, subject, body);

            // Create a new SmtpClient object to send the email
            SmtpClient client = new SmtpClient("smtp.office365.com", 587);
            client.EnableSsl = true;

            // Set the client's credentials
            client.Credentials = new NetworkCredential(sender, password);

            // Send the email
            client.Send(message);
        }

        private List<User> toListOfUsers(SqlDataReader reader)
        {
            List<User> result = new();
            while (reader.Read())
            {
                User user = new User();
                for (int inc = 0; inc < reader.FieldCount; inc++)
                {

                    //Type type = user.GetType();
                    //var prop = type.GetProperty(reader.GetName(inc));
                    //prop.SetValue(user, reader.GetValue(inc));
                    if (inc == 8)
                    {
                        if (Convert.ToInt16(reader.GetValue(inc)) > 0) // boolean
                        {
                            user.GetType().GetProperty(reader.GetName(inc)).SetValue(user, true, null);
                        } else
                        {
                            user.GetType().GetProperty(reader.GetName(inc)).SetValue(user, false, null);
                        }
                        
                    } else if (inc == 9)
                    {
                       if (reader.GetValue(inc) == DBNull.Value) // DateTime parse problem DBNull.Value != null
                        {
                            user.GetType().GetProperty(reader.GetName(inc)).SetValue(user, null, null);
                        } else
                        {
                            user.GetType().GetProperty(reader.GetName(inc)).SetValue(user, (DateTime?)reader.GetValue(inc), null);
                        }
                    }
                    else
                    {
                        user.GetType().GetProperty(reader.GetName(inc)).SetValue(user, reader.GetValue(inc), null);
                    }
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

        private int ExecuteScalarUsers(string sql, Dictionary<string, string> parameters)
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
                MessageBox.Show($"The connection is no longer available! + {ex.Message}");
            }

            return result;
        }

        public List<User> GetAll() 
        {
              string sql = "SELECT * FROM [USER];";
              return ExecuteReaderUsers(sql, new());

           /* return new List<User> {
                new User(1, "Nela", "Geraldo", "nela@mail.com", "password", "+3165123", 10, 99, false, DateTime.UtcNow, "NL71ABNA2405012723"),
                new User(2, "Quanna", "Cevdet", "quanna@mail.com", "password", "+31434342", 7, 1, false, DateTime.UtcNow, "NL78ABNA3470416656"),
                new User(3, "Kalina", "Ravi", "admin", "admin", "+3154i2o", 90, 37, true, DateTime.Now, "NL23INGB4666097791")
            }; */
        }
        public User Get(int id) 
        {
            string sql = "SELECT * FROM [USER] WHERE [USER].Id = @id;";
            Dictionary<string, string> parameters = new()
            {
                { "@id", id.ToString() }
            };
            return ExecuteReaderUsers(sql, parameters).First(); 
          // return new User(1, "firstName", "LastName", "email", "password", "phonenumber", 1, 0, true, DateTime.UtcNow, "NL75ABNA4887467303"); 
        }
       
        public int Insert(string firstName, string lastName, string email, string phoneNumber, bool isAdmin, string IBAN) 
        {
            string sql = "INSERT INTO [USER] (FirstName, LastName, EmailAddress, Password, PhoneNumber, PositiveVotes, NegativeVotes, IsAdmin, IBAN)" +
                " VALUES (@firstName, @lastName, @email, @password , @phoneNumber, 0, 0, @isAdmin, @IBAN)";

            string password = DateTime.Now.Ticks.ToString("x");
            string hashedPassword = PasswordHasher.Hash(password);

            Dictionary<string, string> parameters = new()
            {
                { "@firstName", firstName },
                { "@lastName", lastName },
                { "@email", email},
                { "@password", hashedPassword },
                { "@phoneNumber", phoneNumber},
                { "@isAdmin", Convert.ToInt32(isAdmin).ToString()},
                { "@IBAN", IBAN}
            };

            ExecuteNonQuery(sql, parameters);
            string query = "SELECT Id FROM [USER] WHERE Id = (SELECT MAX(Id) FROM [USER])";
            try
            {
                sendMail(email, password);
            }
            catch
            {
                MessageBox.Show("Mail cannot be sent to the specified address!");
            }
            return ExecuteScalarUsers(query, new()); 
        }
        public void Update(User user) 
        {
            string sql = "UPDATE [USER] SET FirstName = @FirstName, LastName = @LastName, " +
                            "EmailAddress = @EmailAddress, Password = @Password, PhoneNumber = @PhoneNumber, " +
                            "PositiveVotes = @PositiveVotes, NegativeVotes = @NegativeVotes, IsAdmin = @IsAdmin, " +
                            "LastSeenAt = GETDATE(), IBAN = @IBAN " +
                            "WHERE Id = @Id;";

            Dictionary<string, string> parameters = new()
            {
                { "@id", user.Id.ToString() },
                { "@FirstName", user.FirstName },
                { "@LastName", user.LastName },
                { "@EmailAddress", user.EmailAddress },
                { "@Password", user.Password },
                { "@PhoneNumber", user.PhoneNumber },
                { "@PositiveVotes", user.PositiveVotes.ToString() },
                { "@NegativeVotes", user.NegativeVotes.ToString() },
                { "@IsAdmin", Convert.ToInt16(user.IsAdmin).ToString()},
                { "@IBAN", user.IBAN }
            };
            ExecuteNonQuery( sql, parameters );
        }

        public List<User> GetAdminsInBuildingId(int buildingId)
        {
            string sql = "select u.* " +
                            "from [USER] as u " +
                            "inner join [ROOM] as r " +
                            "on r.UserId = u.Id " +
                            "inner join BUILDING as b " +
                            "on r.BuildingId = b.Id " +
                            "where u.IsAdmin = 1 and r.BuildingId = @buildingId;";

            Dictionary<string, string> parameters = new()
            {
                { "@buildingId", buildingId.ToString() }
            };


            return ExecuteReaderUsers( sql, parameters);
        }

        public List<User> GetAllUsersInBuildingId(int buildingId)
        {
            string sql = "select u.* " +
                            "from [USER] as u " +
                            "inner join [ROOM] as r " +
                            "on r.UserId = u.Id " +
                            "inner join BUILDING as b " +
                            "on r.BuildingId = b.Id " +
                            "where r.BuildingId = @buildingId;";

            Dictionary<string, string> parameters = new()
            {
                { "@buildingId", buildingId.ToString() }
            };
            return ExecuteReaderUsers(sql, parameters);
        }

        public List<User> GetAllAdmins()
        {
            string sql = "select * " +
                            "from [USER] " +
                            "where IsAdmin = 1;";
           
            return ExecuteReaderUsers(sql, new());
        }

        public int CountInBuildingId(int id)
        {
            string sql = "select COUNT(*) " +
                        "from [USER] as u " +
                        "inner join [ROOM] as r " +
                        "on r.UserId = u.Id " +
                        "inner join BUILDING as b " +
                        "on r.BuildingId = b.Id " +
                        "where r.BuildingId = @buildingId;";

            Dictionary<string, string> parameters = new()
            {
                { "@buildingId", id.ToString() }
            };
            return ExecuteScalarUsers(sql, parameters);
           
        }

        public User GetCreatorOfEventId(int id)
        {
            string sql = "select u.* " +
                            "from [EVENT] as e " +
                            "inner join [USER] as u " +
                            "on e.CreatorId = u.Id " +
                            "where e.Id = @Id;";

            Dictionary<string, string> parameters = new()
            {
                { "@Id", id.ToString() }
            };

            return ExecuteReaderUsers(sql, parameters).First();

           // return new User(1, "Nela", "Geraldo", "nela@mail.com", "password", "+3165123", 10, 99, false, DateTime.UtcNow, "NL51INGB9304669103");
        }
    }
}
