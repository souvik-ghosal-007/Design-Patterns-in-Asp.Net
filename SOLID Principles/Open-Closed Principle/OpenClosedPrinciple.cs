namespace Design_Patterns.SOLID_Principles.Open_Closed_Principle;


public static class OpenClosedPrinciple
{
    public static void Main(string[] args)
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);

        var products = new [] { apple, tree, house };

        var filter = new ProductFilter();
        
        foreach (var p in filter.Filter(products, new ColorSpecification(Color.Green)))
        {
             Console.WriteLine($"- {p.Name} is {p.Color}");
        }
        
        foreach (var p in filter.Filter(products,
                         new AndSpecification<Product>(new ColorSpecification(Color.Green),
                                 new SizeSpecification(Size.Small))))
        {
            Console.WriteLine($"- {p.Name} is {p.Color} and {p.Size}");
        }
    }
}