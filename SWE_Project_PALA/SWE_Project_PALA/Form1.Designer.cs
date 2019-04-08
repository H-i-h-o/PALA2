namespace SWE_Project_PALA
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
            this.btn_AddCust = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SFButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(555, 420);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // btn_AddCust
            // 
            this.btn_AddCust.Location = new System.Drawing.Point(574, 13);
            this.btn_AddCust.Name = "btn_AddCust";
            this.btn_AddCust.Size = new System.Drawing.Size(168, 64);
            this.btn_AddCust.TabIndex = 1;
            this.btn_AddCust.Text = "Add";
            this.btn_AddCust.UseVisualStyleBackColor = true;
            this.btn_AddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Enabled = false;
            this.btn_Edit.Location = new System.Drawing.Point(574, 83);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(168, 64);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(574, 152);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(168, 64);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // SFButton
            // 
            this.SFButton.Location = new System.Drawing.Point(574, 368);
            this.SFButton.Name = "SFButton";
            this.SFButton.Size = new System.Drawing.Size(168, 64);
            this.SFButton.TabIndex = 4;
            this.SFButton.Text = "Sort or filter ...";
            this.SFButton.UseVisualStyleBackColor = true;
            this.SFButton.Click += new System.EventHandler(this.SFButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 508);
            this.Controls.Add(this.SFButton);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_AddCust);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_AddCust;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button SFButton;
    }
}

