﻿namespace Demo2
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
            this.showMessageBox = new System.Windows.Forms.TextBox();
            this.reverselabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showMessageBox
            // 
            this.showMessageBox.Location = new System.Drawing.Point(57, 32);
            this.showMessageBox.Name = "showMessageBox";
            this.showMessageBox.Size = new System.Drawing.Size(290, 20);
            this.showMessageBox.TabIndex = 1;
            // 
            // reverselabel
            // 
            this.reverselabel.AutoSize = true;
            this.reverselabel.Location = new System.Drawing.Point(183, 133);
            this.reverselabel.Name = "reverselabel";
            this.reverselabel.Size = new System.Drawing.Size(35, 13);
            this.reverselabel.TabIndex = 2;
            this.reverselabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 234);
            this.Controls.Add(this.reverselabel);
            this.Controls.Add(this.showMessageBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Second Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox showMessageBox;
        private System.Windows.Forms.Label reverselabel;
    }
}

