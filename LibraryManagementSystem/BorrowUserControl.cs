using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class BorrowUserControl : UserControl
	{
		public BorrowUserControl()
		{
			InitializeComponent();
		}

		private static BorrowUserControl _instance;

		public BorrowUserControl Instance
		{
			get
			{
				if (_instance == null)
					_instance = new BorrowUserControl();
				return _instance;
			}
		}
	}
}
