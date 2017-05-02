using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngineFile
{
    public class UserFile
    {
       public String name { set; get; }
       public String path { set; get; }
       public List<Category> FileCategories { set; get;}
       public UserFile() { FileCategories = new List<Category>(); }

    }
}
