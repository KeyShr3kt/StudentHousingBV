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
        private int _creatorId;
        private int _agreementId;
        private bool _isPositive;

        public Reaction ()
        {

        }

        public Reaction(int id, int creatorID, int agreementId, bool isPossitive)
        {
            _id = id;
            _creatorId = creatorID;
            _agreementId = agreementId;
            _isPositive = isPossitive;
        }

        public int Id { get => _id; set => _id = value; }
        public int CreatorId { get => _creatorId; set => _creatorId = value; }

        public int AgreementId { get => _agreementId; set => _agreementId = value; }
        public bool IsPositive { get => _isPositive; set => _isPositive = value; }
    }
}
