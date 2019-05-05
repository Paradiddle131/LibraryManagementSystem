using dbForLMS;
using LibraryManagementSystem;
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
		private readonly Login login;
		public UserProfile()
		{
			InitializeComponent();
			login = new Login();
			lblName.Text = login.txtName.Text;
			lblSurname.Text = login.txtSurname.Text;
		}

		private readonly SqlConnection connection = new SqlConnection(AdminForm.ConnectionString);

		private void UserProfile_Load(object sender, EventArgs e)
		{
			UserForm uf = new UserForm();
			string gotname = uf.GetName();
			string gotsurname = uf.GetSurname();
			// TODO: This line of code loads data into the 'userBorrowDataSet.userBorrowView' table. You can move, or remove it, as needed.
			userBorrowViewTableAdapter.FillWithNameInput(userBorrowDataSet.userBorrowView, gotname, gotsurname);
		}

		private void BtnBack_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private void listing()
		{
			connection.Open();
			SqlCommand cmd = new SqlCommand
			{
				Connection = connection,
				CommandText = "SELECT * FROM library.dbo.userSearchView"
			};
			SqlDataAdapter adpr = new SqlDataAdapter(cmd);
			//DataSet ds = new DataSet();
			connection.Close();
		}

		private void BtnReturn_Click(object sender, EventArgs e)
		{
			addBook abook = new addBook();
			abook.addBook_Load(sender, e);
			addBorrow aborrow = new addBorrow();
			aborrow.addBorrow_Load(sender, e);
			addStudent astudent = new addStudent();
			astudent.addStudent_Load(sender, e);
			string bookname = dgvBorrowDisplay.CurrentRow.Cells[2].Value.ToString();

			string thisStudentName = dgvBorrowDisplay.CurrentRow.Cells[0].Value.ToString();
			string thisStudentSurname = dgvBorrowDisplay.CurrentRow.Cells[1].Value.ToString();
			string thisBookName = dgvBorrowDisplay.CurrentRow.Cells[2].Value.ToString();
			string thisAuthorName = dgvBorrowDisplay.CurrentRow.Cells[3].Value.ToString();
			string thisAuthorSurname = dgvBorrowDisplay.CurrentRow.Cells[4].Value.ToString();
			string thisTakenDate = dgvBorrowDisplay.CurrentRow.Cells[5].Value.ToString();
			string thisBroughtDate = dgvBorrowDisplay.CurrentRow.Cells[6].Value.ToString();

			int studentId = astudent.GetStudentId(thisStudentName, thisStudentSurname);

			int currentQuantity = abook.GetQuantity(bookname);

			int bookid = abook.GetBookId(bookname);
			int borrowid = aborrow.GetBorrowId(bookid, studentId);
			int studentid = aborrow.GetStudentId(bookid);
			DateTime takendate = aborrow.GetTakenDate(bookid);
			DateTime broughtdate = aborrow.GetBroughtDate(bookid);

			if (connection.State == ConnectionState.Closed)
			{
				int count = 0; // Trigger should be created only once.
				connection.Open();
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText =
					"UPDATE books SET quantity = " + (currentQuantity - 1) + " WHERE bookId = " + bookid +
					" " +
					"DELETE FROM borrows WHERE " +
					" borrowId = '" + borrowid + "' AND " +
					" studentId = '" + studentid + "' AND " +
					" bookId = '" + bookid + "' AND " +
					" takenDate = '" + takendate + "' AND " +
					" broughtDate = '" + broughtdate + "'" +
					" "
				};/*
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText =
					"UPDATE books SET quantity = " + (currentQuantity - 1) + " WHERE bookId = " + bookid +
					" " +
					"DELETE FROM borrows WHERE " +
					" studentName = '" + thisStudentName + "' AND " +
					" studentSurname = '" + thisStudentSurname + "' AND " +
					" BookName = '" + thisBookName + "' AND " +
					" AuthorName = '" + thisAuthorName + "' AND " +
					" AuthorSurname = '" + thisAuthorSurname + "' AND " +
					" TakenDate = '" + thisTakenDate + "' AND " +
					" BroughtDate = '" + thisBroughtDate + "'" +
					" "
				};*/
				count++;
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				connection.Close();
				//MessageBox.Show("Borrowed", "Borrow Successful");
				listing(); // must be called after the connection closed
			}
		}
	}
}
