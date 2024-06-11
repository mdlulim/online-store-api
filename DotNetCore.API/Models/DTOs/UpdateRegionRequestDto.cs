using System.ComponentModel.DataAnnotations;

namespace DotNetCore.API.Models.DTOs
{
    public class UpdateRegionRequestDto
    {
        [Required]
        [MinLength(2, ErrorMessage ="Code has to be a minimum of 2 characters")]
        [MaxLength(5, ErrorMessage = "Code has to be a maximum of 5 characters")]
        public string Code { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Code has to be a minimum of 2 characters")]
        [MaxLength(50, ErrorMessage = "Code has to be a maximum of 50 characters")]
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
