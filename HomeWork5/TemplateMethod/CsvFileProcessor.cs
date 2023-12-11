namespace HomeWork5.TemplateMethod
{
    class CsvFileProcessor : FileProcessor
    {
        protected override string ReadFile(string filePath) => "CSV content";

        protected override string ProcessContent(string content) => "Processed CSV content";
    }
}