namespace SearchEngineFile
{
    partial class Highlightform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Highlightform));
            this.richHighlight = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboHighlight = new System.Windows.Forms.ComboBox();
            this.listHighlight = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // richHighlight
            // 
            this.richHighlight.Location = new System.Drawing.Point(202, 12);
            this.richHighlight.Name = "richHighlight";
            this.richHighlight.Size = new System.Drawing.Size(471, 253);
            this.richHighlight.TabIndex = 0;
            this.richHighlight.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filename";
            // 
            // comboHighlight
            // 
            this.comboHighlight.FormattingEnabled = true;
            this.comboHighlight.Location = new System.Drawing.Point(66, 34);
            this.comboHighlight.Name = "comboHighlight";
            this.comboHighlight.Size = new System.Drawing.Size(121, 21);
            this.comboHighlight.TabIndex = 3;
            this.comboHighlight.SelectedIndexChanged += new System.EventHandler(this.comboHighlight_SelectedIndexChanged);
            // 
            // listHighlight
            // 
            this.listHighlight.FormattingEnabled = true;
            this.listHighlight.Location = new System.Drawing.Point(66, 118);
            this.listHighlight.Name = "listHighlight";
            this.listHighlight.Size = new System.Drawing.Size(120, 147);
            this.listHighlight.TabIndex = 5;
            this.listHighlight.SelectedIndexChanged += new System.EventHandler(this.listHighlight_SelectedIndexChanged);
            // 
            // Highlightform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 290);
            this.Controls.Add(this.listHighlight);
            this.Controls.Add(this.comboHighlight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richHighlight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Highlightform";
            this.Text = "Highlightform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richHighlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboHighlight;
        private System.Windows.Forms.ListBox listHighlight;
    }
}