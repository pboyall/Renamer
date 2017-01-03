namespace Renamer
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.btnNames = new System.Windows.Forms.Button();
            this.btnFolders = new System.Windows.Forms.Button();
            this.txtFolders = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(831, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(12, 12);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(253, 20);
            this.txtNames.TabIndex = 1;
            // 
            // btnNames
            // 
            this.btnNames.Location = new System.Drawing.Point(287, 13);
            this.btnNames.Name = "btnNames";
            this.btnNames.Size = new System.Drawing.Size(75, 23);
            this.btnNames.TabIndex = 2;
            this.btnNames.Text = "Names";
            this.btnNames.UseVisualStyleBackColor = true;
            this.btnNames.Click += new System.EventHandler(this.btnNames_Click);
            // 
            // btnFolders
            // 
            this.btnFolders.Location = new System.Drawing.Point(287, 39);
            this.btnFolders.Name = "btnFolders";
            this.btnFolders.Size = new System.Drawing.Size(75, 23);
            this.btnFolders.TabIndex = 4;
            this.btnFolders.Text = "Folders";
            this.btnFolders.UseVisualStyleBackColor = true;
            this.btnFolders.Click += new System.EventHandler(this.btnFolders_Click);
            // 
            // txtFolders
            // 
            this.txtFolders.Location = new System.Drawing.Point(12, 38);
            this.txtFolders.Name = "txtFolders";
            this.txtFolders.Size = new System.Drawing.Size(253, 20);
            this.txtFolders.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 261);
            this.Controls.Add(this.btnFolders);
            this.Controls.Add(this.txtFolders);
            this.Controls.Add(this.btnNames);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.Button btnNames;
        private System.Windows.Forms.Button btnFolders;
        private System.Windows.Forms.TextBox txtFolders;
    }
}

