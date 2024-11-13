using _01_Visitor_Concrete.Element;

namespace _01_Visitor_Concrete.Visitor;

public interface IDocumentVisitor
{
    void Visit(TitleElement element);
    void Visit(SubTitleElement element);
    void Visit(ContentElement element);
}