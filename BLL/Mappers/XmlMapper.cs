using BLL.Models;
using System.Xml.Linq;

namespace BLL.Mappers
{
    public static class XmlMapper
    {
        /// <summary>
        /// Mapping uri to the element xml document.
        /// </summary>
        /// <param name="url"></param>
        /// <returns>Xml element.</returns>
        public static XElement ToXElement(this Url url)
        {
            var host = new XElement("host", new XAttribute("name", url.HostName));

            XElement uri = null;

            if (url.Segments.Count > 0)
            {
                uri = new XElement("uri");
                url.Segments.ForEach(s => uri.Add(new XElement("segment", s)));
            }

            XElement parameters = null;

            if (url.Parameters.Count > 0)
            {
                parameters = new XElement("parameters");
                url.Parameters.ForEach(
                    p => parameters.Add(new XElement("parameter",
                        new XAttribute("key", p.Key ?? "null"),
                        new XAttribute("value", p.Value ?? "null"))));
            }


            return new XElement("urlAddress", host, uri, parameters);
        }
    }
}