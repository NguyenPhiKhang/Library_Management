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
            this.cbbNgayBC = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnTaoBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lo_btnTaoBaoCao = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoNgayTT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNgayBC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lo_btnTaoBaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbbNgayBC);
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
            // cbbNgayBC
            // 
            this.cbbNgayBC.Location = new System.Drawing.Point(330, 53);
            this.cbbNgayBC.Name = "cbbNgayBC";
            this.cbbNgayBC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbNgayBC.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.cbbNgayBC.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbbNgayBC.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.cbbNgayBC.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbbNgayBC.Properties.NullText = "Chọn ngày...";
            this.cbbNgayBC.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbNgayBC.Size = new System.Drawing.Size(145, 20);
            this.cbbNgayBC.StyleController = this.layoutControl1;
            this.cbbNgayBC.TabIndex = 4;
            this.cbbNgayBC.SelectedIndexChanged += new System.EventHandler(this.cbbNgay_SelectedIndexChanged);
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
            this.btnTaoBaoCao.Click += new System.EventHandler(this.btnTaoBaoCao_Click);
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
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem1});
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
            this.emptySpaceItem2.Location = new System.Drawing.Point(455, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(187, 27);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbbNgayBC;
            this.layoutControlItem1.Location = new System.Drawing.Point(268, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(187, 27);
            this.layoutControlItem1.Text = "Ngày:  ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(35, 13);
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
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSach,
            this.colTenSach,
            this.colNgayMuon,
            this.colSoNgayTT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCountChanged += new System.EventHandler(this.gridView1_RowCountChanged);
            // 
            // colMaSach
            // 
            this.colMaSach.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colMaSach.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colMaSach.AppearanceHeader.Options.UseBackColor = true;
            this.colMaSach.AppearanceHeader.Options.UseFont = true;
            this.colMaSach.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaSach.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaSach.Caption = "Mã Sách";
            this.colMaSach.FieldName = "MaSach";
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.OptionsColumn.AllowEdit = false;
            this.colMaSach.Visible = true;
            this.colMaSach.VisibleIndex = 0;
            // 
            // colTenSach
            // 
            this.colTenSach.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colTenSach.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colTenSach.AppearanceHeader.Options.UseBackColor = true;
            this.colTenSach.AppearanceHeader.Options.UseFont = true;
            this.colTenSach.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenSach.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenSach.Caption = "Tên  Sách";
            this.colTenSach.FieldName = "TenSach";
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.OptionsColumn.AllowEdit = false;
            this.colTenSach.Visible = true;
            this.colTenSach.VisibleIndex = 1;
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colNgayMuon.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colNgayMuon.AppearanceHeader.Options.UseBackColor = true;
            this.colNgayMuon.AppearanceHeader.Options.UseFont = true;
            this.colNgayMuon.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgayMuon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayMuon.Caption = "Ngày Mượn";
            this.colNgayMuon.FieldName = "NgayMuon";
            this.colNgayMuon.Name = "colNgayMuon";
            this.colNgayMuon.OptionsColumn.AllowEdit = false;
            this.colNgayMuon.Visible = true;
            this.colNgayMuon.VisibleIndex = 2;
            // 
            // colSoNgayTT
            // 
            this.colSoNgayTT.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colSoNgayTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSoNgayTT.AppearanceHeader.Options.UseBackColor = true;
            this.colSoNgayTT.AppearanceHeader.Options.UseFont = true;
            this.colSoNgayTT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoNgayTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoNgayTT.Caption = "Số Ngày Trả Trễ";
            this.colSoNgayTT.FieldName = "SoNgayTraTre";
            this.colSoNgayTT.Name = "colSoNgayTT";
            this.colSoNgayTT.OptionsColumn.AllowEdit = false;
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
            this.Load += new System.EventHandler(this.frmBCTKTraTre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbNgayBC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lo_btnTaoBaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
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
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSach;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSach;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayMuon;
        private DevExpress.XtraGrid.Columns.GridColumn colSoNgayTT;
        private DevExpress.XtraEditors.ComboBoxEdit cbbNgayBC;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}