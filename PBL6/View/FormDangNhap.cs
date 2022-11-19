using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL6.View
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.ToString();
            string pass = txtPass.Text.ToString();
            if (BLL.BLL.Instance.CheckAccount(name, pass))
            {
                Form5 f = new Form5(name);
                f.ShowDialog();

            }
            else
            {
                MessageBox.Show("Tên tài khoản và mật khẩu không đúng");
            }
        }
    }
}
