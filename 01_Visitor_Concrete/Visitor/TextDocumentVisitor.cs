using _01_Visitor_Concrete.Element;

namespace _01_Visitor_Concrete.Visitor;

public class TextDocumentVisitor : IDocumentVisitor
{
    public void Visit(TitleElement element)
    {
        Console.WriteLine(element.Text.ToUpper());
        Console.WriteLine(new string('=', element.Text.Length));
        Console.WriteLine();
    }

    public void Visit(SubTitleElement element)
    {
        Console.WriteLine(element.Text);
        Console.WriteLine(new string('-', element.Text.Length));
        Console.WriteLine();
    }

    public void Visit(ContentElement element)
    {
        Console.WriteLine(element.Text);
        Console.WriteLine();
    }
}