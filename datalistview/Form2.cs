using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datalistview
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtMSNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndongy_Click(object sender, EventArgs e)
        
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
        
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLuongCB_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
