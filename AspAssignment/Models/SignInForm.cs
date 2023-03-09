
using System.ComponentModel.DataAnnotations;

namespace AspAssignment.Models
{
    public class SignInForm
    {
        public string Email { get; set; } = null!;


        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        public string? ReturnUrl { get; set; }
    }
}
