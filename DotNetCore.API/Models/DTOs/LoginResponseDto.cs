using System.ComponentModel.DataAnnotations;

namespace DotNetCore.API.Models.DTOs
{
    public class LoginResponseDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string[] Roles { get; set; }
        [Required]
        public string JwtToken { get; set; }
    }
}
