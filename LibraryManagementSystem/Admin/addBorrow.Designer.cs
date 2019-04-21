using LibraryManagementSystem.Data;
using LibraryManagementSystem.Data.Datasets;
using LibraryManagementSystem.Data.Views;

namespace LibraryManagementSystem
{
	partial class addBorrow
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBorrow));
			this.booksTableAdapter1 = new LibraryManagementSystem.Data.Datasets.BooksDataSetTableAdapters.booksTableAdapter();
			this.lollipopLabel4 = new LollipopLabel();
			this.lollipopLabel3 = new LollipopLabel();
			this.booksTableAdapter = new LibraryManagementSystem.Data.Datasets.BooksTableAdapters.booksTableAdapter();
			this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.books = new LibraryManagementSystem.Data.Datasets.Books();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.authorsTableAdapter = new LibraryManagementSystem.Data.Datasets.libraryDataSet1TableAdapters.authorsTableAdapter();
			this.lollipopLabel2 = new LollipopLabel();
			this.lollipopLabel1 = new LollipopLabel();
			this.libraryDataSet1 = new LibraryManagementSystem.Data.Datasets.libraryDataSet1();
			this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.booksDataSet = new LibraryManagementSystem.Data.Datasets.BooksDataSet();
			this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.dgvBorrow = new System.Windows.Forms.DataGridView();
			this.borrowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.takenDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.broughtDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.borrowsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.borrowsDataSet = new LibraryManagementSystem.Data.Datasets.borrowsDataSet();
			this.dtpTakenDate = new System.Windows.Forms.DateTimePicker();
			this.dtpBroughtDate = new System.Windows.Forms.DateTimePicker();
			this.nudStudentID = new System.Windows.Forms.NumericUpDown();
			this.nudBookID = new System.Windows.Forms.NumericUpDown();
			this.borrowsTableAdapter = new LibraryManagementSystem.Data.Datasets.borrowsDataSetTableAdapters.borrowsTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.books)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.borrowsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.borrowsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudStudentID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBookID)).BeginInit();
			this.SuspendLayout();
			// 
			// booksTableAdapter1
			// 
			this.booksTableAdapter1.ClearBeforeFill = true;
			// 
			// lollipopLabel4
			// 
			this.lollipopLabel4.AutoSize = true;
			this.lollipopLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.lollipopLabel4.Location = new System.Drawing.Point(11, 157);
			this.lollipopLabel4.Name = "lollipopLabel4";
			this.lollipopLabel4.Size = new System.Drawing.Size(137, 24);
			this.lollipopLabel4.TabIndex = 21;
			this.lollipopLabel4.Text = "Brought Date:";
			// 
			// lollipopLabel3
			// 
			this.lollipopLabel3.AutoSize = true;
			this.lollipopLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.lollipopLabel3.Location = new System.Drawing.Point(10, 125);
			this.lollipopLabel3.Name = "lollipopLabel3";
			this.lollipopLabel3.Size = new System.Drawing.Size(122, 24);
			this.lollipopLabel3.TabIndex = 24;
			this.lollipopLabel3.Text = "Taken Date:";
			// 
			// booksTableAdapter
			// 
			this.booksTableAdapter.ClearBeforeFill = true;
			// 
			// booksBindingSource
			// 
			this.booksBindingSource.DataMember = "books";
			this.booksBindingSource.DataSource = this.books;
			// 
			// books
			// 
			this.books.DataSetName = "Books";
			this.books.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.White;
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.Location = new System.Drawing.Point(14, 12);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(39, 38);
			this.btnBack.TabIndex = 20;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.Location = new System.Drawing.Point(657, 63);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 49);
			this.btnDelete.TabIndex = 18;
			this.btnDelete.UseVisualStyleBackColor = false;
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.Location = new System.Drawing.Point(576, 63);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 49);
			this.btnEdit.TabIndex = 17;
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Location = new System.Drawing.Point(495, 63);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 49);
			this.btnAdd.TabIndex = 16;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// authorsTableAdapter
			// 
			this.authorsTableAdapter.ClearBeforeFill = true;
			// 
			// lollipopLabel2
			// 
			this.lollipopLabel2.AutoSize = true;
			this.lollipopLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.lollipopLabel2.Location = new System.Drawing.Point(11, 95);
			this.lollipopLabel2.Name = "lollipopLabel2";
			this.lollipopLabel2.Size = new System.Drawing.Size(88, 24);
			this.lollipopLabel2.TabIndex = 22;
			this.lollipopLabel2.Text = "Book ID:";
			// 
			// lollipopLabel1
			// 
			this.lollipopLabel1.AutoSize = true;
			this.lollipopLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.lollipopLabel1.Location = new System.Drawing.Point(10, 63);
			this.lollipopLabel1.Name = "lollipopLabel1";
			this.lollipopLabel1.Size = new System.Drawing.Size(112, 24);
			this.lollipopLabel1.TabIndex = 23;
			this.lollipopLabel1.Text = "Student ID:";
			// 
			// libraryDataSet1
			// 
			this.libraryDataSet1.DataSetName = "libraryDataSet1";
			this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// authorsBindingSource
			// 
			this.authorsBindingSource.DataMember = "authors";
			this.authorsBindingSource.DataSource = this.libraryDataSet1;
			// 
			// booksDataSet
			// 
			this.booksDataSet.DataSetName = "BooksDataSet";
			this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// booksBindingSource1
			// 
			this.booksBindingSource1.DataMember = "books";
			this.booksBindingSource1.DataSource = this.booksDataSet;
			// 
			// dgvBorrow
			// 
			this.dgvBorrow.AutoGenerateColumns = false;
			this.dgvBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBorrow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.borrowIdDataGridViewTextBoxColumn,
			this.studentIdDataGridViewTextBoxColumn,
			this.bookIdDataGridViewTextBoxColumn,
			this.takenDateDataGridViewTextBoxColumn,
			this.broughtDateDataGridViewTextBoxColumn});
			this.dgvBorrow.DataSource = this.borrowsBindingSource;
			this.dgvBorrow.Location = new System.Drawing.Point(14, 198);
			this.dgvBorrow.Name = "dgvBorrow";
			this.dgvBorrow.Size = new System.Drawing.Size(776, 310);
			this.dgvBorrow.TabIndex = 19;
			this.dgvBorrow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_CellClick);
			// 
			// borrowIdDataGridViewTextBoxColumn
			// 
			this.borrowIdDataGridViewTextBoxColumn.DataPropertyName = "borrowId";
			this.borrowIdDataGridViewTextBoxColumn.HeaderText = "borrowId";
			this.borrowIdDataGridViewTextBoxColumn.Name = "borrowIdDataGridViewTextBoxColumn";
			this.borrowIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// studentIdDataGridViewTextBoxColumn
			// 
			this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "studentId";
			this.studentIdDataGridViewTextBoxColumn.HeaderText = "studentId";
			this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
			// 
			// bookIdDataGridViewTextBoxColumn
			// 
			this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "bookId";
			this.bookIdDataGridViewTextBoxColumn.HeaderText = "bookId";
			this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
			// 
			// takenDateDataGridViewTextBoxColumn
			// 
			this.takenDateDataGridViewTextBoxColumn.DataPropertyName = "takenDate";
			this.takenDateDataGridViewTextBoxColumn.HeaderText = "takenDate";
			this.takenDateDataGridViewTextBoxColumn.Name = "takenDateDataGridViewTextBoxColumn";
			// 
			// broughtDateDataGridViewTextBoxColumn
			// 
			this.broughtDateDataGridViewTextBoxColumn.DataPropertyName = "broughtDate";
			this.broughtDateDataGridViewTextBoxColumn.HeaderText = "broughtDate";
			this.broughtDateDataGridViewTextBoxColumn.Name = "broughtDateDataGridViewTextBoxColumn";
			// 
			// borrowsBindingSource
			// 
			this.borrowsBindingSource.DataMember = "borrows";
			this.borrowsBindingSource.DataSource = this.borrowsDataSet;
			// 
			// borrowsDataSet
			// 
			this.borrowsDataSet.DataSetName = "borrowsDataSet";
			this.borrowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dtpTakenDate
			// 
			this.dtpTakenDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.dtpTakenDate.Location = new System.Drawing.Point(181, 126);
			this.dtpTakenDate.Name = "dtpTakenDate";
			this.dtpTakenDate.Size = new System.Drawing.Size(200, 20);
			this.dtpTakenDate.TabIndex = 25;
			// 
			// dtpBroughtDate
			// 
			this.dtpBroughtDate.Location = new System.Drawing.Point(181, 157);
			this.dtpBroughtDate.Name = "dtpBroughtDate";
			this.dtpBroughtDate.Size = new System.Drawing.Size(200, 20);
			this.dtpBroughtDate.TabIndex = 25;
			// 
			// nudStudentID
			// 
			this.nudStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.nudStudentID.Location = new System.Drawing.Point(181, 63);
			this.nudStudentID.Name = "nudStudentID";
			this.nudStudentID.Size = new System.Drawing.Size(120, 20);
			this.nudStudentID.TabIndex = 26;
			// 
			// nudBookID
			// 
			this.nudBookID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.nudBookID.Location = new System.Drawing.Point(181, 95);
			this.nudBookID.Name = "nudBookID";
			this.nudBookID.Size = new System.Drawing.Size(120, 20);
			this.nudBookID.TabIndex = 26;
			// 
			// borrowsTableAdapter
			// 
			this.borrowsTableAdapter.ClearBeforeFill = true;
			// 
			// addBorrow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(800, 520);
			this.Controls.Add(this.nudBookID);
			this.Controls.Add(this.nudStudentID);
			this.Controls.Add(this.dtpBroughtDate);
			this.Controls.Add(this.dtpTakenDate);
			this.Controls.Add(this.lollipopLabel4);
			this.Controls.Add(this.lollipopLabel3);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lollipopLabel2);
			this.Controls.Add(this.lollipopLabel1);
			this.Controls.Add(this.dgvBorrow);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(800, 520);
			this.Name = "addBorrow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "addBorrow";
			this.Load += new System.EventHandler(this.addBorrow_Load);
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.books)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.borrowsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.borrowsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudStudentID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBookID)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Data.Datasets.BooksDataSetTableAdapters.booksTableAdapter booksTableAdapter1;
		private LollipopLabel lollipopLabel4;
		private LollipopLabel lollipopLabel3;
		private Data.Datasets.BooksTableAdapters.booksTableAdapter booksTableAdapter;
		private System.Windows.Forms.BindingSource booksBindingSource;
		private Data.Datasets.Books books;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private Data.Datasets.libraryDataSet1TableAdapters.authorsTableAdapter authorsTableAdapter;
		private LollipopLabel lollipopLabel2;
		private LollipopLabel lollipopLabel1;
		private Data.Datasets.libraryDataSet1 libraryDataSet1;
		private System.Windows.Forms.BindingSource authorsBindingSource;
		private Data.Datasets.BooksDataSet booksDataSet;
		private System.Windows.Forms.BindingSource booksBindingSource1;
		private System.Windows.Forms.DataGridView dgvBorrow;
		private System.Windows.Forms.DateTimePicker dtpTakenDate;
		private System.Windows.Forms.DateTimePicker dtpBroughtDate;
		private System.Windows.Forms.NumericUpDown nudStudentID;
		private System.Windows.Forms.NumericUpDown nudBookID;
		private Data.Datasets.borrowsDataSet borrowsDataSet;
		private System.Windows.Forms.BindingSource borrowsBindingSource;
		private Data.Datasets.borrowsDataSetTableAdapters.borrowsTableAdapter borrowsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn borrowIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn takenDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn broughtDateDataGridViewTextBoxColumn;
	}
}