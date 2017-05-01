using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace SearchEngineFile
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test ay 7aga");

            if (!File.Exists("Categories.xml"))
            {
                XmlWriter writer = XmlWriter.Create("Categories.xml");
                
                writer.WriteStartDocument();
                writer.WriteStartElement("Categories");
                writer.WriteStartElement("Category");
                writer.WriteAttributeString("Name", CategoryNameTB.Text);
                //writer.WriteString(CategoryNameTB.Text);
                for (int i = 0; i < KeywordsGV.RowCount-1; i++)
                {
                    writer.WriteStartElement("Keyword"+(i+1).ToString());
                    writer.WriteString(KeywordsGV.Rows[i].Cells[0].Value.ToString());
                    writer.WriteEndElement();
                }

                    writer.WriteEndElement();
                    writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
            else
            {
               
                    XmlDocument doc = new XmlDocument();
                doc.Load("Categories.xml");
                if (doc.SelectSingleNode("/ Categories/ Category [@Name =\""+CategoryNameTB.Text+"\"] ") == null)
                {

                    XmlElement CatElm = doc.CreateElement("Category");
                    CatElm.SetAttribute("Name", CategoryNameTB.Text);
                    XmlElement keyword;
                    for (int i = 0; i < KeywordsGV.RowCount - 1; i++)
                    {
                        keyword = doc.CreateElement("Keyword" + (i + 1).ToString());
                        keyword.InnerText = KeywordsGV.Rows[i].Cells[0].Value.ToString();
                        CatElm.AppendChild(keyword);
                    }
                    XmlElement root = doc.DocumentElement;
                    root.AppendChild(CatElm);

                }
                else
                    MessageBox.Show("the category already exists");

                doc.Save("Categories.xml");
            }

            CategoryNameTB.Clear();
          KeywordsGV.Rows.Clear();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
           
        }
    }
}
