namespace QLTV_GUI
{
    partial class frmTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTacGia));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.TimKiem = new DevExpress.XtraBars.BarSubItem();
            this.ck_TatCa = new DevExpress.XtraBars.BarCheckItem();
            this.ck_MaTacGia = new DevExpress.XtraBars.BarCheckItem();
            this.ck_TenTacGia = new DevExpress.XtraBars.BarCheckItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnLuuLai = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txbTenTacGia = new DevExpress.XtraEditors.TextEdit();
            this.txbMaTacGia = new DevExpress.XtraEditors.TextEdit();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lo_btnLuu = new DevExpress.XtraLayout.LayoutControlItem();
            this.lo_btnHuy = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colMaTacGia = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTenTacGia = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenTacGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaTacGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lo_btnLuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lo_btnHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
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
            this.btnLamMoi,
            this.TimKiem,
            this.ck_TatCa,
            this.ck_MaTacGia,
            this.ck_TenTacGia});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
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
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm Mới";
            this.btnLamMoi.Id = 3;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.LargeImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // TimKiem
            // 
            this.TimKiem.Caption = "Tìm Kiếm";
            this.TimKiem.Id = 4;
            this.TimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TimKiem.ImageOptions.Image")));
            this.TimKiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("TimKiem.ImageOptions.LargeImage")));
            this.TimKiem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ck_TatCa),
            new DevExpress.XtraBars.LinkPersistInfo(this.ck_MaTacGia),
            new DevExpress.XtraBars.LinkPersistInfo(this.ck_TenTacGia)});
            this.TimKiem.Name = "TimKiem";
            // 
            // ck_TatCa
            // 
            this.ck_TatCa.Caption = "Tất Cả";
            this.ck_TatCa.Id = 5;
            this.ck_TatCa.Name = "ck_TatCa";
            this.ck_TatCa.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.ck_TatCa_CheckedChanged);
            // 
            // ck_MaTacGia
            // 
            this.ck_MaTacGia.Caption = "Mã Tác Giả";
            this.ck_MaTacGia.Id = 6;
            this.ck_MaTacGia.Name = "ck_MaTacGia";
            this.ck_MaTacGia.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.ck_MaTacGia_CheckedChanged);
            // 
            // ck_TenTacGia
            // 
            this.ck_TenTacGia.Caption = "Tên Tác Giả";
            this.ck_TenTacGia.Id = 7;
            this.ck_TenTacGia.Name = "ck_TenTacGia";
            this.ck_TenTacGia.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.ck_TenTacGia_CheckedChanged);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1166, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 460);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1166, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 436);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1166, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 436);
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.Caption = "Lưu Lại";
            this.btnLuuLai.Id = 2;
            this.btnLuuLai.ImageOptions.Image = global::QLTV_GUI.Properties.Resources.save_icon__1_;
            this.btnLuuLai.Name = "btnLuuLai";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txbTenTacGia);
            this.layoutControl1.Controls.Add(this.txbMaTacGia);
            this.layoutControl1.Controls.Add(this.btnHuy);
            this.layoutControl1.Controls.Add(this.btnLuu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(459, 183, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1166, 85);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txbTenTacGia
            // 
            this.txbTenTacGia.Location = new System.Drawing.Point(641, 45);
            this.txbTenTacGia.MenuManager = this.barManager1;
            this.txbTenTacGia.Name = "txbTenTacGia";
            this.txbTenTacGia.Properties.ReadOnly = true;
            this.txbTenTacGia.Size = new System.Drawing.Size(339, 20);
            this.txbTenTacGia.StyleController = this.layoutControl1;
            this.txbTenTacGia.TabIndex = 5;
            this.txbTenTacGia.EditValueChanged += new System.EventHandler(this.txbTenTacGia_EditValueChanged);
            // 
            // txbMaTacGia
            // 
            this.txbMaTacGia.Location = new System.Drawing.Point(87, 45);
            this.txbMaTacGia.MenuManager = this.barManager1;
            this.txbMaTacGia.Name = "txbMaTacGia";
            this.txbMaTacGia.Properties.ReadOnly = true;
            this.txbMaTacGia.Size = new System.Drawing.Size(487, 20);
            this.txbMaTacGia.StyleController = this.layoutControl1;
            this.txbMaTacGia.TabIndex = 4;
            this.txbMaTacGia.EditValueChanged += new System.EventHandler(this.txbMaTacGia_EditValueChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(1061, 45);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(64, 22);
            this.btnHuy.StyleController = this.layoutControl1;
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(984, 45);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(73, 22);
            this.btnLuu.StyleController = this.layoutControl1;
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1149, 91);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup1.AppearanceGroup.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlGroup1.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.lo_btnLuu,
            this.lo_btnHuy});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1129, 71);
            this.layoutControlGroup1.Text = "Chi tiết tác giả";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txbMaTacGia;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(554, 26);
            this.layoutControlItem1.Text = "Mã Tác Giả:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txbTenTacGia;
            this.layoutControlItem2.Location = new System.Drawing.Point(554, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(406, 26);
            this.layoutControlItem2.Text = "Tên Tác Giả:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 13);
            // 
            // lo_btnLuu
            // 
            this.lo_btnLuu.Control = this.btnLuu;
            this.lo_btnLuu.Location = new System.Drawing.Point(960, 0);
            this.lo_btnLuu.Name = "lo_btnLuu";
            this.lo_btnLuu.Size = new System.Drawing.Size(77, 26);
            this.lo_btnLuu.TextSize = new System.Drawing.Size(0, 0);
            this.lo_btnLuu.TextVisible = false;
            // 
            // lo_btnHuy
            // 
            this.lo_btnHuy.Control = this.btnHuy;
            this.lo_btnHuy.Location = new System.Drawing.Point(1037, 0);
            this.lo_btnHuy.Name = "lo_btnHuy";
            this.lo_btnHuy.Size = new System.Drawing.Size(68, 26);
            this.lo_btnHuy.TextSize = new System.Drawing.Size(0, 0);
            this.lo_btnHuy.TextVisible = false;
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
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "{0}        of {1}";
            this.gridControl1.Location = new System.Drawing.Point(0, 109);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1166, 351);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
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
            this.colMaTacGia,
            this.colTenTacGia});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
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
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand1.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Danh Sách Các Tác Giả";
            this.gridBand1.Columns.Add(this.colMaTacGia);
            this.gridBand1.Columns.Add(this.colTenTacGia);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.RowCount = 2;
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 162;
            // 
            // colMaTacGia
            // 
            this.colMaTacGia.AppearanceCell.Options.UseBackColor = true;
            this.colMaTacGia.AppearanceCell.Options.UseBorderColor = true;
            this.colMaTacGia.AppearanceCell.Options.UseTextOptions = true;
            this.colMaTacGia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMaTacGia.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colMaTacGia.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaTacGia.AppearanceHeader.Options.UseBackColor = true;
            this.colMaTacGia.AppearanceHeader.Options.UseFont = true;
            this.colMaTacGia.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaTacGia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaTacGia.Caption = "Mã Tác Giả";
            this.colMaTacGia.FieldName = "MaTacGia";
            this.colMaTacGia.MinWidth = 21;
            this.colMaTacGia.Name = "colMaTacGia";
            this.colMaTacGia.OptionsColumn.AllowEdit = false;
            this.colMaTacGia.Visible = true;
            this.colMaTacGia.Width = 81;
            // 
            // colTenTacGia
            // 
            this.colTenTacGia.AppearanceCell.Options.UseBackColor = true;
            this.colTenTacGia.AppearanceCell.Options.UseBorderColor = true;
            this.colTenTacGia.AppearanceCell.Options.UseTextOptions = true;
            this.colTenTacGia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTenTacGia.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colTenTacGia.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenTacGia.AppearanceHeader.Options.UseBackColor = true;
            this.colTenTacGia.AppearanceHeader.Options.UseFont = true;
            this.colTenTacGia.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenTacGia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenTacGia.Caption = "Tên Tác Giả";
            this.colTenTacGia.FieldName = "TenTacGia";
            this.colTenTacGia.MinWidth = 21;
            this.colTenTacGia.Name = "colTenTacGia";
            this.colTenTacGia.OptionsColumn.AllowEdit = false;
            this.colTenTacGia.Visible = true;
            this.colTenTacGia.Width = 81;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 460);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTacGia";
            this.Text = "Thông Tin Tác Giả";
            this.Load += new System.EventHandler(this.frmTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txbTenTacGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaTacGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lo_btnLuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lo_btnHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuuLai;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarSubItem TimKiem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txbTenTacGia;
        private DevExpress.XtraEditors.TextEdit txbMaTacGia;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarCheckItem ck_TatCa;
        private DevExpress.XtraBars.BarCheckItem ck_MaTacGia;
        private DevExpress.XtraBars.BarCheckItem ck_TenTacGia;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMaTacGia;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTenTacGia;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraLayout.LayoutControlItem lo_btnLuu;
        private DevExpress.XtraLayout.LayoutControlItem lo_btnHuy;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
    }
}