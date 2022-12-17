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

        public int PossitiveVotes { get => this._possitiveVotes; private set => _possitiveVotes = value;  }
        public int NegativeVotes { get => this._negativeVotes; private set => _negativeVotes = value;  }
        public string EmailAddress { get => _emailAddress; private set => _emailAddress = value;  }
        public string PhoneNumber { get => _phoneNumber; private set => _phoneNumber = value; }
        public string FirstName { get => this._firstName; private set => _firstName = value; }
        public string LastName { get => this._lastName; private set => _lastName = value; }
        public int Id { get => this._id; private set => _id = value; }
        public DateTime? LastSeenAt { get => _lastSeenAt; set => _lastSeenAt = value; }
        public bool isAdmin { get => _isAdmin; private set => _isAdmin = value; }
        public string Password { get => _password; set => _password = PasswordHasher.Hash(value); }

        public string IBAN { get => _IBAN; private set => _IBAN = value; }
        public User(int id, string firstName, string lastName, string emailAddress, 
                    string password, string phoneNumber, int possitiveVotes, 
                    int negativeVotes, bool isAdmin, 
                    DateTime? lastSeenAt, string IBAN) 
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
            this.PossitiveVotes = possitiveVotes;
            this.NegativeVotes = negativeVotes;
            this.isAdmin = isAdmin;
            this.LastSeenAt = lastSeenAt;
            this.IBAN = IBAN;

        }

        public User() { }

    }
}
