using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DoAn
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmMain()
        {
            Thread t = new Thread(new ThreadStart(startForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        private void addTabItem1(string tabName, Form frmNew)
        {
            //////nếu ấn nút 'x' thì tắt tabItem
            ////foreach (TabItem tabPage in tabControl1.Tabs)
            ////{
            ////    if (tabPage.Text == tabName)
            ////    {
            ////        tabControl1.SelectedTab = tabPage;
            ////        return;
            ////    }
            ////}


            //Tạo tabItem mới
            TabItem tab = tabControl1.CreateTab(tabName);

            frmNew.Dock = DockStyle.Fill;
            frmNew.FormBorderStyle = FormBorderStyle.None;
            frmNew.TopLevel = false;
            tab.AttachedControl.Controls.Add(frmNew);
            frmNew.Tag = tabName;
            frmNew.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;


            //Thêm tabItem vào control

        }

        public void startForm()
        {
                Application.Run(new frmLoading());
            
        }

        private void btn_ThietBi_Click(object sender, EventArgs e)
        {
            //frmThietBi frmThietBi = new frmThietBi();
            //addTabItem1("Quản Lý thiết bị", frmThietBi);
            frmThietBi frm = new frmThietBi();
            addTabItem1("Quản lý thiết bị", frm);
        }

        private void btn_lichsu_Click(object sender, EventArgs e)
        {
            frmLichSuHoatDong frmLichSu = new frmLichSuHoatDong();
            addTabItem1("Lịch sử hoạt động", frmLichSu);
        }
    }
}
