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
            this.label7 = new System.Windows.Forms.Label();
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
            this.picCompanyLogo = new System.Windows.Forms.PictureBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picUsername = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(213)))), ((int)(((byte)(251)))));
            this.label7.Location = new System.Drawing.Point(202, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 81);
            this.label7.TabIndex = 1;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(99)))), ((int)(((byte)(133)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(103, 384);
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
            this.chkRememberMe.Location = new System.Drawing.Point(103, 336);
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
            this.llbSignup.Location = new System.Drawing.Point(204, 468);
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
            this.lblNewUser.Location = new System.Drawing.Point(98, 468);
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
            this.lblWelcome.Location = new System.Drawing.Point(64, 67);
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(99)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(953, 564);
            this.Controls.Add(this.picCompanyLogo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblCompanyMotto);
            this.Controls.Add(this.pnlLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pinkunek";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanyMotto;
        private System.Windows.Forms.PictureBox picCompanyLogo;
        private System.Windows.Forms.Label label7;
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
    }
}

