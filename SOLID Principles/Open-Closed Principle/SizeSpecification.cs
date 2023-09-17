namespace Design_Patterns.SOLID_Principles.Open_Closed_Principle;

public class SizeSpecification : ISpecification<Product>
{
    private Size size;
    public SizeSpecification(Size size)
    {
        this.size = size;
    }
    
    public bool IsSatisfied(Product product)
    {
        return product.Size == size;
    }
}