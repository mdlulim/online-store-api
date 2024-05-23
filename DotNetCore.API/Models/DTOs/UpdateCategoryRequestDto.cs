namespace DotNetCore.API.Models.DTOs
{
    public class UpdateCategoryRequestDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
