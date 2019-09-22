using BLL.Converters;
using BLL.Parsers;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var converter = new UrlToXmlConverter(new StringParser());

            Console.WriteLine(converter.Convert(new string[] { "https://github.com/AnzhelikaKravchuk?tab=repositories" }));
            Console.WriteLine();
            Console.WriteLine(converter.Convert(new string[] { "https://github.com/AnzhelikaKravchuk/2017-2018.MMF.BSU" }));
            Console.WriteLine();
            Console.WriteLine(converter.Convert(new string[] { "https://habrahabr.ru/company/it-grad/blog/341486/" }));
        }
    }
}