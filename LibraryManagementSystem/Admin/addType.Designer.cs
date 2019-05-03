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
			this.btnBack = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lollipopLabel1 = new LollipopLabel();
			this.txtTypeName = new LollipopTextBox();
			this.dgvType = new System.Windows.Forms.DataGridView();
			this.typesDataSet = new LibraryManagementSystem.typesDataSet();
			this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.typesTableAdapter = new LibraryManagementSystem.typesDataSetTableAdapters.typesTableAdapter();
			this.typeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.typesDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
			this.SuspendLayout();
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
			// dgvType
			// 
			this.dgvType.AutoGenerateColumns = false;
			this.dgvType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.dgvType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeIdDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn});
			this.dgvType.DataSource = this.typesBindingSource;
			this.dgvType.Location = new System.Drawing.Point(14, 140);
			this.dgvType.Name = "dgvType";
			this.dgvType.Size = new System.Drawing.Size(776, 368);
			this.dgvType.TabIndex = 19;
			this.dgvType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvType_CellClick);
			// 
			// typesDataSet
			// 
			this.typesDataSet.DataSetName = "typesDataSet";
			this.typesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// typesBindingSource
			// 
			this.typesBindingSource.DataMember = "types";
			this.typesBindingSource.DataSource = this.typesDataSet;
			// 
			// typesTableAdapter
			// 
			this.typesTableAdapter.ClearBeforeFill = true;
			// 
			// typeIdDataGridViewTextBoxColumn
			// 
			this.typeIdDataGridViewTextBoxColumn.DataPropertyName = "typeId";
			this.typeIdDataGridViewTextBoxColumn.HeaderText = "typeId";
			this.typeIdDataGridViewTextBoxColumn.Name = "typeIdDataGridViewTextBoxColumn";
			this.typeIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// categoryNameDataGridViewTextBoxColumn
			// 
			this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "categoryName";
			this.categoryNameDataGridViewTextBoxColumn.HeaderText = "categoryName";
			this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
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
			((System.ComponentModel.ISupportInitialize)(this.dgvType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.typesDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private LollipopLabel lollipopLabel1;
		private LollipopTextBox txtTypeName;
		private System.Windows.Forms.DataGridView dgvType;
		private typesDataSet typesDataSet;
		private System.Windows.Forms.BindingSource typesBindingSource;
		private typesDataSetTableAdapters.typesTableAdapter typesTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
	}
}