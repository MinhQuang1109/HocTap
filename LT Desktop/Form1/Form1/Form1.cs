using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        List<String> listGioiTinh = new List<string>() { "Nam", "Nữ", "Không xác định" };
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboGioitinh.DataSource = listGioiTinh;
        }

        private void lbGioitinh_Click(object sender, EventArgs e)
        {
                
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban muon thoat chuong trinh", "Canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
           string hoten = txbHoten.Text;
           string diachi = txbDiachi.Text;

            if (kiemTraNhap())
            {
                XuLyOText.suaChuoi(ref hoten);
                XuLyOText.suaChuoi(ref diachi);

                txbThongtin.Text = "Ho ten: " + hoten + Environment.NewLine // Enviroment.NewLine: xuống dòng.
                                   + "Ngay sinh: " + dtpkNgaysinh.Value.ToShortDateString() + Environment.NewLine
                                   + "Gioi tinh: " + cboGioitinh.SelectedItem + Environment.NewLine
                                   + "Dia chi: " + diachi + Environment.NewLine
                                   + "CCCD: " + txbCCCD.Text;
            }

            //Xóa các ô textBox sau khi đã thực hiện lệnh nhập.
            foreach(var item in groupBox1.Controls)
            {
                TextBox item1 = item as TextBox;

                if(item1 != null)
                {
                    item1.Clear();
                }    
            }
            
            //Trả về ngày tháng năm hiện tại.
            dtpkNgaysinh.Value = DateTime.Now;
        }

        bool kiemTraNhap()
        {
            string cccd = txbCCCD.Text;
            long ketqua;
            char[] mangCCCD = cccd.ToCharArray(); 

            if (txbHoten.Text == "")
            {
                MessageBox.Show("Hay nhap ho ten!", "Thong bao");
                txbHoten.Focus();
                return false;
            }

            if (txbDiachi.Text == "")
            {
                MessageBox.Show("Hay nhap dia chi!", "Thong bao");
                txbDiachi.Focus();
                return false;
            }

            if (txbCCCD.Text == "")
            {
                MessageBox.Show("Hay nhap so CCCD!", "Thong bao");
                txbCCCD.Focus();
                return false;
            }
            

            if (!(long.TryParse(cccd, out ketqua))) 
            {
                MessageBox.Show("Hay nhap dung dinh dang CCCD", "Thong bao");
                txbCCCD.Focus();
                return false;
            }

            if (ketqua < 0)
            {
                MessageBox.Show("So CCCD khong duoc am", "Thong bao");
                txbCCCD.Focus();
                return false;
            }

            if (mangCCCD.Length != 12)
            {
                MessageBox.Show("Phai nhap dung du so CCCD", "Thong bao");
                txbCCCD.Focus();
                return false;
            }

            return true;
        }
    }
}
