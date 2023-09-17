namespace Design_Patterns.SOLID_Principles.Open_Closed_Principle;

public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
}