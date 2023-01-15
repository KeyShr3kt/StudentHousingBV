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
        private bool _isAdmin;
        private DateTime? _lastSeenAt;
        private string _IBAN;

        public User()
        { }

        public User(int id, string firstName, string lastName, string emailAddress,
                    string password, string phoneNumber, int possitiveVotes,
                    int negativeVotes, bool isAdmin,
                    DateTime? lastSeenAt, string IBAN)
        {
            this._id = id;
            this._firstName = firstName;
            this._lastName = lastName;
            this._emailAddress = emailAddress;
            this._password = PasswordHasher.Hash(password);
            this._phoneNumber = phoneNumber;
            this._possitiveVotes = possitiveVotes;
            this._negativeVotes = negativeVotes;
            this._isAdmin = isAdmin;
            this._lastSeenAt = lastSeenAt;
            this._IBAN = IBAN;

        }

        public int PositiveVotes { get => this._possitiveVotes; private set => _possitiveVotes = value;  }

        public int NegativeVotes { get => this._negativeVotes; private set => _negativeVotes = value;  }

        public string EmailAddress { get => _emailAddress; set => _emailAddress = value;  }

        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }

        public string FirstName { get => this._firstName; private set => _firstName = value; }

        public string LastName { get => this._lastName; private set => _lastName = value; }

        public int Id { get => this._id; private set => _id = value; }

        public DateTime? LastSeenAt { get => _lastSeenAt; set => _lastSeenAt = value; }

        public bool IsAdmin { get => _isAdmin; private set => _isAdmin = value; }

        public string Password { get => _password; set => _password = value; }

        public string IBAN { get => _IBAN; private set => _IBAN = value; }
    }
}
