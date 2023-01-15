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
        private int? _userId;
        private int _buildingId;

        public Room()
        { }

        public Room(int id, string type, int? userId, string name, int buildingId)
        {
            Id = id;
            Type = type;
            Name = name;
            UserId = userId;
            BuildingId = buildingId;
        }

        public int Id { get => _id; private set => _id = value; }

        public string Type { get => _type; private set => _type = value; }

        public string Name { get => _name; private set => _name = value; }

        public int? UserId { get => _userId; private set => _userId = value; }

        public int BuildingId { get => _buildingId; private set => _buildingId = value; }

        public override string ToString()
        {
            return $"{Type} - {Name}";
        }
    }
}
