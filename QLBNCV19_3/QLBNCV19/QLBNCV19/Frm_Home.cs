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
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
        }

        BLL_HeThong bd = new BLL_HeThong();
        string err = string.Empty;
        DataTable dt = new DataTable();

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
        }

        private void dSBNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.Hide();
            Frm_DSBN frm_DSBN = new Frm_DSBN();
            //frm_DSBN.MdiParent = this;
            frm_DSBN.Show();
        }

        private void Frm_Home_Load(object sender, EventArgs e)
        {
            
        }
        private void HienThiHome(int tong)
        {
            dt = bd.LayTongBenhNhan(ref err,tong);
            lblTong.Text = Convert.ToString(tong);
        }
    }
}
