using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class Reaction
    {
        private int _id;
        private User _user;
        private bool _isPositive;

        public Reaction(int id, User user, bool isPositive)
        {
            _id = id;
            _user = user;
            _isPositive = isPositive;
        }

        public int Id { get => _id; set => _id = value; }
        public User User { get => _user; set => _user = value; }
        public bool IsPositive { get => _isPositive; set => _isPositive = value; }
    }
}
