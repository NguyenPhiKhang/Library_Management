﻿namespace QLTV_GUI
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateNgayBC = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTaoBC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 41);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateNgayBC);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(265, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 35);
            this.panel1.TabIndex = 3;
            // 
            // dateNgayBC
            // 
            this.dateNgayBC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateNgayBC.BackColor = System.Drawing.Color.Silver;
            this.dateNgayBC.BorderRadius = 0;
            this.dateNgayBC.ForeColor = System.Drawing.Color.Black;
            this.dateNgayBC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayBC.FormatCustom = "dd/MM/yyyy";
            this.dateNgayBC.Location = new System.Drawing.Point(74, 5);
            this.dateNgayBC.Name = "dateNgayBC";
            this.dateNgayBC.Size = new System.Drawing.Size(176, 25);
            this.dateNgayBC.TabIndex = 1;
            this.dateNgayBC.Value = new System.DateTime(2019, 5, 12, 20, 32, 26, 344);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(779, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "BÁO CÁO THỐNG KÊ SÁCH TRẢ TRỄ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTaoBC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 367);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 41);
            this.panel3.TabIndex = 7;
            // 
            // btnTaoBC
            // 
            this.btnTaoBC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTaoBC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTaoBC.BackColor = System.Drawing.Color.Maroon;
            this.btnTaoBC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTaoBC.BorderRadius = 0;
            this.btnTaoBC.ButtonText = "Tạo Báo Cáo";
            this.btnTaoBC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoBC.DisabledColor = System.Drawing.Color.Gray;
            this.btnTaoBC.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaoBC.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTaoBC.Iconimage = global::QLTV_GUI.Properties.Resources.Reports_icon1;
            this.btnTaoBC.Iconimage_right = null;
            this.btnTaoBC.Iconimage_right_Selected = null;
            this.btnTaoBC.Iconimage_Selected = null;
            this.btnTaoBC.IconMarginLeft = 0;
            this.btnTaoBC.IconMarginRight = 0;
            this.btnTaoBC.IconRightVisible = true;
            this.btnTaoBC.IconRightZoom = 0D;
            this.btnTaoBC.IconVisible = true;
            this.btnTaoBC.IconZoom = 50D;
            this.btnTaoBC.IsTab = false;
            this.btnTaoBC.Location = new System.Drawing.Point(329, 3);
            this.btnTaoBC.Name = "btnTaoBC";
            this.btnTaoBC.Normalcolor = System.Drawing.Color.Maroon;
            this.btnTaoBC.OnHovercolor = System.Drawing.Color.Red;
            this.btnTaoBC.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTaoBC.selected = false;
            this.btnTaoBC.Size = new System.Drawing.Size(147, 35);
            this.btnTaoBC.TabIndex = 0;
            this.btnTaoBC.Text = "Tạo Báo Cáo";
            this.btnTaoBC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoBC.Textcolor = System.Drawing.Color.White;
            this.btnTaoBC.TextFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 83);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(779, 284);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frmBCTKTraTre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 408);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Name = "frmBCTKTraTre";
            this.Text = "Báo Cáo Thống Kê Sách Trả Trễ";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDatepicker dateNgayBC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnTaoBC;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}