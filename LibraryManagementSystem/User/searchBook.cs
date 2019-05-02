﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class searchBook : Form
	{
		private readonly addBook abook;
		private readonly addBorrow aborrow;
		private readonly DataGridView dgv;
		public searchBook(DataGridView dgv)
		{
			InitializeComponent();
			this.dgv = dgv;

			label1.Visible = false;
			//label1.Text = bookid;
			//dgvBookForBorrow.Visible = false;
		}
		private readonly SqlConnection connection = new SqlConnection(AdminForm.ConnectionString);

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
		private void BtnBack_Click(object sender, EventArgs e)
		{
			Hide();
			//UserForm uf = new UserForm();
			//uf.Show();
		}

		private void SearchBook_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'bookForBorrowView.booksForBorrow' table. You can move, or remove it, as needed.
			booksForBorrowTableAdapter.Fill(bookForBorrowView.booksForBorrow);
			// TODO: This line of code loads data into the 'userSearchViewDataSet.userSearchView' table. You can move, or remove it, as needed.
			userSearchViewTableAdapter.Fill(userSearchViewDataSet.userSearchView);
		}

		private void SearchAuthorNameToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				userSearchViewTableAdapter.SearchAuthorName(userSearchViewDataSet.userSearchView, authorNameToolStripTextBox.Text);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void SearchAuthorSurnameToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				userSearchViewTableAdapter.SearchAuthorSurname(userSearchViewDataSet.userSearchView, authorSurnameToolStripTextBox.Text);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void SearchBookNameToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				userSearchViewTableAdapter.SearchBookName(userSearchViewDataSet.userSearchView, bookNameToolStripTextBox.Text);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void SearchCategoryToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				userSearchViewTableAdapter.SearchCategory(userSearchViewDataSet.userSearchView, categoryToolStripTextBox.Text);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}

		private void ResetFilterToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				userSearchViewTableAdapter.ResetFilter(userSearchViewDataSet.userSearchView);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			authorNameToolStripTextBox.Text = "";
			authorSurnameToolStripTextBox.Text = "";
			bookNameToolStripTextBox.Text = "";
			categoryToolStripTextBox.Text = "";
		}
		private void DgvBookForBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string bookid = "labeldefault";
			if (dgvBookForBorrow.CurrentRow.Cells[1].Value.ToString() ==
				dgvSearch.CurrentRow.Cells[2].Value.ToString())
			{
				bookid = dgvBookForBorrow.CurrentRow.Cells[0].Value.ToString();
			}
			label1.Text = bookid;
			//if (dgvBookForBorrow.CurrentRow.Cells[0].Value.ToString() ==
			//	dgv.CurrentRow.Cells[1].Value.ToString())
			//{
			//	studentid = dgv.CurrentRow.Cells[1].Value.ToString();
			//}

		}
		private void BtnBorrow_Click(object sender, EventArgs e)
		{
			//string bookname = "Fasti";

			if (connection.State == ConnectionState.Closed)
			{
				string authorname = dgvSearch.CurrentRow.Cells[0].Value.ToString();
				string authorsurname = dgvSearch.CurrentRow.Cells[1].Value.ToString();
				string bookname = dgvSearch.CurrentRow.Cells[2].Value.ToString();
				//foreach (DataGridViewRow row in dgvSearch.Rows)
				//{
				//	if (row.Cells[2].Value.ToString() == bookname)
				//	{
				//		authorname = row.Cells[0].Value.ToString();
				//		break;
				//	}
				//}

				//foreach (DataGridViewRow row in bookObject.dbook.Rows)
				//{
				//	string my = row.Cells[1].Value.ToString();
				//	MessageBox.Show(my);
				//}

				dynamic bookObject = new addBook();
				//dynamic authorObject = new addAuthor();

				foreach (DataGridViewRow searchRow in dgvSearch.Rows)
				{
					foreach (DataGridViewRow bookRow in bookObject.dbook.Rows)
					{
						if (bookname == bookRow.Cells[1].Value.ToString())
						{
							MessageBox.Show("done");
							break;
						}
					}
				}

				//foreach (DataGridViewRow searchRow in dgvSearch.Rows)
				//{
				//	foreach (DataGridViewRow bookRow in bookObject.dBook.Rows)
				//	{
				//		if (bookname == bookRow.Cells[1].Value.ToString())
				//		{
				//			bookid = int.Parse(bookRow.Cells[0].Value.ToString());
				//			MessageBox.Show(bookid.ToString(), "book id");
				//			break;
				//		}
				//	}
				//}


				//foreach (DataGridViewRow authorRow in authorObject.dAuthor.Rows)
				//{
				//	if (authorname == authorRow.Cells[1].Value.ToString())
				//	{// Author Name
				//		authorid = int.Parse(authorObject.Cells[0].Value.ToString());
				//		MessageBox.Show(authorid.ToString(), "author id");
				//		break;
				//	}
				//	if (authorid != -1)
				//	{
				//		break;
				//	}
				//}

				//	if (searchRow.Cells[1].Value.ToString() == bookRow.Cells[1].Value.ToString())
				//	{// Author Surname

				//	}

				//if (searchRow.Cells[3].Value.ToString() == bookRow.Cells[1].Value.ToString())
				//{// Category Name
				//	bookid = int.Parse(bookRow.Cells[0].Value.ToString());
				//	break;
				//}

				/*
				if (dgvSearch.CurrentRow.Cells[2].Value.ToString() ==
					bookObject.dgvBook.CurrentRow.Cells[1].Value.ToString())
				{
					id = bookObject.dgvBook.Rows[].Cells[1].Value.ToString();
				}

				int rowid = dgvSearch.Rows.GetFirstRow(dgvSearch.CurrentRow.Cells.ToString() == bookname)
					rowid = dgvSearch.Rows.GetFirstRow(dgvSearch.Rows.GetRowState == bookname)

				connection.Open();
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText = "INSERT INTO borrows(studentId,bookId,takenDate,broughtDate) " +
								"VALUES('" + +"','" + bookid + "','" +
								dtpTakenDate.Text + "','" + dtpBroughtDate.Text +
								dgv.CurrentRow.Cells[0].Value.ToString() +
								bookObject.dgv + "')"
				};
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				*/
				connection.Close();
				listing(); // must be called after the connection closed
						   //MessageBox.Show("Added.");
			}
		}
	}
}
