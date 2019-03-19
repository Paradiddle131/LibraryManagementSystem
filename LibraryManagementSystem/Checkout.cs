using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dbForLMS
{
	public partial class Checkout : Form
	{
		public Checkout()
		{
			InitializeComponent();
			//searchUserControl1.Show();
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			pnlGreen.Width = btnHome.Width;
			pnlGreen.Left = btnHome.Left;
			//searchUserControl1.Hide();
			if (!pnlIssue.Controls.Contains(homeUserControl1.Instance))
			{
				pnlIssue.Controls.Add(homeUserControl1.Instance);
				homeUserControl1.Instance.Dock = DockStyle.Fill; //sets the control's size and borders
				homeUserControl1.Instance.BringToFront();
			}
			else
				homeUserControl1.Instance.BringToFront();
		}

		private void btnUser_Click(object sender, EventArgs e)
		{
			pnlGreen.Width = btnUser.Width;
			pnlGreen.Left = btnUser.Left;
			pnlIssue.Controls.Clear();

			if (!pnlIssue.Controls.Contains(userUserControl1.Instance))
			{
				pnlIssue.Controls.Add(userUserControl1.Instance);
				userUserControl1.Instance.Dock = DockStyle.Fill;
				userUserControl1.Instance.BringToFront();
			}
			else
				userUserControl1.Instance.BringToFront();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			pnlGreen.Width = btnSearch.Width;
			pnlGreen.Left = btnSearch.Left;
			////searchUserControl1.Show();
			//Search SearchScreen = new Search();
			//SearchScreen.Show();

			//if (!pnlIssue.Controls.Contains(searchUserControl1.Instance))
			//{
			//	pnlIssue.Controls.Add(searchUserControl1.Instance);
			//	searchUserControl1.Instance.Dock = DockStyle.Fill;
			//	searchUserControl1.Instance.BringToFront();
			//}
			//else
			//	searchUserControl1.Instance.BringToFront();
			if (!pnlIssue.Controls.Contains(searchUserControl1.Instance))
			{
				pnlIssue.Controls.Add(searchUserControl1.Instance);
				searchUserControl1.Instance.Dock = DockStyle.Fill;
				searchUserControl1.Instance.BringToFront();
			}
			else
				searchUserControl1.Instance.BringToFront();
		}

		private void btnIssue_Click(object sender, EventArgs e)
		{
			pnlGreen.Width = btnIssue.Width;
			pnlGreen.Left = btnIssue.Left;
			issueUserControl1.Instance.Show();

			if (!pnlIssue.Controls.Contains(issueUserControl1.Instance))
			{
				pnlIssue.Controls.Add(issueUserControl1.Instance);
				issueUserControl1.Instance.Dock = DockStyle.Fill;
				issueUserControl1.Instance.BringToFront();
			}
			else
				issueUserControl1.Instance.BringToFront();
		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			pnlGreen.Width = btnReturn.Width;
			pnlGreen.Left = btnReturn.Left;
		}

		private void btnSocialMedia_Click(object sender, EventArgs e)
		{
			pnlGreen.Width = btnSocialMedia.Width;
			pnlGreen.Left = btnSocialMedia.Left;
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			pnlGreen.Width = btnAbout.Width;
			pnlGreen.Left = btnAbout.Left;
			Coders codersScreen = new Coders();
			codersScreen.Show();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			pnlGreen.Width = btnExit.Width;
			//pnlGreen.Left = btnExit.Left;
			//this.Hide();
			//Login backToLoginScreen = new Login();
			//backToLoginScreen.Show();
			Application.Exit();
		}
	}
}
