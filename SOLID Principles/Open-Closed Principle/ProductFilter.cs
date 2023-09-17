namespace Design_Patterns.SOLID_Principles.Open_Closed_Principle;

public class ProductFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
        foreach (var i in items)
        {
            if (!spec.IsSatisfied(i)) continue;

            yield return i;
        }
    }
}