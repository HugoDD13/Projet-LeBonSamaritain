using System;
using System.Collections.Generic;

namespace LeBonSamaritain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
        public string Picture { get; set; }
        public int IdSchool { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public School School { get; set; }
        public List<Ad> Ads { get; set; }
        public List<Request> Requests { get; set; }
    }
}
