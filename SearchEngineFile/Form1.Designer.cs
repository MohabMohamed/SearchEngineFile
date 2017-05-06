namespace SearchEngineFile
{
    partial class Form1
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
            this.KeywordDetails = new System.Windows.Forms.Button();
            this.DisplayCategoryBtn = new System.Windows.Forms.Button();
            this.DisplayFileBtn = new System.Windows.Forms.Button();
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.AddFileBtn = new System.Windows.Forms.Button();
            this.Highlight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KeywordDetails
            // 
            this.KeywordDetails.Location = new System.Drawing.Point(155, 262);
            this.KeywordDetails.Margin = new System.Windows.Forms.Padding(2);
            this.KeywordDetails.Name = "KeywordDetails";
            this.KeywordDetails.Size = new System.Drawing.Size(143, 37);
            this.KeywordDetails.TabIndex = 19;
            this.KeywordDetails.Text = "Keyword Details";
            this.KeywordDetails.UseVisualStyleBackColor = true;
            this.KeywordDetails.Click += new System.EventHandler(this.KeywordDetails_Click);
            // 
            // DisplayCategoryBtn
            // 
            this.DisplayCategoryBtn.Location = new System.Drawing.Point(155, 202);
            this.DisplayCategoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DisplayCategoryBtn.Name = "DisplayCategoryBtn";
            this.DisplayCategoryBtn.Size = new System.Drawing.Size(143, 37);
            this.DisplayCategoryBtn.TabIndex = 18;
            this.DisplayCategoryBtn.Text = "Display Category";
            this.DisplayCategoryBtn.UseVisualStyleBackColor = true;
            this.DisplayCategoryBtn.Click += new System.EventHandler(this.DisplayCategoryBtn_Click);
            // 
            // DisplayFileBtn
            // 
            this.DisplayFileBtn.Location = new System.Drawing.Point(155, 142);
            this.DisplayFileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DisplayFileBtn.Name = "DisplayFileBtn";
            this.DisplayFileBtn.Size = new System.Drawing.Size(143, 37);
            this.DisplayFileBtn.TabIndex = 17;
            this.DisplayFileBtn.Text = "Display File";
            this.DisplayFileBtn.UseVisualStyleBackColor = true;
            this.DisplayFileBtn.Click += new System.EventHandler(this.DisplayFileBtn_Click);
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.Location = new System.Drawing.Point(155, 83);
            this.AddCategoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(143, 37);
            this.AddCategoryBtn.TabIndex = 16;
            this.AddCategoryBtn.Text = "Add category";
            this.AddCategoryBtn.UseVisualStyleBackColor = true;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // AddFileBtn
            // 
            this.AddFileBtn.Location = new System.Drawing.Point(155, 24);
            this.AddFileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddFileBtn.Name = "AddFileBtn";
            this.AddFileBtn.Size = new System.Drawing.Size(143, 37);
            this.AddFileBtn.TabIndex = 15;
            this.AddFileBtn.Text = "Add File";
            this.AddFileBtn.UseVisualStyleBackColor = true;
            this.AddFileBtn.Click += new System.EventHandler(this.AddFileBtn_Click);
            // 
            // Highlight
            // 
            this.Highlight.Location = new System.Drawing.Point(155, 322);
            this.Highlight.Name = "Highlight";
            this.Highlight.Size = new System.Drawing.Size(143, 37);
            this.Highlight.TabIndex = 20;
            this.Highlight.Text = "Highlight";
            this.Highlight.UseVisualStyleBackColor = true;
            this.Highlight.Click += new System.EventHandler(this.Highlight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 400);
            this.Controls.Add(this.Highlight);
            this.Controls.Add(this.KeywordDetails);
            this.Controls.Add(this.DisplayCategoryBtn);
            this.Controls.Add(this.DisplayFileBtn);
            this.Controls.Add(this.AddCategoryBtn);
            this.Controls.Add(this.AddFileBtn);
            this.Name = "Form1";
            this.Text = "Welcome to File Search Engine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KeywordDetails;
        private System.Windows.Forms.Button DisplayCategoryBtn;
        private System.Windows.Forms.Button DisplayFileBtn;
        private System.Windows.Forms.Button AddCategoryBtn;
        private System.Windows.Forms.Button AddFileBtn;
        private System.Windows.Forms.Button Highlight;
    }
}

