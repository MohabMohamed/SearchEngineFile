using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace SearchEngineFile
{
    public partial class KeywordsDetails : Form
    {
        List<Category> allcategories = new List<Category>();

        public KeywordsDetails()
        {
            InitializeComponent();
            fillCategoryList();
        }

        void fillCategoryList()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Categories.xml");
            XmlNodeList list = doc.GetElementsByTagName("Category");
            for(int i=0;i<list.Count;i++)
            {
                Category one = new Category();
                XmlNodeList children = list[i].ChildNodes;
                XmlAttributeCollection Att= list[i].Attributes;
                one.name = Att[0].Value;
                for(int y=0;y<children.Count;y++)
                {
                    one.keywords.Add(children[y].InnerText);
                }

                allcategories.Add(one);
                category.Items.Add(one.name);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        void selectedCategory(String Categoryname)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("files.xml");
            XmlNode list2 = doc.GetElementById("categories");
            XmlNodeList children = list2.ChildNodes;
            for(int i=0;i<children.Count;i++)
            {

            }


        }


    }
}
