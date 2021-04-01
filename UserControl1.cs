using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormDN;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("thong bao", "khong dc de ten tk");
                this.textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("thong bao", "khong dc de ten tk");
                this.textBox1.Focus();
                return;
            }

            int kq = CauHinh.check();
            if (kq == 0)
            {
                config();
                //dang nhap thanh cong
            }
            if (kq == 1)
            {
                // cau hinh trong
            }
            if (kq == 2)
            {
                //CauHinh hinh sai
            }
        }

        private void config()
        {
            int ressut;
            ressut = CauHinh.config(textBox1.Text, textBox2.Text);
            if (ressut == 10)
            {
                // khong co tai khoan
                return;
            }
            else if (ressut == 20)
            {
                //tai khoan bi khoa
                return;

            }
            else
            {
                FrmMain frm = new FrmMain();
                frm.Show();
            }   
            
           

        }
    }
}
