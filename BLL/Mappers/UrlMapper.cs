using BLL.Models;
using System;
using System.Linq;
using System.Web;

namespace BLL.Mappers
{
    public static class UrlMapper
    {
        /// <summary>
        /// Mapping uri in url.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns>Url.</returns>
        public static Url ToUrl(this Uri uri)
        {
            if (uri == null)
                throw new ArgumentNullException(nameof(uri));

            var values = HttpUtility.ParseQueryString(uri.Query);

            return new Url
            {
                HostName = uri.Host,
                Segments = uri.Segments.Select(s => s.Trim('/')).Where(s => s.Length > 0).ToList(),
                Parameters = values.AllKeys.Select(key => new UrlParameter { Key = key, Value = values[key] }).ToList()
            };
        }
    }
}