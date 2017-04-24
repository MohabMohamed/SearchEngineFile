using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchEngineFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddFileBtn_Click(object sender, EventArgs e)
        {
            AddFile f = new AddFile();
            f.Show();
            this.Hide();
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            AddCategory f = new AddCategory();
            f.Show();
            this.Hide();
        }

        private void DisplayFileBtn_Click(object sender, EventArgs e)
        {
            DisplayFile f = new DisplayFile();
            f.Show();
            this.Hide();
        }

        private void DisplayCategoryBtn_Click(object sender, EventArgs e)
        {
            DisplayCategory f = new DisplayCategory();
            f.Show();
            this.Hide();
        }

        private void KeywordDetails_Click(object sender, EventArgs e)
        {
            KeywordsDetails f = new KeywordsDetails();
            f.Show();
            this.Hide();
        }
    }
}
