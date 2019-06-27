namespace QLTV_GUI
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.txbPass = new DevExpress.XtraEditors.TextEdit();
            this.txbnewpass = new DevExpress.XtraEditors.TextEdit();
            this.txbRenewpass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnthaydoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txbPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbnewpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbRenewpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(12, 31);
            this.txbPass.Name = "txbPass";
            this.txbPass.Properties.UseSystemPasswordChar = true;
            this.txbPass.Size = new System.Drawing.Size(189, 20);
            this.txbPass.TabIndex = 0;
            this.txbPass.EditValueChanged += new System.EventHandler(this.txbPass_EditValueChanged);
            // 
            // txbnewpass
            // 
            this.txbnewpass.Enabled = false;
            this.txbnewpass.Location = new System.Drawing.Point(12, 84);
            this.txbnewpass.Name = "txbnewpass";
            this.txbnewpass.Properties.UseSystemPasswordChar = true;
            this.txbnewpass.Size = new System.Drawing.Size(189, 20);
            this.txbnewpass.TabIndex = 1;
            this.txbnewpass.EditValueChanged += new System.EventHandler(this.txbnewpass_EditValueChanged);
            // 
            // txbRenewpass
            // 
            this.txbRenewpass.Enabled = false;
            this.txbRenewpass.Location = new System.Drawing.Point(12, 139);
            this.txbRenewpass.Name = "txbRenewpass";
            this.txbRenewpass.Properties.UseSystemPasswordChar = true;
            this.txbRenewpass.Size = new System.Drawing.Size(189, 20);
            this.txbRenewpass.TabIndex = 2;
            this.txbRenewpass.EditValueChanged += new System.EventHandler(this.txbRenewpass_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mật khẩu hiện tại:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Mật khẩu mới:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Nhập lại mật khẩu mới:";
            // 
            // btnthaydoi
            // 
            this.btnthaydoi.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnthaydoi.Appearance.Options.UseFont = true;
            this.btnthaydoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthaydoi.ImageOptions.Image")));
            this.btnthaydoi.Location = new System.Drawing.Point(34, 178);
            this.btnthaydoi.Name = "btnthaydoi";
            this.btnthaydoi.Size = new System.Drawing.Size(86, 26);
            this.btnthaydoi.TabIndex = 6;
            this.btnthaydoi.Text = "Thay đổi";
            this.btnthaydoi.Click += new System.EventHandler(this.btnthaydoi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(136, 178);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(65, 26);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            this.AcceptButton = this.btnthaydoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 222);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnthaydoi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txbRenewpass);
            this.Controls.Add(this.txbnewpass);
            this.Controls.Add(this.txbPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.txbPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbnewpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbRenewpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txbPass;
        private DevExpress.XtraEditors.TextEdit txbnewpass;
        private DevExpress.XtraEditors.TextEdit txbRenewpass;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnthaydoi;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}