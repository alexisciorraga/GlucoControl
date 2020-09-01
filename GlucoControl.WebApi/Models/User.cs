using System;

namespace GlucoControl.WebApi.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Lastname1 { get; set; }
        public string Lastname2 { get; set; }
        public int? Age { get; set; }
        public int? Height { get; set; }
        public decimal? Weight { get; set; }
        public Guid RoleId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}