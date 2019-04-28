namespace SWE_Project_PALA
{
    partial class CustomerBalanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise; false.</param>
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
            this.btn_expense = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxAccountBalance = new System.Windows.Forms.TextBox();
            this.LableCustomerName = new System.Windows.Forms.Label();
            this.labelCurrentBalance = new System.Windows.Forms.Label();
            this.btnTakeIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_expense
            // 
            this.btn_expense.Location = new System.Drawing.Point(29, 206);
            this.btn_expense.Name = "btn_expense";
            this.btn_expense.Size = new System.Drawing.Size(75, 23);
            this.btn_expense.TabIndex = 0;
            this.btn_expense.Text = "Expense";
            this.btn_expense.UseVisualStyleBackColor = true;
            this.btn_expense.Click += new System.EventHandler(this.btn_expense_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(189, 206);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "AccountBalance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "value:";
            // 
            // txtBoxAccountBalance
            // 
            this.txtBoxAccountBalance.Location = new System.Drawing.Point(108, 94);
            this.txtBoxAccountBalance.Name = "txtBoxAccountBalance";
            this.txtBoxAccountBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAccountBalance.TabIndex = 5;
            // 
            // LableCustomerName
            // 
            this.LableCustomerName.AutoSize = true;
            this.LableCustomerName.Location = new System.Drawing.Point(40, 64);
            this.LableCustomerName.Name = "LableCustomerName";
            this.LableCustomerName.Size = new System.Drawing.Size(38, 13);
            this.LableCustomerName.TabIndex = 3;
            this.LableCustomerName.Text = "NAME";
            // 
            // labelCurrentBalance
            // 
            this.labelCurrentBalance.AutoSize = true;
            this.labelCurrentBalance.Location = new System.Drawing.Point(129, 136);
            this.labelCurrentBalance.Name = "labelCurrentBalance";
            this.labelCurrentBalance.Size = new System.Drawing.Size(79, 13);
            this.labelCurrentBalance.TabIndex = 3;
            this.labelCurrentBalance.Text = "Current amount";
            // 
            // btnTakeIn
            // 
            this.btnTakeIn.Location = new System.Drawing.Point(108, 206);
            this.btnTakeIn.Name = "btnTakeIn";
            this.btnTakeIn.Size = new System.Drawing.Size(75, 23);
            this.btnTakeIn.TabIndex = 0;
            this.btnTakeIn.Text = "Take in";
            this.btnTakeIn.UseVisualStyleBackColor = true;
            this.btnTakeIn.Click += new System.EventHandler(this.btnTakeIn_Click);
            // 
            // CustomerBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtBoxAccountBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LableCustomerName);
            this.Controls.Add(this.labelCurrentBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnTakeIn);
            this.Controls.Add(this.btn_expense);
            this.Name = "CustomerBalanceForm";
            this.Text = "CustomerBalanceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_expense;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxAccountBalance;
        private System.Windows.Forms.Label LableCustomerName;
        private System.Windows.Forms.Label labelCurrentBalance;
        private System.Windows.Forms.Button btnTakeIn;
    }
}