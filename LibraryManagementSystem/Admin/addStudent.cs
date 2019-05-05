using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class addStudent : Form
	{
		private readonly searchBook sb;
		private readonly AdminForm af;
		public addStudent()
		{
			InitializeComponent();
			for (char c = 'A'; c <= 'Z'; ++c)
			{
				cmbLetter.Items.Add(c);
			}
			//sb = new searchBook(dgvStudent);
			sb = new searchBook();
		}

		private readonly SqlConnection connection = new SqlConnection(AdminForm.ConnectionString);

		private void btnBack_Click(object sender, EventArgs e)
		{
			Hide();
			//AdminForm af = new AdminForm();
			//af.Show();
		}

		public bool isStudentRegistered(string firstname, string surname)
		{
			foreach (DataGridViewRow row in dgvStudent.Rows)
			{
				if (row.Cells[1].Value.ToString().Equals(firstname) &&
					row.Cells[2].Value.ToString().Equals(surname))
				{
					return true;
				}
			}
			return false;
		}

		public int getStudentId(string firstname, string surname)
		{
			listing(); // if the method declared AFTER the listing() method, use this one
			int rowIndex = -1;
			foreach (DataGridViewRow row in dgvStudent.Rows)
			{// if the Rows has 0 item, dgv may not be public
				if (row.Cells[1].Value.ToString().Equals(firstname) &&
					row.Cells[2].Value.ToString().Equals(surname))
				{
					rowIndex = row.Index;
					//MessageBox.Show(int.Parse(row.Cells[0].Value.ToString()).ToString());
					return int.Parse(dgvStudent.Rows[rowIndex].Cells[0].Value.ToString());
				}
			}

			MessageBox.Show("Couldn't return the student id correctly.", "Error");
			return -1;
		}

		public void listing()
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText = "SELECT * FROM students"
				};
				SqlDataAdapter adpr = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				adpr.Fill(ds, "students");
				dgvStudent.DataSource = ds.Tables["students"];
				connection.Close();
			}
		}

		public void clear()
		{
			txtStudentName.Text = "";
			txtStudentSurname.Text = "";
			dtpBirthdate.Text = "01/01/1900";
			rbMale.Checked = false;
			rbFemale.Checked = false;
			nudClass.Value = 0;
			nudPoint.Value = 0;
		}

		public void addStudent_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'studentsDataSet.students' table. You can move, or remove it, as needed.
			studentsTableAdapter.Fill(studentsDataSet.students);

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText = "INSERT INTO students(name,surname,birthdate,gender,class,point) " +
					"VALUES('" + txtStudentName.Text + "','" + txtStudentSurname.Text + "','" +
					dtpBirthdate.Text + "','" + rbMale.Checked + "','" + nudClass.Value + "','" + nudPoint.Value + "')"
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
					CommandText = "UPDATE students SET name='" + txtStudentName.Text +
					"',surname='" + txtStudentSurname.Text + "',birthdate='" + dtpBirthdate.Text +
					"',gender='" + rbMale.Checked + "',class='" + nudClass.Value + "','" + nudPoint.Value +
					"'WHERE studentId=@number"
				};
				cmd.Parameters.AddWithValue("@number", dgvStudent.CurrentRow.Cells[0].Value.ToString());
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
						CommandText = "DELETE FROM students WHERE studentId=@number"
					};
					cmd.Parameters.AddWithValue("@number", dgvStudent.CurrentRow.Cells[0].Value.ToString());
					cmd.ExecuteNonQuery();
					cmd.Dispose();
					connection.Close();
					listing();
					MessageBox.Show("Deleted.");
				}
			}
		}

		private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvStudent.CurrentCell.Value != DBNull.Value && dgvStudent.CurrentRow.Cells[0].Value != DBNull.Value &&
					dgvStudent.CurrentRow.Cells[1].Value != DBNull.Value && dgvStudent.CurrentRow.Cells[2].Value != DBNull.Value &&
					dgvStudent.CurrentRow.Cells[3].Value != DBNull.Value && dgvStudent.CurrentRow.Cells[4].Value != DBNull.Value &&
					dgvStudent.CurrentRow.Cells[5].Value != DBNull.Value && dgvStudent.CurrentRow.Cells[6].Value != DBNull.Value)
			{
				if (dgvStudent.CurrentRow.Cells[4].Value.ToString() == "M")
				{
					rbMale.Checked = true;
				}
				else
				{
					rbFemale.Checked = true;
				}

				nudClass.Value = int.Parse(Regex.Replace(dgvStudent.CurrentRow.Cells[5].Value.ToString(), "[^0-9]", ""));
				cmbLetter.Text = Regex.Replace(dgvStudent.CurrentRow.Cells[5].Value.ToString(), "[^a-zA-Z]", "");
				nudClass.Maximum = nudPoint.Maximum = int.MaxValue;
				txtStudentName.Text = dgvStudent.CurrentRow.Cells[1].Value.ToString();
				txtStudentSurname.Text = dgvStudent.CurrentRow.Cells[2].Value.ToString();
				dtpBirthdate.Text = dgvStudent.CurrentRow.Cells[3].Value.ToString();
				// if rbMale.checked = true, then gender is M, otherwise F
				//rbMale.Checked = Convert.ToBoolean(dgvStudent.CurrentRow.Cells[4].Value.ToString());
				nudPoint.Value = int.Parse(dgvStudent.CurrentRow.Cells[6].Value.ToString());
			}
		}
		#region Focus
		private void txtStudentName_Enter(object sender, EventArgs e)
		{
			if (txtStudentName.Text == "<Enter Student Name>")
			{
				txtStudentName.Text = "";
			}
		}

		private void txtStudentName_Leave(object sender, EventArgs e)
		{
			if (txtStudentName.Text.Trim() == "")
			{
				txtStudentName.Text = "<Enter Student Name>";
			}
		}

		private void txtStudentSurname_Enter(object sender, EventArgs e)
		{
			if (txtStudentSurname.Text == "<Enter Student Name>")
			{
				txtStudentSurname.Text = "";
			}
		}

		private void txtStudentSurname_Leave(object sender, EventArgs e)
		{
			if (txtStudentSurname.Text.Trim() == "")
			{
				txtStudentSurname.Text = "<Enter Student Name>";
			}
		}
		#endregion
	}
}
