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
    public partial class Frm_DSBN : Form
    {
        public Frm_DSBN()
        {
            InitializeComponent();
        }
        BLL_HeThong bd =new BLL_HeThong();
        string err = string.Empty;
        DataTable dt=new DataTable();
        private void Frm_DSBN_Load(object sender, EventArgs e)
        {
            HienThiDanhSachBenhNhan();
            lblSoLuong.Text = Convert.ToString(dgvBenhNhan.RowCount);
        }
        private void HienThiDanhSachBenhNhan()
        {

            dt = bd.LayDanhSachBenhNhan(ref err);
            dgvBenhNhan.DataSource = dt;
               
        }

        private void btnDuongTinh_Click(object sender, EventArgs e)
        {
            dt = bd.LayDanhSachBenhNhanDuongTinh(ref err);
            dgvBenhNhan.DataSource = dt;
            lblSoLuong.Text = Convert.ToString(dgvBenhNhan.RowCount);
        }

        private void btnAmTinh_Click(object sender, EventArgs e)
        {
            dt = bd.LayDanhSachBenhNhanAmTinh(ref err);
            dgvBenhNhan.DataSource = dt;
            lblSoLuong.Text = Convert.ToString(dgvBenhNhan.RowCount);
        }

        private void btnTuVong_Click(object sender, EventArgs e)
        {
            dt = bd.LayDanhSachBenhNhanTuVong(ref err);
            dgvBenhNhan.DataSource = dt;
            lblSoLuong.Text = Convert.ToString(dgvBenhNhan.RowCount);
        }
    }
}
