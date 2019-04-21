namespace LibraryManagementSystem
{
    partial class addStudent
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addStudent));
			this.booksTableAdapter1 = new LibraryManagementSystem.Data.Datasets.BooksDataSetTableAdapters.booksTableAdapter();
			this.lollipopLabel4 = new LollipopLabel();
			this.lollipopLabel5 = new LollipopLabel();
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
			this.txtStudentName = new LollipopTextBox();
			this.libraryDataSet1 = new LibraryManagementSystem.Data.Datasets.libraryDataSet1();
			this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.booksDataSet = new LibraryManagementSystem.Data.Datasets.BooksDataSet();
			this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.nudClass = new System.Windows.Forms.NumericUpDown();
			this.dgvStudent = new System.Windows.Forms.DataGridView();
			this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.studentDataSet = new LibraryManagementSystem.Data.Datasets.StudentDataSet();
			this.nudPoint = new System.Windows.Forms.NumericUpDown();
			this.lollipopLabel6 = new LollipopLabel();
			this.rbMale = new System.Windows.Forms.RadioButton();
			this.rbFemale = new System.Windows.Forms.RadioButton();
			this.txtStudentSurname = new LollipopTextBox();
			this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
			this.studentsTableAdapter = new LibraryManagementSystem.Data.Datasets.StudentDataSetTableAdapters.studentsTableAdapter();
			this.lollipopLabel7 = new LollipopLabel();
			this.cmbLetter = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.books)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudClass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPoint)).BeginInit();
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
			this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.lollipopLabel4.Location = new System.Drawing.Point(11, 157);
			this.lollipopLabel4.Name = "lollipopLabel4";
			this.lollipopLabel4.Size = new System.Drawing.Size(86, 24);
			this.lollipopLabel4.TabIndex = 21;
			this.lollipopLabel4.Text = "Gender:";
			// 
			// lollipopLabel5
			// 
			this.lollipopLabel5.AutoSize = true;
			this.lollipopLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.lollipopLabel5.Location = new System.Drawing.Point(419, 125);
			this.lollipopLabel5.Name = "lollipopLabel5";
			this.lollipopLabel5.Size = new System.Drawing.Size(66, 24);
			this.lollipopLabel5.TabIndex = 25;
			this.lollipopLabel5.Text = "Class:";
			// 
			// lollipopLabel3
			// 
			this.lollipopLabel3.AutoSize = true;
			this.lollipopLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.lollipopLabel3.Location = new System.Drawing.Point(10, 125);
			this.lollipopLabel3.Name = "lollipopLabel3";
			this.lollipopLabel3.Size = new System.Drawing.Size(98, 24);
			this.lollipopLabel3.TabIndex = 24;
			this.lollipopLabel3.Text = "Birthdate:";
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
			// lollipopLabel2
			// 
			this.lollipopLabel2.AutoSize = true;
			this.lollipopLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.lollipopLabel2.Location = new System.Drawing.Point(11, 95);
			this.lollipopLabel2.Name = "lollipopLabel2";
			this.lollipopLabel2.Size = new System.Drawing.Size(177, 24);
			this.lollipopLabel2.TabIndex = 22;
			this.lollipopLabel2.Text = "Student Surname:";
			// 
			// lollipopLabel1
			// 
			this.lollipopLabel1.AutoSize = true;
			this.lollipopLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.lollipopLabel1.Location = new System.Drawing.Point(10, 63);
			this.lollipopLabel1.Name = "lollipopLabel1";
			this.lollipopLabel1.Size = new System.Drawing.Size(148, 24);
			this.lollipopLabel1.TabIndex = 23;
			this.lollipopLabel1.Text = "Student Name:";
			// 
			// txtStudentName
			// 
			this.txtStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.txtStudentName.FocusedColor = "#508ef5";
			this.txtStudentName.FontColor = "#999999";
			this.txtStudentName.IsEnabled = true;
			this.txtStudentName.Location = new System.Drawing.Point(203, 63);
			this.txtStudentName.MaxLength = 32767;
			this.txtStudentName.Multiline = false;
			this.txtStudentName.Name = "txtStudentName";
			this.txtStudentName.ReadOnly = false;
			this.txtStudentName.Size = new System.Drawing.Size(200, 24);
			this.txtStudentName.TabIndex = 11;
			this.txtStudentName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtStudentName.UseSystemPasswordChar = false;
			this.txtStudentName.Enter += new System.EventHandler(this.txtStudentName_Enter);
			this.txtStudentName.Leave += new System.EventHandler(this.txtStudentName_Leave);
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
			// nudClass
			// 
			this.nudClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.nudClass.Location = new System.Drawing.Point(510, 125);
			this.nudClass.Name = "nudClass";
			this.nudClass.Size = new System.Drawing.Size(60, 20);
			this.nudClass.TabIndex = 15;
			// 
			// dgvStudent
			// 
			this.dgvStudent.AutoGenerateColumns = false;
			this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.pointDataGridViewTextBoxColumn});
			this.dgvStudent.DataSource = this.studentsBindingSource;
			this.dgvStudent.Location = new System.Drawing.Point(14, 198);
			this.dgvStudent.Name = "dgvStudent";
			this.dgvStudent.Size = new System.Drawing.Size(776, 310);
			this.dgvStudent.TabIndex = 19;
			this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
			// 
			// studentIdDataGridViewTextBoxColumn
			// 
			this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "studentId";
			this.studentIdDataGridViewTextBoxColumn.HeaderText = "studentId";
			this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
			this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
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
			// birthdateDataGridViewTextBoxColumn
			// 
			this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate";
			this.birthdateDataGridViewTextBoxColumn.HeaderText = "birthdate";
			this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
			// 
			// genderDataGridViewTextBoxColumn
			// 
			this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
			this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
			this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
			// 
			// classDataGridViewTextBoxColumn
			// 
			this.classDataGridViewTextBoxColumn.DataPropertyName = "class";
			this.classDataGridViewTextBoxColumn.HeaderText = "class";
			this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
			// 
			// pointDataGridViewTextBoxColumn
			// 
			this.pointDataGridViewTextBoxColumn.DataPropertyName = "point";
			this.pointDataGridViewTextBoxColumn.HeaderText = "point";
			this.pointDataGridViewTextBoxColumn.Name = "pointDataGridViewTextBoxColumn";
			// 
			// studentsBindingSource
			// 
			this.studentsBindingSource.DataMember = "students";
			this.studentsBindingSource.DataSource = this.studentDataSet;
			// 
			// studentDataSet
			// 
			this.studentDataSet.DataSetName = "StudentDataSet";
			this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// nudPoint
			// 
			this.nudPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.nudPoint.Location = new System.Drawing.Point(510, 157);
			this.nudPoint.Name = "nudPoint";
			this.nudPoint.Size = new System.Drawing.Size(60, 20);
			this.nudPoint.TabIndex = 15;
			// 
			// lollipopLabel6
			// 
			this.lollipopLabel6.AutoSize = true;
			this.lollipopLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.lollipopLabel6.Location = new System.Drawing.Point(419, 157);
			this.lollipopLabel6.Name = "lollipopLabel6";
			this.lollipopLabel6.Size = new System.Drawing.Size(63, 24);
			this.lollipopLabel6.TabIndex = 25;
			this.lollipopLabel6.Text = "Point:";
			// 
			// rbMale
			// 
			this.rbMale.AutoSize = true;
			this.rbMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.rbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.rbMale.Location = new System.Drawing.Point(203, 163);
			this.rbMale.Name = "rbMale";
			this.rbMale.Size = new System.Drawing.Size(48, 17);
			this.rbMale.TabIndex = 26;
			this.rbMale.TabStop = true;
			this.rbMale.Text = "Male";
			this.rbMale.UseVisualStyleBackColor = false;
			// 
			// rbFemale
			// 
			this.rbFemale.AutoSize = true;
			this.rbFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.rbFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.rbFemale.Location = new System.Drawing.Point(281, 163);
			this.rbFemale.Name = "rbFemale";
			this.rbFemale.Size = new System.Drawing.Size(59, 17);
			this.rbFemale.TabIndex = 26;
			this.rbFemale.TabStop = true;
			this.rbFemale.Text = "Female";
			this.rbFemale.UseVisualStyleBackColor = false;
			// 
			// txtStudentSurname
			// 
			this.txtStudentSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.txtStudentSurname.FocusedColor = "#508ef5";
			this.txtStudentSurname.FontColor = "#999999";
			this.txtStudentSurname.IsEnabled = true;
			this.txtStudentSurname.Location = new System.Drawing.Point(203, 93);
			this.txtStudentSurname.MaxLength = 32767;
			this.txtStudentSurname.Multiline = false;
			this.txtStudentSurname.Name = "txtStudentSurname";
			this.txtStudentSurname.ReadOnly = false;
			this.txtStudentSurname.Size = new System.Drawing.Size(200, 24);
			this.txtStudentSurname.TabIndex = 11;
			this.txtStudentSurname.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtStudentSurname.UseSystemPasswordChar = false;
			this.txtStudentSurname.Enter += new System.EventHandler(this.txtStudentSurname_Enter);
			this.txtStudentSurname.Leave += new System.EventHandler(this.txtStudentSurname_Leave);
			// 
			// dtpBirthdate
			// 
			this.dtpBirthdate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.dtpBirthdate.Location = new System.Drawing.Point(203, 124);
			this.dtpBirthdate.Name = "dtpBirthdate";
			this.dtpBirthdate.Size = new System.Drawing.Size(200, 20);
			this.dtpBirthdate.TabIndex = 27;
			// 
			// studentsTableAdapter
			// 
			this.studentsTableAdapter.ClearBeforeFill = true;
			// 
			// lollipopLabel7
			// 
			this.lollipopLabel7.AutoSize = true;
			this.lollipopLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
			this.lollipopLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lollipopLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.lollipopLabel7.Location = new System.Drawing.Point(576, 125);
			this.lollipopLabel7.Name = "lollipopLabel7";
			this.lollipopLabel7.Size = new System.Drawing.Size(68, 24);
			this.lollipopLabel7.TabIndex = 25;
			this.lollipopLabel7.Text = "Letter:";
			// 
			// cmbLetter
			// 
			this.cmbLetter.FormattingEnabled = true;
			this.cmbLetter.Location = new System.Drawing.Point(657, 127);
			this.cmbLetter.Name = "cmbLetter";
			this.cmbLetter.Size = new System.Drawing.Size(121, 21);
			this.cmbLetter.TabIndex = 28;
			// 
			// addStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(800, 520);
			this.Controls.Add(this.cmbLetter);
			this.Controls.Add(this.dtpBirthdate);
			this.Controls.Add(this.rbFemale);
			this.Controls.Add(this.rbMale);
			this.Controls.Add(this.lollipopLabel4);
			this.Controls.Add(this.lollipopLabel6);
			this.Controls.Add(this.lollipopLabel7);
			this.Controls.Add(this.lollipopLabel5);
			this.Controls.Add(this.lollipopLabel3);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lollipopLabel2);
			this.Controls.Add(this.lollipopLabel1);
			this.Controls.Add(this.nudPoint);
			this.Controls.Add(this.txtStudentSurname);
			this.Controls.Add(this.txtStudentName);
			this.Controls.Add(this.nudClass);
			this.Controls.Add(this.dgvStudent);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(800, 520);
			this.Name = "addStudent";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "addStudent";
			this.Load += new System.EventHandler(this.addStudent_Load);
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.books)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudClass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPoint)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Data.Datasets.BooksDataSetTableAdapters.booksTableAdapter booksTableAdapter1;
        private LollipopLabel lollipopLabel4;
        private LollipopLabel lollipopLabel5;
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
        private LollipopTextBox txtStudentName;
        private Data.Datasets.libraryDataSet1 libraryDataSet1;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private Data.Datasets.BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private System.Windows.Forms.NumericUpDown nudClass;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.NumericUpDown nudPoint;
        private LollipopLabel lollipopLabel6;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private LollipopTextBox txtStudentSurname;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
		private Data.Datasets.StudentDataSet studentDataSet;
		private System.Windows.Forms.BindingSource studentsBindingSource;
		private Data.Datasets.StudentDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pointDataGridViewTextBoxColumn;
		private LollipopLabel lollipopLabel7;
		private System.Windows.Forms.ComboBox cmbLetter;
	}
}