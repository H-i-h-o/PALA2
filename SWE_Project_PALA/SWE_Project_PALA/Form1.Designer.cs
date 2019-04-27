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
            this.btn_AddCust = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SFButton = new System.Windows.Forms.Button();
            this.listViewCustomer = new System.Windows.Forms.ListView();
            this.ShowAllBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanelDetails = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_CustNr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_email = new System.Windows.Forms.Label();
            this.lab_balance = new System.Windows.Forms.Label();
            this.lab_Adress = new System.Windows.Forms.Label();
            this.tableLayoutPanelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AddCust
            // 
            this.btn_AddCust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddCust.Location = new System.Drawing.Point(793, 12);
            this.btn_AddCust.Name = "btn_AddCust";
            this.btn_AddCust.Size = new System.Drawing.Size(168, 64);
            this.btn_AddCust.TabIndex = 1;
            this.btn_AddCust.Text = "Add";
            this.btn_AddCust.UseVisualStyleBackColor = true;
            this.btn_AddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.Enabled = false;
            this.btn_Edit.Location = new System.Drawing.Point(793, 83);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(168, 64);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(793, 153);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(168, 64);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // SFButton
            // 
            this.SFButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SFButton.Location = new System.Drawing.Point(793, 483);
            this.SFButton.Name = "SFButton";
            this.SFButton.Size = new System.Drawing.Size(168, 64);
            this.SFButton.TabIndex = 4;
            this.SFButton.Text = "Sort or filter ...";
            this.SFButton.UseVisualStyleBackColor = true;
            this.SFButton.Click += new System.EventHandler(this.SFButton_Click);
            // 
            // listViewCustomer
            // 
            this.listViewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCustomer.HideSelection = false;
            this.listViewCustomer.Location = new System.Drawing.Point(12, 12);
            this.listViewCustomer.Name = "listViewCustomer";
            this.listViewCustomer.Size = new System.Drawing.Size(775, 607);
            this.listViewCustomer.TabIndex = 6;
            this.listViewCustomer.UseCompatibleStateImageBehavior = false;
            this.listViewCustomer.View = System.Windows.Forms.View.Details;
            this.listViewCustomer.SelectedIndexChanged += new System.EventHandler(this.listViewCustomer_Click);
            this.listViewCustomer.Click += new System.EventHandler(this.listViewCustomer_Click);
            this.listViewCustomer.DoubleClick += new System.EventHandler(this.listViewCustomer_DoubleClick);
            // 
            // ShowAllBtn
            // 
            this.ShowAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowAllBtn.Location = new System.Drawing.Point(793, 556);
            this.ShowAllBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowAllBtn.Name = "ShowAllBtn";
            this.ShowAllBtn.Size = new System.Drawing.Size(168, 63);
            this.ShowAllBtn.TabIndex = 7;
            this.ShowAllBtn.Text = "Show all customers";
            this.ShowAllBtn.UseVisualStyleBackColor = true;
            this.ShowAllBtn.Click += new System.EventHandler(this.ShowAllBtn_Click);
            // 
            // tableLayoutPanelDetails
            // 
            this.tableLayoutPanelDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelDetails.ColumnCount = 1;
            this.tableLayoutPanelDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelDetails.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelDetails.Controls.Add(this.lab_CustNr, 0, 1);
            this.tableLayoutPanelDetails.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanelDetails.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanelDetails.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanelDetails.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanelDetails.Controls.Add(this.lab_name, 0, 3);
            this.tableLayoutPanelDetails.Controls.Add(this.lab_email, 0, 5);
            this.tableLayoutPanelDetails.Controls.Add(this.lab_balance, 0, 7);
            this.tableLayoutPanelDetails.Controls.Add(this.lab_Adress, 0, 9);
            this.tableLayoutPanelDetails.Location = new System.Drawing.Point(793, 223);
            this.tableLayoutPanelDetails.Name = "tableLayoutPanelDetails";
            this.tableLayoutPanelDetails.RowCount = 10;
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelDetails.Size = new System.Drawing.Size(168, 254);
            this.tableLayoutPanelDetails.TabIndex = 8;
            this.tableLayoutPanelDetails.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Number:";
            // 
            // lab_CustNr
            // 
            this.lab_CustNr.AutoSize = true;
            this.lab_CustNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_CustNr.Location = new System.Drawing.Point(3, 19);
            this.lab_CustNr.Name = "lab_CustNr";
            this.lab_CustNr.Size = new System.Drawing.Size(46, 17);
            this.lab_CustNr.TabIndex = 1;
            this.lab_CustNr.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Account Balance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Address:";
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_name.Location = new System.Drawing.Point(3, 69);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(46, 17);
            this.lab_name.TabIndex = 1;
            this.lab_name.Text = "label2";
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_email.Location = new System.Drawing.Point(3, 119);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(46, 17);
            this.lab_email.TabIndex = 1;
            this.lab_email.Text = "label2";
            // 
            // lab_balance
            // 
            this.lab_balance.AutoSize = true;
            this.lab_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_balance.Location = new System.Drawing.Point(3, 169);
            this.lab_balance.Name = "lab_balance";
            this.lab_balance.Size = new System.Drawing.Size(46, 17);
            this.lab_balance.TabIndex = 1;
            this.lab_balance.Text = "label2";
            // 
            // lab_Adress
            // 
            this.lab_Adress.AutoSize = true;
            this.lab_Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Adress.Location = new System.Drawing.Point(3, 219);
            this.lab_Adress.Name = "lab_Adress";
            this.lab_Adress.Size = new System.Drawing.Size(35, 13);
            this.lab_Adress.TabIndex = 1;
            this.lab_Adress.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 631);
            this.Controls.Add(this.tableLayoutPanelDetails);
            this.Controls.Add(this.ShowAllBtn);
            this.Controls.Add(this.listViewCustomer);
            this.Controls.Add(this.SFButton);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_AddCust);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanelDetails.ResumeLayout(false);
            this.tableLayoutPanelDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_AddCust;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button SFButton;
        private System.Windows.Forms.ListView listViewCustomer;
        private System.Windows.Forms.Button ShowAllBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_CustNr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.Label lab_balance;
        private System.Windows.Forms.Label lab_Adress;
    }
}

