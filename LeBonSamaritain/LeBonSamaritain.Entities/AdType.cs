using System;
using System.Collections.Generic;
using System.Text;

namespace LeBonSamaritain.Entities
{
    public class AdType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<Ad> Ads { get; set; }
    }
}
