using System;
using System.Collections;

namespace Strings
{
    static class TextTransformer
    {
        private static IEnumerable InputTransformer()
        {
            foreach (var text in InputText.Texts)
            {
                if (text.Equals(""))
                {
                    yield return "Visual Studio";
                }
                else
                {
                    yield return text.ToUpper();
                }
            }
        }

        public static void OutputTransformer()
        {
            foreach (var textelement in TextTransformer.InputTransformer())
            {
                Console.WriteLine(textelement);
            }
        }

    }
}