using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class Building
    {
        private int _id;
        private string _address;

        public Building()
        { }

        public Building(int id, string address)
        {
            _id = id;
            _address = address;
        }

        public int Id { get => _id; private set => _id = value; }

        public string Address { get => _address; private set => _address = value; }
        
        public override string ToString()
        {
            return $"{Id} - {Address}";
        }
    }
}
