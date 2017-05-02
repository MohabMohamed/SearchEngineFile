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
            LoadForm(f);
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            AddCategory f = new AddCategory();
            LoadForm(f);
        }

        private void DisplayFileBtn_Click(object sender, EventArgs e)
        {
            DisplayFile f = new DisplayFile();
            LoadForm(f);
        }

        private void DisplayCategoryBtn_Click(object sender, EventArgs e)
        {
            DisplayCategory f = new DisplayCategory();
            LoadForm(f);
            
        }

        private void KeywordDetails_Click(object sender, EventArgs e)
        {
            KeywordsDetails f = new KeywordsDetails();
            LoadForm(f);
        }
        private void LoadForm(Form frm)
        {
            frm.FormClosed += new FormClosedEventHandler(Form_Closed);
            this.Hide();
            
            frm.Show();
        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Highlight_Click(object sender, EventArgs e)
        {
            Highlightform f = new Highlightform();
            LoadForm(f);
        }
    }
}
