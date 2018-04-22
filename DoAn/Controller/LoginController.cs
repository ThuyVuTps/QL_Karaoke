using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAcess;
using System.Windows.Forms;
using System.Net.Mail;

namespace Controller
{
    public class LoginController
    {
        LoginDataAcess log = new LoginDataAcess();
        public int kt_DangNhap(string user, string password)
        {
            if (!log.kt_Chuoi_Ket_Noi())
                return 1;
            if (log.kt_TaiKhoan(user, password) == 1)
                return 2;
            if (log.kt_TaiKhoan(user, password) == 2)
                return 3;
            return 4;
        }

        //lấy servername
        public void LoadServer(ComboBox cbo)
        {
            cbo.DataSource = log.LayServername();
            cbo.DisplayMember = "ServerName";
        }

        //get database

        public void LoadDB(ComboBox cbo, string name_server, string name_user, string name_pass)
        {
            cbo.DataSource = log.LayDataBase(name_server, name_user, name_pass);
            cbo.DisplayMember = "name";
        }

        //Lưu kết nối

        public void LuuKetNoi(string cbo_server, string cbo_data, string txt_user, string txt_pass)
        {
            log.LuuKetNoi(cbo_server, cbo_data, txt_user, txt_pass);
        }


        #region gửi mail
        public bool guiEmailQuenMatKhau(string username)
        {
            try
            {
                string from = "blacksaruman96@gmail.com";
                string to = "";
                UserInfoModel model = log.layEmailNguoiDung(username);
                if (string.IsNullOrEmpty(model.taikhoan))
                    return false;
                else
                    to = model.email;
                string subject = "[Quên Mật Khẩu] Phần mềm quản lý quán karaoke";
                string body = "Mật khẩu tài khoản của bạn là: " + model.matkhau;
                MailMessage msg = new MailMessage(from, to, subject, body);
                SmtpClient client = new SmtpClient("smtp.live.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("blacksaruman96@gmail.com", "tranngocanh96");
                client.EnableSsl = true;
                client.Send(msg);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}
