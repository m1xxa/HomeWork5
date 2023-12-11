using HomeWork5.Subscriber;
using HomeWork5.TemplateMethod;

namespace HomeWork5
{
    abstract class Program
    {
        static void Main()
        {
            #region TemplateMethod

            FileProcessor pdfProcessor = new PdfFileProcessor();
            pdfProcessor.ProcessFile("example.pdf");

            FileProcessor csvProcessor = new CsvFileProcessor();
            csvProcessor.ProcessFile("example.csv");

            FileProcessor docProcessor = new DocFileProcessor();
            docProcessor.ProcessFile("example.doc");

            #endregion

            #region Subscriber

            MessageBus messageBus = new MessageBus();
            MessageProducer producer = new MessageProducer(messageBus);
            MessageConsumer consumer1 = new MessageConsumer();
            MessageConsumer consumer2 = new MessageConsumer();
            MessageConsumer consumer3 = new MessageConsumer();

            messageBus.Subscribe(consumer1);
            messageBus.Subscribe(consumer2);
            messageBus.Subscribe(consumer3);

            producer.SendMessage("Hello, subscribers!");

            #endregion
        }
    }
}