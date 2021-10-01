using System;
using System.Collections.Generic;
using System.Text;

namespace LeBonSamaritain.Entities
{
    public class Wish
    {
        public int Id { set; get; }
        public string Description { set; get; }
        public DateTime Date { get; set; }
        public List<School> Schools { get; set; }
    }
}
