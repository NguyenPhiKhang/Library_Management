namespace QLTV_GUI
{
    partial class frmThemLoaiDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemLoaiDocGia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenLoaiDG = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbMaLoaiDG = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnNhap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbTenLoaiDG);
            this.panel1.Controls.Add(this.txbMaLoaiDG);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 125);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Loại Độc Giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Loại Độc Giả:";
            // 
            // txbTenLoaiDG
            // 
            this.txbTenLoaiDG.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbTenLoaiDG.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTenLoaiDG.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbTenLoaiDG.BorderThickness = 3;
            this.txbTenLoaiDG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenLoaiDG.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbTenLoaiDG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTenLoaiDG.isPassword = false;
            this.txbTenLoaiDG.Location = new System.Drawing.Point(136, 68);
            this.txbTenLoaiDG.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenLoaiDG.Name = "txbTenLoaiDG";
            this.txbTenLoaiDG.Size = new System.Drawing.Size(235, 34);
            this.txbTenLoaiDG.TabIndex = 1;
            this.txbTenLoaiDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbMaLoaiDG
            // 
            this.txbMaLoaiDG.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbMaLoaiDG.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMaLoaiDG.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbMaLoaiDG.BorderThickness = 3;
            this.txbMaLoaiDG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMaLoaiDG.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbMaLoaiDG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMaLoaiDG.isPassword = false;
            this.txbMaLoaiDG.Location = new System.Drawing.Point(136, 17);
            this.txbMaLoaiDG.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaLoaiDG.Name = "txbMaLoaiDG";
            this.txbMaLoaiDG.Size = new System.Drawing.Size(235, 34);
            this.txbMaLoaiDG.TabIndex = 0;
            this.txbMaLoaiDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnNhap
            // 
            this.btnNhap.ActiveBorderThickness = 1;
            this.btnNhap.ActiveCornerRadius = 20;
            this.btnNhap.ActiveFillColor = System.Drawing.Color.Blue;
            this.btnNhap.ActiveForecolor = System.Drawing.Color.White;
            this.btnNhap.ActiveLineColor = System.Drawing.Color.Blue;
            this.btnNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNhap.BackgroundImage")));
            this.btnNhap.ButtonText = "Nhập";
            this.btnNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhap.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNhap.IdleBorderThickness = 1;
            this.btnNhap.IdleCornerRadius = 20;
            this.btnNhap.IdleFillColor = System.Drawing.Color.White;
            this.btnNhap.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNhap.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNhap.Location = new System.Drawing.Point(140, 145);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(109, 36);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmThemLoaiDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 186);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmThemLoaiDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Loại Độc Giả";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbMaLoaiDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbTenLoaiDG;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNhap;
    }
}