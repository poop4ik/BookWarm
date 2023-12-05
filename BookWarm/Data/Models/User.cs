using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWarm.Data.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string PasswordHash { get; set; }
        public string Description { get; set; }
        public byte[] ProfilePhoto { get; set; }
        public Image ProfilePhotoObject { get; set; }

        public void UpdateProfile(string firstName, string lastName, string email, int age, string description)
        { 
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Age = age;
            Description = description;
        }
    }
}
