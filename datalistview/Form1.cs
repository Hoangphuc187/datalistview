using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace datalistview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

          
            if (form2.ShowDialog() == DialogResult.OK)
            {
                
                string maSoNV = form2.Controls["txtMSNV"].Text;
                string tenNV = form2.Controls["txtTenNV"].Text;
                string luongCB = form2.Controls["txtLuongCB"].Text;          
                ListViewItem item = new ListViewItem(maSoNV);
                item.SubItems.Add(tenNV);
                item.SubItems.Add(luongCB);
                listView.Items.Add(item);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn mục cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            ListViewItem s = listView.SelectedItems[0];

         
            Form2 form2 = new Form2();
            form2.Controls["txtMSNV"].Text = s.SubItems[0].Text; 
            form2.Controls["txtTenNV"].Text = s.SubItems[1].Text; 
            form2.Controls["txtLuongCB"].Text = s.SubItems[2].Text; 

            if (form2.ShowDialog() == DialogResult.OK)
            {
             
                s.SubItems[0].Text = form2.Controls["txtMSNV"].Text;
                s.SubItems[1].Text = form2.Controls["txtTenNV"].Text;
                s.SubItems[2].Text = form2.Controls["txtLuongCB"].Text;
            }

        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn mục cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
              
                foreach (ListViewItem item in listView.SelectedItems)
                {
                    listView.Items.Remove(item);
                }
            }
        }

        private void btndung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
