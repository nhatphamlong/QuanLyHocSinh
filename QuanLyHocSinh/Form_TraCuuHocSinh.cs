using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class Form_TraCuuHocSinh : Form
    {
        BUS_KhoiLop khoilop = new BUS_KhoiLop();
        BUS_HocSinh hocsinh = new BUS_HocSinh();
        BUS_NamHoc namhoc = new BUS_NamHoc();
        BUS_DanhSachLop danhsachlop = new BUS_DanhSachLop();

        bool locTheoLop = false;
        string currentNamHoc = "";
        string currentKhoiLop = "";
        string currentLop = "";

        public Form_TraCuuHocSinh()
        {
            InitializeComponent();

            init();

            LoadDanhSachKhoiLop();
            LoadDanhSachLop();
            LoadDanhSachNamHoc();
            LoadThongTin();
        }

        private void init()
        {
            TextBox_HoTen.TextChanged += TextBox_HoTen_TextChanged;

            TrackBar_CoChu.Value = int.Parse(GridView_DSHocSinh.Font.Size.ToString());
            TrackBar_CoChu.ValueChanged += TrackBar_CoChu_ValueChanged;

            Label_KhoiLop.Hide();
            ComboBox_KhoiLop.Hide();
            Label_Lop.Hide();
            ComboBox_Lop.Hide();
        }

        private void TrackBar_CoChu_ValueChanged(object sender, EventArgs e)
        {
            GridView_DSHocSinh.Font = new Font(GridView_DSHocSinh.Font.FontFamily.ToString(), TrackBar_CoChu.Value);
        }

        private void TextBox_HoTen_TextChanged(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        void LoadDanhSachKhoiLop()
        {
            DataTable temp = khoilop.GetTatCaKhoiLop();
            ComboBox_KhoiLop.DataSource = temp;
            ComboBox_KhoiLop.DisplayMember = "TenKhoiLop";
            ComboBox_KhoiLop.ValueMember = "MaKhoiLop";

            ComboBox_KhoiLop.SelectedValueChanged += ComboBox_KhoiLop_SelectedValueChanged;
        }

        private void ComboBox_KhoiLop_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDanhSachLop();
        }

        void LoadDanhSachLop()
        {
            currentKhoiLop = ComboBox_KhoiLop.SelectedValue.ToString();
            DataTable temp = danhsachlop.GetTatCaLopTrongKhoi(currentKhoiLop);
            ComboBox_Lop.DataSource = temp;
            ComboBox_Lop.DisplayMember = "TenLop";
            ComboBox_Lop.ValueMember = "MaLop";

            ComboBox_Lop.SelectedValueChanged += ComboBox_Lop_SelectedValueChanged;
        }

        private void ComboBox_Lop_SelectedValueChanged(object sender, EventArgs e)
        {
            currentLop = ComboBox_Lop.Text;
            LoadThongTin(currentLop);
        }

        void LoadDanhSachNamHoc()
        {
            DataTable temp = namhoc.GetTatCaNH();
            temp.Columns.Add("Full_NamHoc", typeof(string), "NamBD + ' - ' + NamKT");
            ComboBox_NamHoc.DataSource = temp;
            ComboBox_NamHoc.DisplayMember = "Full_NamHoc";
            ComboBox_NamHoc.ValueMember = "MaNamHoc";

            ComboBox_NamHoc.SelectedValueChanged += ComboBox_NamHoc_SelectedValueChanged;
        }

        private void ComboBox_NamHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            Button_LocTheoLop.Text = "Lọc theo lớp";
            locTheoLop = false;
            Label_KhoiLop.Hide();
            ComboBox_KhoiLop.Hide();
            Label_Lop.Hide();
            ComboBox_Lop.Hide();

            LoadThongTin();
        }

        private void LoadThongTin(string tenlop = null)
        {
            currentNamHoc = ComboBox_NamHoc.SelectedValue.ToString();

            DataTable temp = hocsinh.GetThongTinTraCuu(TextBox_HoTen.Text, currentNamHoc, tenlop);
            // Load Danh sach Hoc sinh
            GridView_DSHocSinh.DataSource = temp;
            GridView_DSHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_DSHocSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_DSHocSinh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GridView_DSHocSinh.RowHeadersVisible = false;
            GridView_DSHocSinh.ReadOnly = true;

            foreach (DataGridViewColumn column in GridView_DSHocSinh.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Edit theme
            GridView_DSHocSinh.BorderStyle = BorderStyle.FixedSingle;
            GridView_DSHocSinh.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView_DSHocSinh.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView_DSHocSinh.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            GridView_DSHocSinh.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView_DSHocSinh.BackgroundColor = Color.White;

            GridView_DSHocSinh.EnableHeadersVisualStyles = false;
            GridView_DSHocSinh.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            GridView_DSHocSinh.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GridView_DSHocSinh.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void Button_LocTheoLop_Click(object sender, EventArgs e)
        {
            if (locTheoLop == false)
            {
                Button_LocTheoLop.Text = "Hiển thị tất cả";
                locTheoLop = true;
                Label_KhoiLop.Show();
                ComboBox_KhoiLop.Show();
                Label_Lop.Show();
                ComboBox_Lop.Show();
                if (ComboBox_Lop.Text != "") ComboBox_Lop.SelectedIndex = 0;
                LoadThongTin(ComboBox_Lop.Text);
            }
            else
            {
                Button_LocTheoLop.Text = "Lọc theo lớp";
                locTheoLop = false;
                Label_KhoiLop.Hide();
                ComboBox_KhoiLop.Hide();
                Label_Lop.Hide();
                ComboBox_Lop.Hide();
                LoadThongTin();
            }
        }
    }
}
