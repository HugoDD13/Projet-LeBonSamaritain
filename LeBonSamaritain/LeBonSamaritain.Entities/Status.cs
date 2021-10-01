using System.Collections.Generic;

namespace LeBonSamaritain.Entities
{
    public class Status
    {
        public int Id { get; set; }
        public string Description  { get; set; }
        public List<Request> Requests { get; set; }
    }
}