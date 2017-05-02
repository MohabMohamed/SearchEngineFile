using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace SearchEngineFile
{
    public partial class DisplayCategory : Form
    {
        public DisplayCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chosenCategory = textBox1.Text.ToString();

            XmlDocument file = new XmlDocument();
            file.Load("categories.xml");

            //XmlNodeList keywords = file.GetElementsByTagName("Keyword");
            XmlNodeList listofcategories = file.GetElementsByTagName("Category");


            List<string> currentkeywords = new List<string>();
            XmlElement root = file.DocumentElement;
            for (int i = 0; i < listofcategories.Count; i++)
            {
                if (listofcategories[i].Attributes["Name"].Value == chosenCategory)
                {

                    for (int j = 0; j < listofcategories[i].ChildNodes.Count; j++)
                    {
                        currentkeywords.Add(listofcategories[i].ChildNodes[j].InnerText.ToString());
                        //MessageBox.Show(listofcategories[i].ChildNodes[j].InnerText.ToString());
                    }
                    //  KeyWordsGV.DataSource = listofcategories[i].ChildNodes;
                    KeyWordsGV.DataSource = currentkeywords;
                   
                }

            }

            // Check to see if the element has a genre attribute.
            /*   string catname = "";
           if (root.HasAttribute("Name"))
           {
               XmlAttribute attr = root.GetAttributeNode("Name");
               catname = attr.Value;

           }*/
        }

        private void DisplayCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
