namespace SearchEngineFile
{
    partial class AddCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Addbtn = new System.Windows.Forms.Button();
            this.KeywordsGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryNameTB = new System.Windows.Forms.TextBox();
            this.Keywords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.KeywordsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(180, 294);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(56, 19);
            this.Addbtn.TabIndex = 7;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // KeywordsGV
            // 
            this.KeywordsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KeywordsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Keywords});
            this.KeywordsGV.Location = new System.Drawing.Point(33, 60);
            this.KeywordsGV.Margin = new System.Windows.Forms.Padding(2);
            this.KeywordsGV.Name = "KeywordsGV";
            this.KeywordsGV.RowTemplate.Height = 24;
            this.KeywordsGV.Size = new System.Drawing.Size(203, 215);
            this.KeywordsGV.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category Name";
            // 
            // CategoryNameTB
            // 
            this.CategoryNameTB.Location = new System.Drawing.Point(130, 22);
            this.CategoryNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.CategoryNameTB.Name = "CategoryNameTB";
            this.CategoryNameTB.Size = new System.Drawing.Size(106, 20);
            this.CategoryNameTB.TabIndex = 4;
            // 
            // Keywords
            // 
            this.Keywords.FillWeight = 160F;
            this.Keywords.HeaderText = "Keywords";
            this.Keywords.Name = "Keywords";
            this.Keywords.Width = 160;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 324);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.KeywordsGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryNameTB);
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KeywordsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.DataGridView KeywordsGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CategoryNameTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keywords;
    }
}