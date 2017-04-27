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
            if (!File.Exists("Categories.xml"))
            {
                XmlWriter writer = XmlWriter.Create("Categories.xml");

                writer.WriteStartDocument();
                writer.WriteStartElement("Category");
                writer.WriteString(CategoryNameTB.Text);
                writer.WriteEndElement();

                writer.WriteEndDocument();
                writer.Close();
            }
            else
            {

                XmlDocument doc = new XmlDocument();
                doc.Load("Categories.xml");
                XmlElement node = doc.CreateElement("Category");
                node.InnerText = CategoryNameTB.Text;
                doc.Save("person.xml");
            }

            CategoryNameTB.Clear();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
           
        }
    }
}
