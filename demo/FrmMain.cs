using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            FrmHangHoa hh = new FrmHangHoa();
            hh.ShowDialog();
        }

        private void pbKho_Click(object sender, EventArgs e)
        {
            FrmKho k = new FrmKho();
            k.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmPhieuNhap nhap = new FrmPhieuNhap();
            nhap.ShowDialog();
        }
    }
}
