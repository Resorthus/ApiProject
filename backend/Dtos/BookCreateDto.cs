using System.ComponentModel.DataAnnotations;

namespace ApiProject.Dtos
{
    public class BookCreateDto
    {

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