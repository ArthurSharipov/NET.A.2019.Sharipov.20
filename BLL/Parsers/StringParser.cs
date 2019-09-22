using BLL.Interface.Interfaces;
using System;

namespace BLL.Parsers
{
    public class StringParser : IParser<string, Uri>
    {
        /// <summary>
        /// The string parser in uri.
        /// </summary>
        /// <param name="sourse"></param>
        /// <returns></returns>
        public Uri Parse(string sourse)
        {
            return new Uri(sourse);
        }
    }
}