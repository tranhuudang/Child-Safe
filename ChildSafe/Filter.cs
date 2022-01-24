using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildSafe
{
    class Filter
    {
        string name;
        string description;
        string linkFile;
        string update;
        string licence;
        public Filter(string n, string d, string l, string u, string li)
        {
            this.Name = n;
            this.Description = d;
            this.LinkFile = l;
            this.Update = u;
            this.Licence = li;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string LinkFile { get => linkFile; set => linkFile = value; }
        public string Update { get => update; set => update = value; }
        public string Licence { get => licence; set => licence = value; }
    }
}
