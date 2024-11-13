using _01_Visitor_Concrete.Visitor;
using static System.Net.Mime.MediaTypeNames;

namespace _01_Visitor_Concrete.Element;

public class SubTitleElement(string text) : IDocumentElement
{
    public string Text { get; } = text;

    public void Accept(IDocumentVisitor documentVisitor)
    {
        documentVisitor.Visit(this);
    }
}