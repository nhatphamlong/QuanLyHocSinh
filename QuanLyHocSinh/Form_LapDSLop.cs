using BUS;
using DTO;
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
    public partial class Form_LapDSLop : Form
    {
        BUS_KhoiLop khoilop = new BUS_KhoiLop();
        BUS_DanhSachLop danhsachlop = new BUS_DanhSachLop();
        BUS_HocSinh hocsinh = new BUS_HocSinh();
        BUS_HocKy hocky = new BUS_HocKy();
        BUS_NamHoc namhoc = new BUS_NamHoc();
        BUS_ThamSo thamso = new BUS_ThamSo();

        ThamSo listThamSo = new ThamSo();

        string currentKhoiLop = "";
        string currentLop = "";
        string currentHocKy = "";
        string currentNamHoc = "";
        string currentHSLop = "";
        string currentHSCho = "";

        public Form_LapDSLop()
        {
            InitializeComponent();

            init();

            LoadDanhSachKhoiLop();
            LoadDanhSachLop();
            LoadDanhSachHocKy();
            LoadDanhSachNamHoc();
            LoadDanhSachHocSinh();
            LoadHocSinhCho();
        }

        void init()
        {
            listThamSo = thamso.GetThamSo();

            DateTimePicker_NgaySinhKT.MaxDate = DateTime.Today.AddYears(-listThamSo.TuoiToiThieu);

            DateTimePicker_NgaySinhBD.MaxDate = DateTimePicker_NgaySinhKT.Value;
            DateTimePicker_NgaySinhKT.MinDate = DateTimePicker_NgaySinhBD.Value;

            DateTimePicker_NgaySinhBD.ValueChanged += DateTimePicker_NgaySinhBD_ValueChanged;
            DateTimePicker_NgaySinhKT.ValueChanged += DateTimePicker_NgaySinhKT_ValueChanged;

            TrackBar_CoChu_Lop.Value = int.Parse(GridView_DSLop.Font.Size.ToString());
            TrackBar_CoChu_Lop.ValueChanged += TrackBar_CoChu_Lop_ValueChanged;

            TrackBar_CoChu_Cho.Value = int.Parse(GridView_DSCho.Font.Size.ToString());
            TrackBar_CoChu_Cho.ValueChanged += TrackBar_CoChu_Cho_ValueChanged;
        }

        private void TrackBar_CoChu_Cho_ValueChanged(object sender, EventArgs e)
        {
            GridView_DSCho.Font = new Font(GridView_DSCho.Font.FontFamily.ToString(), TrackBar_CoChu_Cho.Value);
        }

        private void TrackBar_CoChu_Lop_ValueChanged(object sender, EventArgs e)
        {
            GridView_DSLop.Font = new Font(GridView_DSLop.Font.FontFamily.ToString(), TrackBar_CoChu_Lop.Value);
        }

        private void DateTimePicker_NgaySinhKT_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker_NgaySinhBD.MaxDate = DateTimePicker_NgaySinhKT.Value;
            DateTimePicker_NgaySinhKT.MinDate = DateTimePicker_NgaySinhBD.Value;
        }

        private void DateTimePicker_NgaySinhBD_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker_NgaySinhBD.MaxDate = DateTimePicker_NgaySinhKT.Value;
            DateTimePicker_NgaySinhKT.MinDate = DateTimePicker_NgaySinhBD.Value;
        }

        private void LoadDanhSachKhoiLop()
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
            //Console.WriteLine(currentLop);
            LoadDanhSachHocSinh();
            LoadHocSinhCho();
        }

        void LoadDanhSachHocKy()
        {
            ComboBox_HocKy.DataSource = hocky.GetTatCaHK();
            ComboBox_HocKy.DisplayMember = "TenHocKy";
            ComboBox_HocKy.ValueMember = "MaHocKy";

            ComboBox_HocKy.SelectedValueChanged += ComboBox_HocKy_SelectedValueChanged;
        }

        private void ComboBox_HocKy_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDanhSachHocSinh();
            LoadHocSinhCho();
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
            LoadDanhSachHocSinh();
            LoadHocSinhCho();
        }

        void LoadDanhSachHocSinh()
        {
            currentLop = ComboBox_Lop.SelectedValue.ToString();
            currentHocKy = ComboBox_HocKy.SelectedValue.ToString();
            currentNamHoc = ComboBox_NamHoc.SelectedValue.ToString();

            if (currentLop == "" | currentHocKy == "" | currentNamHoc == "")
            {
                GridView_DSLop.DataSource = null;
                return;
            }
            DataTable temp = hocsinh.GetHocSinh(currentLop, currentHocKy, currentNamHoc);
            temp.Columns.Add("GT", typeof(string));
            temp.Columns.Add("SoThuTu", typeof(int));
            temp.Columns.Add("NS", typeof(string));

            int stt = 1;
            foreach(DataRow row in temp.Rows)
            {
                row["SoThuTu"] = stt;
                stt++;

                DateTime ns = DateTime.Parse(row["NgaySinh"].ToString());
                row["NS"] = ns.ToShortDateString();

                if (row["GioiTinh"].ToString() == "True")
                    row["GT"] = "Nam";
                else
                    row["GT"] = "Nữ";
            }

            foreach (DataGridViewColumn column in GridView_DSLop.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            GridView_DSLop.DataSource = temp;
            GridView_DSLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_DSLop.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridView_DSLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_DSLop.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GridView_DSLop.RowHeadersVisible = false;
            GridView_DSLop.ReadOnly = true;
            GridView_DSLop.ClearSelection();

            TextBox_SiSo.Text = danhsachlop.GetSiSo(currentLop, currentHocKy, currentNamHoc).ToString() + " / " + listThamSo.SiSoToiDa;

            GridView_DSLop.CellClick += GridView_DSLop_CellClick;

            // Edit theme
            GridView_DSLop.BorderStyle = BorderStyle.FixedSingle;
            GridView_DSLop.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView_DSLop.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView_DSLop.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            GridView_DSLop.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView_DSLop.BackgroundColor = Color.White;

            GridView_DSLop.EnableHeadersVisualStyles = false;
            GridView_DSLop.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            GridView_DSLop.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GridView_DSLop.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void GridView_DSLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridView_DSLop.Rows[e.RowIndex];
                currentHSLop = row.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        void LoadHocSinhCho()
        {
            currentHocKy = ComboBox_HocKy.SelectedValue.ToString();
            currentNamHoc = ComboBox_NamHoc.SelectedValue.ToString();

            if (currentHocKy == "" || currentNamHoc == "")
            {
                GridView_DSCho.DataSource = null;
                return;
            }

            DataTable temp = hocsinh.GetHocSinhCho(currentHocKy, currentNamHoc);
            temp.Columns.Add("GT", typeof(string));
            temp.Columns.Add("SoThuTu", typeof(int));

            int stt = 1;
            foreach (DataRow row in temp.Rows)
            {
                row["SoThuTu"] = stt;
                stt++;

                if (row["GioiTinh"].ToString() == "True")
                    row["GT"] = "Nam";
                else
                    row["GT"] = "Nữ";
            }

            foreach (DataGridViewColumn column in GridView_DSCho.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            GridView_DSCho.DataSource = temp;
            GridView_DSCho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_DSCho.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridView_DSCho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_DSCho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GridView_DSCho.RowHeadersVisible = false;
            GridView_DSCho.ReadOnly = true;
            GridView_DSCho.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            GridView_DSCho.CellClick += GridView_DSCho_CellClick;

            // Edit theme
            GridView_DSCho.BorderStyle = BorderStyle.FixedSingle;
            GridView_DSCho.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView_DSCho.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView_DSCho.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            GridView_DSCho.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView_DSCho.BackgroundColor = Color.White;

            GridView_DSCho.EnableHeadersVisualStyles = false;
            GridView_DSCho.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            GridView_DSCho.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GridView_DSCho.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void GridView_DSCho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridView_DSCho.Rows[e.RowIndex];
                currentHSCho = row.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        
        private void Button_Them_Click(object sender, EventArgs e)
        {
            if (currentHSCho == "")
            {
                MessageBox.Show("Vui lòng chọn học sinh để tiếp tục!", "Chưa chọn học sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.Parse(TextBox_SiSo.Text.Substring(0, TextBox_SiSo.Text.IndexOf(' ') + 1)) < listThamSo.SiSoToiDa)
            {
                int? result = hocsinh.AddHocSinhVaoLop(currentHSCho, currentLop, currentHocKy, currentNamHoc);
                if (result == 1)
                {
                    MessageBox.Show("Dữ liệu đã được cập nhật", "Thêm thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  
            else
            {
                MessageBox.Show("Lớp đã đạt sĩ số tối đa", "Không thể thêm học sinh vào lớp!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
                
            LoadDanhSachHocSinh();
            LoadHocSinhCho();
            GridView_DSLop.ClearSelection();
            GridView_DSCho.ClearSelection();
        }

        private void Button_Xoa_Click(object sender, EventArgs e)
        {
            if (currentHSLop == "")
            {
                MessageBox.Show("Vui lòng chọn học sinh để tiếp tục!", "Chưa chọn học sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int? result = hocsinh.Delete_HSTrongLop(currentHSLop, currentLop, currentHocKy, currentNamHoc);
            if (result == 1)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật", "Xóa thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDanhSachHocSinh();
            LoadHocSinhCho();
            GridView_DSLop.ClearSelection();
            GridView_DSCho.ClearSelection();
        }

        private void Button_TimKiem_Click(object sender, EventArgs e)
        {
            DataTable temp = hocsinh.GetHocSinhCho(currentHocKy, currentNamHoc);
            temp.Columns.Add("GT", typeof(string));
            temp.Columns.Add("SoThuTu", typeof(int));

            int stt = 1;
            foreach (DataRow row in temp.Rows)
            {
                if (!row["HoTen"].ToString().ToUpper().Contains(TextBox_HoTen.Text.ToUpper())) 
                {
                    row.Delete();
                    continue;
                }
                int comp_1 = DateTime.Compare(DateTime.Parse(row["NgaySinh"].ToString()), DateTimePicker_NgaySinhBD.Value);
                int comp_2 = DateTime.Compare(DateTime.Parse(row["NgaySinh"].ToString()), DateTimePicker_NgaySinhKT.Value);
                if (comp_1 < 0 || comp_2 > 0)
                {
                    row.Delete();
                    continue;
                }

                if (RadioButton_Nam.Checked)
                {
                    if (row["GioiTinh"].ToString() == "False")
                    {
                        row.Delete();
                        continue;
                    }
                } else if (RadioButton_Nu.Checked)
                {
                    if (row["GioiTinh"].ToString() == "True")
                    {
                        row.Delete();
                        continue;
                    }
                }

                row["SoThuTu"] = stt;
                stt++;
                if (row["GioiTinh"].ToString() == "True")
                    row["GT"] = "Nam";
                else
                    row["GT"] = "Nữ";
            }
            GridView_DSCho.DataSource = temp;
        }

        private void Button_HienThiTatCa_Click(object sender, EventArgs e)
        {
            LoadHocSinhCho();
        }
    }
}
