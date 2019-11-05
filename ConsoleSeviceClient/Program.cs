using ConsoleSeviceClient.ConsoleServiceReference;
using System;

namespace ConsoleSeviceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrencyConverterServiceClient client = new CurrencyConverterServiceClient();

            var result = client.ConvertToWord(3);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
