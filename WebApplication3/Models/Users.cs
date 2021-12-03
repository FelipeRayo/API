using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Names { get; set; }
        public string LastNames { get; set; }
        public string BirthDay { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public DateTime LogDate { get; set; }
        public int LogUser { get; set; }
    }
}
