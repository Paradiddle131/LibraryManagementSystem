namespace dbForLMS
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.btnLogin = new LollipopButton();
			this.lblUsername = new LollipopLabel();
			this.lblPassword = new LollipopLabel();
			this.txtUsername = new LollipopTextBox();
			this.txtPassword = new LollipopTextBox();
			this.btnCoders = new LollipopButton();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.Transparent;
			this.btnLogin.BGColor = "#508ef5";
			this.btnLogin.FontColor = "#ffffff";
			this.btnLogin.Location = new System.Drawing.Point(108, 143);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(143, 41);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "LOGIN";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.BackColor = System.Drawing.Color.Transparent;
			this.lblUsername.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(49)))), ((int)(((byte)(33)))));
			this.lblUsername.Location = new System.Drawing.Point(12, 35);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(110, 27);
			this.lblUsername.TabIndex = 4;
			this.lblUsername.Text = "Username:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(49)))), ((int)(((byte)(33)))));
			this.lblPassword.Location = new System.Drawing.Point(12, 85);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(102, 27);
			this.lblPassword.TabIndex = 5;
			this.lblPassword.Text = "Password:";
			// 
			// txtUsername
			// 
			this.txtUsername.FocusedColor = "#508ef5";
			this.txtUsername.FontColor = "#999999";
			this.txtUsername.IsEnabled = true;
			this.txtUsername.Location = new System.Drawing.Point(142, 38);
			this.txtUsername.MaxLength = 32767;
			this.txtUsername.Multiline = false;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.ReadOnly = false;
			this.txtUsername.Size = new System.Drawing.Size(209, 24);
			this.txtUsername.TabIndex = 6;
			this.txtUsername.Text = "<Enter your username>";
			this.txtUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtUsername.UseSystemPasswordChar = false;
			this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
			this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
			// 
			// txtPassword
			// 
			this.txtPassword.FocusedColor = "#508ef5";
			this.txtPassword.FontColor = "#999999";
			this.txtPassword.IsEnabled = true;
			this.txtPassword.Location = new System.Drawing.Point(142, 88);
			this.txtPassword.MaxLength = 32767;
			this.txtPassword.Multiline = false;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.ReadOnly = false;
			this.txtPassword.Size = new System.Drawing.Size(209, 24);
			this.txtPassword.TabIndex = 7;
			this.txtPassword.Text = "<Enter your password>";
			this.txtPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPassword.UseSystemPasswordChar = false;
			this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
			this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
			// 
			// btnCoders
			// 
			this.btnCoders.BackColor = System.Drawing.Color.Transparent;
			this.btnCoders.BGColor = "#ffa61d";
			this.btnCoders.FontColor = "#ffffff";
			this.btnCoders.Location = new System.Drawing.Point(277, 194);
			this.btnCoders.Name = "btnCoders";
			this.btnCoders.Size = new System.Drawing.Size(74, 26);
			this.btnCoders.TabIndex = 8;
			this.btnCoders.Text = "CODERS";
			this.btnCoders.Click += new System.EventHandler(this.btnCoders_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(363, 232);
			this.Controls.Add(this.btnCoders);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.btnLogin);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private LollipopButton btnLogin;
		private LollipopLabel lblUsername;
		private LollipopLabel lblPassword;
		private LollipopTextBox txtUsername;
		private LollipopTextBox txtPassword;
		private LollipopButton btnCoders;
	}
}