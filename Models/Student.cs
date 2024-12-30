using APIApplication.ValidationAttributes;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace APIApplication.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }

        [EmailAddress]  // Ensures the email format is valid
      
        public string Email { get; set; }

        [PhoneNumber]
        public string PhoneNumber { get; set; }
    }
}
