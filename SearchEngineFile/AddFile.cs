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
    public partial class AddFile : Form
    {
        public AddFile()
        {
            InitializeComponent();
            checklistofcategories();
            txt_path.Enabled = false;
        }

        private void bTn_path_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
            if (directchoosedlg.ShowDialog() == DialogResult.OK)
            {
                folderPath = directchoosedlg.SelectedPath;
                txt_path.Text = folderPath;
            }
        }

        private void bTn_save_Click(object sender, EventArgs e)
        {

            List<string> categories_all = new List<string>(); // list of checkedlist
            for (int i = 0; i < categories.CheckedItems.Count; i++)
            {
                categories_all.Add(categories.CheckedItems[i].ToString());
            }

            if (txt_name.Text == "")
            {
                MessageBox.Show("Please Enter Name of File");
            }
            else if (txt_path.Text == "")
            {
                MessageBox.Show("Please Select Path of File");
            }
            else if (txt_pragrapgh.Text == "")
            {
                MessageBox.Show("Your Forget Enter in Text Paragraph");
            }
            else if (categories_all.Count == 0)
            {
                MessageBox.Show("Please Select Your Categories");
            }
            else
            {
             
                bool a = true;
                string name = txt_name.Text;
                string path = txt_path.Text;
                string paragraph = txt_pragrapgh.Text;

                if (!File.Exists("files.xml"))
                {
                    XmlWriter writer = XmlWriter.Create("files.xml");
                    writer.WriteStartDocument();
                    writer.WriteStartElement("categories"); // root

                    if (categories_all.Count >= 1)
                    {
                        writer.WriteStartElement(categories_all.ElementAt(0)); // node category of list // bageb awl element fel list w a3mlo add lwa7do w lw m3aha 7aga kman b3mlha add b3dha w be keda 7alit moshkelt eno lw msh mwgod w 3mltlo create fe awl mra mydrb4

                        writer.WriteStartElement("Name_File"); // children
                        writer.WriteString(name);
                        writer.WriteEndElement();

                        writer.WriteStartElement("Path_File"); //children
                        writer.WriteString(path);
                        writer.WriteEndElement();

                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndDocument();

                        writer.Close();

                        for (int i = 1; i < categories_all.Count; i++)
                        {
                            XmlDocument doc = new XmlDocument(); // hena bkml ba2y el elments lw ba2y 7aga fel list of categories
                            doc.Load("files.xml");
                            XmlElement category = doc.CreateElement(categories_all.ElementAt(i)); // node category of list of categories mn 1 le el length b2a

                            XmlElement node = doc.CreateElement("Name_File"); // children 
                            node.InnerText = name;
                            category.AppendChild(node);

                            node = doc.CreateElement("Path_File"); // children
                            node.InnerText = path;
                            category.AppendChild(node);

                            XmlElement root = doc.DocumentElement;
                            root.AppendChild(category);
                            doc.Save("files.xml"); // save fel file

                            StreamWriter sw = new StreamWriter(path + "\\" + name + ".txt"); // dh el add text file 3la asas e5tyaro lel path el mo3yn w bytsma el file be esm el input file name ele enTa md5lo
                            sw.Write(paragraph);
                            sw.Close();
                        }
                    }
                }
                else // lw hwa exist b2a 
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("files.xml");

                    List<string> newlistofnames = new List<string>(); // b7ot feha kol el children of name_file le category wa7ed mo3yn 
                    List<string> newlistofpathes = new List<string>(); // b7ot feha kol el children of path_file le category wa7ed mo3yn 

                    foreach (string s in categories_all)
                    {
                        XmlNodeList list = doc.GetElementsByTagName(s); // b7ded el node ele hya catgories ele mwgoda fel list bra check list a2sod

                        for (int i = 0; i < list.Count; i++)
                        {
                            XmlNodeList childerns = list[i].ChildNodes; // bybda2 ylem kol el childrens ele mwgoda fel category kza ele hy3di 3alih bel loop

                            string namef = childerns[0].Name; // bya5od el values ahw hwa fel str ele fo2 yadop byo2af 3nd ft7et el tag 
                            string valuenf = childerns[0].InnerText;
                            newlistofnames.Add(valuenf);

                            string pathf = childerns[1].Name; // nfs el kalam lel path
                            string valuepf = childerns[1].InnerText;
                            newlistofpathes.Add(valuepf);
                        }
                        // hena b3ml check hwa mwgod el file dh fl category dh 2bl keda wla la2 w lw mwgod btl3lo el msg de lw msh mwgod bynzel y3ml save 3adi gedn
                        if (newlistofnames.Contains(txt_name.Text) && newlistofpathes.Contains(txt_path.Text))
                        {
                            a = false;
                            MessageBox.Show("Already Exist");
                            break;
                        }

                        XmlElement category = doc.CreateElement(s); // nfs el kalam ele 4r77to fo2 ele by3ml save
                        XmlElement node = doc.CreateElement("Name_File");
                        node.InnerText = name;
                        category.AppendChild(node);

                        node = doc.CreateElement("Path_File");
                        node.InnerText = path;
                        category.AppendChild(node);

                        XmlElement root = doc.DocumentElement;
                        root.AppendChild(category);
                        doc.Save("files.xml");

                        StreamWriter sw = new StreamWriter(path + "\\" + name + ".txt");
                        sw.Write(paragraph);
                        sw.Close();
                    }
                }

                if (a == true) // lw el bool fedl be true ytala3 b2a msg el accepted w eno keda 3ml save w kolo tmm 
                {
                    MessageBox.Show("Successfully Added in File");
                    txt_name.Clear();
                    txt_path.Clear();
                    txt_pragrapgh.Clear();

                    // el7mdollah el Task 5elst be salam :"D
                }
            }
        }


        void checklistofcategories()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Categories.xml");
            XmlNodeList list = doc.GetElementsByTagName("Category");
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

                categories.Items.Add(one.name);
            }

        }


    }
}
