using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions;

namespace DynamicForm.Models
{
    public class FormViewModel
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Max firstname length is 25 symbols.")]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Max lastname length is 25 symbols.")]
        [DisplayName("Last name")]
        public string LastName { get; set; }

        [Required]
        [Email(ErrorMessage = "Provide correct email address, please.")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Range(16, 150, ErrorMessage = "Age should be between 16 and 150.")]
        [DisplayName("Age")]
        public int? Age { get; set; }

        public IList<DiscountCode> Discounts { get; set; }
    }
}