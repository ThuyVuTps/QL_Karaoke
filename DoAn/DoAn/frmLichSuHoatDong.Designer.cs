namespace DoAn
{
    partial class frmLichSuHoatDong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.date_Start = new System.Windows.Forms.DateTimePicker();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.lblTu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Loc = new DevComponents.DotNetBar.ButtonX();
            this.data_history = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_history)).BeginInit();
            this.SuspendLayout();
            // 
            // date_Start
            // 
            this.date_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.date_Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Start.Location = new System.Drawing.Point(68, 36);
            this.date_Start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_Start.Name = "date_Start";
            this.date_Start.Size = new System.Drawing.Size(179, 23);
            this.date_Start.TabIndex = 5;
            this.date_Start.Value = new System.DateTime(2018, 4, 1, 14, 44, 42, 0);
            this.date_Start.ValueChanged += new System.EventHandler(this.dtpBatDau_ValueChanged);
            // 
            // date_end
            // 
            this.date_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.date_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_end.Location = new System.Drawing.Point(337, 36);
            this.date_end.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(183, 23);
            this.date_end.TabIndex = 6;
            this.date_end.Value = new System.DateTime(2018, 4, 1, 14, 44, 42, 0);
            this.date_end.ValueChanged += new System.EventHandler(this.date_end_ValueChanged);
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.BackColor = System.Drawing.Color.Transparent;
            this.lblTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTu.Location = new System.Drawing.Point(24, 36);
            this.lblTu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(27, 18);
            this.lblTu.TabIndex = 7;
            this.lblTu.Text = "Từ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(279, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đến";
            // 
            // btn_Loc
            // 
            this.btn_Loc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Loc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Loc.Location = new System.Drawing.Point(612, 15);
            this.btn_Loc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(147, 49);
            this.btn_Loc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btn_Loc.TabIndex = 9;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // data_history
            // 
            this.data_history.AllowUserToAddRows = false;
            this.data_history.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_history.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_history.DefaultCellStyle = dataGridViewCellStyle1;
            this.data_history.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_history.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.data_history.Location = new System.Drawing.Point(0, 71);
            this.data_history.Name = "data_history";
            this.data_history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_history.Size = new System.Drawing.Size(843, 443);
            this.data_history.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDHOADONG";
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENDANGNHAP";
            this.Column2.HeaderText = "Tên đăng nhập";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "THOIGIANTHAYDOI";
            this.Column3.HeaderText = "Thời gian thay đổi";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NOIDUNGTHAYDOI";
            this.Column4.HeaderText = "Nội dung thay đổi";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DANHMUCTHAYDOI";
            this.Column5.HeaderText = "Danh mục thay đổi";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "THELOAITHAYDOI";
            this.Column6.HeaderText = "Thể loại thay đổi";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "GHICHU";
            this.Column7.HeaderText = "Ghi chú";
            this.Column7.Name = "Column7";
            // 
            // frmLichSuHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 514);
            this.Controls.Add(this.data_history);
            this.Controls.Add(this.btn_Loc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.date_end);
            this.Controls.Add(this.date_Start);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLichSuHoatDong";
            this.Text = "Lịch Sử Hoạt Động";
            this.Load += new System.EventHandler(this.frmLichSuHoatDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_history)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker date_Start;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btn_Loc;
        private DevComponents.DotNetBar.Controls.DataGridViewX data_history;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}