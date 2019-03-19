namespace LibraryManagementSystem
{
	partial class IssueUserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueUserControl));
			this.pnlIssue = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerIssueDate = new System.Windows.Forms.DateTimePicker();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtAuthor = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtBookName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.libraryDBDataSet6 = new LibraryManagementSystem.libraryDBDataSet6();
			this.libraryDBDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bookIssueTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bookIssueTableTableAdapter = new LibraryManagementSystem.libraryDBDataSet6TableAdapters.BookIssueTableTableAdapter();
			this.libraryDB2DataSet = new LibraryManagementSystem.libraryDB2DataSet();
			this.libraryDB2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pnlIssue.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet6BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookIssueTableBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDB2DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDB2DataSetBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlIssue
			// 
			this.pnlIssue.Controls.Add(this.dataGridView1);
			this.pnlIssue.Controls.Add(this.groupBox1);
			this.pnlIssue.Location = new System.Drawing.Point(0, 0);
			this.pnlIssue.Name = "pnlIssue";
			this.pnlIssue.Size = new System.Drawing.Size(793, 317);
			this.pnlIssue.TabIndex = 5;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(174)))), ((int)(((byte)(252)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.DataSource = this.libraryDB2DataSetBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(0, 106);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(793, 211);
			this.dataGridView1.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(203)))), ((int)(((byte)(174)))));
			this.groupBox1.Controls.Add(this.dateTimePickerReturnDate);
			this.groupBox1.Controls.Add(this.dateTimePickerIssueDate);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.btnEdit);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.txtAuthor);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtBookName);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtSurname);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(-4, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(797, 102);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information";
			// 
			// dateTimePickerReturnDate
			// 
			this.dateTimePickerReturnDate.Location = new System.Drawing.Point(335, 75);
			this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
			this.dateTimePickerReturnDate.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerReturnDate.TabIndex = 3;
			// 
			// dateTimePickerIssueDate
			// 
			this.dateTimePickerIssueDate.Location = new System.Drawing.Point(335, 49);
			this.dateTimePickerIssueDate.Name = "dateTimePickerIssueDate";
			this.dateTimePickerIssueDate.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerIssueDate.TabIndex = 3;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(237)))));
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.Location = new System.Drawing.Point(707, 49);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 49);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.UseVisualStyleBackColor = false;
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(237)))));
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.Location = new System.Drawing.Point(626, 49);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 49);
			this.btnEdit.TabIndex = 2;
			this.btnEdit.UseVisualStyleBackColor = false;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(237)))));
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Location = new System.Drawing.Point(545, 49);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 49);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.UseVisualStyleBackColor = false;
			// 
			// txtAuthor
			// 
			this.txtAuthor.Location = new System.Drawing.Point(104, 72);
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.Size = new System.Drawing.Size(100, 20);
			this.txtAuthor.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Book Author: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(246, 78);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Return Date: ";
			// 
			// txtBookName
			// 
			this.txtBookName.Location = new System.Drawing.Point(104, 46);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.Size = new System.Drawing.Size(100, 20);
			this.txtBookName.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(249, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Surname: ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(18, 23);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Name: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Book Name: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(246, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Issue Date:";
			// 
			// txtSurname
			// 
			this.txtSurname.Location = new System.Drawing.Point(335, 23);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(100, 20);
			this.txtSurname.TabIndex = 1;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(104, 20);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 20);
			this.txtName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(10, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = " ";
			// 
			// libraryDBDataSet6
			// 
			this.libraryDBDataSet6.DataSetName = "libraryDBDataSet6";
			this.libraryDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// libraryDBDataSet6BindingSource
			// 
			this.libraryDBDataSet6BindingSource.DataSource = this.libraryDBDataSet6;
			this.libraryDBDataSet6BindingSource.Position = 0;
			// 
			// bookIssueTableBindingSource
			// 
			this.bookIssueTableBindingSource.DataMember = "BookIssueTable";
			this.bookIssueTableBindingSource.DataSource = this.libraryDBDataSet6BindingSource;
			// 
			// bookIssueTableTableAdapter
			// 
			this.bookIssueTableTableAdapter.ClearBeforeFill = true;
			// 
			// libraryDB2DataSet
			// 
			this.libraryDB2DataSet.DataSetName = "libraryDB2DataSet";
			this.libraryDB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// libraryDB2DataSetBindingSource
			// 
			this.libraryDB2DataSetBindingSource.DataSource = this.libraryDB2DataSet;
			this.libraryDB2DataSetBindingSource.Position = 0;
			// 
			// IssueUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlIssue);
			this.Name = "IssueUserControl";
			this.Size = new System.Drawing.Size(792, 315);
			this.pnlIssue.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet6BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookIssueTableBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDB2DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDB2DataSetBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlIssue;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerIssueDate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtAuthor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtBookName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource libraryDBDataSet6BindingSource;
		private libraryDBDataSet6 libraryDBDataSet6;
		private System.Windows.Forms.BindingSource libraryDB2DataSetBindingSource;
		private libraryDB2DataSet libraryDB2DataSet;
		private System.Windows.Forms.BindingSource bookIssueTableBindingSource;
		private libraryDBDataSet6TableAdapters.BookIssueTableTableAdapter bookIssueTableTableAdapter;
	}
}
