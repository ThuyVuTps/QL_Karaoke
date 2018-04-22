using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Linq;

namespace DataAcess
{
    public class LoginDataAcess
    {
        QL_KaraokeDataContext ql = new QL_KaraokeDataContext(DataAcess.Properties.Settings.Default.QL_karaConnectionString.ToString());

        public Session session = new Session();
        UserInfoModel model = new UserInfoModel();

        #region Kiểm tra đăng nhập
        public bool kt_Chuoi_Ket_Noi()
        {
            //SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_karaConnectionString"].ConnectionString);
            SqlConnection connect = new SqlConnection(DataAcess.Properties.Settings.Default.QL_karaConnectionString.ToString());
            if (string.IsNullOrEmpty(connect.ToString()))
                return false;
            try
            {
                if (connect.State == System.Data.ConnectionState.Closed)
                    connect.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int kt_TaiKhoan(string user, string password)
        {
            var db = (from nd in ql.NGUOIDUNGs
                      from ndnnd in ql.QL_NGUOIDUNG_NHOMNGUOIDUNGs
                      from pq in ql.PHANQUYENs
                      from nnd in ql.QL_NHOMNGUOIDUNGs
                      where nd.TENDANGNHAP == ndnnd.TENDANGNHAP && ndnnd.MANHOMNGUOIDUNG == pq.MANHOMNGUOIDUNG 
                            && nnd.MANHOMNGUOIDUNG == pq.MANHOMNGUOIDUNG &&
                            nd.TENDANGNHAP == user && nd.MATKHAU == password
                      select new
                      {
                         nd.TENDANGNHAP,
                         nd.IDNHANVIEN,
                         pq.COQUYEN,
                         nnd.TENNHOMNGUOIDUNG,
                         nd.HOATDONG
                      }).FirstOrDefault();
            if (db == null)
                return 1;
            if (db.HOATDONG == false)
                return 2;
            session.UserName = db.TENDANGNHAP;
            session.Permision = db.TENNHOMNGUOIDUNG;
            return 3;
        }

        public UserInfoModel  layEmailNguoiDung(string username)
        {
            var db = (from nd in ql.NGUOIDUNGs
                      from nv in ql.THONGTINNHANVIENs
                      where nd.IDNHANVIEN == nv.IDNHANVIEN && nd.TENDANGNHAP == username
                      select new UserInfoModel { email = nv.EMAIL, matkhau = nd.MATKHAU , taikhoan = nd.TENDANGNHAP}).FirstOrDefault();
            return db;
        }


        #endregion

        #region Kiểm tra kết nối
        SqlConnection conn;
        //getservername
        public DataTable LayServername()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable table = instance.GetDataSources();

            return table;
        }

        //lấy tên database
        public DataTable LayDataBase(string name_server, string name_user, string name_pass)
        {
            DataTable dt = new DataTable();

            string a = "Data Source=" + name_server + "\\SQLEXPRESS;Initial Catalog=master;User ID=" + name_user + ";Password=" + name_pass;
            conn = new SqlConnection(a);
            //Data Source=DESKTOP-UTKBS21\SQLEXPRESS;Initial Catalog=master;User ID=sa
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.databases", conn);
            da.Fill(dt);
            return dt;
        }

        //lưu chuỗi kết nối
        public void LuuKetNoi(string cbo_server, string cbo_data, string txt_user, string txt_pass)
        {
            DataAcess.Properties.Settings.Default.QL_karaConnectionString = "Data Source= " + cbo_server + "\\SQLEXPRESS;Initial Catalog=" + cbo_data + ";Persist Security Info=True;User ID=" + txt_user + "; Password=" + txt_pass;
            DataAcess.Properties.Settings.Default.Save();
        }
        #endregion
    }
}
