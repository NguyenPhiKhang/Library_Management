using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTV_GUI
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //Kiểm tra sự tồn tại của form con
        private Form KiemTraTonTai(Type fType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == fType) //Neu Form duoc truyen vao da duoc mo
                    return f;
            }
            return null;
        }
        private void btn_DangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }

        private void btnDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmDocGia));
            if (frm != null)
                frm.Activate();
            else
            {
                frmDocGia f = new frmDocGia
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnLoaiDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmLoaiDocGia));
            if (frm != null)
                frm.Activate();
            else
            {
                frmLoaiDocGia f = new frmLoaiDocGia
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmSach));
            if (frm != null)
                frm.Activate();
            else
            {
                frmSach f = new frmSach
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnTheLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTheLoai));
            if (frm != null)
                frm.Activate();
            else
            {
                frmTheLoai f = new frmTheLoai
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnTacGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTacGia));
            if (frm != null)
                frm.Activate();
            else
            {
                frmTacGia f = new frmTacGia
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnChiTietPM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChiTietPM ctpm = new frmChiTietPM();
            ctpm.ShowDialog();
        }

        private void btnMuonSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTTMuonSach));
            if (frm != null)
                frm.Activate();
            else
            {
                frmTTMuonSach f = new frmTTMuonSach
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnTraSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTTTraSach));
            if (frm != null)
                frm.Activate();
            else
            {
                frmTTTraSach f = new frmTTTraSach
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnBCSachTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmBCTKTraTre));
            if (frm != null)
                frm.Activate();
            else
            {
                frmBCTKTraTre f = new frmBCTKTraTre
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnBCSachMuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmBCTKSachMuonTL));
            if (frm != null)
                frm.Activate();
            else
            {
                frmBCTKSachMuonTL f = new frmBCTKSachMuonTL
                {
                    MdiParent = this
                };
                f.Show();
            }
        }

        private void btnTDQuyDinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmThayDoiQuiDinh));
            if (frm != null)
                frm.Activate();
            else
            {
                frmThayDoiQuiDinh f = new frmThayDoiQuiDinh
                {
                    MdiParent = this
                };
                f.Show();
            }
        }
    }
}
