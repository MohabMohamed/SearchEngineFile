﻿using System;
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
using System.Xml;

namespace SearchEngineFile
{
    public partial class KeywordsDetails : Form
    {
        List<Category> allcategories = new List<Category>();
        List<UserFile> listoffiles = new List<UserFile>();
        private int Counter = 0;

        public KeywordsDetails()
        {
            InitializeComponent();
            fillCategoryList();
        }

        void fillCategoryList()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Categories.xml");
            XmlNodeList list = doc.GetElementsByTagName("Category");
            allcategories.Clear();
            for (int i=0;i<list.Count;i++)
            {
                Category one = new Category();
                XmlNodeList children = list[i].ChildNodes;
                XmlAttributeCollection Att= list[i].Attributes;
                one.name = Att[0].Value;
                for(int y=0;y<children.Count;y++)
                {
                    one.keywords.Add(children[y].InnerText);
                }

                allcategories.Add(one);
                category.Items.Add(one.name);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory(category.Text);
            Category theone = new Category();
            detailsTextBox.Text = "";
            foreach (Category cate in allcategories)
            {
                if(cate.name==category.Text)
                {
                    theone = cate;
                }
            }


            foreach(UserFile Ufile in listoffiles)
            {
                FileStream inFile = new FileStream(Ufile.path+"\\" + Ufile.name + ".txt", FileMode.Open);
                StreamReader reader = new StreamReader(inFile);
                string record;
                foreach(String key in theone.keywords)
                {
                    List<String> numberofline = new List<string>();
                    Counter = 0;

                    record = reader.ReadLine();

                    while (record != null)
                            {
                               Counter++;

                              if (record.Contains(key))
                                     {
                                       numberofline.Add("IN Line " + Counter);
                                     }
                                 record = reader.ReadLine();
                            }

                    /*
                     * hro7 l 2wel l file
                     * w hzher l ntayeg
                     */
                     reader.BaseStream.Position = 0;

                    if(numberofline.Count!=0)
                    {
                          detailsTextBox.Text = detailsTextBox.Text+ "KEYWORD : "+key + "\r"+"In File "+Ufile.name+"   "+numberofline.Count.ToString()+" times\r";

                        for(int q=0;q<numberofline.Count;q++)
                        {
                            detailsTextBox.Text = detailsTextBox.Text + numberofline[q]+"\r";
                        }

                        detailsTextBox.Text = detailsTextBox.Text + "-----------------------------------------------\r";

                    }

                    





                }
                reader.Close();
                inFile.Close();


            }



        }

        void selectedCategory(String Categoryname)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("files.xml");
            XmlNode list2 = doc.SelectSingleNode("categories");
            XmlNodeList children = list2.ChildNodes;
            listoffiles.Clear();
            for (int i=0;i<children.Count;i++)
            {
                UserFile one = new UserFile();
                if(children[i].Name==Categoryname)
                {
                    XmlNodeList childofchild = children[i].ChildNodes;
                    one.name=childofchild[0].InnerText;
                    one.path = childofchild[1].InnerText;
                    listoffiles.Add(one);
                }
                
            }

        }


    }
}
