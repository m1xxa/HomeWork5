namespace HomeWork5.TemplateMethod
{
    class PdfFileProcessor : FileProcessor
    {
        protected override string ReadFile(string filePath) => "PDF content";
        protected override string ProcessContent(string content) => "Processed PDF content";
    }
}