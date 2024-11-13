using _01_Visitor_Concrete.Visitor;

namespace _01_Visitor_Concrete.Element;

public interface IDocumentElement
{
    void Accept(IDocumentVisitor documentVisitor);
}