namespace QLTV_GUI
{
    partial class frmThemPhieuMuon
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaPhieuMuon = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateNgayMuon = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateHanTra = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lkue_MaDocGia = new DevExpress.XtraEditors.LookUpEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTenDocGia = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txbTenSach = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lkue_MaSach = new DevExpress.XtraEditors.LookUpEdit();
            this.txbTinhTrang = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Huy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Nhap = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.lkue_MaDocGia.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkue_MaSach.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Phiếu Mượn:";
            // 
            // txbMaPhieuMuon
            // 
            this.txbMaPhieuMuon.BackColor = System.Drawing.Color.Silver;
            this.txbMaPhieuMuon.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txbMaPhieuMuon.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMaPhieuMuon.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txbMaPhieuMuon.BorderThickness = 3;
            this.txbMaPhieuMuon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMaPhieuMuon.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbMaPhieuMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMaPhieuMuon.isPassword = false;
            this.txbMaPhieuMuon.Location = new System.Drawing.Point(129, 9);
            this.txbMaPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaPhieuMuon.Name = "txbMaPhieuMuon";
            this.txbMaPhieuMuon.Size = new System.Drawing.Size(183, 30);
            this.txbMaPhieuMuon.TabIndex = 3;
            this.txbMaPhieuMuon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày Mượn:";
            // 
            // dateNgayMuon
            // 
            this.dateNgayMuon.BackColor = System.Drawing.Color.Silver;
            this.dateNgayMuon.BorderRadius = 0;
            this.dateNgayMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayMuon.FormatCustom = null;
            this.dateNgayMuon.Location = new System.Drawing.Point(129, 50);
            this.dateNgayMuon.Name = "dateNgayMuon";
            this.dateNgayMuon.Size = new System.Drawing.Size(183, 30);
            this.dateNgayMuon.TabIndex = 41;
            this.dateNgayMuon.Value = new System.DateTime(2019, 5, 11, 16, 15, 55, 945);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Hạn Trả:";
            // 
            // dateHanTra
            // 
            this.dateHanTra.BackColor = System.Drawing.Color.Silver;
            this.dateHanTra.BorderRadius = 0;
            this.dateHanTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHanTra.FormatCustom = null;
            this.dateHanTra.Location = new System.Drawing.Point(129, 91);
            this.dateHanTra.Name = "dateHanTra";
            this.dateHanTra.Size = new System.Drawing.Size(183, 30);
            this.dateHanTra.TabIndex = 43;
            this.dateHanTra.Value = new System.DateTime(2019, 5, 11, 16, 15, 55, 945);
            // 
            // lkue_MaDocGia
            // 
            this.lkue_MaDocGia.EditValue = "Chọn Tác Giả";
            this.lkue_MaDocGia.Location = new System.Drawing.Point(130, 34);
            this.lkue_MaDocGia.Name = "lkue_MaDocGia";
            this.lkue_MaDocGia.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.lkue_MaDocGia.Properties.Appearance.Options.UseBackColor = true;
            this.lkue_MaDocGia.Properties.AutoHeight = false;
            this.lkue_MaDocGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkue_MaDocGia.Size = new System.Drawing.Size(183, 30);
            this.lkue_MaDocGia.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateHanTra);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateNgayMuon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbMaPhieuMuon);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 133);
            this.panel1.TabIndex = 48;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.groupControl1.Controls.Add(this.txbTenDocGia);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.lkue_MaDocGia);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(12, 151);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(324, 112);
            this.groupControl1.TabIndex = 50;
            this.groupControl1.Text = "Thông Tin Độc Giả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(16, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Mã Độc Giả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(16, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "Tên Độc Giả:";
            // 
            // txbTenDocGia
            // 
            this.txbTenDocGia.BackColor = System.Drawing.Color.Silver;
            this.txbTenDocGia.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txbTenDocGia.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTenDocGia.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txbTenDocGia.BorderThickness = 3;
            this.txbTenDocGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenDocGia.Enabled = false;
            this.txbTenDocGia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbTenDocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTenDocGia.isPassword = false;
            this.txbTenDocGia.Location = new System.Drawing.Point(130, 71);
            this.txbTenDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenDocGia.Name = "txbTenDocGia";
            this.txbTenDocGia.Size = new System.Drawing.Size(183, 30);
            this.txbTenDocGia.TabIndex = 51;
            this.txbTenDocGia.Text = "dgdfgdfgdsf";
            this.txbTenDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.txbTinhTrang);
            this.groupControl2.Controls.Add(this.txbTenSach);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.lkue_MaSach);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(361, 41);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(304, 142);
            this.groupControl2.TabIndex = 52;
            this.groupControl2.Text = "Thông Tin Sách";
            // 
            // txbTenSach
            // 
            this.txbTenSach.BackColor = System.Drawing.Color.Silver;
            this.txbTenSach.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txbTenSach.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTenSach.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txbTenSach.BorderThickness = 3;
            this.txbTenSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenSach.Enabled = false;
            this.txbTenSach.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbTenSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTenSach.isPassword = false;
            this.txbTenSach.Location = new System.Drawing.Point(108, 64);
            this.txbTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenSach.Name = "txbTenSach";
            this.txbTenSach.Size = new System.Drawing.Size(183, 30);
            this.txbTenSach.TabIndex = 51;
            this.txbTenSach.Text = "dgdfgdfgdsf";
            this.txbTenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Tên Sách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(21, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Mã Sách:";
            // 
            // lkue_MaSach
            // 
            this.lkue_MaSach.EditValue = "Chọn Tác Giả";
            this.lkue_MaSach.Location = new System.Drawing.Point(108, 27);
            this.lkue_MaSach.Name = "lkue_MaSach";
            this.lkue_MaSach.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.lkue_MaSach.Properties.Appearance.Options.UseBackColor = true;
            this.lkue_MaSach.Properties.AutoHeight = false;
            this.lkue_MaSach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkue_MaSach.Size = new System.Drawing.Size(183, 30);
            this.lkue_MaSach.TabIndex = 46;
            // 
            // txbTinhTrang
            // 
            this.txbTinhTrang.BackColor = System.Drawing.Color.Silver;
            this.txbTinhTrang.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txbTinhTrang.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTinhTrang.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txbTinhTrang.BorderThickness = 3;
            this.txbTinhTrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTinhTrang.Enabled = false;
            this.txbTinhTrang.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTinhTrang.isPassword = false;
            this.txbTinhTrang.Location = new System.Drawing.Point(108, 102);
            this.txbTinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.txbTinhTrang.Name = "txbTinhTrang";
            this.txbTinhTrang.Size = new System.Drawing.Size(183, 30);
            this.txbTinhTrang.TabIndex = 52;
            this.txbTinhTrang.Text = "dgdfgdfgdsf";
            this.txbTinhTrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(21, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "Tình Trạng:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Huy);
            this.panel2.Controls.Add(this.btn_Nhap);
            this.panel2.Location = new System.Drawing.Point(406, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 43);
            this.panel2.TabIndex = 53;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Huy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Huy.BorderRadius = 0;
            this.btn_Huy.ButtonText = "HỦY";
            this.btn_Huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Huy.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Huy.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Huy.Iconimage = global::QLTV_GUI.Properties.Resources.delete_icon;
            this.btn_Huy.Iconimage_right = null;
            this.btn_Huy.Iconimage_right_Selected = null;
            this.btn_Huy.Iconimage_Selected = null;
            this.btn_Huy.IconMarginLeft = 0;
            this.btn_Huy.IconMarginRight = 0;
            this.btn_Huy.IconRightVisible = true;
            this.btn_Huy.IconRightZoom = 0D;
            this.btn_Huy.IconVisible = true;
            this.btn_Huy.IconZoom = 50D;
            this.btn_Huy.IsTab = false;
            this.btn_Huy.Location = new System.Drawing.Point(121, 7);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Huy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Huy.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Huy.selected = false;
            this.btn_Huy.Size = new System.Drawing.Size(99, 31);
            this.btn_Huy.TabIndex = 47;
            this.btn_Huy.Text = "HỦY";
            this.btn_Huy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Huy.Textcolor = System.Drawing.Color.White;
            this.btn_Huy.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Nhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Nhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Nhap.BorderRadius = 0;
            this.btn_Nhap.ButtonText = "NHẬP";
            this.btn_Nhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nhap.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Nhap.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nhap.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Nhap.Iconimage = global::QLTV_GUI.Properties.Resources.man;
            this.btn_Nhap.Iconimage_right = null;
            this.btn_Nhap.Iconimage_right_Selected = null;
            this.btn_Nhap.Iconimage_Selected = null;
            this.btn_Nhap.IconMarginLeft = 0;
            this.btn_Nhap.IconMarginRight = 0;
            this.btn_Nhap.IconRightVisible = true;
            this.btn_Nhap.IconRightZoom = 0D;
            this.btn_Nhap.IconVisible = true;
            this.btn_Nhap.IconZoom = 50D;
            this.btn_Nhap.IsTab = false;
            this.btn_Nhap.Location = new System.Drawing.Point(2, 7);
            this.btn_Nhap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Nhap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Nhap.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Nhap.selected = false;
            this.btn_Nhap.Size = new System.Drawing.Size(99, 31);
            this.btn_Nhap.TabIndex = 46;
            this.btn_Nhap.Text = "NHẬP";
            this.btn_Nhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Nhap.Textcolor = System.Drawing.Color.White;
            this.btn_Nhap.TextFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmThemPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 277);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmThemPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Phiếu Mượn";
            ((System.ComponentModel.ISupportInitialize)(this.lkue_MaDocGia.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkue_MaSach.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbMaPhieuMuon;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker dateNgayMuon;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker dateHanTra;
        private DevExpress.XtraEditors.LookUpEdit lkue_MaDocGia;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbTenDocGia;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbTinhTrang;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbTenSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.LookUpEdit lkue_MaSach;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Huy;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Nhap;
    }
}