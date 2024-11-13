using _01.Visitor.Element;

namespace _01.Visitor.Visitor;

public class ConcreteVisitor1 : IVisitor
{
    public void Visit(ConcreteElement1 element)
    {
        var message = element.Operation1();
        Console.WriteLine($"ConcreteVisitor1 : {message}" );
    }

    public void Visit(ConcreteElement2 element)
    {
        var message = element.Operation2();
        Console.WriteLine($"ConcreteVisitor2 : {message}");
    }
}