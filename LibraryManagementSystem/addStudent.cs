using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
	public partial class addStudent : Form
	{
		dbForLMS.Checkout checkout = new dbForLMS.Checkout();
		public addStudent()
		{
			InitializeComponent();
		}

		SqlConnection connection = new SqlConnection(dbForLMS.Checkout.ConnectionString);

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			checkout.Show();
		}

		public void listing()
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = "SELECT * FROM students";
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

		private void addStudent_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'studentDataSet.students' table. You can move, or remove it, as needed.
			this.studentsTableAdapter.Fill(this.studentDataSet.students);

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = "INSERT INTO students(name,surname,birthdate,gender,class,point) " +
					"VALUES('" + txtStudentName.Text + "','" + txtStudentSurname.Text + "','" +
					dtpBirthdate.Text + "','" + rbMale.Checked + "','" + nudClass.Value + "','" + nudPoint.Value + "')";				cmd.ExecuteNonQuery();
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
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = "UPDATE students SET name='" + txtStudentName.Text +
					"',surname='" + txtStudentSurname.Text + "',birthdate='" + dtpBirthdate.Text +
					"',gender='" + rbMale.Checked + "',class='" + nudClass.Value + "','" + nudPoint.Value +
					"'WHERE studentId=@number";
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
					SqlCommand cmd = new SqlCommand();
					cmd.Connection = connection;
					cmd.CommandText = "DELETE FROM students WHERE studentId=@number";
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
			txtStudentName.Text = dgvStudent.CurrentRow.Cells[1].Value.ToString();
			txtStudentSurname.Text = dgvStudent.CurrentRow.Cells[2].Value.ToString();
			dtpBirthdate.Text = dgvStudent.CurrentRow.Cells[3].Value.ToString();
			// if rbMale.checked = true, then gender is M, otherwise F
			rbMale.Checked = Convert.ToBoolean(dgvStudent.CurrentRow.Cells[4].Value.ToString());
			nudClass.Value = int.Parse(dgvStudent.CurrentRow.Cells[5].Value.ToString());
			nudPoint.Value = int.Parse(dgvStudent.CurrentRow.Cells[6].Value.ToString());
		}

		private void txtStudentName_Enter(object sender, EventArgs e)
		{
			if (txtStudentName.Text == "<Enter Student Name>")
				txtStudentName.Text = "";
		}

		private void txtStudentName_Leave(object sender, EventArgs e)
		{
			if (txtStudentName.Text.Trim() == "")
				txtStudentName.Text = "<Enter Student Name>";
		}

		private void txtStudentSurname_Enter(object sender, EventArgs e)
		{
			if (txtStudentSurname.Text == "<Enter Student Name>")
				txtStudentSurname.Text = "";
		}

		private void txtStudentSurname_Leave(object sender, EventArgs e)
		{
			if (txtStudentSurname.Text.Trim() == "")
				txtStudentSurname.Text = "<Enter Student Name>";
		}
	}
}
