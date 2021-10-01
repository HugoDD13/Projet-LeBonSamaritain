using System;
using System.Collections.Generic;
using System.Text;

namespace LeBonSamaritain.Entities
{
    public class Ad
    {
        public Ad()
        {
            Requests = new List<Request>();
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set;  }
        public int UserId { get; set; }
        public int AdTypeId { get; set; }
        public string Picture { get; set; }
        public AdType AdType { get; set; }
        public List<Request> Requests { get; set; }

    }
}

