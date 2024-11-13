using _01.Visitor.Element;

namespace _01.Visitor.Visitor;

public interface IVisitor
{
    void Visit(ConcreteElement1 element);
    void Visit(ConcreteElement2 element);
}