﻿namespace SWE_Project_PALA
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(555, 459);
            this.listBox1.TabIndex = 0;
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(574, 13);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(168, 64);
            this.btnAddCust.TabIndex = 1;
            this.btnAddCust.Text = "Add";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(574, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(574, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 64);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 476);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
