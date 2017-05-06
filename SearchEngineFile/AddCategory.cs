using System;
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

            /*
             check if Categories.xml dosn't exist then create one
             then adds the category name and the keywords of it to 
             the file and if it exists just add it.but first it 
             checks if the category exists if yes it adds the 
             new keywords to the category if not
             just makes a new category
             
             */
            if (!File.Exists("Categories.xml"))
            {
                XmlWriter writer = XmlWriter.Create("Categories.xml");

                writer.WriteStartDocument();
                writer.WriteStartElement("Categories");
                writer.WriteStartElement("Category");
                writer.WriteAttributeString("Name", CategoryNameTB.Text);


                for (int i = 0; i < KeywordsGV.RowCount - 1; i++)

                {
                    writer.WriteStartElement("Keyword");
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
                XmlNode alredyExistNode;
                XmlDocument doc = new XmlDocument();
                doc.Load("Categories.xml");
                if ((alredyExistNode = doc.SelectSingleNode("/ Categories/ Category [@Name =\"" + CategoryNameTB.Text + "\"] ")) == null)
                {

                    XmlElement CatElm = doc.CreateElement("Category");
                    CatElm.SetAttribute("Name", CategoryNameTB.Text);
                    XmlElement keyword;
                    for (int i = 0; i < KeywordsGV.RowCount - 1; i++)
                    {
                        keyword = doc.CreateElement("Keyword");
                        keyword.InnerText = KeywordsGV.Rows[i].Cells[0].Value.ToString();
                        CatElm.AppendChild(keyword);
                    }
                    XmlElement root = doc.DocumentElement;
                    root.AppendChild(CatElm);

                }
                else
                {
                    MessageBox.Show("the category already exists the new keywords will be add");
                    XmlElement keyword;
                    for (int i = 0; i < KeywordsGV.RowCount - 1; i++)
                    {
                        keyword = doc.CreateElement("Keyword");
                        keyword.InnerText = KeywordsGV.Rows[i].Cells[0].Value.ToString();
                        alredyExistNode.AppendChild(keyword);
                    }

                }
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
