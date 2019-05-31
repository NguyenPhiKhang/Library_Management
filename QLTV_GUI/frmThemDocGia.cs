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
    public partial class frmThemDocGia : DevExpress.XtraEditors.XtraForm
    {
        public frmThemDocGia()
        {
            InitializeComponent();
        }
        private void frmThemDocGia_Load(object sender, EventArgs e)
        {
            txbUsername.DataBindings.Add("Text", txbMaDocGia, "Text");
            dateNgayLapThe.EditValue = DateTime.Now;
            dateNgayHetHan.EditValue = ((DateTime)dateNgayLapThe.EditValue).AddMonths(6);
            var a = LOAIDOCGIABUS.Instance.GetLoaiDocGia();
            luedLoaiDocGia.Properties.DataSource = a;
            luedLoaiDocGia.Properties.DisplayMember = "TenLoaiDocGia";
            luedLoaiDocGia.Properties.ValueMember = "MaLoaiDocGia";
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có muốn thêm thông tin độc giả?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
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

    }
}