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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemTheLoai));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenTheLoai = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbMaTheLoai = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnNhap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbTenTheLoai);
            this.panel1.Controls.Add(this.txbMaTheLoai);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 125);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Thể Loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Thể Loại:";
            // 
            // txbTenTheLoai
            // 
            this.txbTenTheLoai.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbTenTheLoai.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTenTheLoai.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbTenTheLoai.BorderThickness = 3;
            this.txbTenTheLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenTheLoai.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbTenTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTenTheLoai.isPassword = false;
            this.txbTenTheLoai.Location = new System.Drawing.Point(136, 68);
            this.txbTenTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenTheLoai.Name = "txbTenTheLoai";
            this.txbTenTheLoai.Size = new System.Drawing.Size(235, 34);
            this.txbTenTheLoai.TabIndex = 1;
            this.txbTenTheLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbMaTheLoai
            // 
            this.txbMaTheLoai.BorderColorFocused = System.Drawing.Color.Blue;
            this.txbMaTheLoai.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMaTheLoai.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txbMaTheLoai.BorderThickness = 3;
            this.txbMaTheLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMaTheLoai.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbMaTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMaTheLoai.isPassword = false;
            this.txbMaTheLoai.Location = new System.Drawing.Point(136, 17);
            this.txbMaTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaTheLoai.Name = "txbMaTheLoai";
            this.txbMaTheLoai.Size = new System.Drawing.Size(235, 34);
            this.txbMaTheLoai.TabIndex = 0;
            this.txbMaTheLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnNhap.TabIndex = 3;
            this.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmThemTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 185);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmThemTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Thể Loại";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbTenTheLoai;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbMaTheLoai;
    }
}