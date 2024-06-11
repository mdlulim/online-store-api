namespace DotNetCore.API.Models.Domain
{
    public class Supplier
    {
        public Guid Id { get; set; }
        public string VendorCode { get; set; }
        public string Name { get; set; }
        public int IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
