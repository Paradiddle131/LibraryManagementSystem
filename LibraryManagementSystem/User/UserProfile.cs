using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.User
{
	public partial class UserProfile : Form
	{
		public UserProfile()
		{
			InitializeComponent();
		}

		private readonly SqlConnection connection = new SqlConnection(AdminForm.ConnectionString);

		private void UserProfile_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'userBorrowsView.userBorrowView' table. You can move, or remove it, as needed.
			userBorrowViewTableAdapter.Fill(userBorrowsView.userBorrowView);
		}

		private void BtnBack_Click(object sender, EventArgs e)
		{
			Hide();
		}
	}
}
