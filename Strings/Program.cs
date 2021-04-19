using System;

namespace Strings
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Text\n:q - exit");
            InputText.Input();
            TextTransformer.OutputTransformer();
        }
    }
}