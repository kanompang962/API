using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }
    }
}
