using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class User
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _emailAddress;
        private string _password;
        private string _phoneNumber;
        private int _possitiveVotes;
        private int _negativeVotes;
        private int _strikes;
        private bool _isAdmin;
        private DateTime? _lastSeenAt;
        private int roomId = 0;

        public User(int id, string firstName, string lastName, string emailAddress, string password, string phoneNumber, bool isAdmin) 
        {
            this._id = id;
            this._firstName = firstName;
            this._lastName = lastName;
            this._emailAddress = emailAddress;
            this._password = PasswordHasher.Hash(password);
            this._phoneNumber = phoneNumber;
            this._possitiveVotes = 0;
            this._negativeVotes = 0;
            this._strikes = 0;
            this._isAdmin = isAdmin;
            this._lastSeenAt = null;

        }
        public int PossitiveVotes { get => this._possitiveVotes; }
        public int NegativeVotes { get => this._negativeVotes; }
        public int Strikes { get => this._strikes; }
        public string EmailAddress { get => _emailAddress;}
        public string PhoneNumber { get => _phoneNumber; }
        public string FirstName { get => this._firstName;}
        public string LastName { get => this._lastName; }
        public int Id { get => this._id;}
        public DateTime? LastSeenAt { get => _lastSeenAt; set => _lastSeenAt = value; }
        public bool isAdmin { get => _isAdmin;}
        public string Password { get => _password; set => _password = PasswordHasher.Hash(value); }
    }
}
