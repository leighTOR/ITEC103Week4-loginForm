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
    public partial class LoginForm : Form
    {
        List<Panel> loginPage = new List<Panel>();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "user.leigh" && txtPassword.Text == "leighpass")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                lblIncorrect.Text = "The username or password you entered is incorrect.";
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            loginPage.Add(pnlLogin);
            loginPage.Add(pnlSignUp);
            loginPage.Add(pnlForgetPassword);
        }

        private void llbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.BringToFront();
        }

        private void llbForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlForgetPassword.BringToFront();
        }

        private void llbGoBackToLoginForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.BringToFront();
        }

        private void llbSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlSignUp.BringToFront();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
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
    }
}
