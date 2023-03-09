using System.ComponentModel.DataAnnotations;

namespace AspAssignment.Models
{
    public class SignUpForm
    {
            [Required]
            [Display(Name = "First Name")]
            public string FirstName { get; set; } = string.Empty;

            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; } = string.Empty;

            //[Required]
            //[Display(Name = "Street Name")]
            //public string StreetName { get; set; } = string.Empty;

            //[Required]
            //[Display(Name = "Postal Code")]
            //public string PostalCode { get; set; } = string.Empty;

            //[Required]
            //[Display(Name = "City")]
            //public string City { get; set; } = string.Empty;

            [Required]
            [EmailAddress]
            [Display(Name = "E-mail Address")]
            public string Email { get; set; } = string.Empty;

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; } = string.Empty;

            //[Required]
            //[DataType(DataType.Password)]
            //[Display(Name = "Confirm Password")]
            //[Compare(nameof(Password))]
            //public string ConfirmPassword { get; set; } = string.Empty;

            //[Display(Name = "Phone")]
            //public string? Mobile { get; set; }

            //[Display(Name = "Company")]
            //public string? Company { get; set; }

            public string ReturnUrl { get; set; } = null!;
    }
}
