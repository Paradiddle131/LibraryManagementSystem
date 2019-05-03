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
			this.lblName = new LollipopLabel();
			this.lblSurname = new LollipopLabel();
			this.txtName = new LollipopTextBox();
			this.txtSurname = new LollipopTextBox();
			this.btnCoders = new LollipopButton();
			this.btnExit = new LollipopButton();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.Transparent;
			this.btnLogin.BGColor = "#508ef5";
			this.btnLogin.FontColor = "#ffffff";
			this.btnLogin.Location = new System.Drawing.Point(142, 158);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(143, 41);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "LOGIN";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(49)))), ((int)(((byte)(33)))));
			this.lblName.Location = new System.Drawing.Point(12, 52);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(121, 27);
			this.lblName.TabIndex = 4;
			this.lblName.Text = "Your Name:";
			// 
			// lblSurname
			// 
			this.lblSurname.AutoSize = true;
			this.lblSurname.BackColor = System.Drawing.Color.Transparent;
			this.lblSurname.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(49)))), ((int)(((byte)(33)))));
			this.lblSurname.Location = new System.Drawing.Point(12, 102);
			this.lblSurname.Name = "lblSurname";
			this.lblSurname.Size = new System.Drawing.Size(156, 27);
			this.lblSurname.TabIndex = 5;
			this.lblSurname.Text = "Your Surname: ";
			// 
			// txtName
			// 
			this.txtName.FocusedColor = "#508ef5";
			this.txtName.FontColor = "#999999";
			this.txtName.IsEnabled = true;
			this.txtName.Location = new System.Drawing.Point(178, 55);
			this.txtName.MaxLength = 32767;
			this.txtName.Multiline = false;
			this.txtName.Name = "txtName";
			this.txtName.ReadOnly = false;
			this.txtName.Size = new System.Drawing.Size(209, 24);
			this.txtName.TabIndex = 0;
			this.txtName.Text = "<Enter your name>";
			this.txtName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtName.UseSystemPasswordChar = false;
			this.txtName.Enter += new System.EventHandler(this.TxtName_Enter);
			this.txtName.Leave += new System.EventHandler(this.TxtName_Leave);
			// 
			// txtSurname
			// 
			this.txtSurname.FocusedColor = "#508ef5";
			this.txtSurname.FontColor = "#999999";
			this.txtSurname.IsEnabled = true;
			this.txtSurname.Location = new System.Drawing.Point(178, 105);
			this.txtSurname.MaxLength = 32767;
			this.txtSurname.Multiline = false;
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.ReadOnly = false;
			this.txtSurname.Size = new System.Drawing.Size(209, 24);
			this.txtSurname.TabIndex = 1;
			this.txtSurname.Text = "<Enter your surname>";
			this.txtSurname.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSurname.UseSystemPasswordChar = false;
			this.txtSurname.Enter += new System.EventHandler(this.TxtSurname_Enter);
			this.txtSurname.Leave += new System.EventHandler(this.TxtSurname_Leave);
			// 
			// btnCoders
			// 
			this.btnCoders.BackColor = System.Drawing.Color.Transparent;
			this.btnCoders.BGColor = "#ffa61d";
			this.btnCoders.FontColor = "#ffffff";
			this.btnCoders.Location = new System.Drawing.Point(313, 192);
			this.btnCoders.Name = "btnCoders";
			this.btnCoders.Size = new System.Drawing.Size(74, 26);
			this.btnCoders.TabIndex = 3;
			this.btnCoders.Text = "CODERS";
			this.btnCoders.Click += new System.EventHandler(this.btnCoders_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Transparent;
			this.btnExit.BGColor = "#ff0000";
			this.btnExit.FontColor = "#ffffff";
			this.btnExit.Location = new System.Drawing.Point(349, 9);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(38, 24);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "EXIT";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(49)))), ((int)(((byte)(33)))));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "PROJECT ID: 55";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(400, 230);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCoders);
			this.Controls.Add(this.txtSurname);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblSurname);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.btnLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(400, 230);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private LollipopButton btnLogin;
		private LollipopLabel lblName;
		private LollipopLabel lblSurname;
		private LollipopButton btnCoders;
		private LollipopButton btnExit;
		private System.Windows.Forms.Label label1;
		public LollipopTextBox txtName;
		public LollipopTextBox txtSurname;
	}
}