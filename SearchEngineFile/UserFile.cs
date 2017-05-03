using System;
using System.Collections.Generic;

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
