using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class addBorrow : Form
	{
		private readonly searchBook sb;
		private readonly AdminForm af;
		public addBorrow()
		{
			InitializeComponent();
			//sb = new searchBook(dgvBorrow);
			sb = new searchBook();
		}

		private readonly SqlConnection connection = new SqlConnection(AdminForm.ConnectionString);

		private void btnBack_Click(object sender, EventArgs e)
		{
			Hide();
			//AdminForm af = new AdminForm();
			//af.Show();
		}
		public void listing()
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText = "SELECT * FROM borrows"
				};
				SqlDataAdapter adpr = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				adpr.Fill(ds, "borrows");
				dgvBorrow.DataSource = ds.Tables["borrows"];
				connection.Close();
			}
		}

		public void clear()
		{
			nudStudentID.Value = 0;
			nudBookID.Value = 0;
			dtpTakenDate.Text = "01 / 01 / 1900";
			dtpBroughtDate.Text = "01 / 01 / 1900";
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText = "INSERT INTO borrows(studentId,bookId,takenDate,broughtDate) " +
					"VALUES('" + nudStudentID.Value + "','" + nudBookID.Value + "','" +
					dtpTakenDate.Text + "','" + dtpBroughtDate.Text + "')"
				};
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				connection.Close();
				listing(); // must be called after the connection closed
				MessageBox.Show("Added.");
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText = "UPDATE borrows SET borrowId='" + nudStudentID.Value +
					"',bookId='" + nudBookID.Value + "',takenDate='" + dtpTakenDate.Text +
					"',broughtDate='" + dtpBroughtDate.Text +
					"'WHERE borrowId=@number"
				};
				cmd.Parameters.AddWithValue("@number", dgvBorrow.CurrentRow.Cells[0].Value.ToString());
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				connection.Close();
				MessageBox.Show("Edited.");
				clear();
				listing();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to delete?", "Hold On!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (connection.State == ConnectionState.Closed)
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand
					{
						Connection = connection,
						CommandText = "DELETE FROM borrows WHERE borrowId=@number"
					};
					cmd.Parameters.AddWithValue("@number", dgvBorrow.CurrentRow.Cells[0].Value.ToString());
					cmd.ExecuteNonQuery();
					cmd.Dispose();
					connection.Close();
					listing();
					MessageBox.Show("Deleted.");
				}
			}
		}

		public void addBorrow_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'borrowsDataSet.borrows' table. You can move, or remove it, as needed.
			borrowsTableAdapter.Fill(borrowsDataSet.borrows);
			// TODO: This line of code loads data into the 'borrowsDataSet.borrows' table. You can move, or remove it, as needed.
			borrowsTableAdapter.Fill(borrowsDataSet.borrows);

		}

		private void dgvBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//if (dgvBorrow.CurrentCell.Value != DBNull.Value)
			if (dgvBorrow.CurrentCell.Value != DBNull.Value && dgvBorrow.CurrentRow.Cells[0].Value != DBNull.Value &&
					dgvBorrow.CurrentRow.Cells[1].Value != DBNull.Value && dgvBorrow.CurrentRow.Cells[2].Value != DBNull.Value &&
					dgvBorrow.CurrentRow.Cells[3].Value != DBNull.Value && dgvBorrow.CurrentRow.Cells[4].Value != DBNull.Value)
			{
				//nudStudentID.Maximum = nudBookID.Maximum = 9999;
				nudStudentID.Maximum = nudBookID.Maximum = int.MaxValue;
				// Default range of the numeric up down properties is [0,100] and this causes an "ArgumentOutOfRangeException" 
				// when the user clicks a cell which contains a value out of the range. 
				// Therefore, we had to set the maximum value as higher like 9999.
				nudStudentID.Value = int.Parse(dgvBorrow.CurrentRow.Cells[1].Value.ToString());
				nudBookID.Value = int.Parse(dgvBorrow.CurrentRow.Cells[2].Value.ToString());
				dtpTakenDate.Value = Convert.ToDateTime(dgvBorrow.CurrentRow.Cells[3].Value.ToString());
				dtpBroughtDate.Value = Convert.ToDateTime(dgvBorrow.CurrentRow.Cells[4].Value.ToString());
				dgvBorrow.PerformLayout();
			}
			//if (dgvBorrow.SelectedCells.Contains(null)) return;
			//if (dgvBorrow.CurrentCell.Value == null || dgvBorrow.CurrentRow.Cells[0] == null ||
			//	dgvBorrow.CurrentRow.Cells[1] == null || dgvBorrow.CurrentRow.Cells[2] == null ||
			//	dgvBorrow.CurrentRow.Cells[3] == null || dgvBorrow.CurrentRow.Cells[4] == null)
			//{
			//	return;
			//}

		}


		public int GetBorrowId(int bookid, int studentid)
		{
			listing();
			foreach (DataGridViewRow row in dgvBorrow.Rows)
			{
				if (row.Cells[1].Value.ToString() != DBNull.Value.ToString() &&
					row.Cells[2].Value.ToString() != DBNull.Value.ToString())
				{
					if (int.Parse(row.Cells[1].Value.ToString()).Equals(studentid) &&
						int.Parse(row.Cells[2].Value.ToString()).Equals(bookid))
					{
						return int.Parse(row.Cells[0].Value.ToString());
					}
				}
			}
			return -1;
		}

		public int GetStudentId(int bookid)
		{
			listing();
			foreach (DataGridViewRow row in dgvBorrow.Rows)
			{
				if (int.Parse(row.Cells[2].Value.ToString()).Equals(bookid))
				{
					return int.Parse(row.Cells[1].Value.ToString());
				}
			}
			return -1;
		}

		public string GetTakenDate(int bookid)
		{
			CultureInfo zhHans = new CultureInfo("zh-Hans");
			CultureInfo enUS = new CultureInfo("en-US");
			listing();
			foreach (DataGridViewRow row in dgvBorrow.Rows)
			{
				if (int.Parse(row.Cells[2].Value.ToString()).Equals(bookid))
				{
					string returnDate = row.Cells[3].Value.ToString();
					string[] fulldate = row.Cells[3].Value.ToString().Split('/');
					string[] splitIntoTwo = row.Cells[3].Value.ToString().Split(' ');
					int year2 = int.Parse(fulldate[2].Substring(0, 4));
					int month2 = int.Parse(fulldate[1]);
					int day2 = int.Parse(fulldate[0]);
					int hour = int.Parse(splitIntoTwo[1].Substring(0, 1));
					int minute = int.Parse(splitIntoTwo[1].Substring(2, 2));
					int second = int.Parse(splitIntoTwo[1].Substring(5, 2));
					string total2 = "";
					if (returnDate.Substring(17) == "AM" ||
						returnDate.Substring(18) == "AM" ||
						returnDate.Substring(19) == "AM")
					{
						total2 = year2 + "/" + month2 + "/" + day2 + " " + hour + ":" + minute + ":" + second + " " + "AM";
					}
					else
					{
						total2 = year2 + "/" + month2 + "/" + day2 + " " + hour + ":" + minute + ":" + second + " " + "PM";
					}


					string[] date = row.Cells[3].Value.ToString().Split('/');
					int year = int.Parse(date[2].Substring(0, 4));
					int month = int.Parse(date[1]);
					int day = int.Parse(date[0]);
					string test3 = DateTime.Now.ToString("yyyy/MM/dd");
					string test4 = DateTime.Parse(returnDate).ToString("yyyy/MM/dd");
					DateTime test5 = DateTime.Parse(DateTime.Parse(returnDate).ToString("yyyy/MM/dd"));
					//int[] test3Array = new int[3];
					//test3Array[0] = int.Parse(test3.Substring(0, 4));
					//test3Array[1] = int.Parse(test3.Substring(5, 2));
					//test3Array[2] = int.Parse(test3.Substring(8, 2));
					string[] test3Array = new string[3]; // "2019/05/05" 
					test3Array[0] = test3.Substring(0, 4); // "2019"
					test3Array[1] = test3.Substring(5, 2); // "05"
					test3Array[2] = test3.Substring(8, 2); // "05"
					string total = test3Array[0] + "/" + test3Array[1] + "/" + test3Array[2];
					DateTime formattedDate = new DateTime(int.Parse(test3Array[0]), int.Parse(test3Array[1]), int.Parse(test3Array[2]));
					//DateTime test = DateTime.ParseExact(returnDate, "yyyy/MM/dd hh:mm:ss", zhHans, DateTimeStyles.None);
					DateTime test2 = DateTime.Parse(formattedDate.ToString("yyyy/MM/dd"));
					DateTime datetest = DateTime.Parse(total, zhHans);
					DateTime datatest2 = DateTime.ParseExact(total, "yyyy/MM/dd", enUS, DateTimeStyles.None);
					DateTime datatest3 = DateTime.ParseExact(total, "yyyy/MM/dd", enUS);
					return total2;
				}
			}
			return "";
		}
		public string GetBroughtDate(int bookid)
		{
			listing();
			foreach (DataGridViewRow row in dgvBorrow.Rows)
			{
				if (int.Parse(row.Cells[2].Value.ToString()).Equals(bookid))
				{
					string returnDate = row.Cells[3].Value.ToString();
					string test4 = DateTime.Parse(returnDate).ToString("yyyy/MM/dd");
					return test4;
					//DateTime returnDate = DateTime.Parse(row.Cells[4].Value.ToString());
					//return DateTime.Parse(returnDate.ToString("yyyy/MM/dd"));
				}
			}
			return "";
		}


	}
}
