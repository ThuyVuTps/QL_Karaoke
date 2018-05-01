using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class ThietBiDataAccess
    {
        QL_KaraokeDataContext data = new QL_KaraokeDataContext(DataAcess.Properties.Settings.Default.QL_karaConnectionString);

        //select toàn bộ giá trị
        public IQueryable GetAllData()
        {
            var thietBi = from tb in data.BANGGIATHIETBIs
                          where tb.TRANGTHAI == true
                          select new { tb.IDLOAIVATCHAT, tb.TENLOAIVATCHAT, tb.GIATRIVATCHAT, tb.NHANVIENTAO, tb.THOIGIANTAO, tb.GHICHU };
            return thietBi;
        }

        //insert thiet bi
        public void InsertDevice(BANGGIATHIETBI device)
        {
            data.BANGGIATHIETBIs.InsertOnSubmit(device);
        }

        public void SaveDevice()
        {
            data.SubmitChanges();
        }

        public bool FindNameDevice(string name)
        {
            var countNameDevice = data.BANGGIATHIETBIs.Where(n => n.TENLOAIVATCHAT == name && n.TRANGTHAI == true).Count();
            if (countNameDevice != 0)
                return true;
            else
                return false;
        }

        public BANGGIATHIETBI FindDevice(int id)
        {
            var device = data.BANGGIATHIETBIs.Where(d => d.IDLOAIVATCHAT == id && d.TRANGTHAI == true).FirstOrDefault();
            return device;
        }
    }
}
