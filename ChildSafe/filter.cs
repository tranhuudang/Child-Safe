using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildSafe
{
    class filter
    {
        private string hostFileSource;
        private string description;
        private string rawHost;
        private string update;
        private string licence;
        public string HostFileSource { get; set; }
        public string Description { get; set; }
        public string RawHost { get; set; }
        public string Update { get; set; }
        public string Licence { get; set; }

        public filter(string _hostFileSource, string _description, string _rawHost, string _update, string _licence)
        {
            this.hostFileSource = _hostFileSource;
            this.description = _description;
            this.rawHost = _rawHost;
            this.update = _update;
            this.licence = _licence;
        }
        public filter()
        {
            hostFileSource = "";
            description = "";
            rawHost = "";
            update = "";
            licence = "";
        }
    }
}
