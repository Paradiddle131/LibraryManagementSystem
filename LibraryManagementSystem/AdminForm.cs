﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class AdminForm : Form
	{
		AdminForm af;
		public AdminForm()
		{
			InitializeComponent();
		}

		public static string ConnectionString { get; set; } = @"Data Source=DESKTOP-VGI8J75\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";

		private void BtnHome_Click(object sender, EventArgs e)
		{
			AdminForm af = new AdminForm();
			pnlGreen.Width = btnHome.Width;
			pnlGreen.Left = btnHome.Left;
			if (!pnlUserControls.Controls.Contains(homeUserControl.Instance))
			{
				pnlUserControls.Controls.Add(homeUserControl.Instance);
				homeUserControl.Instance.Dock = DockStyle.Fill; //sets the control's size and borders
				homeUserControl.Instance.BringToFront();
			}
			else
				homeUserControl.Instance.BringToFront();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			AdminForm af = new AdminForm();
			pnlGreen.Width = btnSearch.Width;
			pnlGreen.Left = btnSearch.Left;
			searchUserControl.Instance.Show();

			if (!pnlUserControls.Controls.Contains(searchUserControl.Instance))
			{
				pnlUserControls.Controls.Add(searchUserControl.Instance);
				searchUserControl.Instance.Dock = DockStyle.Fill;
				searchUserControl.Instance.BringToFront();
			}
			else
				searchUserControl.Instance.BringToFront();
		}

		private void btnSocialMedia_Click(object sender, EventArgs e)
		{
			AdminForm af = new AdminForm();
			pnlGreen.Width = btnLogout.Width;
			pnlGreen.Left = btnLogout.Left;
			dbForLMS.Login loginScreen = new dbForLMS.Login();
			this.Hide();
			loginScreen.Show();
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			AdminForm af = new AdminForm();
			pnlGreen.Width = btnAbout.Width;
			pnlGreen.Left = btnAbout.Left;
			dbForLMS.Coders codersScreen = new dbForLMS.Coders();
			codersScreen.Show();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			pnlGreen.Width = btnExit.Width;
			//pnlGreen.Left = btnExit.Left; pnlIssue.Width = af.Width; pnlIssue.Height = af.Height - btnHome.Height;
			//this.Hide();
			//Login backToLoginScreen = new Login();
			//backToLoginScreen.Show();
			Application.Exit();
		}
		
		private void BtnManage_Click(object sender, EventArgs e)
		{
			AdminForm af = new AdminForm();
			pnlGreen.Width = btnManage.Width;
			pnlGreen.Left = btnManage.Left;
			
			if (!pnlUserControls.Controls.Contains(manageUserControl.Instance))
			{
				pnlUserControls.Controls.Add(manageUserControl.Instance);
				manageUserControl.Instance.Dock = DockStyle.Fill;
				manageUserControl.Instance.BringToFront();
			}
			else
				manageUserControl.Instance.BringToFront();
		}
	}
}