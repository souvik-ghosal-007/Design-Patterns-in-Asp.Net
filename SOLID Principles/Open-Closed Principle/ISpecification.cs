namespace Design_Patterns.SOLID_Principles.Open_Closed_Principle;

public interface ISpecification<T>
{
    bool IsSatisfied(T t);
}