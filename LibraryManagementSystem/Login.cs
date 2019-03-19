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
		public Login()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			this.Hide(); // first closes the login screen
			Checkout BookManagement = new Checkout();
			BookManagement.Show(); // then opens the next screen which is BookManagement
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
	}
}