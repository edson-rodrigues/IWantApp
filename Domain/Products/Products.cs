using IWantAPP.Domain.Products;

namespace IWantApp.Domain.Products;

public class Products
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Category Category { get; set; }
    public string Description { get; set; }
    public bool HasStock { get; set; }
    public string EditedBy { get; set; }
    public DateTime EditedOn { get; set; }
}
