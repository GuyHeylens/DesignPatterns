// See https://aka.ms/new-console-template for more information


//Benefits: when the elements do not change a lot.

using _01_Visitor_Concrete.Element;
using _01_Visitor_Concrete.Visitor;

Console.WriteLine("Hello, World!");


List<IDocumentElement> elements =
    [
        new TitleElement("The Visitor design pattern"),
        new SubTitleElement("Intent"),
        new ContentElement("Represent an operation ...."),
        new SubTitleElement("Is it amazing?"),
        new ContentElement("The end.")

    ];


Console.WriteLine("Text document visitor:");

TextDocumentVisitor textDocumentVisitor = new();

foreach (var element in elements)
{
    element.Accept(textDocumentVisitor);
}

Console.WriteLine("MarkDown visitor:");

MarkDownDocumentVisitor markDownDocumentVisitor = new();

foreach (var element in elements)
{
    element.Accept(markDownDocumentVisitor);
}