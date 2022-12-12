using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class Room
    {
        private int _id;
        private string _type;
        private string _name;
        private User? _user;

        public int Id { get => _id; private set => _id = value; }
        public string Type { get => _type; private set => _type = value; }

        public string Name { get => _name; private set => _name = value; }

        public User? User { get => _user; private set => _user = value; }

        public Room(int id, string type, string name, User? user)
        {
            Id = id;
            Type = type;
            Name = name;
            User = user;
        }
    }
}
