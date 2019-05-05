using dbForLMS;
using LibraryManagementSystem.User;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class UserForm : Form
	{
		public Label nameLabel;
		public Label surnameLabel;
		private readonly searchBook sb;
		public UserForm()
		{
			InitializeComponent();
			Login login = new Login();
			sb = new searchBook(nameLabel, surnameLabel);
			//lblName.Text = login.currentUserName;
			//lblSurname.Text = login.currentUserSurname;
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
			{
				homeUserControl1.Instance.BringToFront();
			}
			lblLoginedAs.BringToFront();
			lblName.BringToFront();
			lblSurname.BringToFront();
		}

		internal string GetFullName()
		{
			UserProfile up = new UserProfile();
			string firstname = "";
			string lastname = "";
			string fullNameInput = "";
			fullNameInput = Interaction.InputBox("Enter your full name please:", "Your Full Name.", "");
			StartPosition = FormStartPosition.CenterScreen;
			string[] splitted = fullNameInput.Split(' ');
			bool singleName = true;
			for (int i = 0; i < splitted.Length; i++)
			{
				if (splitted.Length == 2 && firstname == "")
				{
					firstname = splitted[i];
				}
				else if (splitted.Length > 2 && i != splitted.Length - 1)
				{
					singleName = false;
					if (i == splitted.Length - 1)
					{
						firstname += splitted[i];
					}
					else
					{
						firstname += splitted[i] + " ";
						//firstnameL.Add(splitted[i]);
					}
				}
			}
			lastname = splitted[splitted.Length - 1];
			if (singleName)
			{
				return firstname + " " + lastname;
			}
			else
			{
				return firstname + lastname;
			}
		}

		public string GetName()
		{
			UserProfile up = new UserProfile();
			string firstname = "";
			string fullNameInput = "";
			if (fullNameInput == "")
			{
				fullNameInput = Interaction.InputBox("Enter your full name please:", "Your Full Name.", "");
				StartPosition = FormStartPosition.CenterScreen;
			}
			string[] splitted = fullNameInput.Split(' ');
			for (int i = 0; i < splitted.Length; i++)
			{
				if (splitted.Length == 2 && firstname == "")
				{
					firstname = splitted[i];
				}
				else if (splitted.Length > 2 && i != splitted.Length - 1)
				{
					firstname += splitted[i] + " ";
					//firstnameL.Add(splitted[i]);
				}
			}
			return firstname;
		}

		public string GetSurname()
		{
			UserProfile up = new UserProfile();
			string lastname = "";
			string fullNameInput = "";
			if (fullNameInput == "")
			{
				fullNameInput = Interaction.InputBox("Enter your full name please:", "Your Full Name.", "");
				StartPosition = FormStartPosition.CenterScreen;
			}

			string[] splitted = fullNameInput.Split(' ');
			lastname = splitted[splitted.Length - 1];
			return lastname;
		}

		public void btnUser_Click(object sender, EventArgs e)
		{
			UserProfile up = new UserProfile();
			//if (GetName() == "TERMINATE")
			//{
			//	MessageBox.Show("Please enter your full name", "Cannot Be Empty");
			//	up.Hide();
			//}
			//else
			//{
			//	up.Show();
			//}
			up.Show();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			pnlGreen.Width = btnLogout.Width;
			pnlGreen.Left = btnLogout.Left;
			Login loginScreen = new Login();
			Hide();
			loginScreen.Show();
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

		private void BtnBorrow_Click(object sender, EventArgs e)
		{
			//this.Hide();
			//searchBook sb = new searchBook(dgv);
			searchBook sb = new searchBook();
			sb.Show();
		}
	}
}
