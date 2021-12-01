namespace QuanLyHocSinh
{
    partial class Form_TraCuuHocSinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_Tittle = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.GroupBox_DSHocSinh = new System.Windows.Forms.GroupBox();
            this.Panel_CoChu = new System.Windows.Forms.Panel();
            this.TrackBar_CoChu = new System.Windows.Forms.TrackBar();
            this.GridView_DSHocSinh = new System.Windows.Forms.DataGridView();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoThuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBHKI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBHKII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBox_Lop = new System.Windows.Forms.ComboBox();
            this.Label_Lop = new System.Windows.Forms.Label();
            this.ComboBox_NamHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_HoTen = new System.Windows.Forms.TextBox();
            this.Label_HoTen = new System.Windows.Forms.Label();
            this.ComboBox_KhoiLop = new System.Windows.Forms.ComboBox();
            this.Label_KhoiLop = new System.Windows.Forms.Label();
            this.Button_LocTheoLop = new System.Windows.Forms.Button();
            this.Panel_Tittle.SuspendLayout();
            this.GroupBox_DSHocSinh.SuspendLayout();
            this.Panel_CoChu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_CoChu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_DSHocSinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Tittle
            // 
            this.Panel_Tittle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel_Tittle.Controls.Add(this.Title);
            this.Panel_Tittle.Location = new System.Drawing.Point(366, 12);
            this.Panel_Tittle.Name = "Panel_Tittle";
            this.Panel_Tittle.Size = new System.Drawing.Size(497, 50);
            this.Panel_Tittle.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(108, 11);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(291, 29);
            this.Title.TabIndex = 0;
            this.Title.Text = "DANH SÁCH HỌC SINH";
            // 
            // GroupBox_DSHocSinh
            // 
            this.GroupBox_DSHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_DSHocSinh.Controls.Add(this.Panel_CoChu);
            this.GroupBox_DSHocSinh.Controls.Add(this.GridView_DSHocSinh);
            this.GroupBox_DSHocSinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_DSHocSinh.Location = new System.Drawing.Point(3, 148);
            this.GroupBox_DSHocSinh.Name = "GroupBox_DSHocSinh";
            this.GroupBox_DSHocSinh.Size = new System.Drawing.Size(1221, 514);
            this.GroupBox_DSHocSinh.TabIndex = 3;
            this.GroupBox_DSHocSinh.TabStop = false;
            this.GroupBox_DSHocSinh.Text = "Danh sách học sinh";
            // 
            // Panel_CoChu
            // 
            this.Panel_CoChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_CoChu.Controls.Add(this.TrackBar_CoChu);
            this.Panel_CoChu.Location = new System.Drawing.Point(1192, 25);
            this.Panel_CoChu.Name = "Panel_CoChu";
            this.Panel_CoChu.Size = new System.Drawing.Size(23, 483);
            this.Panel_CoChu.TabIndex = 4;
            // 
            // TrackBar_CoChu
            // 
            this.TrackBar_CoChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TrackBar_CoChu.Location = new System.Drawing.Point(0, 0);
            this.TrackBar_CoChu.Maximum = 100;
            this.TrackBar_CoChu.Minimum = 1;
            this.TrackBar_CoChu.Name = "TrackBar_CoChu";
            this.TrackBar_CoChu.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBar_CoChu.Size = new System.Drawing.Size(45, 480);
            this.TrackBar_CoChu.TabIndex = 3;
            this.TrackBar_CoChu.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBar_CoChu.Value = 1;
            // 
            // GridView_DSHocSinh
            // 
            this.GridView_DSHocSinh.AllowUserToAddRows = false;
            this.GridView_DSHocSinh.AllowUserToDeleteRows = false;
            this.GridView_DSHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView_DSHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_DSHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocSinh,
            this.SoThuTu,
            this.HoTen,
            this.TenLop,
            this.TBHKI,
            this.TBHKII});
            this.GridView_DSHocSinh.Location = new System.Drawing.Point(8, 25);
            this.GridView_DSHocSinh.Name = "GridView_DSHocSinh";
            this.GridView_DSHocSinh.ReadOnly = true;
            this.GridView_DSHocSinh.RowHeadersWidth = 62;
            this.GridView_DSHocSinh.Size = new System.Drawing.Size(1178, 483);
            this.GridView_DSHocSinh.TabIndex = 0;
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.DataPropertyName = "MaHocSinh";
            this.MaHocSinh.HeaderText = "Mã Học Sinh";
            this.MaHocSinh.MinimumWidth = 8;
            this.MaHocSinh.Name = "MaHocSinh";
            this.MaHocSinh.ReadOnly = true;
            this.MaHocSinh.Visible = false;
            this.MaHocSinh.Width = 150;
            // 
            // SoThuTu
            // 
            this.SoThuTu.DataPropertyName = "SoThuTu";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SoThuTu.DefaultCellStyle = dataGridViewCellStyle21;
            this.SoThuTu.HeaderText = "Số Thứ Tự";
            this.SoThuTu.MinimumWidth = 8;
            this.SoThuTu.Name = "SoThuTu";
            this.SoThuTu.ReadOnly = true;
            this.SoThuTu.Width = 150;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.HoTen.DefaultCellStyle = dataGridViewCellStyle22;
            this.HoTen.HeaderText = "Họ và Tên";
            this.HoTen.MinimumWidth = 8;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 150;
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TenLop.DefaultCellStyle = dataGridViewCellStyle23;
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.MinimumWidth = 8;
            this.TenLop.Name = "TenLop";
            this.TenLop.ReadOnly = true;
            this.TenLop.Width = 150;
            // 
            // TBHKI
            // 
            this.TBHKI.DataPropertyName = "TBHKI";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TBHKI.DefaultCellStyle = dataGridViewCellStyle24;
            this.TBHKI.HeaderText = "Trung bình HK1";
            this.TBHKI.MinimumWidth = 8;
            this.TBHKI.Name = "TBHKI";
            this.TBHKI.ReadOnly = true;
            this.TBHKI.Width = 150;
            // 
            // TBHKII
            // 
            this.TBHKII.DataPropertyName = "TBHKII";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TBHKII.DefaultCellStyle = dataGridViewCellStyle25;
            this.TBHKII.HeaderText = "Trung bình HK2";
            this.TBHKII.MinimumWidth = 8;
            this.TBHKII.Name = "TBHKII";
            this.TBHKII.ReadOnly = true;
            this.TBHKII.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Button_LocTheoLop);
            this.groupBox1.Controls.Add(this.ComboBox_KhoiLop);
            this.groupBox1.Controls.Add(this.Label_KhoiLop);
            this.groupBox1.Controls.Add(this.ComboBox_Lop);
            this.groupBox1.Controls.Add(this.Label_Lop);
            this.groupBox1.Controls.Add(this.ComboBox_NamHoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextBox_HoTen);
            this.groupBox1.Controls.Add(this.Label_HoTen);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1221, 65);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tra cứu";
            // 
            // ComboBox_Lop
            // 
            this.ComboBox_Lop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Lop.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.ComboBox_Lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Lop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Lop.FormattingEnabled = true;
            this.ComboBox_Lop.Location = new System.Drawing.Point(793, 20);
            this.ComboBox_Lop.Name = "ComboBox_Lop";
            this.ComboBox_Lop.Size = new System.Drawing.Size(144, 26);
            this.ComboBox_Lop.TabIndex = 5;
            // 
            // Label_Lop
            // 
            this.Label_Lop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Lop.AutoSize = true;
            this.Label_Lop.Location = new System.Drawing.Point(746, 23);
            this.Label_Lop.Name = "Label_Lop";
            this.Label_Lop.Size = new System.Drawing.Size(41, 18);
            this.Label_Lop.TabIndex = 4;
            this.Label_Lop.Text = "Lớp:";
            // 
            // ComboBox_NamHoc
            // 
            this.ComboBox_NamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_NamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_NamHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_NamHoc.FormattingEnabled = true;
            this.ComboBox_NamHoc.Location = new System.Drawing.Point(1025, 20);
            this.ComboBox_NamHoc.Name = "ComboBox_NamHoc";
            this.ComboBox_NamHoc.Size = new System.Drawing.Size(188, 26);
            this.ComboBox_NamHoc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(943, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Năm học:";
            // 
            // TextBox_HoTen
            // 
            this.TextBox_HoTen.Location = new System.Drawing.Point(93, 20);
            this.TextBox_HoTen.Name = "TextBox_HoTen";
            this.TextBox_HoTen.Size = new System.Drawing.Size(199, 26);
            this.TextBox_HoTen.TabIndex = 1;
            // 
            // Label_HoTen
            // 
            this.Label_HoTen.AutoSize = true;
            this.Label_HoTen.Location = new System.Drawing.Point(5, 27);
            this.Label_HoTen.Name = "Label_HoTen";
            this.Label_HoTen.Size = new System.Drawing.Size(82, 18);
            this.Label_HoTen.TabIndex = 0;
            this.Label_HoTen.Text = "Họ và Tên:";
            // 
            // ComboBox_KhoiLop
            // 
            this.ComboBox_KhoiLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_KhoiLop.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.ComboBox_KhoiLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_KhoiLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_KhoiLop.FormattingEnabled = true;
            this.ComboBox_KhoiLop.Location = new System.Drawing.Point(596, 20);
            this.ComboBox_KhoiLop.Name = "ComboBox_KhoiLop";
            this.ComboBox_KhoiLop.Size = new System.Drawing.Size(144, 26);
            this.ComboBox_KhoiLop.TabIndex = 7;
            // 
            // Label_KhoiLop
            // 
            this.Label_KhoiLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_KhoiLop.AutoSize = true;
            this.Label_KhoiLop.Location = new System.Drawing.Point(519, 23);
            this.Label_KhoiLop.Name = "Label_KhoiLop";
            this.Label_KhoiLop.Size = new System.Drawing.Size(71, 18);
            this.Label_KhoiLop.TabIndex = 6;
            this.Label_KhoiLop.Text = "Khối lớp:";
            // 
            // Button_LocTheoLop
            // 
            this.Button_LocTheoLop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Button_LocTheoLop.BackColor = System.Drawing.Color.RoyalBlue;
            this.Button_LocTheoLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_LocTheoLop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_LocTheoLop.Location = new System.Drawing.Point(298, 18);
            this.Button_LocTheoLop.Name = "Button_LocTheoLop";
            this.Button_LocTheoLop.Size = new System.Drawing.Size(124, 29);
            this.Button_LocTheoLop.TabIndex = 8;
            this.Button_LocTheoLop.Text = "Lọc theo lớp";
            this.Button_LocTheoLop.UseVisualStyleBackColor = false;
            this.Button_LocTheoLop.Click += new System.EventHandler(this.Button_LocTheoLop_Click);
            // 
            // Form_TraCuuHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1226, 663);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox_DSHocSinh);
            this.Controls.Add(this.Panel_Tittle);
            this.Name = "Form_TraCuuHocSinh";
            this.Text = "Form_TraCuuHocSinh";
            this.Panel_Tittle.ResumeLayout(false);
            this.Panel_Tittle.PerformLayout();
            this.GroupBox_DSHocSinh.ResumeLayout(false);
            this.Panel_CoChu.ResumeLayout(false);
            this.Panel_CoChu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_CoChu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_DSHocSinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Tittle;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox GroupBox_DSHocSinh;
        private System.Windows.Forms.DataGridView GridView_DSHocSinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBox_HoTen;
        private System.Windows.Forms.Label Label_HoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox_NamHoc;
        private System.Windows.Forms.ComboBox ComboBox_Lop;
        private System.Windows.Forms.Label Label_Lop;
        private System.Windows.Forms.Panel Panel_CoChu;
        private System.Windows.Forms.TrackBar TrackBar_CoChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoThuTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TBHKI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TBHKII;
        private System.Windows.Forms.ComboBox ComboBox_KhoiLop;
        private System.Windows.Forms.Label Label_KhoiLop;
        private System.Windows.Forms.Button Button_LocTheoLop;
    }
}