using System.ComponentModel.DataAnnotations;

namespace PayrollApp.Api.Dto
{
    public class LoginDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}