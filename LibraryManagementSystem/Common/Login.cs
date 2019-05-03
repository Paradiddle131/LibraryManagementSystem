using LibraryManagementSystem;
using System;
using System.Windows.Forms;

namespace dbForLMS
{
	public partial class Login : Form
	{
		private readonly addAuthor au;
		private readonly AdminForm af;
		private readonly UserForm uf;
		public bool isAdmin = false;
		public string currentUserName;
		public string currentUserSurname;
		public Login()
		{
			InitializeComponent();
			//au = new .addAuthor(isAdmin);
			au = new addAuthor();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			UserForm uf = new UserForm();
			Hide();
			currentUserName = txtName.Text;
			currentUserSurname = txtSurname.Text;
			uf.lblName.Text = currentUserName;
			uf.lblSurname.Text = currentUserSurname;

			if (txtName.Text == "a" && txtSurname.Text == "a")
			{
				isAdmin = true;
				AdminForm af = new AdminForm();
				af.Show();
			}
			else
			{
				uf.Show();
			}
		}

		private void btnCoders_Click(object sender, EventArgs e)
		{
			//this.Hide();
			Coders codersScreen = new Coders();
			codersScreen.ShowDialog();
		}

		private void TxtName_Enter(object sender, EventArgs e)
		{
			//when the textbox gains focus:
			if (txtName.Text == "<Enter your name>")
			{
				txtName.Text = "";
			}
		}

		private void TxtName_Leave(object sender, EventArgs e)
		{
			if (txtName.Text.Trim() == "")
			{
				txtName.Text = "<Enter your name>";
			}
		}

		private void TxtSurname_Enter(object sender, EventArgs e)
		{
			if (txtSurname.Text == "<Enter your surname>")
			{
				txtSurname.Text = "";
			}
		}

		private void TxtSurname_Leave(object sender, EventArgs e)
		{
			if (txtSurname.Text.Trim() == "")
			{
				txtSurname.Text = "<Enter your surname>";
			}
		}
		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}