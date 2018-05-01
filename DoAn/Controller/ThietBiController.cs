using System;
using System.IO;
using System.Security;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAcess;
using DevComponents.DotNetBar.Controls;

namespace Controller
{
    public class ThietBiController
    {
        ThietBiDataAccess thietbi = new ThietBiDataAccess();
        string employee = "Thuy";

        public void GetAllInfo(DataGridViewX data)
        {
            try
            {
                data.DataSource = thietbi.GetAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải thông tin Thiết bị");
            }
        }
        
        public void DataBingding̣(DataGridViewX data, TextBoxX txt_ma, TextBoxX txt_ten, TextBoxX txt_giatri, TextBoxX txt_ghichu)
        {
            try
            {
                txt_ma.Text = data.CurrentRow.Cells[0].Value.ToString();
                if (data.CurrentRow.Cells[1].Value == null)
                    txt_ten.Text = String.Empty;
                else
                    txt_ten.Text = data.CurrentRow.Cells[1].Value.ToString();
                if (data.CurrentRow.Cells[2].Value == null)
                    txt_giatri.Text = String.Empty;
                else
                    txt_giatri.Text = data.CurrentRow.Cells[2].Value.ToString();
                if (data.CurrentRow.Cells[5].Value == null)
                    txt_ghichu.Text = String.Empty;
                else
                    txt_ghichu.Text = data.CurrentRow.Cells[5].Value.ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error");
            }
            
        } 

        public void EnableTextBox(Control txt,bool giatri)
        {
            txt.Enabled = giatri;
        }

        public void InsertDevice(string ten, float giatri, string ghichu)
        {
            try
            {
                if (ten == String.Empty || giatri.ToString() == String.Empty)
                {
                    MessageBox.Show("Value not null or empty");
                    return;
                }
                if (thietbi.FindNameDevice(ten) == true)
                {
                    MessageBox.Show("Already exists name decive");
                    return;
                }
                BANGGIATHIETBI device = new BANGGIATHIETBI();
                device.TENLOAIVATCHAT = ten;
                device.GIATRIVATCHAT = giatri;
                device.THOIGIANTAO = DateTime.Now;
                device.TRANGTHAI = true;
                device.NHANVIENTAO = employee;
                device.GHICHU = ghichu;
                thietbi.InsertDevice(device);
                thietbi.SaveDevice();
            }
            catch
            {
                MessageBox.Show("Can't insert device because require property");
            }
        }

        public void DeleteDevice(int id)
        {
            try
            {
                if (id <0 ||id.ToString() == String.Empty)
                {
                    MessageBox.Show("IDLOAIVATCHAT not exists");
                    return;
                }
                BANGGIATHIETBI device = thietbi.FindDevice(id);
                if(device==null)
                {
                    MessageBox.Show("This device not exists");
                    return;
                }
                device.TRANGTHAI = false;
                thietbi.SaveDevice();
            }
            catch
            {
                MessageBox.Show("Can't delete this device");
            }
        }

        public void UpdateDevice(int id, string ten, float giatri, string ghichu)
        {
            try
            {
                
                BANGGIATHIETBI device = thietbi.FindDevice(id);
                if (device == null)
                {
                    MessageBox.Show("This device not exists");
                    return;
                }
                device.TENLOAIVATCHAT = ten;
                device.GIATRIVATCHAT = giatri;
                device.NHANVIENTAO = employee;
                device.THOIGIANTAO = DateTime.Now;
                device.GHICHU = ghichu;
                thietbi.SaveDevice();

            }
            catch
            {
                MessageBox.Show("Can't update infomation this device");
            }
        }
    }
}
