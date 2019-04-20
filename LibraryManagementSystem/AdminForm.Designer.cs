namespace LibraryManagementSystem
{
	partial class AdminForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
			this.pnlButtons = new System.Windows.Forms.Panel();
			this.pnlGreen = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.btnHome = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnManage = new System.Windows.Forms.Button();
			this.pnlUserControls = new System.Windows.Forms.Panel();
			this.homeUserControl = new LibraryManagementSystem.HomeUserControl();
			this.searchUserControl = new LibraryManagementSystem.SearchUserControl();
			this.manageUserControl = new LibraryManagementSystem.ManageUserControl();
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
			this.pnlButtons.Controls.Add(this.btnSearch);
			this.pnlButtons.Controls.Add(this.btnManage);
			this.pnlButtons.Location = new System.Drawing.Point(0, 0);
			this.pnlButtons.Name = "pnlButtons";
			this.pnlButtons.Size = new System.Drawing.Size(600, 75);
			this.pnlButtons.TabIndex = 6;
			// 
			// pnlGreen
			// 
			this.pnlGreen.BackColor = System.Drawing.Color.Lime;
			this.pnlGreen.Location = new System.Drawing.Point(0, 70);
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
			this.btnExit.Location = new System.Drawing.Point(500, 0);
			this.btnExit.Margin = new System.Windows.Forms.Padding(0);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(100, 75);
			this.btnExit.TabIndex = 6;
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
			this.btnAbout.Location = new System.Drawing.Point(400, 0);
			this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(100, 75);
			this.btnAbout.TabIndex = 5;
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
			this.btnHome.TabIndex = 1;
			this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnHome.UseVisualStyleBackColor = false;
			this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
			this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnLogout.Location = new System.Drawing.Point(300, 0);
			this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(100, 75);
			this.btnLogout.TabIndex = 4;
			this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnSocialMedia_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSearch.Location = new System.Drawing.Point(100, 0);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(100, 75);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnManage
			// 
			this.btnManage.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnManage.Image = ((System.Drawing.Image)(resources.GetObject("btnManage.Image")));
			this.btnManage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnManage.Location = new System.Drawing.Point(200, 0);
			this.btnManage.Margin = new System.Windows.Forms.Padding(0);
			this.btnManage.Name = "btnManage";
			this.btnManage.Size = new System.Drawing.Size(100, 75);
			this.btnManage.TabIndex = 3;
			this.btnManage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnManage.UseVisualStyleBackColor = false;
			this.btnManage.Click += new System.EventHandler(this.BtnManage_Click);
			// 
			// pnlUserControls
			// 
			this.pnlUserControls.Controls.Add(this.homeUserControl);
			this.pnlUserControls.Controls.Add(this.searchUserControl);
			this.pnlUserControls.Controls.Add(this.manageUserControl);
			this.pnlUserControls.Location = new System.Drawing.Point(0, 75);
			this.pnlUserControls.Name = "pnlUserControls";
			this.pnlUserControls.Size = new System.Drawing.Size(600, 325);
			this.pnlUserControls.TabIndex = 8;
			// 
			// homeUserControl
			// 
			this.homeUserControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.homeUserControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeUserControl.BackgroundImage")));
			this.homeUserControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.homeUserControl.Location = new System.Drawing.Point(0, 0);
			this.homeUserControl.Margin = new System.Windows.Forms.Padding(0);
			this.homeUserControl.Name = "homeUserControl";
			this.homeUserControl.Size = new System.Drawing.Size(600, 325);
			this.homeUserControl.TabIndex = 3;
			// 
			// searchUserControl
			// 
			this.searchUserControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchUserControl.BackgroundImage")));
			this.searchUserControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.searchUserControl.Location = new System.Drawing.Point(0, 0);
			this.searchUserControl.Margin = new System.Windows.Forms.Padding(0);
			this.searchUserControl.Name = "searchUserControl";
			this.searchUserControl.Size = new System.Drawing.Size(600, 325);
			this.searchUserControl.TabIndex = 7;
			// 
			// manageUserControl
			// 
			this.manageUserControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.manageUserControl.Location = new System.Drawing.Point(0, 0);
			this.manageUserControl.Margin = new System.Windows.Forms.Padding(0);
			this.manageUserControl.Name = "manageUserControl";
			this.manageUserControl.Size = new System.Drawing.Size(600, 325);
			this.manageUserControl.TabIndex = 8;
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.pnlButtons);
			this.Controls.Add(this.pnlUserControls);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(600, 400);
			this.Name = "AdminForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminForm";
			this.pnlButtons.ResumeLayout(false);
			this.pnlUserControls.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private HomeUserControl homeUserControl;
		private System.Windows.Forms.Panel pnlButtons;
		private System.Windows.Forms.Panel pnlGreen;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnManage;
		private SearchUserControl searchUserControl;
		private System.Windows.Forms.Panel pnlUserControls;
		private ManageUserControl manageUserControl;
	}
}