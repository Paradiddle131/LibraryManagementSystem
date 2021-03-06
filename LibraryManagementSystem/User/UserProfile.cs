﻿using dbForLMS;
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
		}

		private readonly SqlConnection connection = new SqlConnection(AdminForm.ConnectionString);

		private void UserProfile_Load(object sender, EventArgs e)
		{
			UserForm uf = new UserForm();
			string gotname = "";
			string gotsurname = "";
			string fullname = uf.GetFullName();
			string[] splitted = fullname.Split(' ');
			//for (int i = 0; i < splitted.Length; i++)
			//{
			//	if (splitted.Length > 2)
			//	{
			//		if (i + 1 != splitted.Length - 1)
			//		{
			//			gotname += splitted[i] + " ";
			//		}
			//	}
			//	else
			//	{
			//		if (i + 1 != splitted.Length)
			//		{
			//			gotname += splitted[i];
			//		}
			//	}
			//}
			for (int i = 0; i < splitted.Length; i++)
			{
				if (splitted.Length == 2 && gotname == "")
				{
					gotname = splitted[i];
				}
				else if (splitted.Length > 2 && i != splitted.Length - 1)
				{
					if (i + 1 == splitted.Length - 1)
					{
						gotname += splitted[i];
					}
					else
					{
						gotname += splitted[i] + " ";
						//firstnameL.Add(splitted[i]);
					}
				}
			}
			gotsurname = splitted[splitted.Length - 1];
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
			string takendate = aborrow.GetTakenDate(bookid);
			string broughtdate = aborrow.GetBroughtDate(bookid);

			if (connection.State == ConnectionState.Closed)
			{
				int count = 0; // Trigger should be created only once.
				connection.Open();
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText =
					"UPDATE books SET quantity = " + (currentQuantity + 1) + " WHERE bookId = " + bookid +
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
			string message = thisStudentName + " " + thisStudentSurname + " returned " + bookname;
			MessageBox.Show(message, "Returned Successfully!");

		}

		private void DgvBorrowDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvBorrowDisplay.CurrentRow.Cells[0].Value.ToString() != DBNull.Value.ToString() &&
				dgvBorrowDisplay.CurrentRow.Cells[1].Value.ToString() != DBNull.Value.ToString() &&
				dgvBorrowDisplay.CurrentRow.Cells[2].Value.ToString() != DBNull.Value.ToString() &&
				dgvBorrowDisplay.CurrentRow.Cells[3].Value.ToString() != DBNull.Value.ToString() &&
				dgvBorrowDisplay.CurrentRow.Cells[4].Value.ToString() != DBNull.Value.ToString() &&
				dgvBorrowDisplay.CurrentRow.Cells[5].Value.ToString() != DBNull.Value.ToString() &&
				dgvBorrowDisplay.CurrentRow.Cells[6].Value.ToString() != DBNull.Value.ToString())
			{
				string[] borrowDateArray = dgvBorrowDisplay.CurrentRow.Cells[5].Value.ToString().Split('/');
				int borrowYear = int.Parse(borrowDateArray[2].Substring(0, 4));
				int borrowMonth = int.Parse(borrowDateArray[1]);
				int borrowDay = int.Parse(borrowDateArray[0]);

				string[] returnDateArray = dgvBorrowDisplay.CurrentRow.Cells[6].Value.ToString().Split('/');
				int returnYear = int.Parse(returnDateArray[2].Substring(0, 4));
				int returnMonth = int.Parse(returnDateArray[1]);
				int returnDay = int.Parse(returnDateArray[0]);

				string[] todayDateArray = DateTime.Now.ToString().Split('/');
				int todayYear = int.Parse(todayDateArray[2].Substring(0, 4));
				int todayMonth = int.Parse(todayDateArray[1]);
				int todayDay = int.Parse(todayDateArray[0]);

				DateTime borrowDate = new DateTime(borrowYear, borrowDay, borrowMonth);
				DateTime returnDate = new DateTime(returnYear, returnDay, returnMonth);
				DateTime todayDate = new DateTime(todayYear, todayDay, todayMonth);
				int dayDiff = (returnDate - borrowDate).Days;
				int todayDiff = (returnDate - todayDate).Days;

				lblDue.Text = "Borrowed for " + dayDiff.ToString() + " days";

				if (todayDiff > 0)
				{
					lblRemaining.Text = todayDiff.ToString() + " days before return date";
					lblCharge.Text = "No charge";
				}
				else if (todayDiff < 0 && returnYear < 2019)
				{
					lblRemaining.Text = "Returned";
					lblCharge.Text = "No charge";
				}
				else
				{
					lblRemaining.Text = Math.Abs(todayDiff).ToString() + " days passed";
					lblCharge.Text = (Math.Abs(todayDiff) * 0.49).ToString() + "₺ charged";
				}

				//lblDue.Text = (int.Parse(dgvBorrowDisplay.CurrentRow.Cells[6].Value.ToString()) -
				//	int.Parse(dgvBorrowDisplay.CurrentRow.Cells[5].Value.ToString())).ToString();
			}
		}
	}
}
