namespace DotNetCore.API.Models.DTOs
{
    public class UpdateRegionRequestDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
