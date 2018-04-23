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

        public void startForm()
        {
            Application.Run(new frmLoading());
        }

        private void btn_ThietBi_Click(object sender, EventArgs e)
        {
            frmThietBi frmThietBi = new frmThietBi();
            frmThietBi.ShowDialog();
        }
    }
}
