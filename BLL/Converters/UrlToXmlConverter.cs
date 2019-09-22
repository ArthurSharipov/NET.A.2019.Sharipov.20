using BLL.Interface.Interfaces;
using BLL.Mappers;
using BLL.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace BLL.Converters
{
    public class UrlToXmlConverter : IConverter<IEnumerable<string>, XDocument>
    {
        private readonly StringParser _parser;

        /// <summary>
        /// The constructor gets the string parser in uri.
        /// </summary>
        /// <param name="parser"></param>
        public UrlToXmlConverter(StringParser parser)
        {
            _parser = parser;
        }

        /// <summary>
        /// Converts string representation url to xml document.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>Xml document.</returns>
        public XDocument Convert(IEnumerable<string> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            IEnumerable<XElement> urlList = source
                .Select(s => _parser.Parse(s).ToUrl().ToXElement());

            var xDocument = new XDocument();
            xDocument.Add(new XElement("urlAddresses", urlList.ToArray()));

            return xDocument;
        }
    }
}