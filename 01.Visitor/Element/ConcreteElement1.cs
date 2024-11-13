using System.Globalization;
using _01.Visitor.Visitor;

namespace _01.Visitor.Element;

public class ConcreteElement1 : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public string Operation1()
    {
        return "Concrete element 1";
    }
}