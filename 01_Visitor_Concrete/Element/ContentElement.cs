using _01_Visitor_Concrete.Visitor;

namespace _01_Visitor_Concrete.Element;

public class ContentElement(string text) : IDocumentElement
{
    public string Text { get; } = text;

    public void Accept(IDocumentVisitor documentVisitor)
    {
        documentVisitor.Visit(this);
    }
}