using DotNetCore.API.Models.Domain;

namespace DotNetCore.API.Models.DTOs
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public Supplier Supplier { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int IsActive { get; set; }
        public Category Category { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
