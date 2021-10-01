using System;
using System.Collections.Generic;
using System.Text;

namespace LeBonSamaritain.Entities
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public List <Wish> Wishes { get; set; }
        public List <User> Users { get; set; }

    }
}
