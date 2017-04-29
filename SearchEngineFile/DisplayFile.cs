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
    public partial class DisplayFile : Form
    {
        public DisplayFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void DiplayFileBtn_Click(object sender, EventArgs e)
        {
            string t = "Path";
            string s = "Name";
            Boolean status = false;
           string name = FileNameTB.Text.ToString();
            dataGridView1.Rows.Clear();
            XmlDocument docement = new XmlDocument();
            docement.Load("files.xml");
         
            XmlNodeList list_name = docement.GetElementsByTagName("Name_File");
            XmlNodeList list_path = docement.GetElementsByTagName("Path_File");
            for (int i = 0; i < list_name.Count; i++)
            {
                string innerValue = list_name[i].InnerText;
                string path = list_path[i].InnerText;
                if (innerValue == name)
                {
                    status = true;
                    if (dataGridView1.ColumnCount == 0)
                    {
                        dataGridView1.Columns.Add("name", s);
                        dataGridView1.Columns.Add("path", t);
                    }
                    dataGridView1.Rows.Add(new string[] { innerValue, path });

                }
                else
                    continue;
            }
            if (!status)
            {
                    MessageBox.Show("the file name Does not exist try again");  
            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 f = new Form1();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             string t = "Path";
             string s = "Name";
            XmlDocument docement = new XmlDocument();
            docement.Load("files.xml");
            XmlNodeList list_name = docement.GetElementsByTagName("Name_File");
            XmlNodeList list_path = docement.GetElementsByTagName("Path_File");
            for (int i = 0; i < list_name.Count ; i++)
            {
                if (dataGridView1.ColumnCount == 0)
                {
                    dataGridView1.Columns.Add("name", s);
                    dataGridView1.Columns.Add("path", t);
                    
                }
                dataGridView1.Rows.Add(new string[] { list_name[i].InnerText, list_path[i].InnerText });


            }


        }

        private void DisplayFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

           
        }
    }
