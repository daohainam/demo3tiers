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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public string UserName
        {
            get { return txtUser.Text; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
        }
    }
}
