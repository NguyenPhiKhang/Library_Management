namespace QLTV_GUI
{
    partial class frmThemTheLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemTheLoai));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txbMaTheLoai = new DevExpress.XtraEditors.TextEdit();
            this.txbTenTheLoai = new DevExpress.XtraEditors.TextEdit();
            this.btn_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Nhap = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaTheLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenTheLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txbMaTheLoai);
            this.layoutControl1.Controls.Add(this.txbTenTheLoai);
            this.layoutControl1.Controls.Add(this.btn_Huy);
            this.layoutControl1.Controls.Add(this.btn_Nhap);
            this.layoutControl1.Location = new System.Drawing.Point(3, -1);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(560, 0, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(494, 197);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txbMaTheLoai
            // 
            this.txbMaTheLoai.Location = new System.Drawing.Point(118, 53);
            this.txbMaTheLoai.Name = "txbMaTheLoai";
            this.txbMaTheLoai.Size = new System.Drawing.Size(352, 22);
            this.txbMaTheLoai.StyleController = this.layoutControl1;
            this.txbMaTheLoai.TabIndex = 4;
            // 
            // txbTenTheLoai
            // 
            this.txbTenTheLoai.Location = new System.Drawing.Point(118, 79);
            this.txbTenTheLoai.Name = "txbTenTheLoai";
            this.txbTenTheLoai.Properties.NullText = "[Nhập tên thể loại sách]";
            this.txbTenTheLoai.Size = new System.Drawing.Size(352, 22);
            this.txbTenTheLoai.StyleController = this.layoutControl1;
            this.txbTenTheLoai.TabIndex = 5;
            this.txbTenTheLoai.EditValueChanged += new System.EventHandler(this.txbTenTheLoai_EditValueChanged);
            // 
            // btn_Huy
            // 
            this.btn_Huy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huy.ImageOptions.Image")));
            this.btn_Huy.Location = new System.Drawing.Point(247, 117);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(68, 27);
            this.btn_Huy.StyleController = this.layoutControl1;
            this.btn_Huy.TabIndex = 9;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nhap.ImageOptions.Image")));
            this.btn_Nhap.Location = new System.Drawing.Point(158, 117);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(68, 27);
            this.btn_Nhap.StyleController = this.layoutControl1;
            this.btn_Nhap.TabIndex = 10;
            this.btn_Nhap.Text = "Nhập";
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(494, 197);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup1.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(474, 105);
            this.layoutControlGroup1.Text = "Thể Loại";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txbMaTheLoai;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(450, 26);
            this.layoutControlItem1.Text = "Mã Thể Loại :";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(91, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txbTenTheLoai;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(450, 26);
            this.layoutControlItem2.Text = "Tên Thể Loại : ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(91, 17);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btn_Nhap;
            this.layoutControlItem6.Location = new System.Drawing.Point(146, 105);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(72, 72);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(218, 105);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(17, 72);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btn_Huy;
            this.layoutControlItem5.Location = new System.Drawing.Point(235, 105);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(72, 72);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 105);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(146, 72);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(307, 105);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(167, 72);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmThemTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 159);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmThemTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Thể Loại";
            this.Load += new System.EventHandler(this.frmThemTheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txbMaTheLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenTheLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txbMaTheLoai;
        private DevExpress.XtraEditors.TextEdit txbTenTheLoai;
        private DevExpress.XtraEditors.SimpleButton btn_Huy;
        private DevExpress.XtraEditors.SimpleButton btn_Nhap;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}