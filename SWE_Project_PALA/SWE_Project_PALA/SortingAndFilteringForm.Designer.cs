using System.Windows.Forms;

namespace SWE_Project_PALA
{
    partial class SortingAndFilteringForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //public CheckBox SortCheckBox { get; private set; }

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
            this.SortCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterCheckBox = new System.Windows.Forms.CheckBox();
            this.SortGroupBox = new System.Windows.Forms.GroupBox();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.DescendingCheckBox = new System.Windows.Forms.CheckBox();
            this.AscendingCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchStringTextBox = new System.Windows.Forms.TextBox();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SortGroupBox.SuspendLayout();
            this.FilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SortCheckBox
            // 
            this.SortCheckBox.AutoSize = true;
            this.SortCheckBox.Location = new System.Drawing.Point(32, 28);
            this.SortCheckBox.Name = "SortCheckBox";
            this.SortCheckBox.Size = new System.Drawing.Size(139, 21);
            this.SortCheckBox.TabIndex = 0;
            this.SortCheckBox.Text = "Sort customer list";
            this.SortCheckBox.UseVisualStyleBackColor = true;
            this.SortCheckBox.Click += new System.EventHandler(this.SortCheckBox_Click);
            // 
            // FilterCheckBox
            // 
            this.FilterCheckBox.AutoSize = true;
            this.FilterCheckBox.Location = new System.Drawing.Point(32, 186);
            this.FilterCheckBox.Name = "FilterCheckBox";
            this.FilterCheckBox.Size = new System.Drawing.Size(144, 21);
            this.FilterCheckBox.TabIndex = 1;
            this.FilterCheckBox.Text = "Filter customer list";
            this.FilterCheckBox.UseVisualStyleBackColor = true;
            this.FilterCheckBox.Click += new System.EventHandler(this.FilterCheckBox_Click);
            // 
            // SortGroupBox
            // 
            this.SortGroupBox.Controls.Add(this.SortComboBox);
            this.SortGroupBox.Controls.Add(this.DescendingCheckBox);
            this.SortGroupBox.Controls.Add(this.AscendingCheckBox);
            this.SortGroupBox.Enabled = false;
            this.SortGroupBox.Location = new System.Drawing.Point(32, 55);
            this.SortGroupBox.Name = "SortGroupBox";
            this.SortGroupBox.Size = new System.Drawing.Size(369, 112);
            this.SortGroupBox.TabIndex = 2;
            this.SortGroupBox.TabStop = false;
            this.SortGroupBox.Text = "Settings for sorting";
            // 
            // SortComboBox
            // 
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Items.AddRange(new object[] {
            "Cusomer number",
            "First name",
            "Last name",
            "Email",
            "Account balance",
            "Last Access"});
            this.SortComboBox.Location = new System.Drawing.Point(18, 33);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(137, 24);
            this.SortComboBox.TabIndex = 4;
            this.SortComboBox.Text = "Sort by ...";
            // 
            // DescendingCheckBox
            // 
            this.DescendingCheckBox.AutoSize = true;
            this.DescendingCheckBox.Location = new System.Drawing.Point(225, 69);
            this.DescendingCheckBox.Name = "DescendingCheckBox";
            this.DescendingCheckBox.Size = new System.Drawing.Size(105, 21);
            this.DescendingCheckBox.TabIndex = 1;
            this.DescendingCheckBox.Text = "Descending";
            this.DescendingCheckBox.UseVisualStyleBackColor = true;
            this.DescendingCheckBox.Click += new System.EventHandler(this.DescendingCheckBox_Click);
            // 
            // AscendingCheckBox
            // 
            this.AscendingCheckBox.AutoSize = true;
            this.AscendingCheckBox.Checked = true;
            this.AscendingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AscendingCheckBox.Location = new System.Drawing.Point(225, 33);
            this.AscendingCheckBox.Name = "AscendingCheckBox";
            this.AscendingCheckBox.Size = new System.Drawing.Size(96, 21);
            this.AscendingCheckBox.TabIndex = 0;
            this.AscendingCheckBox.Text = "Ascending";
            this.AscendingCheckBox.UseVisualStyleBackColor = true;
            this.AscendingCheckBox.Click += new System.EventHandler(this.AscendingCheckBox_Click);
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.Controls.Add(this.SearchStringTextBox);
            this.FilterGroupBox.Controls.Add(this.FilterComboBox);
            this.FilterGroupBox.Enabled = false;
            this.FilterGroupBox.Location = new System.Drawing.Point(32, 213);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(369, 87);
            this.FilterGroupBox.TabIndex = 3;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Settings for filtering";
            // 
            // SearchStringTextBox
            // 
            this.SearchStringTextBox.Location = new System.Drawing.Point(202, 36);
            this.SearchStringTextBox.Name = "SearchStringTextBox";
            this.SearchStringTextBox.Size = new System.Drawing.Size(150, 22);
            this.SearchStringTextBox.TabIndex = 1;
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "First name",
            "Last name",
            "Email",
            "Postal code",
            "City"});
            this.FilterComboBox.Location = new System.Drawing.Point(18, 36);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(137, 24);
            this.FilterComboBox.TabIndex = 0;
            this.FilterComboBox.Text = "Filter by ...";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(32, 328);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(326, 328);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SortingAndFilteringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 377);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.FilterGroupBox);
            this.Controls.Add(this.SortGroupBox);
            this.Controls.Add(this.FilterCheckBox);
            this.Controls.Add(this.SortCheckBox);
            this.Name = "SortingAndFilteringForm";
            this.Text = "SortingAndFilteringForm";
            this.SortGroupBox.ResumeLayout(false);
            this.SortGroupBox.PerformLayout();
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SortCheckBox;
        private System.Windows.Forms.CheckBox FilterCheckBox;
        private System.Windows.Forms.GroupBox SortGroupBox;
        private System.Windows.Forms.CheckBox AscendingCheckBox;
        private System.Windows.Forms.GroupBox FilterGroupBox;
        private System.Windows.Forms.ComboBox SortComboBox;
        private System.Windows.Forms.CheckBox DescendingCheckBox;
        private System.Windows.Forms.TextBox SearchStringTextBox;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
    }
}