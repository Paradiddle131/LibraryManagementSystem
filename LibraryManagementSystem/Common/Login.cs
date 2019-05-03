using LibraryManagementSystem;
using LibraryManagementSystem.User;
using System;
using System.Windows.Forms;

namespace dbForLMS
{
	public partial class Login : Form
	{
		private readonly addAuthor au;
		private readonly AdminForm af;
		private readonly UserForm uf;
		private readonly searchBook sb;
		private readonly UserProfile up;
		public bool isAdmin = false;
		public string currentUserName;
		public string currentUserSurname;
		//public string[] sendName { get { return new string[] { currentUserName, currentUserSurname }; }} // same
		//public string[] sendName => new string[] { txtName.Text, txtSurname.Text };
		public Login()
		{
			InitializeComponent();
			//string[] sendName = new string[] { currentUserName, currentUserSurname };
			//au = new .addAuthor(isAdmin);
			au = new addAuthor();
			//searchBook sb = new searchBook();
			sb = new searchBook(txtName, txtSurname);
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			UserForm uf = new UserForm();
			UserProfile up = new UserProfile();
			searchBook sb = new searchBook();
			Hide();
			currentUserName = txtName.Text;
			currentUserSurname = txtSurname.Text;
			uf.lblName.Text = currentUserName;
			uf.lblSurname.Text = currentUserSurname;
			sb.lblNameGot.Text = currentUserName;
			sb.lblSurnameGot.Text = currentUserSurname;
			up.lblName.Text = currentUserName;
			up.lblSurname.Text = currentUserSurname;
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

		public string[] GetNameAndSurname(string name)
		{
			return new string[] { currentUserName, currentUserSurname };
		}

		private void btnCoders_Click(object sender, EventArgs e)
		{
			//this.Hide();
			Coders codersScreen = new Coders();
			codersScreen.ShowDialog();
		}
		#region Focus
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
		#endregion
		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}