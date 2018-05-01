using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAcess;
using DevComponents.DotNetBar.Controls;

namespace Controller
{
    public class HistoryController
    {
        HistoryDataAccess history = new HistoryDataAccess();

        public void Load(DataGridViewX data, DateTime date1, DateTime date2)
        {
            try
            {
                if(date1>date2)
                {
                    MessageBox.Show("Select date again!!!");
                    return;
                }
                data.DataSource = history.LoadInfo(date1, date2);
            }
            catch
            {
                MessageBox.Show("Can't load info histoty app");
                return;
            }
            
        }

        //hàm dùng chung cho tất cả những nút ghi lại lịch sử sử dụng ứng dụng

        public void WriteHistory(string name, string content, string category, string kind, string note)
        {
            try
            {
                LICHSUHOATDONG WriteHistory = new LICHSUHOATDONG();
                WriteHistory.TENDANGNHAP = name;
                WriteHistory.THOIGIANTHAYDOI = DateTime.Now;
                WriteHistory.NOIDUNGTHAYDOI = content;
                WriteHistory.THELOAITHAYDOI = category;
                WriteHistory.THELOAITHAYDOI = kind;
                WriteHistory.GHICHU = note;
                WriteHistory.TRANGTHAI = true;
                history.InsertHistory(WriteHistory);
            }
            catch
            {
                MessageBox.Show("Can't write history this event");
            }
            
        }
    }
}
