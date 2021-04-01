using System;

namespace DiagSequenceExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Command uneCommand = new Command();
            var data = uneCommand.CalculerPrix();
            Console.WriteLine(data);
        }
    }
}
