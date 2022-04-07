using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginFormDesign_winforms
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPeerUsername.Text == "" && txtYourUsername.Text == "" && txtNewPassword.Text == "" && txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill out all.");
            }
            else
            {
                MessageBox.Show("Succesfully Submitted!");
                txtConfirmPassword.Clear();
                txtPeerUsername.Clear();
                txtYourUsername.Clear();
                txtNewPassword.Clear();
            }
        }

        private void llbGoBackToLoginForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
