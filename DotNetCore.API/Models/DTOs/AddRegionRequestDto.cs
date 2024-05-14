namespace DotNetCore.API.Models.DTOs
{
    public class AddRegionRequestDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
