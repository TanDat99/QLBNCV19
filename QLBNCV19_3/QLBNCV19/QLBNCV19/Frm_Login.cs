using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBNCV19
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        BLL_HeThong bd= new BLL_HeThong();
        DataTable dt;
        string err = string.Empty;

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(DangNhap(txtTaiKhoan.Text,txtMatKhau.Text)==true)
            {
                Frm_Admin frm_Admin = new Frm_Admin();
                frm_Admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu sai");
            }
        }
        private bool DangNhap(string taiKhoan, string matKhau)
        {
            bool result = false;
            dt = new DataTable();
            dt = bd.KiemTraDangNhap(ref err, taiKhoan, matKhau);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["code"].ToString().Equals("1"))
                    {
                        ClsMain.TenTaiKhoan = dt.Rows[0]["TaiKhoan"].ToString();              
                        ClsMain.MatKhau = dt.Rows[0]["MatKhau"].ToString();
                        result = true;
                    }
                }
                else
                {
                    MessageBox.Show("User name hay password không đúng");
                }
            }
            else
            {
                MessageBox.Show(err);
            }
            return result;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
