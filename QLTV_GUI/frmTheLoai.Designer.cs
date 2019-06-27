namespace QLTV_GUI
{
    partial class frmTheLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheLoai));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamLai = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.ck_TatCa = new DevExpress.XtraBars.BarCheckItem();
            this.ck_MaTheLoai = new DevExpress.XtraBars.BarCheckItem();
            this.ck_TenTheLoai = new DevExpress.XtraBars.BarCheckItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnLuuLai = new DevExpress.XtraBars.BarButtonItem();
            this.TimKiem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.txbTenTheLoai = new DevExpress.XtraEditors.TextEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txbMaTheLoai = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lo_btnLuu = new DevExpress.XtraLayout.LayoutControlItem();
            this.lo_btnHuy = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colMaTheLoai = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTenTheLoai = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenTheLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaTheLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lo_btnLuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lo_btnHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
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
            this.btnSua,
            this.btnLuuLai,
            this.btnLamLai,
            this.TimKiem,
            this.barSubItem1,
            this.ck_TatCa,
            this.ck_MaTheLoai,
            this.barButtonItem1,
            this.ck_TenTheLoai});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamLai, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Caption = "Làm Mới";
            this.btnLamLai.Id = 3;
            this.btnLamLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamLai.ImageOptions.Image")));
            this.btnLamLai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLamLai.ImageOptions.LargeImage")));
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamLai_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Tìm Kiếm";
            this.barSubItem1.Id = 5;
            this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            this.barSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.LargeImage")));
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ck_TatCa),
            new DevExpress.XtraBars.LinkPersistInfo(this.ck_MaTheLoai),
            new DevExpress.XtraBars.LinkPersistInfo(this.ck_TenTheLoai)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // ck_TatCa
            // 
            this.ck_TatCa.Caption = "Tất Cả";
            this.ck_TatCa.Id = 6;
            this.ck_TatCa.Name = "ck_TatCa";
            this.ck_TatCa.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.ck_TatCa_CheckedChanged);
            // 
            // ck_MaTheLoai
            // 
            this.ck_MaTheLoai.Caption = "Mã Thể Loại";
            this.ck_MaTheLoai.Id = 7;
            this.ck_MaTheLoai.Name = "ck_MaTheLoai";
            this.ck_MaTheLoai.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.ck_MaTheLoai_CheckedChanged);
            // 
            // ck_TenTheLoai
            // 
            this.ck_TenTheLoai.Caption = "Tên Thể Loại";
            this.ck_TenTheLoai.Id = 9;
            this.ck_TenTheLoai.Name = "ck_TenTheLoai";
            this.ck_TenTheLoai.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.ck_TenTheLoai_CheckedChanged);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(999, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 459);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(999, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 435);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(999, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 435);
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.Caption = "Lưu Lại";
            this.btnLuuLai.Id = 2;
            this.btnLuuLai.ImageOptions.Image = global::QLTV_GUI.Properties.Resources.save_icon__1_;
            this.btnLuuLai.Name = "btnLuuLai";
            // 
            // TimKiem
            // 
            this.TimKiem.Caption = "Tìm Kiếm";
            this.TimKiem.Id = 4;
            this.TimKiem.ImageOptions.Image = global::QLTV_GUI.Properties.Resources.search_icon__1_;
            this.TimKiem.Name = "TimKiem";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnHuy);
            this.layoutControl1.Controls.Add(this.txbTenTheLoai);
            this.layoutControl1.Controls.Add(this.btnLuu);
            this.layoutControl1.Controls.Add(this.txbMaTheLoai);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(0, 0, 1938, 1098);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(999, 90);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(906, 43);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(69, 22);
            this.btnHuy.StyleController = this.layoutControl1;
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txbTenTheLoai
            // 
            this.txbTenTheLoai.Location = new System.Drawing.Point(497, 43);
            this.txbTenTheLoai.MenuManager = this.barManager1;
            this.txbTenTheLoai.Name = "txbTenTheLoai";
            this.txbTenTheLoai.Properties.AllowFocused = false;
            this.txbTenTheLoai.Properties.ReadOnly = true;
            this.txbTenTheLoai.Size = new System.Drawing.Size(334, 20);
            this.txbTenTheLoai.StyleController = this.layoutControl1;
            this.txbTenTheLoai.TabIndex = 5;
            this.txbTenTheLoai.EditValueChanged += new System.EventHandler(this.txbTenTheLoai_EditValueChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(835, 43);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(67, 22);
            this.btnLuu.StyleController = this.layoutControl1;
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txbMaTheLoai
            // 
            this.txbMaTheLoai.Location = new System.Drawing.Point(92, 43);
            this.txbMaTheLoai.MenuManager = this.barManager1;
            this.txbMaTheLoai.Name = "txbMaTheLoai";
            this.txbMaTheLoai.Properties.ReadOnly = true;
            this.txbMaTheLoai.Size = new System.Drawing.Size(333, 20);
            this.txbMaTheLoai.StyleController = this.layoutControl1;
            this.txbMaTheLoai.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(999, 90);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup1.AppearanceGroup.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlGroup1.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.lo_btnLuu,
            this.lo_btnHuy});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(979, 70);
            this.layoutControlGroup1.Text = "Chi tiết Thể Loại";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txbTenTheLoai;
            this.layoutControlItem2.Location = new System.Drawing.Point(405, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(406, 27);
            this.layoutControlItem2.Text = "Tên Thể Loại:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(65, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txbMaTheLoai;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(405, 27);
            this.layoutControlItem1.Text = "Mã Thể Loại:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(65, 13);
            // 
            // lo_btnLuu
            // 
            this.lo_btnLuu.Control = this.btnLuu;
            this.lo_btnLuu.Location = new System.Drawing.Point(811, 0);
            this.lo_btnLuu.Name = "lo_btnLuu";
            this.lo_btnLuu.Size = new System.Drawing.Size(71, 27);
            this.lo_btnLuu.TextSize = new System.Drawing.Size(0, 0);
            this.lo_btnLuu.TextVisible = false;
            // 
            // lo_btnHuy
            // 
            this.lo_btnHuy.Control = this.btnHuy;
            this.lo_btnHuy.Location = new System.Drawing.Point(882, 0);
            this.lo_btnHuy.Name = "lo_btnHuy";
            this.lo_btnHuy.Size = new System.Drawing.Size(73, 27);
            this.lo_btnHuy.TextSize = new System.Drawing.Size(0, 0);
            this.lo_btnHuy.TextVisible = false;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandedGridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bandedGridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colMaTheLoai,
            this.colTenTheLoai});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsCustomization.AllowGroup = false;
            this.bandedGridView1.OptionsFind.AlwaysVisible = true;
            this.bandedGridView1.OptionsFind.FindNullPrompt = "Nhập nội dung tìm kiếm...";
            this.bandedGridView1.OptionsFind.ShowFindButton = false;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            this.bandedGridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.bandedGridView1_RowClick);
            this.bandedGridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.bandedGridView1_FocusedRowChanged);
            this.bandedGridView1.ColumnFilterChanged += new System.EventHandler(this.bandedGridView1_ColumnFilterChanged);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Danh Sách Các Thể Loại";
            this.gridBand1.Columns.Add(this.colMaTheLoai);
            this.gridBand1.Columns.Add(this.colTenTheLoai);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.RowCount = 2;
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 162;
            // 
            // colMaTheLoai
            // 
            this.colMaTheLoai.AppearanceCell.Options.UseBackColor = true;
            this.colMaTheLoai.AppearanceCell.Options.UseBorderColor = true;
            this.colMaTheLoai.AppearanceCell.Options.UseTextOptions = true;
            this.colMaTheLoai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMaTheLoai.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colMaTheLoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaTheLoai.AppearanceHeader.Options.UseBackColor = true;
            this.colMaTheLoai.AppearanceHeader.Options.UseFont = true;
            this.colMaTheLoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaTheLoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaTheLoai.Caption = "Mã Thể Loại";
            this.colMaTheLoai.FieldName = "MaTheLoai";
            this.colMaTheLoai.MinWidth = 21;
            this.colMaTheLoai.Name = "colMaTheLoai";
            this.colMaTheLoai.OptionsColumn.AllowEdit = false;
            this.colMaTheLoai.Visible = true;
            this.colMaTheLoai.Width = 81;
            // 
            // colTenTheLoai
            // 
            this.colTenTheLoai.AppearanceCell.Options.UseBackColor = true;
            this.colTenTheLoai.AppearanceCell.Options.UseBorderColor = true;
            this.colTenTheLoai.AppearanceCell.Options.UseTextOptions = true;
            this.colTenTheLoai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTenTheLoai.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colTenTheLoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenTheLoai.AppearanceHeader.Options.UseBackColor = true;
            this.colTenTheLoai.AppearanceHeader.Options.UseFont = true;
            this.colTenTheLoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenTheLoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenTheLoai.Caption = "Tên Thể Loại";
            this.colTenTheLoai.FieldName = "TenTheLoai";
            this.colTenTheLoai.MinWidth = 21;
            this.colTenTheLoai.Name = "colTenTheLoai";
            this.colTenTheLoai.OptionsColumn.AllowEdit = false;
            this.colTenTheLoai.Visible = true;
            this.colTenTheLoai.Width = 81;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "{0}         of {1}";
            this.gridControl1.Location = new System.Drawing.Point(0, 114);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(999, 345);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // frmTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 459);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTheLoai";
            this.Text = "Thông Tin Thể Loại";
            this.Load += new System.EventHandler(this.frmTheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txbTenTheLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaTheLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lo_btnLuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lo_btnHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuuLai;
        private DevExpress.XtraBars.BarButtonItem btnLamLai;
        private DevExpress.XtraBars.BarButtonItem TimKiem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txbTenTheLoai;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarCheckItem ck_TatCa;
        private DevExpress.XtraBars.BarCheckItem ck_MaTheLoai;
        private DevExpress.XtraBars.BarCheckItem ck_TenTheLoai;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraLayout.LayoutControlItem lo_btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.TextEdit txbMaTheLoai;
        private DevExpress.XtraLayout.LayoutControlItem lo_btnHuy;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMaTheLoai;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTenTheLoai;
    }
}