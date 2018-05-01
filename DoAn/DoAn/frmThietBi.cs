using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Controller;
using DevComponents.DotNetBar.Controls;

namespace DoAn
{
    public partial class frmThietBi : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmThietBi()
        {
            InitializeComponent();
        }
        ThietBiController thietBi = new ThietBiController();
        HistoryController history = new HistoryController();
        int flag = 0;
        string employee = "Thuy";

        public void LoadAll()
        {
            thietBi.GetAllInfo(data_thietBi);
            thietBi.EnableTextBox(txt_maThietBi,false);
            thietBi.EnableTextBox(txt_tenThietBi,false);
            thietBi.EnableTextBox(txt_giaTri,false);
            thietBi.EnableTextBox(txt_ghiChu,false);
            thietBi.EnableTextBox(btn_luu, false);
            thietBi.EnableTextBox(btn_them, true);
            thietBi.EnableTextBox(btn_xoa, true);
            thietBi.EnableTextBox(btn_sua, true);
        }

        private void frmThietBi_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void data_thietBi_SelectionChanged(object sender, EventArgs e)
        {
            thietBi.DataBingding̣(data_thietBi, txt_maThietBi, txt_tenThietBi, txt_giaTri, txt_ghiChu);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                flag = 1;
                thietBi.EnableTextBox(txt_maThietBi,false);
                thietBi.EnableTextBox(txt_tenThietBi,true);
                thietBi.EnableTextBox(txt_giaTri,true);
                thietBi.EnableTextBox(txt_ghiChu,true);
                txt_maThietBi.Text = String.Empty;
                txt_tenThietBi.Text = String.Empty;
                txt_giaTri.Text = String.Empty;
                txt_ghiChu.Text = String.Empty;
                thietBi.EnableTextBox(btn_luu, true);
                thietBi.EnableTextBox(btn_them, false);
                thietBi.EnableTextBox(btn_xoa, false);
                thietBi.EnableTextBox(btn_sua, false);
            }
            catch
            {
                MessageBox.Show("Can't insert");
            }
            
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == 1)
                {
                    float giatri = float.Parse(txt_giaTri.Text);
                    history.WriteHistory(employee, "Insert a device", "BANG GIA THIET BI", "Insert", "");
                    thietBi.InsertDevice(txt_tenThietBi.Text, giatri, txt_ghiChu.Text);
                    LoadAll();
                    flag = 0;
                }
                if (flag == 2)
                {

                    
                    int id = int.Parse(data_thietBi.CurrentRow.Cells[0].Value.ToString());
                    if (txt_tenThietBi.Text == String.Empty || txt_giaTri.Text == String.Empty)
                    {
                        MessageBox.Show("Value not null or empty or GIATRI is Integer");
                        return;
                    }
                    if (id < 0 || id.ToString() == String.Empty)
                    {
                        MessageBox.Show("IDLOAIVATCHAT not exists");
                        return;
                    }
                    float giatri = float.Parse(txt_giaTri.Text);
                    if (giatri < 0)
                    {
                        MessageBox.Show("GIATRI elder 0");
                        return;
                    }
                    history.WriteHistory(employee, "Update a device Name ="+txt_tenThietBi.Text, "BANG GIA THIET BI", "Update", "");
                    thietBi.UpdateDevice(id, txt_tenThietBi.Text, giatri, txt_ghiChu.Text);
                    flag = 0;
                    LoadAll();
                }
                thietBi.DataBingding̣(data_thietBi, txt_maThietBi, txt_tenThietBi, txt_giaTri, txt_ghiChu);
                thietBi.EnableTextBox(txt_tenThietBi, false);
                thietBi.EnableTextBox(txt_giaTri, false);
                thietBi.EnableTextBox(txt_ghiChu, false);
                thietBi.EnableTextBox(btn_luu, false);
                thietBi.EnableTextBox(btn_them, true);
                thietBi.EnableTextBox(btn_xoa, true);
                thietBi.EnableTextBox(btn_sua, true);
            }
            catch
            {
                MessageBox.Show("Save not susscess");
                thietBi.DataBingding̣(data_thietBi, txt_maThietBi, txt_tenThietBi, txt_giaTri, txt_ghiChu);
                thietBi.EnableTextBox(txt_tenThietBi, false);
                thietBi.EnableTextBox(txt_giaTri, false);
                thietBi.EnableTextBox(txt_ghiChu, false);
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(data_thietBi.CurrentRow.Cells[0].Value.ToString());
            if (id < 0 || id.ToString() == String.Empty)
            {
                MessageBox.Show("IDLOAIVATCHAT not exists");
                return;
            }
            history.WriteHistory(employee, "Delete a device Id=" + id, "BANG GIA THIET BI", "Delete", "");
            thietBi.DeleteDevice(id);
            //truyen vao 5 gia tri
            
            LoadAll();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                flag = 2;
                thietBi.EnableTextBox(txt_maThietBi, false);
                thietBi.EnableTextBox(txt_tenThietBi, true);
                thietBi.EnableTextBox(txt_giaTri, true);
                thietBi.EnableTextBox(txt_ghiChu, true);
                thietBi.EnableTextBox(btn_luu, true);
                thietBi.EnableTextBox(btn_them, false);
                thietBi.EnableTextBox(btn_xoa, false);
                thietBi.EnableTextBox(btn_sua, false);

            }
            catch
            {
                MessageBox.Show("can't update this device");
            }
            
        }
    }
}
