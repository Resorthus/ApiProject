using System.ComponentModel.DataAnnotations;

namespace ApiProject.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string FirstName {get; set;} // First name of author
        
        [Required]
        public string LastName { get; set; } // Last name of author

        [Required]
        public int PageCount { get; set; }
    }
}