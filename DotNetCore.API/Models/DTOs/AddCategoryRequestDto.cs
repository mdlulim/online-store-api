using System.ComponentModel.DataAnnotations;

namespace DotNetCore.API.Models.DTOs
{
    public class AddCategoryRequestDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "Code has to be a minimum of 2 characters")]
        [MaxLength(50, ErrorMessage = "Code has to be a maximum of 50 characters")]
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}