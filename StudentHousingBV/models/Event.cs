using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class Event
    {
        private int _id;
        private DateTime _createdAt;
        private string _description;
        private string _title;
        private StudentHousingBV.models.User _user;

        public Event(int id, string title, string description, StudentHousingBV.models.User user, DateTime createdAt)
        {
            this._id = id;
            this._description = description;
            this._createdAt = createdAt;
            this._title = title;
            this._user = user;
        }

        public string Description
        {
            get
            { return this._description; }
            set
            { this._description = value; }
        }

        public int Id
        {
            get
            { return this._id; }
            set
            { this._id = value; }
        }

        public DateTime CreatedAt
        {
            get
            { return this._createdAt; }
            set
            { this._createdAt = value; }
        }

        public string Title
        {
            get
            { return this._title; }
            set
            { this._title = value; }
        }

        public StudentHousingBV.models.User User
        {
            get
            { return this._user; }
            set
            { this._user = value; }
        }
    }
}
