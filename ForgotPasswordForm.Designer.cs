namespace loginFormDesign_winforms
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.txtPeerUsername = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.picNewPassword = new System.Windows.Forms.PictureBox();
            this.lblPeersUsername = new System.Windows.Forms.Label();
            this.picPeersUsername = new System.Windows.Forms.PictureBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.llbGoBackToLoginForm = new System.Windows.Forms.LinkLabel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.picYourUsername = new System.Windows.Forms.PictureBox();
            this.lblYourUsername = new System.Windows.Forms.Label();
            this.txtYourUsername = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.picConfirmPassword = new System.Windows.Forms.PictureBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeersUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYourUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.BackColor = System.Drawing.Color.White;
            this.lblForgotPassword.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(99)))), ((int)(((byte)(133)))));
            this.lblForgotPassword.Location = new System.Drawing.Point(47, 31);
            this.lblForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(414, 50);
            this.lblForgotPassword.TabIndex = 2;
            this.lblForgotPassword.Text = "FORGOT PASSWORD?";
            this.lblForgotPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.BackColor = System.Drawing.Color.White;
            this.lblDirection.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirection.Location = new System.Drawing.Point(52, 81);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(405, 63);
            this.lblDirection.TabIndex = 4;
            this.lblDirection.Text = "Let us help you. Fill out the information below and we will\r\nconfirm it through y" +
    "ou trusted peer’s aide. You will receive\r\na link of verification after confirmin" +
    "g it.";
            // 
            // txtPeerUsername
            // 
            this.txtPeerUsername.BackColor = System.Drawing.Color.White;
            this.txtPeerUsername.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeerUsername.Location = new System.Drawing.Point(83, 187);
            this.txtPeerUsername.Name = "txtPeerUsername";
            this.txtPeerUsername.Size = new System.Drawing.Size(387, 33);
            this.txtPeerUsername.TabIndex = 10;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.White;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(83, 326);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(387, 33);
            this.txtNewPassword.TabIndex = 11;
            // 
            // picNewPassword
            // 
            this.picNewPassword.BackColor = System.Drawing.Color.White;
            this.picNewPassword.Image = global::loginFormDesign_winforms.Properties.Resources.output_onlinepngtools__1_;
            this.picNewPassword.Location = new System.Drawing.Point(47, 326);
            this.picNewPassword.Name = "picNewPassword";
            this.picNewPassword.Size = new System.Drawing.Size(30, 30);
            this.picNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNewPassword.TabIndex = 17;
            this.picNewPassword.TabStop = false;
            // 
            // lblPeersUsername
            // 
            this.lblPeersUsername.AutoSize = true;
            this.lblPeersUsername.BackColor = System.Drawing.Color.White;
            this.lblPeersUsername.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeersUsername.Location = new System.Drawing.Point(37, 159);
            this.lblPeersUsername.Name = "lblPeersUsername";
            this.lblPeersUsername.Size = new System.Drawing.Size(146, 25);
            this.lblPeersUsername.TabIndex = 12;
            this.lblPeersUsername.Text = "Peer\'s Username";
            // 
            // picPeersUsername
            // 
            this.picPeersUsername.BackColor = System.Drawing.Color.Transparent;
            this.picPeersUsername.Image = global::loginFormDesign_winforms.Properties.Resources.output_onlinepngtools;
            this.picPeersUsername.Location = new System.Drawing.Point(47, 187);
            this.picPeersUsername.Name = "picPeersUsername";
            this.picPeersUsername.Size = new System.Drawing.Size(30, 30);
            this.picPeersUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPeersUsername.TabIndex = 16;
            this.picPeersUsername.TabStop = false;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.White;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(44, 298);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(130, 25);
            this.lblNewPassword.TabIndex = 13;
            this.lblNewPassword.Text = "New Password";
            // 
            // llbGoBackToLoginForm
            // 
            this.llbGoBackToLoginForm.AutoSize = true;
            this.llbGoBackToLoginForm.BackColor = System.Drawing.Color.White;
            this.llbGoBackToLoginForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbGoBackToLoginForm.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(99)))), ((int)(((byte)(133)))));
            this.llbGoBackToLoginForm.Location = new System.Drawing.Point(79, 498);
            this.llbGoBackToLoginForm.Name = "llbGoBackToLoginForm";
            this.llbGoBackToLoginForm.Size = new System.Drawing.Size(168, 21);
            this.llbGoBackToLoginForm.TabIndex = 15;
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
            this.btnSubmit.Location = new System.Drawing.Point(83, 443);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 42);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // picYourUsername
            // 
            this.picYourUsername.BackColor = System.Drawing.Color.Transparent;
            this.picYourUsername.Image = global::loginFormDesign_winforms.Properties.Resources.output_onlinepngtools;
            this.picYourUsername.Location = new System.Drawing.Point(47, 257);
            this.picYourUsername.Name = "picYourUsername";
            this.picYourUsername.Size = new System.Drawing.Size(30, 30);
            this.picYourUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYourUsername.TabIndex = 16;
            this.picYourUsername.TabStop = false;
            // 
            // lblYourUsername
            // 
            this.lblYourUsername.AutoSize = true;
            this.lblYourUsername.BackColor = System.Drawing.Color.White;
            this.lblYourUsername.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourUsername.Location = new System.Drawing.Point(37, 229);
            this.lblYourUsername.Name = "lblYourUsername";
            this.lblYourUsername.Size = new System.Drawing.Size(135, 25);
            this.lblYourUsername.TabIndex = 12;
            this.lblYourUsername.Text = "Your Username";
            // 
            // txtYourUsername
            // 
            this.txtYourUsername.BackColor = System.Drawing.Color.White;
            this.txtYourUsername.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYourUsername.Location = new System.Drawing.Point(83, 257);
            this.txtYourUsername.Name = "txtYourUsername";
            this.txtYourUsername.Size = new System.Drawing.Size(387, 33);
            this.txtYourUsername.TabIndex = 10;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(44, 367);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(158, 25);
            this.lblConfirmPassword.TabIndex = 13;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // picConfirmPassword
            // 
            this.picConfirmPassword.BackColor = System.Drawing.Color.White;
            this.picConfirmPassword.Image = global::loginFormDesign_winforms.Properties.Resources.output_onlinepngtools__1_;
            this.picConfirmPassword.Location = new System.Drawing.Point(47, 395);
            this.picConfirmPassword.Name = "picConfirmPassword";
            this.picConfirmPassword.Size = new System.Drawing.Size(30, 30);
            this.picConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picConfirmPassword.TabIndex = 17;
            this.picConfirmPassword.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(83, 395);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(387, 33);
            this.txtConfirmPassword.TabIndex = 11;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(522, 546);
            this.Controls.Add(this.txtYourUsername);
            this.Controls.Add(this.txtPeerUsername);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.picConfirmPassword);
            this.Controls.Add(this.lblYourUsername);
            this.Controls.Add(this.picNewPassword);
            this.Controls.Add(this.picYourUsername);
            this.Controls.Add(this.lblPeersUsername);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.picPeersUsername);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.llbGoBackToLoginForm);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.lblForgotPassword);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            ((System.ComponentModel.ISupportInitialize)(this.picNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeersUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYourUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirmPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TextBox txtPeerUsername;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.PictureBox picNewPassword;
        private System.Windows.Forms.Label lblPeersUsername;
        private System.Windows.Forms.PictureBox picPeersUsername;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.LinkLabel llbGoBackToLoginForm;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox picYourUsername;
        private System.Windows.Forms.Label lblYourUsername;
        private System.Windows.Forms.TextBox txtYourUsername;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.PictureBox picConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
    }
}