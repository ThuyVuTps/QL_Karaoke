using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class HistoryDataAccess
    {
        QL_KaraokeDataContext data = new QL_KaraokeDataContext(DataAcess.Properties.Settings.Default.QL_karaConnectionString);

        //load data
        public IQueryable LoadInfo(DateTime date1, DateTime date2)
        {
            var history = from ls in data.LICHSUHOATDONGs
                          where ls.TRANGTHAI == true && ls.THOIGIANTHAYDOI >= date1 && ls.THOIGIANTHAYDOI <= date2
                          select new
                          {
                              ls.IDHOADONG,
                              ls.TENDANGNHAP,
                              ls.THOIGIANTHAYDOI,
                              ls.NOIDUNGTHAYDOI,
                              ls.DANHMUCTHAYDOI,
                              ls.THELOAITHAYDOI,
                              ls.GHICHU
                          };
            return history;
        }

        public void InsertHistory(LICHSUHOATDONG history)
        {
            data.LICHSUHOATDONGs.InsertOnSubmit(history);
            data.SubmitChanges();
        }
    }
}
