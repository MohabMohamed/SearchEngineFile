using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace SearchEngineFile
{

    public partial class Highlightform : Form
    {
        List<Category> allcategories = new List<Category>();
        List<UserFile> listoffiles = new List<UserFile>();
        Category theone = new Category();
        UserFile fileone = new UserFile();



      


        public Highlightform()
        {
            InitializeComponent();
            fillCategoryList();
        }

        void fillCategoryList()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Categories.xml");
            XmlNodeList list = doc.GetElementsByTagName("Category");
            allcategories.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                Category one = new Category();
                XmlNodeList children = list[i].ChildNodes;
                XmlAttributeCollection Att = list[i].Attributes;
                one.name = Att[0].Value;
                for (int y = 0; y < children.Count; y++)
                {
                    one.keywords.Add(children[y].InnerText);
                }

                allcategories.Add(one);
                comboHighlight.Items.Add(one.name);
            }


        }

        private void listHighlight_SelectedIndexChanged(object sender, EventArgs e)
        {


            foreach (UserFile www in listoffiles)
            {
                if (www.name == listHighlight.Text)
                {
                    fileone = www;
                }

            }


            try
            {
                richHighlight.Text = "";
                richHighlight.Text = File.ReadAllText(fileone.path + "\\" + fileone.name + ".txt");
            }
            catch
            {
                MessageBox.Show("This File Doesn't exist on This Computer.");
            }


            /*
             * h3ml load ll file
             * h3ml Highlight
             */
            richHighlight.SelectAll();
            richHighlight.SelectionBackColor = Color.White;

            foreach (String key in theone.keywords)
            {
                HighlightFun(key);
            }

        }

        private void comboHighlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            listHighlight.Items.Clear();
            selectedCategory(comboHighlight.Text);

            foreach (Category cate in allcategories)
            {
                if (cate.name == comboHighlight.Text)
                {
                    theone = cate;
                }
            }


        }

        void HighlightFun(String key)
        {
            int start = 0;
            int end = richHighlight.Text.LastIndexOf(key);

            richHighlight.Find(key, start, richHighlight.TextLength, RichTextBoxFinds.MatchCase);
            richHighlight.SelectionBackColor = Color.Chartreuse;

        }

        void selectedCategory(String Categoryname)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("files.xml");
            XmlNode list2 = doc.SelectSingleNode("categories");
            XmlNodeList children = list2.ChildNodes;
            listoffiles.Clear();
            for (int i = 0; i < children.Count; i++)
            {
                UserFile one = new UserFile();
                if (children[i].Name == Categoryname)
                {
                    XmlNodeList childofchild = children[i].ChildNodes;
                    one.name = childofchild[0].InnerText;
                    one.path = childofchild[1].InnerText;
                    listoffiles.Add(one);
                    listHighlight.Items.Add(one.name);
                }

            }

        }


    }
}
