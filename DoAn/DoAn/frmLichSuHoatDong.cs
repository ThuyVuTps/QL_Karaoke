using DevComponents.DotNetBar.Controls;
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
    public partial class frmLichSuHoatDong : Form
    {
        public frmLichSuHoatDong()
        {
            InitializeComponent();
        }
        HistoryController history = new HistoryController();

        private void dtpBatDau_ValueChanged(object sender, EventArgs e)
        {
            history.Load(data_history, date_Start.Value, date_end.Value);
        }

        private void date_end_ValueChanged(object sender, EventArgs e)
        {
            history.Load(data_history, date_Start.Value, date_end.Value);
        }

        private void frmLichSuHoatDong_Load(object sender, EventArgs e)
        {
            history.Load(data_history, date_Start.Value, date_end.Value);
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            history.Load(data_history, date_Start.Value, date_end.Value);
        }
    }
}
