using System;
using System.Collections.Generic;

namespace Strings
{
    static class InputText
    {
        private static readonly List<string> texts = new List<string>();

        public static IReadOnlyList<string> Texts =>
            texts.AsReadOnly();

        public static void Input()
        {
            const string Quit = ":q";
            while (true)
            {
                string line = Console.ReadLine();
                if (line.Trim() == Quit)
                {
                    break;
                }
                texts.Add(line);
            }
        }
    }
}