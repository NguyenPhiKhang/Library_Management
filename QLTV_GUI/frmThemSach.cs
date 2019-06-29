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
using QLTV_BUS;

namespace QLTV_GUI
{
    public partial class frmThemSach : DevExpress.XtraEditors.XtraForm
    {
        string IdLast;
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
            try
            {
               IdLast= QLTV_BUS.SACHBUS.Instance.GetListSachInfo()[QLTV_BUS.SACHBUS.Instance.GetListSachInfo().Count - 1].MaSach;
            }
            catch
            {
                IdLast = "";
            }
            txb_MaSach.Text = HelpGUI.AutoIncreaseID.Load_AutoIncreaseID("S", IdLast, 6);
        }
        bool CheckNull ()
        {
            if (txb_TenSach.EditValue == null || txb_NhaXuatBan.EditValue == null || dateNamXuatBan.EditValue == null)
                return true;
            return false;
        }
        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            { MessageBox.Show("Thông Tin nhập vào không thể để trống.");}
            else
            {
                if (XtraMessageBox.Show("Bạn có muốn thêm thông tin độc giả?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    QLTV_BUS.SACHBUS.Instance.AddInfoSach(txb_MaSach.Text, txb_TenSach.Text, lkedit_TheLoai.EditValue.ToString(), (int)Convert.ToInt32(dateNamXuatBan.EditValue.ToString()), txb_NhaXuatBan.Text, lkedit_TacGia.EditValue.ToString(), (DateTime)dateNgayNhap.EditValue, (int)Convert.ToDecimal(txb_TriGia.EditValue), lkedit_TinhTrang.EditValue.ToString());
                    this.Close();
                }
            }
           

        }

        private void btn_Huy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            

            frmThemTacGia addtg = new frmThemTacGia();
            addtg.ShowDialog();
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
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmThemTheLoai addtl = new frmThemTheLoai();
            addtl.ShowDialog();
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
        }

        private void txb_TenSach_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txb_TenSach, HelpGUI.KiemTraDieuKien.isTenSach(txb_TenSach.Text.Trim()), "Tên sách không hợp lệ!");
        }

        private void txb_NhaXuatBan_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txb_NhaXuatBan, HelpGUI.KiemTraDieuKien.isDiaChi(txb_NhaXuatBan.Text.Trim()), "Tên Nhà Xuất Bản không hợp lệ!");
        }

        private void dateNamXuatBan_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider1.SetIconAlignment(dateNamXuatBan, ErrorIconAlignment.BottomRight);
                if (Convert.ToInt32(dateNamXuatBan.EditValue.ToString()) > DateTime.Now.Year)
                    dxErrorProvider1.SetError(dateNamXuatBan, "Năm Xuất Bản không hợp lệ !");
                else if (Convert.ToInt32(dateNamXuatBan.EditValue.ToString()) < DateTime.Now.Year - THAMSOBUS.Instance.GetDSQuiDinh()[0].KhoangCachXB)
                    dxErrorProvider1.SetError(dateNamXuatBan, "Sai Quy Định Chỉ nhận sách xuất bản trong vòng " + THAMSOBUS.Instance.GetDSQuiDinh()[0].KhoangCachXB + " năm.");
                else dxErrorProvider1.SetError(dateNamXuatBan, null);
        }
    }
}