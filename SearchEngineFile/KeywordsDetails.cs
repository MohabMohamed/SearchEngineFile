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

namespace SearchEngineFile
{
    public partial class KeywordsDetails : Form
    {
        List<Category> allcategories = new List<Category>();

        public KeywordsDetails()
        {
            InitializeComponent();
            XmlSerializer xs = new XmlSerializer(allcategories.GetType());
            FileStream fs = new FileStream("Categories.xml", FileMode.Open);
            allcategories = (List<Category>)xs.Deserialize(fs);
            fs.Close();
            dataGridView1.DataSource = allcategories;


            fillCategoryList();
        }

        void fillCategoryList()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
