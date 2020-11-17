using System;

namespace GlucoControl.Domain.Model.Data.User
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Lastname1 { get; set; }
        public string Lastname2 { get; set; }
        public int? Age { get; set; }
        public int? Height { get; set; }
        public decimal? Weight { get; set; }
        public int RoleId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}