using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiKtr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhtoan_Click(object sender, EventArgs e)
        {
            double x1,x2;
            double delta;
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(txtC.Text);
            delta = (b * b) - (4 * a * c);
            if(a<=0)
            {
                txtKQ.Text = "Phương trình vô nghiệm";
            }
            if(a>0)
            {
                if(delta<0)
                {
                    txtKQ.Text = "Phương trình vô nghiệm";
                }

                if(delta==0)
                {
                    x1 = x2 = (-b) / (2 * a);
                    txtKQ.Text = "Phương trình có nghiệm kép: "+"x1=x2= "+x1;
                }

                if(delta>0)
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2= (-b - Math.Sqrt(delta)) / (2 * a);
                    txtKQ.Text = "Phương trình có 2 nghiệm: " + "x1= " + x1 + ", " + "x2= " + x2;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn muốn thoát form", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if(a==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập số");
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập số");
            }
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập số");
            }
        }

        private void txtC_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnTinhtoan.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnThoat.PerformClick();
            }
        }
    }
}
