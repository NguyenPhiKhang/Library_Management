using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLTV_GUI
{
    public partial class frmThemSach : DevExpress.XtraEditors.XtraForm
    {
        public frmThemSach()
        {
            InitializeComponent();
        }

        private void txbTriGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng chữ
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemSach_Load(object sender, EventArgs e)
        {
            var a = QLTV_BUS.TACGIABUS.Instance.GetTacGia();
            lkedit_TacGia.Properties.DataSource = a;
            lkedit_TacGia.Properties.ValueMember = "MaTacGia";
            lkedit_TacGia.Properties.DisplayMember = "TenTacGia";
            var b = QLTV_BUS.THELOAIBUS.Instance.GetTheLoai();
            lkedit_TheLoai.Properties.DataSource = b;
            lkedit_TheLoai.Properties.ValueMember = "MaTheLoai";
            lkedit_TheLoai.Properties.DisplayMember = "TenTheLoai";
            var c = QLTV_BUS.TINHTRANGBUS.Instance.GetTinhTrang();
            lkedit_TinhTrang.Properties.DataSource = c;
            lkedit_TinhTrang.Properties.ValueMember = "MaTinhTrang";
            lkedit_TinhTrang.Properties.DisplayMember = "TenTinhTrang";

            dateNgayNhap.EditValue = DateTime.Now;

        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thêm thông tin độc giả?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                QLTV_BUS.SACHBUS.Instance.AddInfoSach(txb_MaSach.Text, txb_TenSach.Text, lkedit_TheLoai.EditValue.ToString(), (int)Convert.ToUInt32(dateNamXuatBan.EditValue.ToString()), txb_NhaXuatBan.Text, lkedit_TacGia.EditValue.ToString(), (DateTime)dateNgayNhap.EditValue, (int)Convert.ToUInt32(txb_TriGia.EditValue), lkedit_TinhTrang.EditValue.ToString());
                this.Close();
            }
           

        }

        private void btn_Huy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textEdit9_Properties_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }
        }
    }
}