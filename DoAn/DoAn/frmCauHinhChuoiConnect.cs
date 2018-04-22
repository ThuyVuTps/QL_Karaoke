using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace DoAn
{
    public partial class frmCauHinhChuoiConnect : Form
    {
        public frmCauHinhChuoiConnect()
        {
            InitializeComponent();
        }

        // khai báo lớp
        LoginController log = new LoginController();
        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Cảnh Báo", "Bạn có muốn thoát?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d != DialogResult.No)
                this.Close();
        }
        void loadCbo_serverName()// kết nối server
        {
            log.LoadServer(cboServerName);
        }
        //dùng đồ dữ liệu từ dataTable vào combobox
        public void loaddata2(string name_server, string name_user, string name_pass)
        {

            log.LoadDB(cboDatabase, name_server, name_user, name_pass);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            log.LuuKetNoi(cboServerName.Text, cboDatabase.Text, txtUser.Text, txtPassword.Text);
            frmDangNhap dn = new frmDangNhap();
            this.Hide();
            dn.ShowDialog();
            this.Close();
        }

        private void cboDatabase_DropDown(object sender, EventArgs e)
        {
            //kiểm tra các textbox và load thông tin lên
            if (cboServerName.Text != "" && txtUser.Text != "" && txtPassword.Text != "")
            {
                loaddata2(cboServerName.Text, txtUser.Text, txtPassword.Text);
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin yêu cầu");
            }
        }

        private void cboServerName_DropDown(object sender, EventArgs e)
        {
            loadCbo_serverName();
        }
    }
}
