namespace SearchEngineFile
{
    partial class DisplayFile
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DiplayFileBtn = new System.Windows.Forms.Button();
            this.FileNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(424, 249);
            this.dataGridView1.TabIndex = 14;
            // 
            // DiplayFileBtn
            // 
            this.DiplayFileBtn.Location = new System.Drawing.Point(326, 16);
            this.DiplayFileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DiplayFileBtn.Name = "DiplayFileBtn";
            this.DiplayFileBtn.Size = new System.Drawing.Size(74, 27);
            this.DiplayFileBtn.TabIndex = 13;
            this.DiplayFileBtn.Text = "Display";
            this.DiplayFileBtn.UseVisualStyleBackColor = true;
            this.DiplayFileBtn.Click += new System.EventHandler(this.DiplayFileBtn_Click);
            // 
            // FileNameTB
            // 
            this.FileNameTB.Location = new System.Drawing.Point(125, 17);
            this.FileNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.FileNameTB.Name = "FileNameTB";
            this.FileNameTB.Size = new System.Drawing.Size(103, 20);
            this.FileNameTB.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter File Name";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(405, 17);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 27);
            this.button3.TabIndex = 17;
            this.button3.Text = "Display  all Files";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DisplayFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 378);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DiplayFileBtn);
            this.Controls.Add(this.FileNameTB);
            this.Controls.Add(this.label1);
            this.Name = "DisplayFile";
            this.Text = "DisplayFile";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DiplayFileBtn;
        private System.Windows.Forms.TextBox FileNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}