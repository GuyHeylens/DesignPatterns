using _01.Visitor.Visitor;

namespace _01.Visitor.Element;

public interface IElement
{
    void Accept(IVisitor visitor);
}