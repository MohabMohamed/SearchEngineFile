using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngineFile
{
    class Category
    {
        public String name { set; get; }
        public List<String> keywords { set; get; }
        public Category() { keywords = new List<string>(); }


    }
}
