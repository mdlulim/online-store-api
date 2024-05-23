namespace DotNetCore.API.Models.DTOs
{
    public class AddCategoryRequestDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}