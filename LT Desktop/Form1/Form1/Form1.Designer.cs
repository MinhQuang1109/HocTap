
namespace Form1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.cboGioitinh = new System.Windows.Forms.ComboBox();
            this.dtpkNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txbCCCD = new System.Windows.Forms.TextBox();
            this.txbDiachi = new System.Windows.Forms.TextBox();
            this.txbHoten = new System.Windows.Forms.TextBox();
            this.lbGioitinh = new System.Windows.Forms.Label();
            this.lbDiachi = new System.Windows.Forms.Label();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbCCCD = new System.Windows.Forms.Label();
            this.txbThongtin = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnNhap);
            this.groupBox1.Controls.Add(this.cboGioitinh);
            this.groupBox1.Controls.Add(this.dtpkNgaysinh);
            this.groupBox1.Controls.Add(this.txbCCCD);
            this.groupBox1.Controls.Add(this.txbDiachi);
            this.groupBox1.Controls.Add(this.txbHoten);
            this.groupBox1.Controls.Add(this.lbGioitinh);
            this.groupBox1.Controls.Add(this.lbDiachi);
            this.groupBox1.Controls.Add(this.lbNgaysinh);
            this.groupBox1.Controls.Add(this.lbHoTen);
            this.groupBox1.Controls.Add(this.lbCCCD);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(228, 209);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(99, 204);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(77, 28);
            this.btnNhap.TabIndex = 10;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // cboGioitinh
            // 
            this.cboGioitinh.FormattingEnabled = true;
            this.cboGioitinh.Location = new System.Drawing.Point(299, 178);
            this.cboGioitinh.Name = "cboGioitinh";
            this.cboGioitinh.Size = new System.Drawing.Size(110, 24);
            this.cboGioitinh.TabIndex = 9;
            // 
            // dtpkNgaysinh
            // 
            this.dtpkNgaysinh.Location = new System.Drawing.Point(101, 78);
            this.dtpkNgaysinh.Name = "dtpkNgaysinh";
            this.dtpkNgaysinh.Size = new System.Drawing.Size(308, 22);
            this.dtpkNgaysinh.TabIndex = 8;
            // 
            // txbCCCD
            // 
            this.txbCCCD.Location = new System.Drawing.Point(99, 176);
            this.txbCCCD.Name = "txbCCCD";
            this.txbCCCD.Size = new System.Drawing.Size(110, 22);
            this.txbCCCD.TabIndex = 7;
            // 
            // txbDiachi
            // 
            this.txbDiachi.Location = new System.Drawing.Point(99, 120);
            this.txbDiachi.Name = "txbDiachi";
            this.txbDiachi.Size = new System.Drawing.Size(310, 22);
            this.txbDiachi.TabIndex = 6;
            this.txbDiachi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txbHoten
            // 
            this.txbHoten.Location = new System.Drawing.Point(99, 34);
            this.txbHoten.Name = "txbHoten";
            this.txbHoten.Size = new System.Drawing.Size(310, 22);
            this.txbHoten.TabIndex = 5;
            this.txbHoten.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbGioitinh
            // 
            this.lbGioitinh.AutoSize = true;
            this.lbGioitinh.Location = new System.Drawing.Point(225, 181);
            this.lbGioitinh.Name = "lbGioitinh";
            this.lbGioitinh.Size = new System.Drawing.Size(68, 17);
            this.lbGioitinh.TabIndex = 4;
            this.lbGioitinh.Text = "Giới tính: ";
            this.lbGioitinh.Click += new System.EventHandler(this.lbGioitinh_Click);
            // 
            // lbDiachi
            // 
            this.lbDiachi.AutoSize = true;
            this.lbDiachi.Location = new System.Drawing.Point(15, 125);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(59, 17);
            this.lbDiachi.TabIndex = 2;
            this.lbDiachi.Text = "Địa chỉ: ";
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Location = new System.Drawing.Point(15, 84);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(79, 17);
            this.lbNgaysinh.TabIndex = 1;
            this.lbNgaysinh.Text = "Ngày sinh: ";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(15, 39);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(54, 17);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ tên:";
            // 
            // lbCCCD
            // 
            this.lbCCCD.AutoSize = true;
            this.lbCCCD.Location = new System.Drawing.Point(15, 176);
            this.lbCCCD.Name = "lbCCCD";
            this.lbCCCD.Size = new System.Drawing.Size(53, 17);
            this.lbCCCD.TabIndex = 3;
            this.lbCCCD.Text = "CCCD: ";
            this.lbCCCD.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbThongtin
            // 
            this.txbThongtin.Location = new System.Drawing.Point(12, 256);
            this.txbThongtin.Multiline = true;
            this.txbThongtin.Name = "txbThongtin";
            this.txbThongtin.ReadOnly = true;
            this.txbThongtin.Size = new System.Drawing.Size(451, 166);
            this.txbThongtin.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.txbThongtin);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbGioitinh;
        private System.Windows.Forms.Label lbDiachi;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbCCCD;
        private System.Windows.Forms.TextBox txbThongtin;
        private System.Windows.Forms.TextBox txbCCCD;
        private System.Windows.Forms.TextBox txbDiachi;
        private System.Windows.Forms.TextBox txbHoten;
        private System.Windows.Forms.DateTimePicker dtpkNgaysinh;
        private System.Windows.Forms.ComboBox cboGioitinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNhap;
    }
}

