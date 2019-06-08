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
        List<string> listUsername = new List<string>();
        List<string> listemail = new List<string>();
        string IdLast;
        public frmThemDocGia()
        {
            InitializeComponent();
        }
        #endregion
        #region Event_Load
        private void frmThemDocGia_Load(object sender, EventArgs e)
        {
            dateNgayLapThe.EditValue = DateTime.Now;
            dateNgayHetHan.EditValue = ((DateTime)dateNgayLapThe.EditValue).AddMonths(THAMSOBUS.Instance.GetDSQuiDinh()[0].ThoiHanThe);
            Load_LoaiDG();
            ListEmail();
            ListUser();
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
            if (XtraMessageBox.Show("Bạn có muốn thêm thông tin độc giả?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                USERBUS.Instance.AddInfoUser(txbUsername.Text, txbPassword.Text);
                DOCGIABUS.Instance.AddInfoDocGia(
                    txbMaDocGia.Text, txbHoTen.Text, (DateTime)dateNgaySinh.EditValue, txbEmail.Text, txbDiaChi.Text, luedLoaiDocGia.EditValue.ToString(),
                    (DateTime)dateNgayLapThe.EditValue, (DateTime)dateNgayHetHan.EditValue, txbUsername.Text);
                this.Close();
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
            return listemail;
        }
        List<string> ListUser()
        {
            foreach (var item in listinfoDG)
            {
                listUsername.Add(item.IDUser);
            }
            return listUsername;
        }
        #endregion
        #region Event_Changed
        private void dateNgaySinh_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1,dateNgaySinh, HelpGUI.KiemTraDieuKien.Check_Tuoi(dateNgaySinh.EditValue), "Ngày sinh không hợp lệ!");
        }

        private void txbHoTen_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbHoTen, HelpGUI.KiemTraDieuKien.isTen(txbHoTen.Text), "Tên không hợp lệ!");
        }
        private void txbEmail_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbEmail, HelpGUI.KiemTraDieuKien.isEmail(txbEmail.Text), "Email không hợp lệ!", HelpGUI.KiemTraDieuKien.Check_Trung(listemail, txbEmail.Text), "Email bị trùng!");
        }

        private void txbDiaChi_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbDiaChi, HelpGUI.KiemTraDieuKien.isDiaChi(txbDiaChi.Text), "Địa chỉ không hợp lệ!");
        }
        private void txbUsername_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbUsername, HelpGUI.KiemTraDieuKien.isUsername(txbUsername.Text), "Username không hợp lệ!", HelpGUI.KiemTraDieuKien.Check_Trung(listUsername, txbUsername.Text), "Username bị trùng!");
        }

        private void txbPassword_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbPassword, HelpGUI.KiemTraDieuKien.isPassword(txbPassword.Text), "Password không hợp lệ!");
        }
        #endregion
    }
}