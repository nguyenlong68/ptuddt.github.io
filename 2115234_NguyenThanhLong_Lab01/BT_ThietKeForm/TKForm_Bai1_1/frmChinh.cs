﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKForm_Bai1_1
{
	public partial class frmChinh : Form
	{
		public frmChinh()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void tsmiBai1_Click(object sender, EventArgs e)
		{
			var form =  new frmBai1();
			form.ShowDialog();
		}

		private void tsmiBai2_Click(object sender, EventArgs e)
		{
			var form = new frmBai2();
			form.ShowDialog();
		}

		private void tsmiBai3_Click(object sender, EventArgs e)
		{
			var form = new frmBai3();
			form.ShowDialog();
		}

		private void tsmiBai4_Click(object sender, EventArgs e)
		{
			var form = new frmBai4();
			form.ShowDialog();
		}
	}
}
