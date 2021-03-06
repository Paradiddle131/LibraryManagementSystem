﻿namespace LibraryManagementSystem
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
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.authorsDataSet = new LibraryManagementSystem.authorsDataSet();
			this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.authorsTableAdapter = new LibraryManagementSystem.authorsDataSetTableAdapters.authorsTableAdapter();
			this.authorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.authorsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// txtAuthorName
			// 
			this.txtAuthorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.txtAuthorName.FocusedColor = "#508ef5";
			this.txtAuthorName.FontColor = "#999999";
			this.txtAuthorName.IsEnabled = true;
			this.txtAuthorName.Location = new System.Drawing.Point(186, 63);
			this.txtAuthorName.MaxLength = 32767;
			this.txtAuthorName.Multiline = false;
			this.txtAuthorName.Name = "txtAuthorName";
			this.txtAuthorName.ReadOnly = false;
			this.txtAuthorName.Size = new System.Drawing.Size(200, 24);
			this.txtAuthorName.TabIndex = 0;
			this.txtAuthorName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtAuthorName.UseSystemPasswordChar = false;
			this.txtAuthorName.Enter += new System.EventHandler(this.txtAuthorName_Enter);
			this.txtAuthorName.Leave += new System.EventHandler(this.txtAuthorName_Leave);
			// 
			// lollipopLabel1
			// 
			this.lollipopLabel1.AutoSize = true;
			this.lollipopLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.lollipopLabel1.Location = new System.Drawing.Point(8, 63);
			this.lollipopLabel1.Name = "lollipopLabel1";
			this.lollipopLabel1.Size = new System.Drawing.Size(139, 24);
			this.lollipopLabel1.TabIndex = 1;
			this.lollipopLabel1.Text = "Author Name:";
			// 
			// lollipopLabel2
			// 
			this.lollipopLabel2.AutoSize = true;
			this.lollipopLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.lollipopLabel2.Location = new System.Drawing.Point(9, 101);
			this.lollipopLabel2.Name = "lollipopLabel2";
			this.lollipopLabel2.Size = new System.Drawing.Size(168, 24);
			this.lollipopLabel2.TabIndex = 1;
			this.lollipopLabel2.Text = "Author Surname:";
			// 
			// txtAuthorSurname
			// 
			this.txtAuthorSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.txtAuthorSurname.FocusedColor = "#508ef5";
			this.txtAuthorSurname.FontColor = "#999999";
			this.txtAuthorSurname.IsEnabled = true;
			this.txtAuthorSurname.Location = new System.Drawing.Point(186, 101);
			this.txtAuthorSurname.MaxLength = 32767;
			this.txtAuthorSurname.Multiline = false;
			this.txtAuthorSurname.Name = "txtAuthorSurname";
			this.txtAuthorSurname.ReadOnly = false;
			this.txtAuthorSurname.Size = new System.Drawing.Size(200, 24);
			this.txtAuthorSurname.TabIndex = 1;
			this.txtAuthorSurname.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtAuthorSurname.UseSystemPasswordChar = false;
			this.txtAuthorSurname.Enter += new System.EventHandler(this.txtAuthorSurname_Enter);
			this.txtAuthorSurname.Leave += new System.EventHandler(this.txtAuthorSurname_Leave);
			// 
			// dgvAuthor
			// 
			this.dgvAuthor.AutoGenerateColumns = false;
			this.dgvAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAuthor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIdDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.authorSurnameDataGridViewTextBoxColumn});
			this.dgvAuthor.DataSource = this.authorsBindingSource;
			this.dgvAuthor.Location = new System.Drawing.Point(12, 198);
			this.dgvAuthor.Name = "dgvAuthor";
			this.dgvAuthor.Size = new System.Drawing.Size(776, 310);
			this.dgvAuthor.TabIndex = 6;
			this.dgvAuthor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthor_CellClick);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.Location = new System.Drawing.Point(655, 63);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 49);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.Location = new System.Drawing.Point(574, 63);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 49);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Location = new System.Drawing.Point(493, 63);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 49);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.White;
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.Location = new System.Drawing.Point(12, 12);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(39, 38);
			this.btnBack.TabIndex = 7;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// authorsDataSet
			// 
			this.authorsDataSet.DataSetName = "authorsDataSet";
			this.authorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// authorsBindingSource
			// 
			this.authorsBindingSource.DataMember = "authors";
			this.authorsBindingSource.DataSource = this.authorsDataSet;
			// 
			// authorsTableAdapter
			// 
			this.authorsTableAdapter.ClearBeforeFill = true;
			// 
			// authorIdDataGridViewTextBoxColumn
			// 
			this.authorIdDataGridViewTextBoxColumn.DataPropertyName = "authorId";
			this.authorIdDataGridViewTextBoxColumn.HeaderText = "authorId";
			this.authorIdDataGridViewTextBoxColumn.Name = "authorIdDataGridViewTextBoxColumn";
			this.authorIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// authorNameDataGridViewTextBoxColumn
			// 
			this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "authorName";
			this.authorNameDataGridViewTextBoxColumn.HeaderText = "authorName";
			this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
			// 
			// authorSurnameDataGridViewTextBoxColumn
			// 
			this.authorSurnameDataGridViewTextBoxColumn.DataPropertyName = "authorSurname";
			this.authorSurnameDataGridViewTextBoxColumn.HeaderText = "authorSurname";
			this.authorSurnameDataGridViewTextBoxColumn.Name = "authorSurnameDataGridViewTextBoxColumn";
			// 
			// addAuthor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(800, 520);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dgvAuthor);
			this.Controls.Add(this.lollipopLabel2);
			this.Controls.Add(this.lollipopLabel1);
			this.Controls.Add(this.txtAuthorSurname);
			this.Controls.Add(this.txtAuthorName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(800, 520);
			this.Name = "addAuthor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "addAuthor";
			this.Load += new System.EventHandler(this.addAuthor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.authorsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private LollipopTextBox txtAuthorName;
		private LollipopLabel lollipopLabel1;
		private LollipopLabel lollipopLabel2;
		private LollipopTextBox txtAuthorSurname;
		private System.Windows.Forms.DataGridView dgvAuthor;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnBack;
		private authorsDataSet authorsDataSet;
		private System.Windows.Forms.BindingSource authorsBindingSource;
		private authorsDataSetTableAdapters.authorsTableAdapter authorsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorSurnameDataGridViewTextBoxColumn;
	}
}