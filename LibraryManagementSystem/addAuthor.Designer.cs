namespace LibraryManagementSystem
{
	partial class addAuthor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addAuthor));
			this.txtAuthorName = new LollipopTextBox();
			this.lollipopLabel1 = new LollipopLabel();
			this.lollipopLabel2 = new LollipopLabel();
			this.txtAuthorSurname = new LollipopTextBox();
			this.dgvAuthor = new System.Windows.Forms.DataGridView();
			this.authorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.libraryDataSet1 = new LibraryManagementSystem.libraryDataSet1();
			this.authorsTableAdapter = new LibraryManagementSystem.libraryDataSet1TableAdapters.authorsTableAdapter();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtAuthorName
			// 
			this.txtAuthorName.FocusedColor = "#508ef5";
			this.txtAuthorName.FontColor = "#999999";
			this.txtAuthorName.IsEnabled = true;
			this.txtAuthorName.Location = new System.Drawing.Point(176, 51);
			this.txtAuthorName.MaxLength = 32767;
			this.txtAuthorName.Multiline = false;
			this.txtAuthorName.Name = "txtAuthorName";
			this.txtAuthorName.ReadOnly = false;
			this.txtAuthorName.Size = new System.Drawing.Size(300, 24);
			this.txtAuthorName.TabIndex = 0;
			this.txtAuthorName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtAuthorName.UseSystemPasswordChar = false;
			// 
			// lollipopLabel1
			// 
			this.lollipopLabel1.AutoSize = true;
			this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
			this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.lollipopLabel1.Location = new System.Drawing.Point(24, 51);
			this.lollipopLabel1.Name = "lollipopLabel1";
			this.lollipopLabel1.Size = new System.Drawing.Size(95, 17);
			this.lollipopLabel1.TabIndex = 1;
			this.lollipopLabel1.Text = "Author Name:";
			// 
			// lollipopLabel2
			// 
			this.lollipopLabel2.AutoSize = true;
			this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
			this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.lollipopLabel2.Location = new System.Drawing.Point(25, 95);
			this.lollipopLabel2.Name = "lollipopLabel2";
			this.lollipopLabel2.Size = new System.Drawing.Size(115, 17);
			this.lollipopLabel2.TabIndex = 1;
			this.lollipopLabel2.Text = "Author Surname:";
			// 
			// txtAuthorSurname
			// 
			this.txtAuthorSurname.FocusedColor = "#508ef5";
			this.txtAuthorSurname.FontColor = "#999999";
			this.txtAuthorSurname.IsEnabled = true;
			this.txtAuthorSurname.Location = new System.Drawing.Point(176, 95);
			this.txtAuthorSurname.MaxLength = 32767;
			this.txtAuthorSurname.Multiline = false;
			this.txtAuthorSurname.Name = "txtAuthorSurname";
			this.txtAuthorSurname.ReadOnly = false;
			this.txtAuthorSurname.Size = new System.Drawing.Size(300, 24);
			this.txtAuthorSurname.TabIndex = 0;
			this.txtAuthorSurname.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtAuthorSurname.UseSystemPasswordChar = false;
			// 
			// dgvAuthor
			// 
			this.dgvAuthor.AutoGenerateColumns = false;
			this.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn});
			this.dgvAuthor.DataSource = this.authorsBindingSource;
			this.dgvAuthor.Location = new System.Drawing.Point(28, 139);
			this.dgvAuthor.Name = "dgvAuthor";
			this.dgvAuthor.Size = new System.Drawing.Size(742, 299);
			this.dgvAuthor.TabIndex = 2;
			this.dgvAuthor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthor_CellClick);
			// 
			// authorIdDataGridViewTextBoxColumn
			// 
			this.authorIdDataGridViewTextBoxColumn.DataPropertyName = "authorId";
			this.authorIdDataGridViewTextBoxColumn.HeaderText = "authorId";
			this.authorIdDataGridViewTextBoxColumn.Name = "authorIdDataGridViewTextBoxColumn";
			this.authorIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// surnameDataGridViewTextBoxColumn
			// 
			this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
			this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
			this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
			// 
			// authorsBindingSource
			// 
			this.authorsBindingSource.DataMember = "authors";
			this.authorsBindingSource.DataSource = this.libraryDataSet1;
			// 
			// libraryDataSet1
			// 
			this.libraryDataSet1.DataSetName = "libraryDataSet1";
			this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// authorsTableAdapter
			// 
			this.authorsTableAdapter.ClearBeforeFill = true;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(237)))));
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.Location = new System.Drawing.Point(671, 63);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 49);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(237)))));
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.Location = new System.Drawing.Point(590, 63);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 49);
			this.btnEdit.TabIndex = 4;
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(237)))));
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Location = new System.Drawing.Point(509, 63);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 49);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// addAuthor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dgvAuthor);
			this.Controls.Add(this.lollipopLabel2);
			this.Controls.Add(this.lollipopLabel1);
			this.Controls.Add(this.txtAuthorSurname);
			this.Controls.Add(this.txtAuthorName);
			this.Name = "addAuthor";
			this.Text = "addAuthor";
			this.Load += new System.EventHandler(this.addAuthor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private LollipopTextBox txtAuthorName;
		private LollipopLabel lollipopLabel1;
		private LollipopLabel lollipopLabel2;
		private LollipopTextBox txtAuthorSurname;
		private System.Windows.Forms.DataGridView dgvAuthor;
		private libraryDataSet1 libraryDataSet1;
		private System.Windows.Forms.BindingSource authorsBindingSource;
		private libraryDataSet1TableAdapters.authorsTableAdapter authorsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
	}
}