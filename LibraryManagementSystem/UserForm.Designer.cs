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
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnSocialMedia = new System.Windows.Forms.Button();
			this.btnUser = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnBorrow = new System.Windows.Forms.Button();
			this.pnlUserControls = new System.Windows.Forms.Panel();
			this.homeUserControl1 = new LibraryManagementSystem.HomeUserControl();
			this.manageUserControl1 = new LibraryManagementSystem.ManageUserControl();
			this.userUserControl1 = new LibraryManagementSystem.UserUserControl1();
			this.searchUserControl1 = new LibraryManagementSystem.SearchUserControl();
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
			this.pnlButtons.Controls.Add(this.btnReturn);
			this.pnlButtons.Controls.Add(this.btnSocialMedia);
			this.pnlButtons.Controls.Add(this.btnUser);
			this.pnlButtons.Controls.Add(this.btnSearch);
			this.pnlButtons.Controls.Add(this.btnBorrow);
			this.pnlButtons.Location = new System.Drawing.Point(0, 0);
			this.pnlButtons.Margin = new System.Windows.Forms.Padding(0);
			this.pnlButtons.Name = "pnlButtons";
			this.pnlButtons.Size = new System.Drawing.Size(800, 75);
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
			this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
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
			// btnBorrow
			// 
			this.btnBorrow.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnBorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBorrow.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrow.Image")));
			this.btnBorrow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnBorrow.Location = new System.Drawing.Point(300, 0);
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
			this.pnlUserControls.Controls.Add(this.homeUserControl1);
			this.pnlUserControls.Controls.Add(this.manageUserControl1);
			this.pnlUserControls.Controls.Add(this.userUserControl1);
			this.pnlUserControls.Location = new System.Drawing.Point(0, 75);
			this.pnlUserControls.Margin = new System.Windows.Forms.Padding(0);
			this.pnlUserControls.Name = "pnlUserControls";
			this.pnlUserControls.Size = new System.Drawing.Size(800, 325);
			this.pnlUserControls.TabIndex = 8;
			// 
			// homeUserControl1
			// 
			this.homeUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeUserControl1.BackgroundImage")));
			this.homeUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.homeUserControl1.Location = new System.Drawing.Point(0, 0);
			this.homeUserControl1.Margin = new System.Windows.Forms.Padding(0);
			this.homeUserControl1.Name = "homeUserControl1";
			this.homeUserControl1.Size = new System.Drawing.Size(800, 325);
			this.homeUserControl1.TabIndex = 3;
			// 
			// manageUserControl1
			// 
			this.manageUserControl1.Location = new System.Drawing.Point(0, 0);
			this.manageUserControl1.Margin = new System.Windows.Forms.Padding(0);
			this.manageUserControl1.Name = "manageUserControl1";
			this.manageUserControl1.Size = new System.Drawing.Size(800, 325);
			this.manageUserControl1.TabIndex = 5;
			// 
			// userUserControl1
			// 
			this.userUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userUserControl1.BackgroundImage")));
			this.userUserControl1.Location = new System.Drawing.Point(0, 0);
			this.userUserControl1.Margin = new System.Windows.Forms.Padding(0);
			this.userUserControl1.Name = "userUserControl1";
			this.userUserControl1.Size = new System.Drawing.Size(800, 325);
			this.userUserControl1.TabIndex = 4;
			// 
			// searchUserControl1
			// 
			this.searchUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchUserControl1.BackgroundImage")));
			this.searchUserControl1.Location = new System.Drawing.Point(0, 75);
			this.searchUserControl1.Margin = new System.Windows.Forms.Padding(0);
			this.searchUserControl1.Name = "searchUserControl1";
			this.searchUserControl1.Size = new System.Drawing.Size(800, 325);
			this.searchUserControl1.TabIndex = 7;
			// 
			// UserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 400);
			this.Controls.Add(this.pnlButtons);
			this.Controls.Add(this.pnlUserControls);
			this.Controls.Add(this.searchUserControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(800, 400);
			this.MinimumSize = new System.Drawing.Size(800, 400);
			this.Name = "UserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UserForm";
			this.pnlButtons.ResumeLayout(false);
			this.pnlUserControls.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private HomeUserControl homeUserControl1;
		private System.Windows.Forms.Panel pnlButtons;
		private System.Windows.Forms.Panel pnlGreen;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Button btnSocialMedia;
		private System.Windows.Forms.Button btnUser;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnBorrow;
		private SearchUserControl searchUserControl1;
		private System.Windows.Forms.Panel pnlUserControls;
		private ManageUserControl manageUserControl1;
		private UserUserControl1 userUserControl1;
	}
}