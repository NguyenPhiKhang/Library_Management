namespace QLTV_GUI
{
    partial class frmBCTKTraTre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBCTKTraTre));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dateNgayBC = new DevExpress.XtraEditors.DateEdit();
            this.btnTaoBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lo_btnTaoBaoCao = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoNgayTT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBC.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lo_btnTaoBaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dateNgayBC);
            this.layoutControl1.Controls.Add(this.btnTaoBaoCao);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 298, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(779, 100);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dateNgayBC
            // 
            this.dateNgayBC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateNgayBC.EditValue = null;
            this.dateNgayBC.Location = new System.Drawing.Point(344, 53);
            this.dateNgayBC.Name = "dateNgayBC";
            this.dateNgayBC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayBC.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayBC.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayBC.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayBC.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayBC.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayBC.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNgayBC.Properties.NullText = "--Chọn ngày--";
            this.dateNgayBC.Size = new System.Drawing.Size(84, 20);
            this.dateNgayBC.StyleController = this.layoutControl1;
            this.dateNgayBC.TabIndex = 4;
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoBaoCao.ImageOptions.Image")));
            this.btnTaoBaoCao.Location = new System.Drawing.Point(666, 53);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(89, 22);
            this.btnTaoBaoCao.StyleController = this.layoutControl1;
            this.btnTaoBaoCao.TabIndex = 3;
            this.btnTaoBaoCao.Text = "Tạo báo cáo";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(779, 100);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup1.AppearanceGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.layoutControlGroup1.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup1.AppearanceGroup.Options.UseForeColor = true;
            this.layoutControlGroup1.AppearanceGroup.Options.UseTextOptions = true;
            this.layoutControlGroup1.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlGroup1.CustomizationFormText = "BÁO CÁO THỐNG KÊ SÁCH TRẢ TRỄ";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lo_btnTaoBaoCao,
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(759, 80);
            this.layoutControlGroup1.Text = "BÁO CÁO THỐNG KÊ SÁCH TRẢ TRỄ";
            // 
            // lo_btnTaoBaoCao
            // 
            this.lo_btnTaoBaoCao.Control = this.btnTaoBaoCao;
            this.lo_btnTaoBaoCao.Location = new System.Drawing.Point(642, 0);
            this.lo_btnTaoBaoCao.Name = "lo_btnTaoBaoCao";
            this.lo_btnTaoBaoCao.Size = new System.Drawing.Size(93, 27);
            this.lo_btnTaoBaoCao.TextSize = new System.Drawing.Size(0, 0);
            this.lo_btnTaoBaoCao.TextVisible = false;
            this.lo_btnTaoBaoCao.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.dateNgayBC;
            this.layoutControlItem1.Location = new System.Drawing.Point(268, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(140, 27);
            this.layoutControlItem1.Text = "Ngày:   ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(49, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(268, 27);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(408, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(234, 27);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
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
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "{0}           of {1}";
            this.gridControl1.Location = new System.Drawing.Point(0, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(779, 308);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSach,
            this.colTenSach,
            this.colNgayMuon,
            this.colSoNgayTT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaSach
            // 
            this.colMaSach.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaSach.AppearanceHeader.Options.UseFont = true;
            this.colMaSach.Caption = "Mã Sách";
            this.colMaSach.FieldName = "MaSach";
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.Visible = true;
            this.colMaSach.VisibleIndex = 0;
            // 
            // colTenSach
            // 
            this.colTenSach.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenSach.AppearanceHeader.Options.UseFont = true;
            this.colTenSach.Caption = "Tên  Sách";
            this.colTenSach.FieldName = "TenSach";
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.Visible = true;
            this.colTenSach.VisibleIndex = 1;
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNgayMuon.AppearanceHeader.Options.UseFont = true;
            this.colNgayMuon.Caption = "Ngày Mượn";
            this.colNgayMuon.FieldName = "NgayMuon";
            this.colNgayMuon.Name = "colNgayMuon";
            this.colNgayMuon.Visible = true;
            this.colNgayMuon.VisibleIndex = 2;
            // 
            // colSoNgayTT
            // 
            this.colSoNgayTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSoNgayTT.AppearanceHeader.Options.UseFont = true;
            this.colSoNgayTT.Caption = "Số Ngày Trả Trễ";
            this.colSoNgayTT.Name = "colSoNgayTT";
            this.colSoNgayTT.Visible = true;
            this.colSoNgayTT.VisibleIndex = 3;
            // 
            // frmBCTKTraTre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 408);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmBCTKTraTre";
            this.Text = "Báo Cáo Thống Kê Sách Trả Trễ";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBC.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lo_btnTaoBaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnTaoBaoCao;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lo_btnTaoBaoCao;
        private DevExpress.XtraEditors.DateEdit dateNgayBC;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSach;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSach;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayMuon;
        private DevExpress.XtraGrid.Columns.GridColumn colSoNgayTT;
    }
}