namespace LibraryManagementSystem
{
	partial class addType
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addType));
			this.booksTableAdapter1 = new LibraryManagementSystem.BooksDataSetTableAdapters.booksTableAdapter();
			this.booksTableAdapter = new LibraryManagementSystem.BooksTableAdapters.booksTableAdapter();
			this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.books = new LibraryManagementSystem.Books();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.authorsTableAdapter = new LibraryManagementSystem.libraryDataSet1TableAdapters.authorsTableAdapter();
			this.lollipopLabel1 = new LollipopLabel();
			this.txtTypeName = new LollipopTextBox();
			this.libraryDataSet1 = new LibraryManagementSystem.libraryDataSet1();
			this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.booksDataSet = new LibraryManagementSystem.BooksDataSet();
			this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.dgvType = new System.Windows.Forms.DataGridView();
			this.typeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.typeDataSet = new LibraryManagementSystem.typeDataSet();
			this.typesTableAdapter = new LibraryManagementSystem.typeDataSetTableAdapters.typesTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.books)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.typeDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// booksTableAdapter1
			// 
			this.booksTableAdapter1.ClearBeforeFill = true;
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
			// 
			// authorsTableAdapter
			// 
			this.authorsTableAdapter.ClearBeforeFill = true;
			// 
			// lollipopLabel1
			// 
			this.lollipopLabel1.AutoSize = true;
			this.lollipopLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.lollipopLabel1.Location = new System.Drawing.Point(10, 79);
			this.lollipopLabel1.Name = "lollipopLabel1";
			this.lollipopLabel1.Size = new System.Drawing.Size(99, 24);
			this.lollipopLabel1.TabIndex = 23;
			this.lollipopLabel1.Text = "Category:";
			// 
			// txtTypeName
			// 
			this.txtTypeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.txtTypeName.FocusedColor = "#508ef5";
			this.txtTypeName.FontColor = "#999999";
			this.txtTypeName.IsEnabled = true;
			this.txtTypeName.Location = new System.Drawing.Point(181, 79);
			this.txtTypeName.MaxLength = 32767;
			this.txtTypeName.Multiline = false;
			this.txtTypeName.Name = "txtTypeName";
			this.txtTypeName.ReadOnly = false;
			this.txtTypeName.Size = new System.Drawing.Size(200, 24);
			this.txtTypeName.TabIndex = 11;
			this.txtTypeName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtTypeName.UseSystemPasswordChar = false;
			this.txtTypeName.Enter += new System.EventHandler(this.txtTypeName_Enter);
			this.txtTypeName.Leave += new System.EventHandler(this.txtTypeName_Leave);
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
			// dgvType
			// 
			this.dgvType.AutoGenerateColumns = false;
			this.dgvType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.dgvType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
			this.dgvType.DataSource = this.typesBindingSource;
			this.dgvType.Location = new System.Drawing.Point(14, 140);
			this.dgvType.Name = "dgvType";
			this.dgvType.Size = new System.Drawing.Size(776, 368);
			this.dgvType.TabIndex = 19;
			// 
			// typeIdDataGridViewTextBoxColumn
			// 
			this.typeIdDataGridViewTextBoxColumn.DataPropertyName = "typeId";
			this.typeIdDataGridViewTextBoxColumn.HeaderText = "typeId";
			this.typeIdDataGridViewTextBoxColumn.Name = "typeIdDataGridViewTextBoxColumn";
			this.typeIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// typesBindingSource
			// 
			this.typesBindingSource.DataMember = "types";
			this.typesBindingSource.DataSource = this.typeDataSet;
			// 
			// typeDataSet
			// 
			this.typeDataSet.DataSetName = "typeDataSet";
			this.typeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// typesTableAdapter
			// 
			this.typesTableAdapter.ClearBeforeFill = true;
			// 
			// addType
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(800, 520);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lollipopLabel1);
			this.Controls.Add(this.txtTypeName);
			this.Controls.Add(this.dgvType);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(800, 520);
			this.Name = "addType";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "addType";
			this.Load += new System.EventHandler(this.addType_Load);
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.books)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.typeDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private BooksDataSetTableAdapters.booksTableAdapter booksTableAdapter1;
		private BooksTableAdapters.booksTableAdapter booksTableAdapter;
		private System.Windows.Forms.BindingSource booksBindingSource;
		private Books books;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private libraryDataSet1TableAdapters.authorsTableAdapter authorsTableAdapter;
		private LollipopLabel lollipopLabel1;
		private LollipopTextBox txtTypeName;
		private libraryDataSet1 libraryDataSet1;
		private System.Windows.Forms.BindingSource authorsBindingSource;
		private BooksDataSet booksDataSet;
		private System.Windows.Forms.BindingSource booksBindingSource1;
		private System.Windows.Forms.DataGridView dgvType;
		private typeDataSet typeDataSet;
		private System.Windows.Forms.BindingSource typesBindingSource;
		private typeDataSetTableAdapters.typesTableAdapter typesTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
	}
}