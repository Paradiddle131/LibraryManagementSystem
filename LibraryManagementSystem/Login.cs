using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbForLMS
{
	public partial class Login : Form
	{
		private readonly LibraryManagementSystem.addAuthor au;
		private readonly LibraryManagementSystem.AdminForm af;
		public bool isAdmin = false;
		public Login()
		{
			InitializeComponent();
			au = new LibraryManagementSystem.addAuthor(isAdmin);
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			this.Hide(); // first closes the login screen
			//Checkout BookManagement = new Checkout();
			//BookManagement.Show(); // then opens the next screen which is BookManagement

			if (txtUsername.Text == "a" && txtPassword.Text == "a")
			{
				isAdmin = true;
				LibraryManagementSystem.AdminForm af = new LibraryManagementSystem.AdminForm();
				af.Show();
			}
			else
			{
				LibraryManagementSystem.UserForm uf = new LibraryManagementSystem.UserForm();
				uf.Show();
			}
		}

		private void btnCoders_Click(object sender, EventArgs e)
		{
			//this.Hide();
			Coders codersScreen = new Coders();
			codersScreen.ShowDialog();
		}

		private void txtUsername_Enter(object sender, EventArgs e)
		{
			//when the textbox gains focus:
			if (txtUsername.Text == "<Enter your username>")
				txtUsername.Text = "";
		}

		private void txtUsername_Leave(object sender, EventArgs e)
		{
			if (txtUsername.Text.Trim() == "")
				txtUsername.Text = "<Enter your username>";
		}

		private void txtPassword_Enter(object sender, EventArgs e)
		{
			if (txtPassword.Text == "<Enter your password>")
				txtPassword.Text = "";
		}

		private void txtPassword_Leave(object sender, EventArgs e)
		{
			if (txtPassword.Text.Trim() == "")
				txtPassword.Text = "<Enter your password>";
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


	}
}