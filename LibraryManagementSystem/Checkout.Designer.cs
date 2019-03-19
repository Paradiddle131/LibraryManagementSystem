namespace dbForLMS
{
	partial class Checkout
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlGreen = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.btnHome = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnSocialMedia = new System.Windows.Forms.Button();
			this.btnUser = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnIssue = new System.Windows.Forms.Button();
			this.pnlIssue = new System.Windows.Forms.Panel();
			this.issueUserControl1 = new LibraryManagementSystem.IssueUserControl();
			this.userUserControl1 = new LibraryManagementSystem.UserUserControl1();
			this.homeUserControl1 = new LibraryManagementSystem.HomeUserControl();
			this.searchUserControl1 = new LibraryManagementSystem.SearchUserControl();
			this.panel1.SuspendLayout();
			this.pnlIssue.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(203)))), ((int)(((byte)(174)))));
			this.panel1.Controls.Add(this.searchUserControl1);
			this.panel1.Controls.Add(this.pnlGreen);
			this.panel1.Controls.Add(this.btnExit);
			this.panel1.Controls.Add(this.btnAbout);
			this.panel1.Controls.Add(this.btnHome);
			this.panel1.Controls.Add(this.btnReturn);
			this.panel1.Controls.Add(this.btnSocialMedia);
			this.panel1.Controls.Add(this.btnUser);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.btnIssue);
			this.panel1.Location = new System.Drawing.Point(-7, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 75);
			this.panel1.TabIndex = 3;
			// 
			// pnlGreen
			// 
			this.pnlGreen.BackColor = System.Drawing.Color.Lime;
			this.pnlGreen.Location = new System.Drawing.Point(7, 71);
			this.pnlGreen.Name = "pnlGreen";
			this.pnlGreen.Size = new System.Drawing.Size(90, 15);
			this.pnlGreen.TabIndex = 4;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnExit.Location = new System.Drawing.Point(700, 0);
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
			this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
			this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAbout.Location = new System.Drawing.Point(600, 0);
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
			this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
			this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnHome.Location = new System.Drawing.Point(0, 0);
			this.btnHome.Margin = new System.Windows.Forms.Padding(0);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(100, 75);
			this.btnHome.TabIndex = 4;
			this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnHome.UseVisualStyleBackColor = false;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// btnReturn
			// 
			this.btnReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
			this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnReturn.Location = new System.Drawing.Point(400, 0);
			this.btnReturn.Margin = new System.Windows.Forms.Padding(0);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(100, 75);
			this.btnReturn.TabIndex = 8;
			this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnReturn.UseVisualStyleBackColor = false;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// btnSocialMedia
			// 
			this.btnSocialMedia.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSocialMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSocialMedia.Image = ((System.Drawing.Image)(resources.GetObject("btnSocialMedia.Image")));
			this.btnSocialMedia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSocialMedia.Location = new System.Drawing.Point(500, 0);
			this.btnSocialMedia.Margin = new System.Windows.Forms.Padding(0);
			this.btnSocialMedia.Name = "btnSocialMedia";
			this.btnSocialMedia.Size = new System.Drawing.Size(100, 75);
			this.btnSocialMedia.TabIndex = 9;
			this.btnSocialMedia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSocialMedia.UseVisualStyleBackColor = false;
			this.btnSocialMedia.Click += new System.EventHandler(this.btnSocialMedia_Click);
			// 
			// btnUser
			// 
			this.btnUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.ForeColor = System.Drawing.Color.Black;
			this.panel2.Location = new System.Drawing.Point(100, 65);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(93, 21);
			this.panel2.TabIndex = 12;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSearch.Location = new System.Drawing.Point(200, 0);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(100, 75);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnIssue
			// 
			this.btnIssue.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnIssue.Image = ((System.Drawing.Image)(resources.GetObject("btnIssue.Image")));
			this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnIssue.Location = new System.Drawing.Point(300, 0);
			this.btnIssue.Margin = new System.Windows.Forms.Padding(0);
			this.btnIssue.Name = "btnIssue";
			this.btnIssue.Size = new System.Drawing.Size(100, 75);
			this.btnIssue.TabIndex = 7;
			this.btnIssue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnIssue.UseVisualStyleBackColor = false;
			this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
			// 
			// pnlIssue
			// 
			this.pnlIssue.Controls.Add(this.homeUserControl1);
			this.pnlIssue.Controls.Add(this.issueUserControl1);
			this.pnlIssue.Controls.Add(this.userUserControl1);
			this.pnlIssue.Location = new System.Drawing.Point(0, 74);
			this.pnlIssue.Name = "pnlIssue";
			this.pnlIssue.Size = new System.Drawing.Size(793, 324);
			this.pnlIssue.TabIndex = 5;
			// 
			// issueUserControl1
			// 
			this.issueUserControl1.Location = new System.Drawing.Point(0, 3);
			this.issueUserControl1.Name = "issueUserControl1";
			this.issueUserControl1.Size = new System.Drawing.Size(793, 321);
			this.issueUserControl1.TabIndex = 5;
			// 
			// userUserControl1
			// 
			this.userUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userUserControl1.BackgroundImage")));
			this.userUserControl1.Location = new System.Drawing.Point(0, 3);
			this.userUserControl1.Name = "userUserControl1";
			this.userUserControl1.Size = new System.Drawing.Size(793, 321);
			this.userUserControl1.TabIndex = 4;
			// 
			// homeUserControl1
			// 
			this.homeUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeUserControl1.BackgroundImage")));
			this.homeUserControl1.Location = new System.Drawing.Point(0, 0);
			this.homeUserControl1.Name = "homeUserControl1";
			this.homeUserControl1.Size = new System.Drawing.Size(793, 325);
			this.homeUserControl1.TabIndex = 3;
			// 
			// searchUserControl1
			// 
			this.searchUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchUserControl1.BackgroundImage")));
			this.searchUserControl1.Location = new System.Drawing.Point(7, 74);
			this.searchUserControl1.Name = "searchUserControl1";
			this.searchUserControl1.Size = new System.Drawing.Size(793, 296);
			this.searchUserControl1.TabIndex = 4;
			// 
			// Checkout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(203)))), ((int)(((byte)(174)))));
			this.ClientSize = new System.Drawing.Size(792, 398);
			this.Controls.Add(this.pnlIssue);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(808, 437);
			this.Name = "Checkout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Library Management System";
			this.panel1.ResumeLayout(false);
			this.pnlIssue.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Button btnSocialMedia;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Button btnIssue;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnUser;
		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pnlGreen;
		private LibraryManagementSystem.SearchUserControl searchUserControl1;
		private LibraryManagementSystem.HomeUserControl homeUserControl1;
		private LibraryManagementSystem.UserUserControl1 userUserControl1;
		private System.Windows.Forms.Panel pnlIssue;
		private LibraryManagementSystem.IssueUserControl issueUserControl1;
	}
}

