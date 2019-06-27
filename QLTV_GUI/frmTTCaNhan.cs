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
using System.Threading;
using QLTV_DTO;
using QLTV_BUS;
using DevExpress.DataProcessing;

namespace QLTV_GUI
{
    public partial class frmTTCaNhan : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        public frmTTCaNhan()
        {
            InitializeComponent();
        }
        public frmTTCaNhan(string idAccount) : this()
        {
            IdAccount = idAccount;
        }
        DOCGIA dg = new DOCGIA();
        string IdAccount = "";
        List<TTDOCGIADTO> listdg = new List<TTDOCGIADTO>();
        List<ADMIN> listad = new List<ADMIN>();
        List<CHITIETPHIEUMUONDTO> listpm = new List<CHITIETPHIEUMUONDTO>();
        List<string> listemail = new List<string>();
        string email = "";
        #endregion
        #region Methods
        void ListEmail()
        {
            listemail.Clear();
            foreach (var item in listdg)
            {
                listemail.Add(item.Email);
            }
            foreach (var item in listad)
            {
                listemail.Add(item.Email);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Visible = false;
            lked_LDG.ReadOnly = false;
            Thread.Sleep(100);
            btnHuy.Visible = true;
            btnLuu.Visible = true;
            txbMail.ReadOnly = false;
            dateNgaySinh.ReadOnly = false;
            lked_LDG.Properties.DataSource = LOAIDOCGIABUS.Instance.GetLoaiDocGia().ToList();
            rtxb_gioithieu.BackColor = Color.FromArgb(245, 245, 247);
            rtxb_gioithieu.ReadOnly = false;
            btndoimk.Visible = true;
        }
        void ReadOnly_TT()
        {
            btnHuy.Visible = false;
            btnLuu.Visible = false;
            lked_LDG.ReadOnly = true;
            Thread.Sleep(100);
            btnSua.Visible = true;
            txbMail.ReadOnly = true;
            dateNgaySinh.ReadOnly = true;
            rtxb_gioithieu.BackColor = Color.FromArgb(224, 224, 224);
            rtxb_gioithieu.ReadOnly = true;
            btndoimk.Visible = false;
        }
        void format_TT()
        {
            dg = DOCGIABUS.Instance.GetInfoDocGia(IdAccount).ToList()[0];
            txbID.Text = dg.MaDocGia;
            dateNgaySinh.Text = dg.NgaySinh.ToString();
            txbDiaChi.Text = dg.DiaChi;
            email = dg.Email;
            txbMail.Text = dg.Email;
            txbSdt.Text = dg.SDT;
            txbUser.Text = dg.IDAccount;
            txbPass.Text = ACCOUNTBUS.Instance.GetInfoAccount(IdAccount).ToList()[0].PasswordAccount;
            lked_LDG.Properties.DataSource = LOAIDOCGIABUS.Instance.GetLoaiDocGia(dg.MaLoaiDocGia).ToList();
            lked_LDG.EditValue = LOAIDOCGIABUS.Instance.GetLoaiDocGia(dg.MaLoaiDocGia).ToList()[0].MaLoaiDocGia;
            //lked_LDG.Properties.NullText = LOAIDOCGIABUS.Instance.GetLoaiDocGia(dg.MaLoaiDocGia).ToList()[0].TenLoaiDocGia;
            txbNgayLapThe.Text = dg.NgayLapThe.ToString();
            txbNgayHetHan.Text = dg.NgayHetHan.ToString();
            txbTongNo.Text = dg.TongNo.ToString();
            rtxb_gioithieu.Text = dg.GioiThieu;
            lb_name.Text = dg.HoTen.ToUpper();
        }
        void Load_Data()
        {
            listpm = CHITIETPHIEUMUONBUS.Instance.GetListPhieuMuon()
                .Where(x => x.MaDocGia == txbID.EditValue.ToString() && x.TinhTrangMuon.ToLower() != "đã trả").ToList();
            gridControl1.DataSource = listpm;
            lb_SoSachMuon.Text = (gridView1.RowCount > 0) ? gridView1.RowCount.ToString() : "0";
        }
        #endregion
        #region Event_Click
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!dxErrorProvider1.HasErrors)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu thông tin tài khoản không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DOCGIABUS.Instance.UpdateInfoDocGia(txbID.Text, HelpGUI.KiemTraDieuKien.ToFirstUpper(lb_name.Text), txbDiaChi.Text, Convert.ToDateTime(dateNgaySinh.EditValue), txbMail.Text, lked_LDG.EditValue.ToString(), Convert.ToDateTime(txbNgayHetHan.EditValue), txbSdt.Text, rtxb_gioithieu.Text);
                    ACCOUNTBUS.Instance.UpdateInfoAccount(txbUser.Text, txbPass.Text);
                    ReadOnly_TT();
                    format_TT();
                }
            }
            else XtraMessageBox.Show("Sửa thông tin không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ReadOnly_TT();
            format_TT();
        }
        private void btnShowpass_Click(object sender, EventArgs e)
        {
            if (txbPass.Properties.UseSystemPasswordChar == true)
            {
                btnShowpass.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/hide_16x16.png");
                btnShowpass.ToolTip = "Ẩn mật khẩu";
                txbPass.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                btnShowpass.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/show_16x16.png");
                btnShowpass.ToolTip = "Hiện mật khẩu";
                txbPass.Properties.UseSystemPasswordChar = true;
            }
        }
        private void btndoimk_Click(object sender, EventArgs e)
        {
            frmChangePassword cpass = new frmChangePassword(txbPass.Text);
            cpass.ShowDialog();
            txbPass.Text = cpass.PassWord;
        }
        #endregion
        #region Event_Load
        private void frmTTCaNhan_Load(object sender, EventArgs e)
        {
            listad = ADMINBUS.Instance.GetInfoAdmin().ToList();
            listdg = QLTV_BUS.TTDOCGIABUS.Instance.GetListDocGiaInfo();
            ListEmail();
            format_TT();
            Load_Data();
            if (Convert.ToInt32(lb_SoSachMuon.Text)==0)
            {
                gridControl1.Visible = false;
            }
        }
        #endregion
        #region Event_Changed
        private void dateNgaySinh_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, dateNgaySinh, HelpGUI.KiemTraDieuKien.Check_Tuoi(dateNgaySinh.EditValue)
                , $"Ngày sinh không hợp lệ!\n\rTuổi phải từ {THAMSOBUS.Instance.GetDSQuiDinh().ToList()[0].TuoiToiThieu} đến " +
                $"{THAMSOBUS.Instance.GetDSQuiDinh().ToList()[0].TuoiToiDa}");
        }

        private void txbMail_EditValueChanged(object sender, EventArgs e)
        {
            if (btnHuy.Visible == true&&txbMail.Text!=email)
            {
                HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbMail, HelpGUI.KiemTraDieuKien.isEmail(txbMail.EditValue.ToString()), "Email không hợp lệ!",
                    HelpGUI.KiemTraDieuKien.Check_Trung(listemail, txbMail.EditValue.ToString()), "Email này đã được sử dụng!");
            }
            else dxErrorProvider1.SetError(txbMail, null);
        }
        #endregion
    }
}