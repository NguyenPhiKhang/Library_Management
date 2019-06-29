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
using DevExpress.XtraEditors.DXErrorProvider;
using System.Text.RegularExpressions;
using QLTV_DTO;

namespace QLTV_GUI
{
    public partial class frmThemDocGia : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        List<TTDOCGIADTO> listinfoDG = TTDOCGIABUS.Instance.GetListDocGiaInfo().ToList();
        List<ADMIN> listinfoAd = ADMINBUS.Instance.GetInfoAdmin().ToList();
        List<ACCOUNT> listAccount = new List<ACCOUNT>();
        List<string> listUsername = new List<string>();
        List<string> listemail = new List<string>();
        List<string> listsdt = new List<string>();
        string IdLast;
        int tuoimin;
        int tuoimax;
        public frmThemDocGia()
        {
            InitializeComponent();
        }
        #endregion
        #region Event_Load
        private /*async*/ void frmThemDocGia_Load(object sender, EventArgs e)
        {
            listAccount = /*await*/ ACCOUNTBUS.Instance.GetInfoAccount();
            dateNgayLapThe.EditValue = DateTime.Now;
            dateNgayHetHan.EditValue = ((DateTime)dateNgayLapThe.EditValue).AddMonths(THAMSOBUS.Instance.GetDSQuiDinh()[0].ThoiHanThe);
            Load_LoaiDG();
            ListEmail();
            ListUser();
            ListSDT();
            try
            {
                TTDOCGIADTO ttdg = TTDOCGIABUS.Instance.GetListDocGiaInfo()[TTDOCGIABUS.Instance.GetListDocGiaInfo().Count-1];
                IdLast = ttdg.MaDocGia;
            }
            catch { IdLast = ""; }
            txbMaDocGia.Text = HelpGUI.AutoIncreaseID.Load_AutoIncreaseID("DG",IdLast, 6);
        }
        void Load_LoaiDG()
        {
            var a = LOAIDOCGIABUS.Instance.GetLoaiDocGia();
            luedLoaiDocGia.Properties.DataSource = a;
            luedLoaiDocGia.Properties.DisplayMember = "TenLoaiDocGia";
            luedLoaiDocGia.Properties.ValueMember = "MaLoaiDocGia";
        }
        #endregion
        #region Event_Click
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (!dxErrorProvider1.HasErrors&&!CheckNull())
            {
                if (XtraMessageBox.Show("Bạn có muốn thêm thông tin độc giả?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ACCOUNTBUS.Instance.AddInfoAccount(txbUsername.Text, txbPassword.Text, "USER");
                    DOCGIABUS.Instance.AddInfoDocGia(
                        txbMaDocGia.Text, txbHoTen.Text, (DateTime)dateNgaySinh.EditValue, txbEmail.Text, txbDiaChi.Text, luedLoaiDocGia.EditValue.ToString(),
                        (DateTime)dateNgayLapThe.EditValue, (DateTime)dateNgayHetHan.EditValue, txbUsername.Text, txbSDT.Text);
                    CHITIETPHANQUYENBUS.Instance.AddCTPhanQuyen(txbUsername.Text, "IP001", true);
                    this.Close();
                }
            }
            else
            {
                XtraMessageBox.Show("Nhập thông tin không đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThemLDG_Click(object sender, EventArgs e)
        {
            frmThemLoaiDocGia addLDG = new frmThemLoaiDocGia();
            addLDG.ShowDialog();
            Load_LoaiDG();
        }
        #endregion
        #region Methods
        List<string> ListEmail()
        {
            foreach (var item in listinfoDG)
            {
                listemail.Add(item.Email);
            }
            foreach (var item in listinfoAd)
            {
                listemail.Add(item.Email);
            }
            return listemail;
        }
        List<string> ListUser()
        {
            foreach (var item in listAccount)
            {
                listUsername.Add(item.IDAccount);
            }
            return listUsername;
        }
        List<string> ListSDT()
        {
            foreach (var item in listinfoDG)
            {
                listsdt.Add(item.SDT);
            }
            foreach (var item in listinfoAd)
            {
                listsdt.Add(item.NumberPhone);
            }
            return listsdt;
        }
        bool CheckNull()
        {
            if (txbHoTen.EditValue==null||dateNgaySinh.EditValue==null||txbEmail.EditValue==null||txbDiaChi.EditValue==null||luedLoaiDocGia.EditValue==null
                ||txbUsername.EditValue==null||txbPassword.EditValue==null||txbSDT.EditValue ==null)
                return true;
            return false;
        }
        #endregion
        #region Event_Changed
        private void dateNgaySinh_EditValueChanged(object sender, EventArgs e)
        {
            tuoimin = THAMSOBUS.Instance.GetDSQuiDinh()[0].TuoiToiThieu;
            tuoimax = THAMSOBUS.Instance.GetDSQuiDinh()[0].TuoiToiDa;
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1,dateNgaySinh, HelpGUI.KiemTraDieuKien.Check_Tuoi(dateNgaySinh.EditValue), $"Ngày sinh không hợp lệ!\r\nTuổi phải từ {tuoimin} đến {tuoimax}");
        }

        private void txbHoTen_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbHoTen, HelpGUI.KiemTraDieuKien.isTen(txbHoTen.Text.Trim()), "Tên không hợp lệ!");
        }
        private void txbEmail_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbEmail, HelpGUI.KiemTraDieuKien.isEmail(txbEmail.Text.Trim()), "Email không hợp lệ!", HelpGUI.KiemTraDieuKien.Check_Trung(listemail, txbEmail.Text), "Email này đã được sử dụng!");
        }

        private void txbDiaChi_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbDiaChi, HelpGUI.KiemTraDieuKien.isDiaChi(txbDiaChi.Text.Trim()), "Địa chỉ không hợp lệ!");
        }
        private void txbUsername_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbUsername, HelpGUI.KiemTraDieuKien.isUsername(txbUsername.Text.Trim()), "Username không hợp lệ!", HelpGUI.KiemTraDieuKien.Check_Trung(listUsername, txbUsername.Text), "Username này đã được sử dụng!");
        }

        private void txbPassword_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbPassword, HelpGUI.KiemTraDieuKien.isPassword(txbPassword.Text.Trim()), "Password không hợp lệ!\r\nPhải có 8 ký tự trở lên");
        }
        private void txbSDT_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbSDT, HelpGUI.KiemTraDieuKien.isNumPhone(txbSDT.Text.Trim()), "Số điện thoại không hợp lệ!\r\nPhải có 9 đến 11 số", HelpGUI.KiemTraDieuKien.Check_Trung(listsdt, txbSDT.Text), "Số điện thoại này đã được sử dụng!");
        }
        #endregion
        #region Event_KeyPress
        private void txbSDT_Properties_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelpGUI.KiemTraDieuKien.NhapSo(e);
        }
        #endregion
    }
}