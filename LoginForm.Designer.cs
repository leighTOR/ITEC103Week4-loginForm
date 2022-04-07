namespace loginFormDesign_winforms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCompanyMotto = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.llbSignup = new System.Windows.Forms.LinkLabel();
            this.lblNewUser = new System.Windows.Forms.Label();
            this.llbForgotPassword = new System.Windows.Forms.LinkLabel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picUsername = new System.Windows.Forms.PictureBox();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.lblCreateAn = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtCPassword = new System.Windows.Forms.TextBox();
            this.txtCUsername = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblCPassword = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblCUsername = new System.Windows.Forms.Label();
            this.llbLogin = new System.Windows.Forms.LinkLabel();
            this.chkCRememberMe = new System.Windows.Forms.CheckBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAlreadyHaveAnAccount = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlForgetPassword = new System.Windows.Forms.Panel();
            this.txtYourUsername = new System.Windows.Forms.TextBox();
            this.txtPeerUsername = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.picConfirmPassword = new System.Windows.Forms.PictureBox();
            this.lblYourUsername = new System.Windows.Forms.Label();
            this.picNewPassword = new System.Windows.Forms.PictureBox();
            this.picYourUsername = new System.Windows.Forms.PictureBox();
            this.lblPeersUsername = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.picPeersUsername = new System.Windows.Forms.PictureBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.llbGoBackToLoginForm = new System.Windows.Forms.LinkLabel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.picCompanyLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            this.pnlSignUp.SuspendLayout();
            this.pnlForgetPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYourUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeersUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI Black", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(227)))), ((int)(((byte)(235)))));
            this.lblCompanyName.Location = new System.Drawing.Point(52, 345);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(352, 81);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "PINKUNEK";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCompanyMotto
            // 
            this.lblCompanyMotto.AutoSize = true;
            this.lblCompanyMotto.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyMotto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyMotto.ForeColor = System.Drawing.Color.White;
            this.lblCompanyMotto.Location = new System.Drawing.Point(94, 426);
            this.lblCompanyMotto.Name = "lblCompanyMotto";
            this.lblCompanyMotto.Size = new System.Drawing.Size(267, 64);
            this.lblCompanyMotto.TabIndex = 3;
            this.lblCompanyMotto.Text = "Connect with peers and\r\nbe productive together";
            this.lblCompanyMotto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(99)))), ((int)(((byte)(133)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(103, 413);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 42);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.BackColor = System.Drawing.Color.White;
            this.chkRememberMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRememberMe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRememberMe.Location = new System.Drawing.Point(103, 363);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(164, 34);
            this.chkRememberMe.TabIndex = 4;
            this.chkRememberMe.Text = "Remember me";
            this.chkRememberMe.UseVisualStyleBackColor = false;
            // 
            // llbSignup
            // 
            this.llbSignup.AutoSize = true;
            this.llbSignup.BackColor = System.Drawing.Color.White;
            this.llbSignup.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.llbSignup.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(99)))), ((int)(((byte)(133)))));
            this.llbSignup.Location = new System.Drawing.Point(207, 513);
            this.llbSignup.Name = "llbSignup";
            this.llbSignup.Size = new System.Drawing.Size(83, 30);
            this.llbSignup.TabIndex = 6;
            this.llbSignup.TabStop = true;
            this.llbSignup.Text = "Sign up";
            this.llbSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSignup_LinkClicked);
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.BackColor = System.Drawing.Color.White;
            this.lblNewUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUser.Location = new System.Drawing.Point(101, 513);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(109, 30);
            this.lblNewUser.TabIndex = 3;
            this.lblNewUser.Text = "New user?";
            // 
            // llbForgotPassword
            // 
            this.llbForgotPassword.AutoSize = true;
            this.llbForgotPassword.BackColor = System.Drawing.Color.White;
            this.llbForgotPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(99)))), ((int)(((byte)(133)))));
            this.llbForgotPassword.Location = new System.Drawing.Point(308, 265);
            this.llbForgotPassword.Name = "llbForgotPassword";
            this.llbForgotPassword.Size = new System.Drawing.Size(134, 21);
            this.llbForgotPassword.TabIndex = 6;
            this.llbForgotPassword.TabStop = true;
            this.llbForgotPassword.Text = "Forgot password?";
            this.llbForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbForgotPassword_LinkClicked);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(57, 256);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(111, 32);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(57, 165);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(117, 32);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(103, 291);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(339, 35);
            this.txtPassword.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(103, 200);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(339, 35);
            this.txtUsername.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.White;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Black", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(99)))), ((int)(((byte)(133)))));
            this.lblWelcome.Location = new System.Drawing.Point(56, 56);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(378, 89);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "WELCOME";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.lblWelcome);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.picPassword);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.picUsername);
            this.pnlLogin.Controls.Add(this.lblIncorrect);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.llbForgotPassword);
            this.pnlLogin.Controls.Add(this.lblNewUser);
            this.pnlLogin.Controls.Add(this.llbSignup);
            this.pnlLogin.Controls.Add(this.chkRememberMe);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLogin.Location = new System.Drawing.Point(465, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(490, 565);
            this.pnlLogin.TabIndex = 10;
            // 
            // picPassword
            // 
            this.picPassword.BackColor = System.Drawing.Color.White;
            this.picPassword.Image = global::loginFormDesign_winforms.Properties.Resources.output_onlinepngtools__1_;
            this.picPassword.Location = new System.Drawing.Point(67, 296);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(30, 30);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPassword.TabIndex = 9;
            this.picPassword.TabStop = false;
            // 
            // picUsername
            // 
            this.picUsername.BackColor = System.Drawing.Color.Transparent;
            this.picUsername.Image = global::loginFormDesign_winforms.Properties.Resources.output_onlinepngtools;
            this.picUsername.Location = new System.Drawing.Point(67, 205);
            this.picUsername.Name = "picUsername";
            this.picUsername.Size = new System.Drawing.Size(30, 30);
            this.picUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsername.TabIndex = 8;
            this.picUsername.TabStop = false;
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.BackColor = System.Drawing.Color.White;
            this.lblIncorrect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrect.Location = new System.Drawing.Point(63, 337);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(0, 21);
            this.lblIncorrect.TabIndex = 3;
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.BackColor = System.Drawing.Color.White;
            this.pnlSignUp.Controls.Add(this.lblCreateAn);
            this.pnlSignUp.Controls.Add(this.lblAccount);
            this.pnlSignUp.Controls.Add(this.txtCPassword);
            this.pnlSignUp.Controls.Add(this.txtCUsername);
            this.pnlSignUp.Controls.Add(this.txtLastName);
            this.pnlSignUp.Controls.Add(this.txtFirstName);
            this.pnlSignUp.Controls.Add(this.lblCPassword);
            this.pnlSignUp.Controls.Add(this.btnSignUp);
            this.pnlSignUp.Controls.Add(this.lblCUsername);
            this.pnlSignUp.Controls.Add(this.llbLogin);
            this.pnlSignUp.Controls.Add(this.chkCRememberMe);
            this.pnlSignUp.Controls.Add(this.lblLastName);
            this.pnlSignUp.Controls.Add(this.lblAlreadyHaveAnAccount);
            this.pnlSignUp.Controls.Add(this.lblFirstName);
            this.pnlSignUp.Location = new System.Drawing.Point(465, 0);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(490, 565);
            this.pnlSignUp.TabIndex = 10;
            // 
            // lblCreateAn
            // 
            this.lblCreateAn.AutoSize = true;
            this.lblCreateAn.BackColor = System.Drawing.Color.White;
            this.lblCreateAn.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(99)))), ((int)(((byte)(133)))));
            this.lblCreateAn.Location = new System.Drawing.Point(96, 33);
            this.lblCreateAn.Name = "lblCreateAn";
            this.lblCreateAn.Size = new System.Drawing.Size(298, 65);
            this.lblCreateAn.TabIndex = 1;
            this.lblCreateAn.Text = "CREATE AN\r";
            this.lblCreateAn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.Color.White;
            this.lblAccount.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(99)))), ((int)(((byte)(133)))));
            this.lblAccount.Location = new System.Drawing.Point(112, 15);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(267, 130);
            this.lblAccount.TabIndex = 10;
            this.lblAccount.Text = "\r\nACCOUNT";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCPassword
            // 
            this.txtCPassword.BackColor = System.Drawing.Color.White;
            this.txtCPassword.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPassword.Location = new System.Drawing.Point(140, 318);
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.PasswordChar = '*';
            this.txtCPassword.Size = new System.Drawing.Size(312, 33);
            this.txtCPassword.TabIndex = 0;
            // 
            // txtCUsername
            // 
            this.txtCUsername.BackColor = System.Drawing.Color.White;
            this.txtCUsername.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUsername.Location = new System.Drawing.Point(140, 274);
            this.txtCUsername.Name = "txtCUsername";
            this.txtCUsername.Size = new System.Drawing.Size(312, 33);
            this.txtCUsername.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(140, 230);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(312, 33);
            this.txtLastName.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(140, 186);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(312, 33);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblCPassword
            // 
            this.lblCPassword.AutoSize = true;
            this.lblCPassword.BackColor = System.Drawing.Color.White;
            this.lblCPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPassword.Location = new System.Drawing.Point(46, 321);
            this.lblCPassword.Name = "lblCPassword";
            this.lblCPassword.Size = new System.Drawing.Size(88, 25);
            this.lblCPassword.TabIndex = 3;
            this.lblCPassword.Text = "Password";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(99)))), ((int)(((byte)(133)))));
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(140, 414);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(128, 42);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblCUsername
            // 
            this.lblCUsername.AutoSize = true;
            this.lblCUsername.BackColor = System.Drawing.Color.White;
            this.lblCUsername.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUsername.Location = new System.Drawing.Point(39, 277);
            this.lblCUsername.Name = "lblCUsername";
            this.lblCUsername.Size = new System.Drawing.Size(95, 25);
            this.lblCUsername.TabIndex = 3;
            this.lblCUsername.Text = "Username";
            // 
            // llbLogin
            // 
            this.llbLogin.AutoSize = true;
            this.llbLogin.BackColor = System.Drawing.Color.White;
            this.llbLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.llbLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(99)))), ((int)(((byte)(133)))));
            this.llbLogin.Location = new System.Drawing.Point(385, 511);
            this.llbLogin.Name = "llbLogin";
            this.llbLogin.Size = new System.Drawing.Size(64, 30);
            this.llbLogin.TabIndex = 6;
            this.llbLogin.TabStop = true;
            this.llbLogin.Text = "Login";
            this.llbLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLogin_LinkClicked);
            // 
            // chkCRememberMe
            // 
            this.chkCRememberMe.AutoSize = true;
            this.chkCRememberMe.BackColor = System.Drawing.Color.White;
            this.chkCRememberMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkCRememberMe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCRememberMe.Location = new System.Drawing.Point(140, 363);
            this.chkCRememberMe.Name = "chkCRememberMe";
            this.chkCRememberMe.Size = new System.Drawing.Size(164, 34);
            this.chkCRememberMe.TabIndex = 4;
            this.chkCRememberMe.Text = "Remember me";
            this.chkCRememberMe.UseVisualStyleBackColor = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(34, 233);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 25);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblAlreadyHaveAnAccount
            // 
            this.lblAlreadyHaveAnAccount.AutoSize = true;
            this.lblAlreadyHaveAnAccount.BackColor = System.Drawing.Color.White;
            this.lblAlreadyHaveAnAccount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlreadyHaveAnAccount.Location = new System.Drawing.Point(135, 511);
            this.lblAlreadyHaveAnAccount.Name = "lblAlreadyHaveAnAccount";
            this.lblAlreadyHaveAnAccount.Size = new System.Drawing.Size(251, 30);
            this.lblAlreadyHaveAnAccount.TabIndex = 3;
            this.lblAlreadyHaveAnAccount.Text = "Already have an account?";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(34, 189);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(100, 25);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlForgetPassword
            // 
            this.pnlForgetPassword.BackColor = System.Drawing.Color.White;
            this.pnlForgetPassword.Controls.Add(this.txtYourUsername);
            this.pnlForgetPassword.Controls.Add(this.txtPeerUsername);
            this.pnlForgetPassword.Controls.Add(this.txtConfirmPassword);
            this.pnlForgetPassword.Controls.Add(this.txtNewPassword);
            this.pnlForgetPassword.Controls.Add(this.picConfirmPassword);
            this.pnlForgetPassword.Controls.Add(this.lblYourUsername);
            this.pnlForgetPassword.Controls.Add(this.picNewPassword);
            this.pnlForgetPassword.Controls.Add(this.picYourUsername);
            this.pnlForgetPassword.Controls.Add(this.lblPeersUsername);
            this.pnlForgetPassword.Controls.Add(this.lblConfirmPassword);
            this.pnlForgetPassword.Controls.Add(this.picPeersUsername);
            this.pnlForgetPassword.Controls.Add(this.lblNewPassword);
            this.pnlForgetPassword.Controls.Add(this.llbGoBackToLoginForm);
            this.pnlForgetPassword.Controls.Add(this.btnSubmit);
            this.pnlForgetPassword.Controls.Add(this.lblDirection);
            this.pnlForgetPassword.Controls.Add(this.lblForgotPassword);
            this.pnlForgetPassword.Location = new System.Drawing.Point(465, 0);
            this.pnlForgetPassword.Name = "pnlForgetPassword";
            this.pnlForgetPassword.Size = new System.Drawing.Size(490, 565);
            this.pnlForgetPassword.TabIndex = 11;
            // 
            // txtYourUsername
            // 
            this.txtYourUsername.BackColor = System.Drawing.Color.White;
            this.txtYourUsername.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYourUsername.Location = new System.Drawing.Point(75, 264);
            this.txtYourUsername.Name = "txtYourUsername";
            this.txtYourUsername.Size = new System.Drawing.Size(387, 33);
            this.txtYourUsername.TabIndex = 20;
            // 
            // txtPeerUsername
            // 
            this.txtPeerUsername.BackColor = System.Drawing.Color.White;
            this.txtPeerUsername.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeerUsername.Location = new System.Drawing.Point(75, 194);
            this.txtPeerUsername.Name = "txtPeerUsername";
            this.txtPeerUsername.Size = new System.Drawing.Size(387, 33);
            this.txtPeerUsername.TabIndex = 21;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(75, 402);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(387, 33);
            this.txtConfirmPassword.TabIndex = 22;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.White;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(75, 333);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(387, 33);
            this.txtNewPassword.TabIndex = 23;
            // 
            // picConfirmPassword
            // 
            this.picConfirmPassword.BackColor = System.Drawing.Color.White;
            this.picConfirmPassword.Image = global::loginFormDesign_winforms.Properties.Resources.output_onlinepngtools__1_;
            this.picConfirmPassword.Location = new System.Drawing.Point(39, 402);
            this.picConfirmPassword.Name = "picConfirmPassword";
            this.picConfirmPassword.Size = new System.Drawing.Size(30, 30);
            this.picConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picConfirmPassword.TabIndex = 32;
            this.picConfirmPassword.TabStop = false;
            // 
            // lblYourUsername
            // 
            this.lblYourUsername.AutoSize = true;
            this.lblYourUsername.BackColor = System.Drawing.Color.White;
            this.lblYourUsername.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourUsername.Location = new System.Drawing.Point(29, 236);
            this.lblYourUsername.Name = "lblYourUsername";
            this.lblYourUsername.Size = new System.Drawing.Size(167, 25);
            this.lblYourUsername.TabIndex = 24;
            this.lblYourUsername.Text = "Your Email Address";
            // 
            // picNewPassword
            // 
            this.picNewPassword.BackColor = System.Drawing.Color.White;
            this.picNewPassword.Image = global::loginFormDesign_winforms.Properties.Resources.output_onlinepngtools__1_;
            this.picNewPassword.Location = new System.Drawing.Point(39, 333);
            this.picNewPassword.Name = "picNewPassword";
            this.picNewPassword.Size = new System.Drawing.Size(30, 30);
            this.picNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNewPassword.TabIndex = 33;
            this.picNewPassword.TabStop = false;
            // 
            // picYourUsername
            // 
            this.picYourUsername.BackColor = System.Drawing.Color.Transparent;
            this.picYourUsername.Image = global::loginFormDesign_winforms.Properties.Resources.emailicon;
            this.picYourUsername.Location = new System.Drawing.Point(39, 264);
            this.picYourUsername.Name = "picYourUsername";
            this.picYourUsername.Size = new System.Drawing.Size(30, 30);
            this.picYourUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYourUsername.TabIndex = 30;
            this.picYourUsername.TabStop = false;
            // 
            // lblPeersUsername
            // 
            this.lblPeersUsername.AutoSize = true;
            this.lblPeersUsername.BackColor = System.Drawing.Color.White;
            this.lblPeersUsername.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeersUsername.Location = new System.Drawing.Point(29, 166);
            this.lblPeersUsername.Name = "lblPeersUsername";
            this.lblPeersUsername.Size = new System.Drawing.Size(146, 25);
            this.lblPeersUsername.TabIndex = 25;
            this.lblPeersUsername.Text = "Peer\'s Username";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(36, 374);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(158, 25);
            this.lblConfirmPassword.TabIndex = 26;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // picPeersUsername
            // 
            this.picPeersUsername.BackColor = System.Drawing.Color.Transparent;
            this.picPeersUsername.Image = global::loginFormDesign_winforms.Properties.Resources.output_onlinepngtools;
            this.picPeersUsername.Location = new System.Drawing.Point(39, 194);
            this.picPeersUsername.Name = "picPeersUsername";
            this.picPeersUsername.Size = new System.Drawing.Size(30, 30);
            this.picPeersUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPeersUsername.TabIndex = 31;
            this.picPeersUsername.TabStop = false;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.White;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(36, 305);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(130, 25);
            this.lblNewPassword.TabIndex = 27;
            this.lblNewPassword.Text = "New Password";
            // 
            // llbGoBackToLoginForm
            // 
            this.llbGoBackToLoginForm.AutoSize = true;
            this.llbGoBackToLoginForm.BackColor = System.Drawing.Color.White;
            this.llbGoBackToLoginForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbGoBackToLoginForm.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(99)))), ((int)(((byte)(133)))));
            this.llbGoBackToLoginForm.Location = new System.Drawing.Point(71, 520);
            this.llbGoBackToLoginForm.Name = "llbGoBackToLoginForm";
            this.llbGoBackToLoginForm.Size = new System.Drawing.Size(168, 21);
            this.llbGoBackToLoginForm.TabIndex = 29;
            this.llbGoBackToLoginForm.TabStop = true;
            this.llbGoBackToLoginForm.Text = "Go back to Login Form";
            this.llbGoBackToLoginForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGoBackToLoginForm_LinkClicked);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(99)))), ((int)(((byte)(133)))));
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(75, 466);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 42);
            this.btnSubmit.TabIndex = 28;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.BackColor = System.Drawing.Color.White;
            this.lblDirection.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirection.Location = new System.Drawing.Point(44, 81);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(410, 63);
            this.lblDirection.TabIndex = 19;
            this.lblDirection.Text = "Let us help you. Fill out the information below and we will\r\nconfirm it through y" +
    "our trusted peer’s aide. You will receive\r\na link in your email after we verify " +
    "it.";
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.BackColor = System.Drawing.Color.White;
            this.lblForgotPassword.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(99)))), ((int)(((byte)(133)))));
            this.lblForgotPassword.Location = new System.Drawing.Point(39, 32);
            this.lblForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(414, 50);
            this.lblForgotPassword.TabIndex = 18;
            this.lblForgotPassword.Text = "FORGOT PASSWORD?";
            this.lblForgotPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picCompanyLogo
            // 
            this.picCompanyLogo.BackColor = System.Drawing.Color.Transparent;
            this.picCompanyLogo.Image = global::loginFormDesign_winforms.Properties.Resources.Picture1;
            this.picCompanyLogo.Location = new System.Drawing.Point(52, 54);
            this.picCompanyLogo.Name = "picCompanyLogo";
            this.picCompanyLogo.Size = new System.Drawing.Size(352, 304);
            this.picCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompanyLogo.TabIndex = 7;
            this.picCompanyLogo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(99)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(953, 564);
            this.Controls.Add(this.picCompanyLogo);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblCompanyMotto);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlForgetPassword);
            this.Controls.Add(this.pnlSignUp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pinkunek";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUp.PerformLayout();
            this.pnlForgetPassword.ResumeLayout(false);
            this.pnlForgetPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYourUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeersUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanyMotto;
        private System.Windows.Forms.PictureBox picCompanyLogo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.LinkLabel llbSignup;
        private System.Windows.Forms.Label lblNewUser;
        private System.Windows.Forms.LinkLabel llbForgotPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox picUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlSignUp;
        private System.Windows.Forms.Label lblCreateAn;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtCPassword;
        private System.Windows.Forms.TextBox txtCUsername;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblCPassword;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblCUsername;
        private System.Windows.Forms.LinkLabel llbLogin;
        private System.Windows.Forms.CheckBox chkCRememberMe;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAlreadyHaveAnAccount;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel pnlForgetPassword;
        private System.Windows.Forms.TextBox txtYourUsername;
        private System.Windows.Forms.TextBox txtPeerUsername;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.PictureBox picConfirmPassword;
        private System.Windows.Forms.Label lblYourUsername;
        private System.Windows.Forms.PictureBox picNewPassword;
        private System.Windows.Forms.PictureBox picYourUsername;
        private System.Windows.Forms.Label lblPeersUsername;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.PictureBox picPeersUsername;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.LinkLabel llbGoBackToLoginForm;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Label lblIncorrect;
    }
}

