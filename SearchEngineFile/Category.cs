using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SearchEngineFile
{
    [XmlRoot("Category")]
    public class Category
    {
        [XmlAttribute("Name")]
        public String name { set; get; }

        public List<String> keywords { set; get; }
        public Category() { keywords = new List<string>(); }


    }
}
