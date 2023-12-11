namespace HomeWork5.TemplateMethod
{
    class DocFileProcessor : FileProcessor
    {
        protected override string ReadFile(string filePath) =>"DOC content";
        protected override string ProcessContent(string content) => "Processed DOC content";
    }
}