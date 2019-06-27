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
    public partial class frmThemTheLoai : DevExpress.XtraEditors.XtraForm
    {
        string IdLast;
        List<THELOAI> listinfoTG = THELOAIBUS.Instance.GetListTheLoai().ToList();
        public frmThemTheLoai()
        {
            InitializeComponent();
        }

        bool CheckNull()
        {
            if (txbTenTheLoai.EditValue == null)
                return true;
            return false;
        }

        //private void btnNhap_Click(object sender, EventArgs e)
        //{
        //    if (!dxErrorProvider1.HasErrors && !CheckNull())
        //    {
        //        if (XtraMessageBox.Show("Bạn có muốn thêm thể loại sách?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
        //        {
        //            THELOAIBUS.Instance.AddInfoTheloai(txbMaTheLoai.Text, txbTenTheLoai.Text);
        //            this.Close();
        //        }
        //    }
        //    else { XtraMessageBox.Show("Nhập thông tin bị lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        //}

        //private void btnHuy_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void frmThemTheLoai_Load(object sender, EventArgs e)
        {
            //txbMaTheLoai.DataBindings.Add("Text", txbMaTheLoai, "Text");
            //txbTenTheLoai.DataBindings.Add("Text", txbTenTheLoai, "Text");
            try
            {
                THELOAI ttl = THELOAIBUS.Instance.GetListTheLoai()[THELOAIBUS.Instance.GetListTheLoai().Count - 1];
                IdLast = ttl.MaTheLoai;
            }
            catch { IdLast = ""; }
            txbMaTheLoai.Text = HelpGUI.AutoIncreaseID.Load_AutoIncreaseID("TL", IdLast, 6);
            

        }

        private void txbTenTheLoai_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbTenTheLoai, HelpGUI.KiemTraDieuKien.isTen(txbTenTheLoai.Text.Trim()), "Không hợp lệ!");
        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            if (!dxErrorProvider1.HasErrors && !CheckNull())
            {
                if (XtraMessageBox.Show("Bạn có muốn thêm thể loại sách?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    THELOAIBUS.Instance.AddInfoTheloai(txbMaTheLoai.Text, txbTenTheLoai.Text);
                    this.Close();
                }
            }
            else { XtraMessageBox.Show("Nhập thông tin bị lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbMaTheLoai_EditValueChanged(object sender, EventArgs e)
        {
            
            //HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1,txbMaTheLoai,HelpGUI.KiemTraDieuKien.isUsername(txbTenTheLoai),)
        }
    }
}