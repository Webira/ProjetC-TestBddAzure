using System;

namespace testbdd.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }

        public string Adresse { get; set; }

        public User()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
