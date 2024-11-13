using _01.Visitor.Visitor;

namespace _01.Visitor.Element;

public class ConcreteElement2 : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public string Operation2()
    {
        return "Concrete element 2";
    }
}