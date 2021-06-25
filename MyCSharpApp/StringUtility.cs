using System;
using System.Collections.Generic;
using System.Text;

namespace MyCSharpApp
{
    public class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 25)
        {
            //const int maxLength = 20;
            if (text.Length < maxLength)
                //Console.WriteLine(text);
                return text;

            //sentence.Substring(0, maxLength); -> this might cause data loss
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();
            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }
            var summary = String.Join(" ", summaryWords) + "...";
            //Console.WriteLine(summary);
            return summary;

        }
    }
}
