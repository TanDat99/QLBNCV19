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
    public partial class Frm_Admin : Form
    {
        public Frm_Admin()
        {
            InitializeComponent();
        }
        BLL_HeThong bd = new BLL_HeThong();
        string err = string.Empty;
        DataTable dt = new DataTable();
        public DTO_QLBN dTO_QLBN;
        int count = 0;
        public bool Them = false;

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Admin_Load(object sender, EventArgs e)
        {
            HienThiDanhSachBenhNhan();
            lblSoLuong.Text = Convert.ToString(dgvBenhNhan.RowCount);
        }
        private void HienThiDanhSachBenhNhan()
        {
            dt = bd.LayDanhSachBenhNhan(ref err);
            dgvBenhNhan.DataSource = dt;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                txtMaBN.Text = "";
                txtHvTBN.Focus();
            }
            else //sửa
            {
                //view thông tin cần sửa
                LayDuLieuVaoControl(dTO_QLBN);
            }

            if (!string.IsNullOrEmpty(txtHvTBN.Text))
            {
                LayDuLieuTuControl();
                if (bd.CapNhatBenhNhan(ref err, ref count, dTO_QLBN))
                {
                    HienThiDanhSachBenhNhan();
                    //this.Close();

                }
                else
                {
                    MessageBox.Show("Chưa thêm thành công");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập thành công");
                txtHvTBN.Focus();
            }
        }

        private void LayDuLieuVaoControl(DTO_QLBN dTO_QLBN)
        {
            dTO_QLBN = new DTO_QLBN();
            dTO_QLBN.MaBN = txtMaBN.Text;
            dTO_QLBN.HoVaTen = txtHvTBN.Text;
            dTO_QLBN.DiaChi = txtDiaChi.Text;
            dTO_QLBN.NgaySinh = dTP_NgaySinh.Value;
            dTO_QLBN.TinhTrang = txtTinhTrang.Text;
            dTO_QLBN.HoVaTenBS = txtHvTBS.Text;
            dTO_QLBN.MoTa = txtMoTa.Text;
        }

        private void dgvBenhNhan_Click(object sender, EventArgs e)
        {
            if(dgvBenhNhan.RowCount>0)
            {
                txtMaBN.Text = dgvBenhNhan.CurrentRow.Cells["colMaBN"].Value.ToString();
                txtHvTBN.Text = dgvBenhNhan.CurrentRow.Cells["colHoVaTen"].Value.ToString();
                txtDiaChi.Text = dgvBenhNhan.CurrentRow.Cells["colDiaChi"].Value.ToString();
                dTP_NgaySinh.Value =Convert.ToDateTime( dgvBenhNhan.CurrentRow.Cells["colNgaySinh"].Value.ToString());
                txtTinhTrang.Text= dgvBenhNhan.CurrentRow.Cells["colTinhTrang"].Value.ToString();
                txtHvTBS.Text = dgvBenhNhan.CurrentRow.Cells["colHoVaTenBS"].Value.ToString();
                txtMoTa.Text = dgvBenhNhan.CurrentRow.Cells["colMoTa"].Value.ToString();
            }

        }
        private void LayDuLieuTuControl()
        {
            dTO_QLBN = new DTO_QLBN();
            dTO_QLBN.MaBN = txtMaBN.Text;
            dTO_QLBN.HoVaTen = txtHvTBN.Text;
            dTO_QLBN.NgaySinh = dTP_NgaySinh.Value;
            dTO_QLBN.DiaChi = txtDiaChi.Text;
            dTO_QLBN.TinhTrang = txtTinhTrang.Text;
            dTO_QLBN.HoVaTenBS = txtHvTBS.Text;
            dTO_QLBN.MoTa = txtMoTa.Text;
        }

    }
}
