using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddContact.Models
{
    

    public class Contact
    {
        public enum ContactCategory
        {
            Friend,
            Work,
            Family
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }

        // first name
        [Required(ErrorMessage = "Please enter a first name")]
        [MaxLength(200)]
        public string FirstName { get; set; } = string.Empty;

        // last name
        [Required(ErrorMessage = "Please enter a last name.")]
        [MaxLength(200)]
        public string LastName { get; set; } = string.Empty;

        // phone number
       [Range(1, int.MaxValue, ErrorMessage = "Please enter a 10 digits number")]
        public int Phone { get; set; }

        // email
        [Required(ErrorMessage = "Please enter an email")]
        [MaxLength(200)]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;

        // catagory
        [Required(ErrorMessage = "Please select a category")]
        public ContactCategory Category { get; set; }
    }
}
