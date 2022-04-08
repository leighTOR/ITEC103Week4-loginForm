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
        List<Panel> panelList = new List<Panel>();

        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clicking the login button in the login panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "user.leigh" && txtPassword.Text == "leighpass")
            {
                HomeForm home = new HomeForm();
                home.Show();
                this.Hide();
            }
            else
            {
                lblIncorrect.Text = "The username or password you entered is incorrect.";
            }
        }

        /// <summary>
        /// Loading the panels of the Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            panelList.Add(pnlLogin);
            panelList.Add(pnlSignUp);
            panelList.Add(pnlForgetPassword);
        }

        /// <summary>
        /// Clicking the Forgot Password link label from login panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llbForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlForgetPassword.BringToFront();
        }

        /// <summary>
        /// Clicking Sign up button in sign up panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtCUsername.Text == "" || txtCPassword.Text == "")
            {
                MessageBox.Show("Please fill out all.");
            }
            else
            {
                HomeForm home = new HomeForm();
                home.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Clicking submit button in Forgot Password panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (txtPeerUsername.Text == "" || txtYourUsername.Text == "" || txtNewPassword.Text == "" || txtConfirmPassword.Text == "")
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

        /// <summary>
        /// Clicking the Login link label from Sign up and Forgot pass panels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.BringToFront();
        }

        /// <summary>
        /// Clicking the Sign up link label from login panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llbSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlSignUp.BringToFront();
        }
    }
}