using System;
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
	public partial class UserForm : Form
	{
		DataGridView dgv;
		public UserForm()
		{
			InitializeComponent();
		}

		public string ConnectionString { get; set; } = @"Data Source=DESKTOP-VGI8J75\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";

		private void BtnHome_Click(object sender, EventArgs e)
		{
			pnlGreen.Width = btnHome.Width;
			pnlGreen.Left = btnHome.Left;
			//searchUserControl1.Hide();
			if (!pnlUserControls.Controls.Contains(homeUserControl1.Instance))
			{
				pnlUserControls.Controls.Add(homeUserControl1.Instance);
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
			pnlUserControls.Controls.Clear();

			if (!pnlUserControls.Controls.Contains(userUserControl1.Instance))
			{
				pnlUserControls.Controls.Add(userUserControl1.Instance);
				userUserControl1.Instance.Dock = DockStyle.Fill;
				userUserControl1.Instance.BringToFront();
			}
			else
				userUserControl1.Instance.BringToFront();
		}
		private void btnLogout_Click(object sender, EventArgs e)
		{
			pnlGreen.Width = btnLogout.Width;
			pnlGreen.Left = btnLogout.Left;
			dbForLMS.Login loginScreen = new dbForLMS.Login();
			this.Hide();
			loginScreen.Show();
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			pnlGreen.Width = btnAbout.Width;
			pnlGreen.Left = btnAbout.Left;
			dbForLMS.Coders codersScreen = new dbForLMS.Coders();
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

		private void BtnBorrow_Click(object sender, EventArgs e)
		{
			//this.Hide();
			searchBook sb = new searchBook(dgv);
			sb.Show();
		}
	}
}
