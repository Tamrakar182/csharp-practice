// Objects of a superclass should be replaceable with 
// objects of a subclass without affecting correctness of the program.

public abstract class Document
{
    public abstract void Print();
}

public class WordDocument : Document
{
    // here worddocument (subclass) overrides objects 
    // from document(superclass)
    // without affecting the program execution 
    public override void Print()
    {
        Console.WriteLine("Printing Word document");
    }
}

public class PdfDocument : Document
{
    // here pdfdocument (subclass) overrides objects 
    // from document(superclass)
    // without affecting the program execution 
    public override void Print()
    {
        Console.WriteLine("Printing PDF document");
    }
}

public class DocumentProcessor
{
    public void PrintDocument(Document doc)
    {
        doc.Print();
    }
}
