using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Project_PALA
{
    public partial class SortingAndFilteringForm : Form
    {
        public bool SortList = false;
        public string SortBy = "";
        public bool SortAscending = false;
        public bool SortDescending = false;

        public bool FilterList = false;
        public string FilterBy = "";
        public string FilterSearchString = "";

        public SortingAndFilteringForm()
        {
            InitializeComponent();
        }
        
        private void SortCheckBox_Click(object sender, EventArgs e)
        {
            if(SortCheckBox.Checked)
            {
                FilterCheckBox.Checked = false;
            }
            SortGroupBox.Enabled = SortCheckBox.Checked;
            FilterGroupBox.Enabled = FilterCheckBox.Checked;
        }

        private void FilterCheckBox_Click(object sender, EventArgs e)
        {
            if (FilterCheckBox.Checked)
            {
                SortCheckBox.Checked = false;
            }
            SortGroupBox.Enabled = SortCheckBox.Checked;
            FilterGroupBox.Enabled = FilterCheckBox.Checked;
        }

        private void AscendingCheckBox_Click(object sender, EventArgs e)
        {
            AscendingCheckBox.Checked = true;
            DescendingCheckBox.Checked = false;
        }

        private void DescendingCheckBox_Click(object sender, EventArgs e)
        {
            DescendingCheckBox.Checked = true;
            AscendingCheckBox.Checked = false;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(SortCheckBox.Checked || FilterCheckBox.Checked)
            {
                if (SortCheckBox.Checked)
                {
                    if (SortComboBox.SelectedItem != null)
                    {
                        SortList = true;
                        SortBy = SortComboBox.SelectedItem.ToString();
                        SortAscending = AscendingCheckBox.Checked;
                        SortDescending = DescendingCheckBox.Checked;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error: invalid input" + Environment.NewLine + "Check if you have selected a category for sorting!");
                    }
                }
                if(FilterCheckBox.Checked)
                {
                    if (FilterComboBox.SelectedItem != null && SearchStringTextBox.Text != string.Empty)
                    {
                        FilterList = true;
                        FilterBy = FilterComboBox.SelectedItem.ToString();
                        FilterSearchString = SearchStringTextBox.Text;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error: invalid input" + Environment.NewLine + "Check if you have selected a category for filtering!" + Environment.NewLine + "Check if you have entered something to search for");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: invalid input" + Environment.NewLine + "Check if you have selected sorting or filtering!");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
