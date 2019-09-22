using System.Collections.Generic;

namespace BLL.Models
{
    public class Url
    {
        public string HostName { get; set; }

        public List<string> Segments { get; set; }

        public List<UrlParameter> Parameters { get; set; }
    }
}