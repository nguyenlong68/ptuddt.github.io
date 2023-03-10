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
	public partial class frmBai2 : Form
	{
		public frmBai2()
		{
			InitializeComponent();
		}

		private void btnChonHang_Click(object sender, EventArgs e)
		{
			var item = listBox1.SelectedItem;
			listBox2.Items.Add(item);
		}

		private void btnBoHang_Click(object sender, EventArgs e)
		{
			listBox2.Items.Remove(listBox2.SelectedItem);
		}

		private void bntTinhTien_Click(object sender, EventArgs e)
		{
			int soTien = 0;

            //Duyệt danh sách  các mặt hàng đã mua nằm trong listbox2
            //Cộng dồn số tiền cần thanh toán

            foreach (string hang in listBox2.Items)
            {
                switch (hang)
				{
					case "Chuột":
						soTien += 100000;
						break;
					case "Bàn phím":
						soTien += 150000;
						break;
					case "Máy in":
						soTien += 2000000;
						break;
					case "USB Kingmax":
						soTien += 200000;
						break;
					//Lưu ý tên hằng phải viết giống tên đã gõ trong listbox1
				}
				lblSoTien.Text = soTien + " đồng";
            }
        }
	}
}
