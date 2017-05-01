namespace SearchEngineFile
{
    partial class AddFile
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
            this.bTn_save = new System.Windows.Forms.Button();
            this.bTn_path = new System.Windows.Forms.Button();
            this.categories = new System.Windows.Forms.CheckedListBox();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bTn_save
            // 
            this.bTn_save.Location = new System.Drawing.Point(77, 158);
            this.bTn_save.Name = "bTn_save";
            this.bTn_save.Size = new System.Drawing.Size(75, 23);
            this.bTn_save.TabIndex = 26;
            this.bTn_save.Text = "Save";
            this.bTn_save.UseVisualStyleBackColor = true;
            this.bTn_save.Click += new System.EventHandler(this.bTn_save_Click);
            // 
            // bTn_path
            // 
            this.bTn_path.Location = new System.Drawing.Point(312, 42);
            this.bTn_path.Name = "bTn_path";
            this.bTn_path.Size = new System.Drawing.Size(103, 23);
            this.bTn_path.TabIndex = 25;
            this.bTn_path.Text = "Location Path";
            this.bTn_path.UseVisualStyleBackColor = true;
            this.bTn_path.Click += new System.EventHandler(this.bTn_path_Click);
            // 
            // categories
            // 
            this.categories.FormattingEnabled = true;
            this.categories.Items.AddRange(new object[] {
            "category1",
            "category2",
            "category3",
            "category4"});
            this.categories.Location = new System.Drawing.Point(454, 16);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(183, 304);
            this.categories.TabIndex = 24;
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(77, 42);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(229, 20);
            this.txt_path.TabIndex = 22;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(77, 16);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(229, 20);
            this.txt_name.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "File Path : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "File Name : ";
            // 
            // AddFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 373);
            this.Controls.Add(this.bTn_save);
            this.Controls.Add(this.bTn_path);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFile";
            this.Text = "AddFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bTn_save;
        private System.Windows.Forms.Button bTn_path;
        private System.Windows.Forms.CheckedListBox categories;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}