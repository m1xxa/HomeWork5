using System;

namespace HomeWork5.TemplateMethod
{
    public abstract class FileProcessor
    {
        public void ProcessFile(string filePath)
        {
            string content = ReadFile(filePath);
            string processedContent = ProcessContent(content);
            DisplayResults(processedContent);
        }

        protected abstract string ReadFile(string filePath);

        protected abstract string ProcessContent(string content);

        protected virtual void DisplayResults(string processedContent)
        {
            Console.WriteLine("Processed content:");
            Console.WriteLine(processedContent);
        }
    }
}