using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class EditBookForm : Form
    {
        public EditBookForm()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return txtTitle.Text; }
        }

        public string Author
        {
            get { return txtAuthor.Text; }
        }

        public double Price
        {
            get { return double.Parse(txtPrice.Text); }
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            double p;
            if (!double.TryParse(txtPrice.Text, out p) || p < 0)
            {
                MessageBox.Show("Price is not a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.SelectAll();
                txtPrice.Focus();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
