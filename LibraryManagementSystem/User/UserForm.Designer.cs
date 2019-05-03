namespace LibraryManagementSystem
{
	partial class UserForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
			this.pnlButtons = new System.Windows.Forms.Panel();
			this.pnlGreen = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.btnHome = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnUser = new System.Windows.Forms.Button();
			this.btnBorrow = new System.Windows.Forms.Button();
			this.pnlUserControls = new System.Windows.Forms.Panel();
			this.lblName = new System.Windows.Forms.Label();
			this.lblSurname = new System.Windows.Forms.Label();
			this.homeUserControl1 = new LibraryManagementSystem.HomeUserControl();
			this.lblLoginedAs = new System.Windows.Forms.Label();
			this.pnlButtons.SuspendLayout();
			this.pnlUserControls.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlButtons
			// 
			this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(203)))), ((int)(((byte)(174)))));
			this.pnlButtons.Controls.Add(this.pnlGreen);
			this.pnlButtons.Controls.Add(this.btnExit);
			this.pnlButtons.Controls.Add(this.btnAbout);
			this.pnlButtons.Controls.Add(this.btnHome);
			this.pnlButtons.Controls.Add(this.btnLogout);
			this.pnlButtons.Controls.Add(this.btnUser);
			this.pnlButtons.Controls.Add(this.btnBorrow);
			this.pnlButtons.Location = new System.Drawing.Point(0, 0);
			this.pnlButtons.Margin = new System.Windows.Forms.Padding(0);
			this.pnlButtons.Name = "pnlButtons";
			this.pnlButtons.Size = new System.Drawing.Size(600, 75);
			this.pnlButtons.TabIndex = 6;
			// 
			// pnlGreen
			// 
			this.pnlGreen.BackColor = System.Drawing.Color.Lime;
			this.pnlGreen.Location = new System.Drawing.Point(0, 70);
			this.pnlGreen.Margin = new System.Windows.Forms.Padding(0);
			this.pnlGreen.Name = "pnlGreen";
			this.pnlGreen.Size = new System.Drawing.Size(100, 15);
			this.pnlGreen.TabIndex = 4;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnExit.Location = new System.Drawing.Point(500, 0);
			this.btnExit.Margin = new System.Windows.Forms.Padding(0);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(100, 75);
			this.btnExit.TabIndex = 11;
			this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnAbout
			// 
			this.btnAbout.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnAbout.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
			this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAbout.Location = new System.Drawing.Point(400, 0);
			this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(100, 75);
			this.btnAbout.TabIndex = 10;
			this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAbout.UseVisualStyleBackColor = false;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// btnHome
			// 
			this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnHome.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
			this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnHome.Location = new System.Drawing.Point(0, 0);
			this.btnHome.Margin = new System.Windows.Forms.Padding(0);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(100, 75);
			this.btnHome.TabIndex = 4;
			this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnHome.UseVisualStyleBackColor = false;
			this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnLogout.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
			this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnLogout.Location = new System.Drawing.Point(300, 0);
			this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(100, 75);
			this.btnLogout.TabIndex = 9;
			this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnUser
			// 
			this.btnUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnUser.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
			this.btnUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnUser.Location = new System.Drawing.Point(100, 0);
			this.btnUser.Margin = new System.Windows.Forms.Padding(0);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(100, 75);
			this.btnUser.TabIndex = 5;
			this.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnUser.UseVisualStyleBackColor = false;
			this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
			// 
			// btnBorrow
			// 
			this.btnBorrow.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnBorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBorrow.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.btnBorrow.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrow.Image")));
			this.btnBorrow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnBorrow.Location = new System.Drawing.Point(200, 0);
			this.btnBorrow.Margin = new System.Windows.Forms.Padding(0);
			this.btnBorrow.Name = "btnBorrow";
			this.btnBorrow.Size = new System.Drawing.Size(100, 75);
			this.btnBorrow.TabIndex = 7;
			this.btnBorrow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnBorrow.UseVisualStyleBackColor = false;
			this.btnBorrow.Click += new System.EventHandler(this.BtnBorrow_Click);
			// 
			// pnlUserControls
			// 
			this.pnlUserControls.Controls.Add(this.lblSurname);
			this.pnlUserControls.Controls.Add(this.lblLoginedAs);
			this.pnlUserControls.Controls.Add(this.lblName);
			this.pnlUserControls.Controls.Add(this.homeUserControl1);
			this.pnlUserControls.Location = new System.Drawing.Point(0, 75);
			this.pnlUserControls.Margin = new System.Windows.Forms.Padding(0);
			this.pnlUserControls.Name = "pnlUserControls";
			this.pnlUserControls.Size = new System.Drawing.Size(600, 325);
			this.pnlUserControls.TabIndex = 8;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(102)))), ((int)(((byte)(225)))));
			this.lblName.Location = new System.Drawing.Point(12, 58);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(59, 27);
			this.lblName.TabIndex = 4;
			this.lblName.Text = "name";
			// 
			// lblSurname
			// 
			this.lblSurname.AutoSize = true;
			this.lblSurname.BackColor = System.Drawing.Color.Transparent;
			this.lblSurname.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(102)))), ((int)(((byte)(225)))));
			this.lblSurname.Location = new System.Drawing.Point(12, 94);
			this.lblSurname.Name = "lblSurname";
			this.lblSurname.Size = new System.Drawing.Size(87, 27);
			this.lblSurname.TabIndex = 4;
			this.lblSurname.Text = "surname";
			// 
			// homeUserControl1
			// 
			this.homeUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeUserControl1.BackgroundImage")));
			this.homeUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.homeUserControl1.Location = new System.Drawing.Point(0, 0);
			this.homeUserControl1.Margin = new System.Windows.Forms.Padding(0);
			this.homeUserControl1.Name = "homeUserControl1";
			this.homeUserControl1.Size = new System.Drawing.Size(600, 325);
			this.homeUserControl1.TabIndex = 3;
			// 
			// lblLoginedAs
			// 
			this.lblLoginedAs.AutoSize = true;
			this.lblLoginedAs.BackColor = System.Drawing.Color.Transparent;
			this.lblLoginedAs.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblLoginedAs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(32)))), ((int)(((byte)(225)))));
			this.lblLoginedAs.Location = new System.Drawing.Point(12, 21);
			this.lblLoginedAs.Name = "lblLoginedAs";
			this.lblLoginedAs.Size = new System.Drawing.Size(118, 27);
			this.lblLoginedAs.TabIndex = 4;
			this.lblLoginedAs.Text = "Logined As:";
			// 
			// UserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.pnlButtons);
			this.Controls.Add(this.pnlUserControls);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(600, 400);
			this.MinimumSize = new System.Drawing.Size(600, 400);
			this.Name = "UserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UserForm";
			this.pnlButtons.ResumeLayout(false);
			this.pnlUserControls.ResumeLayout(false);
			this.pnlUserControls.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private HomeUserControl homeUserControl1;
		private System.Windows.Forms.Panel pnlButtons;
		private System.Windows.Forms.Panel pnlGreen;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnUser;
		private System.Windows.Forms.Button btnBorrow;
		private System.Windows.Forms.Panel pnlUserControls;
		public System.Windows.Forms.Label lblSurname;
		public System.Windows.Forms.Label lblName;
		public System.Windows.Forms.Label lblLoginedAs;
	}
}