using System;
using System.Windows.Forms;
using System.Xml;


namespace SearchEngineFile
{
    public partial class DisplayFile : Form
    {
        public DisplayFile()
        {
            InitializeComponent();
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


            //remove duplicate file names

            for (int currentRow = 0; currentRow < dataGridView1.Rows.Count - 1; currentRow++)
            {
                DataGridViewRow rowToCompare = dataGridView1.Rows[currentRow];

                for (int otherRow = currentRow + 1; otherRow < dataGridView1.Rows.Count; otherRow++)
                {
                    DataGridViewRow row = dataGridView1.Rows[otherRow];

                    bool duplicateRow = true;

                    for (int cellIndex = 0; cellIndex < row.Cells.Count; cellIndex++)
                    {
                        if (!rowToCompare.Cells[cellIndex].Value.Equals(row.Cells[cellIndex].Value))
                        {
                            duplicateRow = false;
                            break;
                        }
                    }

                    if (duplicateRow)
                    {
                        dataGridView1.Rows.Remove(row);
                        otherRow--;
                    }
                }
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string t = "Path";
            string s = "Name";
            XmlDocument docement = new XmlDocument();
            docement.Load("files.xml");
            XmlNodeList list_name = docement.GetElementsByTagName("Name_File");
            XmlNodeList list_path = docement.GetElementsByTagName("Path_File");
            for (int i = 0; i < list_name.Count; i++)
            {
                if (dataGridView1.ColumnCount == 0)
                {
                    dataGridView1.Columns.Add("name", s);
                    dataGridView1.Columns.Add("path", t);

                }
                dataGridView1.Rows.Add(new string[] { list_name[i].InnerText, list_path[i].InnerText });


            }



            for (int currentRow = 0; currentRow < dataGridView1.Rows.Count - 1; currentRow++)
            {
                DataGridViewRow rowToCompare = dataGridView1.Rows[currentRow];

                for (int otherRow = currentRow + 1; otherRow < dataGridView1.Rows.Count; otherRow++)
                {
                    DataGridViewRow row = dataGridView1.Rows[otherRow];

                    bool duplicateRow = true;

                    for (int cellIndex = 0; cellIndex < row.Cells.Count; cellIndex++)
                    {
                        if (!rowToCompare.Cells[cellIndex].Value.Equals(row.Cells[cellIndex].Value))
                        {
                            duplicateRow = false;
                            break;
                        }
                    }

                    if (duplicateRow)
                    {
                        dataGridView1.Rows.Remove(row);
                        otherRow--;
                    }
                }
            }

        }




    }
}
