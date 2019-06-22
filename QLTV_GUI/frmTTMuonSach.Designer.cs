namespace QLTV_GUI
{
    partial class frmTTMuonSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.TimKiem = new DevExpress.XtraBars.BarSubItem();
            this.ck_TatCa = new DevExpress.XtraBars.BarCheckItem();
            this.ck_MaPhieuMuon = new DevExpress.XtraBars.BarCheckItem();
            this.ck_MaDocGia = new DevExpress.XtraBars.BarCheckItem();
            this.ck_TenDocGia = new DevExpress.XtraBars.BarCheckItem();
            this.ck_MaSach = new DevExpress.XtraBars.BarCheckItem();
            this.ck_TenSach = new DevExpress.XtraBars.BarCheckItem();
            this.ck_NgayMuon = new DevExpress.XtraBars.BarCheckItem();
            this.ck_HanTra = new DevExpress.XtraBars.BarCheckItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnLuuLai,
            this.btnLamMoi,
            this.TimKiem,
            this.ck_TatCa,
            this.ck_MaPhieuMuon,
            this.ck_MaDocGia,
            this.ck_TenDocGia,
            this.ck_MaSach,
            this.ck_TenSach,
            this.ck_NgayMuon,
            this.ck_HanTra});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 12;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuLai, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.TimKiem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::QLTV_GUI.Properties.Resources.add_icon;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.Caption = "Lưu Lại";
            this.btnLuuLai.Id = 1;
            this.btnLuuLai.ImageOptions.Image = global::QLTV_GUI.Properties.Resources.save_icon__1_;
            this.btnLuuLai.Name = "btnLuuLai";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm Mới";
            this.btnLamMoi.Id = 2;
            this.btnLamMoi.ImageOptions.Image = global::QLTV_GUI.Properties.Resources.refresh;
            this.btnLamMoi.Name = "btnLamMoi";
            // 
            // TimKiem
            // 
            this.TimKiem.Caption = "Tìm Kiếm";
            this.TimKiem.Id = 3;
            this.TimKiem.ImageOptions.Image = global::QLTV_GUI.Properties.Resources.Search_icon;
            this.TimKiem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ck_TatCa),
            new DevExpress.XtraBars.LinkPersistInfo(this.ck_MaPhieuMuon),
            new DevExpress.XtraBars.LinkPersistInfo(this.ck_MaDocGia),
            new DevExpress.XtraBars.LinkPersistInfo(this.ck_TenDocGia),
            new DevExpress.XtraBars.LinkPersistInfo(this.ck_MaSach),
            new DevExpress.XtraBars.LinkPersistInfo(this.ck_TenSach),
            new DevExpress.XtraBars.LinkPersistInfo(this.ck_NgayMuon),
            new DevExpress.XtraBars.LinkPersistInfo(this.ck_HanTra)});
            this.TimKiem.Name = "TimKiem";
            // 
            // ck_TatCa
            // 
            this.ck_TatCa.Caption = "Tất Cả";
            this.ck_TatCa.Id = 4;
            this.ck_TatCa.Name = "ck_TatCa";
            // 
            // ck_MaPhieuMuon
            // 
            this.ck_MaPhieuMuon.Caption = "Mã Phiếu Mượn";
            this.ck_MaPhieuMuon.Id = 5;
            this.ck_MaPhieuMuon.Name = "ck_MaPhieuMuon";
            // 
            // ck_MaDocGia
            // 
            this.ck_MaDocGia.Caption = "Mã Độc Giả";
            this.ck_MaDocGia.Id = 6;
            this.ck_MaDocGia.Name = "ck_MaDocGia";
            // 
            // ck_TenDocGia
            // 
            this.ck_TenDocGia.Caption = "Tên Độc Giả";
            this.ck_TenDocGia.Id = 7;
            this.ck_TenDocGia.Name = "ck_TenDocGia";
            // 
            // ck_MaSach
            // 
            this.ck_MaSach.Caption = "Mã Sách";
            this.ck_MaSach.Id = 8;
            this.ck_MaSach.Name = "ck_MaSach";
            // 
            // ck_TenSach
            // 
            this.ck_TenSach.Caption = "Tên Sách";
            this.ck_TenSach.Id = 9;
            this.ck_TenSach.Name = "ck_TenSach";
            // 
            // ck_NgayMuon
            // 
            this.ck_NgayMuon.Caption = "Ngày Mượn";
            this.ck_NgayMuon.Id = 10;
            this.ck_NgayMuon.Name = "ck_NgayMuon";
            // 
            // ck_HanTra
            // 
            this.ck_HanTra.Caption = "Hạn Trả";
            this.ck_HanTra.Id = 11;
            this.ck_HanTra.Name = "ck_HanTra";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(836, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 442);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(836, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 402);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(836, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 402);
            // 
            // frmTTMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 442);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTTMuonSach";
            this.Text = "Thông Tin Mượn Sách";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnLuuLai;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarSubItem TimKiem;
        private DevExpress.XtraBars.BarCheckItem ck_TatCa;
        private DevExpress.XtraBars.BarCheckItem ck_MaPhieuMuon;
        private DevExpress.XtraBars.BarCheckItem ck_MaDocGia;
        private DevExpress.XtraBars.BarCheckItem ck_TenDocGia;
        private DevExpress.XtraBars.BarCheckItem ck_MaSach;
        private DevExpress.XtraBars.BarCheckItem ck_TenSach;
        private DevExpress.XtraBars.BarCheckItem ck_NgayMuon;
        private DevExpress.XtraBars.BarCheckItem ck_HanTra;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}