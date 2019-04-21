﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
	public partial class UserUserControl1 : UserControl
	{
		private static UserUserControl1 _instance;
		public UserUserControl1 Instance
		{
			get
			{
				if (_instance == null)
					_instance = new UserUserControl1();
				return _instance;
			}
		}
		public UserUserControl1()
		{
			InitializeComponent();
		}

		private const string ConnectionString = @"Data Source=DESKTOP-VGI8J75\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
		SqlConnection connection = new SqlConnection(ConnectionString);
	}
}