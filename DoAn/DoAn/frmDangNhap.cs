using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Controller;
using System.Configuration;

namespace DoAn
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        // khai báo class
        LoginController login = new LoginController();

        // khai báo biến
        //SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_karaConnectionString"].ConnectionString);


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show("Tài khoản không được để trống","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.Focus();
                return;
            }
            if(string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return;
            }
            int flag = login.kt_DangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
            if (flag == 4)
            {
                //MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                frmTrangChu frm = new frmTrangChu();
                frm.ShowDialog();
                this.Close();
            }
            else if(flag == 1)
            {
                MessageBox.Show("Chuối kết nối không đúng, cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                frmCauHinhChuoiConnect frm = new frmCauHinhChuoiConnect();
                frm.ShowDialog();
            }
            else if(flag == 2)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else if(flag == 3)
            {
                MessageBox.Show("Tài khoản này đã bị khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show("Bạn phải nhập vào tên tài khoản cần lấy lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(login.guiEmailQuenMatKhau(txtTaiKhoan.Text))
                MessageBox.Show("Mật khẩu đã được gửi đến email mà bạn đăng ký tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Tài khoản này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
