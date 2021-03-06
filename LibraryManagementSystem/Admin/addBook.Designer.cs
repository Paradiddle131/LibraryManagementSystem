﻿namespace LibraryManagementSystem
{
	partial class addBook
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBook));
			this.dgvBook = new System.Windows.Forms.DataGridView();
			this.lollipopLabel2 = new LollipopLabel();
			this.lollipopLabel1 = new LollipopLabel();
			this.txtBookName = new LollipopTextBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lollipopLabel3 = new LollipopLabel();
			this.lollipopLabel4 = new LollipopLabel();
			this.lollipopLabel5 = new LollipopLabel();
			this.numPageCount = new System.Windows.Forms.NumericUpDown();
			this.numPoint = new System.Windows.Forms.NumericUpDown();
			this.numAuthorID = new System.Windows.Forms.NumericUpDown();
			this.numTypeID = new System.Windows.Forms.NumericUpDown();
			this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.booksDataSet = new LibraryManagementSystem.Data.Datasets.BooksDataSet();
			this.booksTableAdapter = new LibraryManagementSystem.Data.Datasets.BooksDataSetTableAdapters.booksTableAdapter();
			this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pagecountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numPageCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numPoint)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numAuthorID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numTypeID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvBook
			// 
			this.dgvBook.AutoGenerateColumns = false;
			this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.bookName,
            this.pagecountDataGridViewTextBoxColumn,
            this.pointDataGridViewTextBoxColumn,
            this.authorIdDataGridViewTextBoxColumn,
            this.typeIdDataGridViewTextBoxColumn,
            this.quantity});
			this.dgvBook.DataSource = this.booksBindingSource;
			this.dgvBook.Location = new System.Drawing.Point(14, 198);
			this.dgvBook.Name = "dgvBook";
			this.dgvBook.Size = new System.Drawing.Size(774, 310);
			this.dgvBook.TabIndex = 8;
			this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
			// 
			// lollipopLabel2
			// 
			this.lollipopLabel2.AutoSize = true;
			this.lollipopLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.lollipopLabel2.Location = new System.Drawing.Point(11, 95);
			this.lollipopLabel2.Name = "lollipopLabel2";
			this.lollipopLabel2.Size = new System.Drawing.Size(125, 24);
			this.lollipopLabel2.TabIndex = 9;
			this.lollipopLabel2.Text = "Page Count:";
			// 
			// lollipopLabel1
			// 
			this.lollipopLabel1.AutoSize = true;
			this.lollipopLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.lollipopLabel1.Location = new System.Drawing.Point(10, 63);
			this.lollipopLabel1.Name = "lollipopLabel1";
			this.lollipopLabel1.Size = new System.Drawing.Size(124, 24);
			this.lollipopLabel1.TabIndex = 10;
			this.lollipopLabel1.Text = "Book Name:";
			// 
			// txtBookName
			// 
			this.txtBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.txtBookName.FocusedColor = "#508ef5";
			this.txtBookName.FontColor = "#999999";
			this.txtBookName.IsEnabled = true;
			this.txtBookName.Location = new System.Drawing.Point(181, 63);
			this.txtBookName.MaxLength = 32767;
			this.txtBookName.Multiline = false;
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.ReadOnly = false;
			this.txtBookName.Size = new System.Drawing.Size(200, 24);
			this.txtBookName.TabIndex = 0;
			this.txtBookName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtBookName.UseSystemPasswordChar = false;
			this.txtBookName.Enter += new System.EventHandler(this.txtBookName_Enter);
			this.txtBookName.Leave += new System.EventHandler(this.txtBookName_Leave);
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.White;
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.Location = new System.Drawing.Point(14, 12);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(39, 38);
			this.btnBack.TabIndex = 9;
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
			this.btnDelete.TabIndex = 7;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.Location = new System.Drawing.Point(576, 63);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 49);
			this.btnEdit.TabIndex = 6;
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
			this.btnAdd.TabIndex = 5;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lollipopLabel3
			// 
			this.lollipopLabel3.AutoSize = true;
			this.lollipopLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.lollipopLabel3.Location = new System.Drawing.Point(10, 125);
			this.lollipopLabel3.Name = "lollipopLabel3";
			this.lollipopLabel3.Size = new System.Drawing.Size(63, 24);
			this.lollipopLabel3.TabIndex = 10;
			this.lollipopLabel3.Text = "Point:";
			// 
			// lollipopLabel4
			// 
			this.lollipopLabel4.AutoSize = true;
			this.lollipopLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.lollipopLabel4.Location = new System.Drawing.Point(11, 157);
			this.lollipopLabel4.Name = "lollipopLabel4";
			this.lollipopLabel4.Size = new System.Drawing.Size(103, 24);
			this.lollipopLabel4.TabIndex = 9;
			this.lollipopLabel4.Text = "Author ID:";
			// 
			// lollipopLabel5
			// 
			this.lollipopLabel5.AutoSize = true;
			this.lollipopLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.lollipopLabel5.Location = new System.Drawing.Point(419, 125);
			this.lollipopLabel5.Name = "lollipopLabel5";
			this.lollipopLabel5.Size = new System.Drawing.Size(88, 24);
			this.lollipopLabel5.TabIndex = 10;
			this.lollipopLabel5.Text = "Type ID:";
			// 
			// numPageCount
			// 
			this.numPageCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.numPageCount.Location = new System.Drawing.Point(181, 101);
			this.numPageCount.Name = "numPageCount";
			this.numPageCount.Size = new System.Drawing.Size(60, 20);
			this.numPageCount.TabIndex = 1;
			// 
			// numPoint
			// 
			this.numPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.numPoint.Location = new System.Drawing.Point(181, 127);
			this.numPoint.Name = "numPoint";
			this.numPoint.Size = new System.Drawing.Size(60, 20);
			this.numPoint.TabIndex = 2;
			// 
			// numAuthorID
			// 
			this.numAuthorID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.numAuthorID.Location = new System.Drawing.Point(181, 157);
			this.numAuthorID.Name = "numAuthorID";
			this.numAuthorID.Size = new System.Drawing.Size(60, 20);
			this.numAuthorID.TabIndex = 3;
			// 
			// numTypeID
			// 
			this.numTypeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.numTypeID.Location = new System.Drawing.Point(561, 125);
			this.numTypeID.Name = "numTypeID";
			this.numTypeID.Size = new System.Drawing.Size(60, 20);
			this.numTypeID.TabIndex = 4;
			// 
			// booksBindingSource
			// 
			this.booksBindingSource.DataMember = "books";
			this.booksBindingSource.DataSource = this.booksDataSet;
			// 
			// booksDataSet
			// 
			this.booksDataSet.DataSetName = "BooksDataSet";
			this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// booksTableAdapter
			// 
			this.booksTableAdapter.ClearBeforeFill = true;
			// 
			// bookIdDataGridViewTextBoxColumn
			// 
			this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "bookId";
			this.bookIdDataGridViewTextBoxColumn.HeaderText = "bookId";
			this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
			this.bookIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bookName
			// 
			this.bookName.DataPropertyName = "bookName";
			this.bookName.HeaderText = "bookName";
			this.bookName.Name = "bookName";
			// 
			// pagecountDataGridViewTextBoxColumn
			// 
			this.pagecountDataGridViewTextBoxColumn.DataPropertyName = "pagecount";
			this.pagecountDataGridViewTextBoxColumn.HeaderText = "pagecount";
			this.pagecountDataGridViewTextBoxColumn.Name = "pagecountDataGridViewTextBoxColumn";
			// 
			// pointDataGridViewTextBoxColumn
			// 
			this.pointDataGridViewTextBoxColumn.DataPropertyName = "point";
			this.pointDataGridViewTextBoxColumn.HeaderText = "point";
			this.pointDataGridViewTextBoxColumn.Name = "pointDataGridViewTextBoxColumn";
			// 
			// authorIdDataGridViewTextBoxColumn
			// 
			this.authorIdDataGridViewTextBoxColumn.DataPropertyName = "authorId";
			this.authorIdDataGridViewTextBoxColumn.HeaderText = "authorId";
			this.authorIdDataGridViewTextBoxColumn.Name = "authorIdDataGridViewTextBoxColumn";
			// 
			// typeIdDataGridViewTextBoxColumn
			// 
			this.typeIdDataGridViewTextBoxColumn.DataPropertyName = "typeId";
			this.typeIdDataGridViewTextBoxColumn.HeaderText = "typeId";
			this.typeIdDataGridViewTextBoxColumn.Name = "typeIdDataGridViewTextBoxColumn";
			// 
			// quantity
			// 
			this.quantity.DataPropertyName = "quantity";
			this.quantity.HeaderText = "quantity";
			this.quantity.Name = "quantity";
			// 
			// addBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(800, 520);
			this.Controls.Add(this.numTypeID);
			this.Controls.Add(this.numAuthorID);
			this.Controls.Add(this.numPoint);
			this.Controls.Add(this.numPageCount);
			this.Controls.Add(this.dgvBook);
			this.Controls.Add(this.lollipopLabel4);
			this.Controls.Add(this.lollipopLabel2);
			this.Controls.Add(this.lollipopLabel5);
			this.Controls.Add(this.lollipopLabel3);
			this.Controls.Add(this.lollipopLabel1);
			this.Controls.Add(this.txtBookName);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(800, 520);
			this.Name = "addBook";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "addBook";
			this.Load += new System.EventHandler(this.addBook_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numPageCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numPoint)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numAuthorID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numTypeID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private LollipopLabel lollipopLabel2;
		private LollipopLabel lollipopLabel1;
		private LollipopTextBox txtBookName;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private LollipopLabel lollipopLabel3;
		private LollipopLabel lollipopLabel4;
		private LollipopLabel lollipopLabel5;
		private System.Windows.Forms.NumericUpDown numPageCount;
		private System.Windows.Forms.NumericUpDown numPoint;
		private System.Windows.Forms.NumericUpDown numAuthorID;
		private System.Windows.Forms.NumericUpDown numTypeID;
		public System.Windows.Forms.DataGridView dgvBook;
		private Data.Datasets.BooksDataSet booksDataSet;
		private System.Windows.Forms.BindingSource booksBindingSource;
		private Data.Datasets.BooksDataSetTableAdapters.booksTableAdapter booksTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
		private System.Windows.Forms.DataGridViewTextBoxColumn pagecountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pointDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
	}
}