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
            fillCategory();
        }



        private void DisplayCategory_Load(object sender, EventArgs e)
        {

        }

        private void fillCategory()
        {
            XmlDocument file = new XmlDocument();
            file.Load("Categories.xml");
            XmlNodeList listofcategories = file.GetElementsByTagName("Category");

            for (int i = 0; i < listofcategories.Count; i++)
            {
                comboBox1.Items.Add(listofcategories[i].Attributes["Name"].Value);
            }




        }

         


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listView1.Clear();
            string chosenCategory = comboBox1.Text;

            XmlDocument file = new XmlDocument();
            file.Load("categories.xml");

            XmlNodeList listofcategories = file.GetElementsByTagName("Category");

            List<string> currentkeywords = new List<string>();

            for (int i = 0; i < listofcategories.Count; i++)
            {
                if (listofcategories[i].Attributes["Name"].Value == chosenCategory)
                {
                    //add every childnode of selected category to the list
                    for (int j = 0; j < listofcategories[i].ChildNodes.Count; j++)
                    {
                        currentkeywords.Add(listofcategories[i].ChildNodes[j].InnerText.ToString());
                    }

                    //display
                    for (int k = 0; k < currentkeywords.Count; k++)
                    {
                        listView1.Items.Add(currentkeywords[k].ToString());
                    }


                }

            }
        }
    }
}
