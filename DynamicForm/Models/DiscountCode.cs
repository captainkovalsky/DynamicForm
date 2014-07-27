using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions;

namespace DynamicForm.Models
{
    public class DiscountCode
    {
        [Required]
        [DisplayName("Code name")]
        [StringLength(10, ErrorMessage = "Max name length is 10 symbols.")]
        public string Code { get; set; }

        [Required]
        [DisplayName("Code discount")]
        [Integer(ErrorMessage = "The field Percent should be a positive non-decimal number")]
        [Range(1,60, ErrorMessage = "The field Percent should be between 1 and 60.")]
        public int Percent { get; set; }
    }
}