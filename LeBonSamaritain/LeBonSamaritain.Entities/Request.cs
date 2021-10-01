using System;
using System.Collections.Generic;
using System.Text;

namespace LeBonSamaritain.Entities
{
    public class Request
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public User Seeker { get; set; }
        public int AdId { get; set; }
        public Ad Ad { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
    }
}
