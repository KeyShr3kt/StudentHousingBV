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

        public User(int id, string firstName, string lastName, string emailAddress, string password, string phoneNumber, bool isAdmin) 
        {
            this._id = id;
            this._firstName = firstName;
            this._lastName = lastName;
            this._emailAddress = emailAddress;
            this._password = SecurePassword.Hash(password);
            this._phoneNumber = phoneNumber;
            this._possitiveVotes = 0;
            this._negativeVotes = 0;
            this._strikes = 0;
            this._isAdmin = isAdmin;
            this._lastSeenAt = null;
        }

        public string GetPassword()
        {
            return this._password;
        }

        public string GetEmailAddress() { return this._emailAddress; }
        public string GetFirstName() { return this._firstName; }

        public int GetId() { return this._id; }
        public DateTime? GetLastSeenAt() { return this._lastSeenAt; }

        public bool GetIsAdmin() { return this._isAdmin; }

        public void SetPassword(string password) { this._password = SecurePassword.Hash(password); }

   
    }
}
