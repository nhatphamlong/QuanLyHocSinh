using DTO;
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
    public partial class Form_ThietLap : Form
    {
        BUS_ThamSo thamso = new BUS_ThamSo();
        BUS_DanhSachLop danhsachlop = new BUS_DanhSachLop();
        BUS_KhoiLop khoilop = new BUS_KhoiLop();
        BUS_MonHoc monhoc = new BUS_MonHoc();
        BUS_HocKy hocky = new BUS_HocKy();
        BUS_NamHoc namhoc = new BUS_NamHoc();
        BUS_SiSo siso = new BUS_SiSo();

        string currentMaLop = "";
        string currentKhoiLop = "";
        string currentMaMH = "";
        string currentHocKy = "";
        string currentNamHoc = "";
        public Form_ThietLap()
        {
            InitializeComponent();

            SetQuyDinh();

            LoadDSLop();
            LoadDSMonHoc();
            LoadDSKhoi();
            LoadDSHocKy();
            LoadDSNamHoc();
        }
        void SetQuyDinh()
        {
            ThamSo temp = thamso.GetThamSo();
            TextBox_TuoiMin.Text = temp.TuoiToiThieu.ToString();
            TextBox_TuoiMax.Text = temp.TuoiToiDa.ToString();
            TextBox_SiSoMax.Text = temp.SiSoToiDa.ToString();
            TextBox_DiemMin.Text = temp.DiemToiThieu.ToString();
            TextBox_DiemMax.Text = temp.DiemToiDa.ToString();
            TextBox_DiemDat.Text = temp.DiemDat.ToString();
            TextBox_DiemDatMon.Text = temp.DiemDatMon.ToString();
        }
        void LoadDSLop()
        {
            DataTable temp = danhsachlop.GetTatCaLop();
            temp.Columns.Add("SoThuTu", typeof(int));

            int stt = 1;
            foreach (DataRow row in temp.Rows)
            {
                row["SoThuTu"] = stt;
                stt++;
            }

            GridView_DSLop.DataSource = temp;
            GridView_DSLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_DSLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_DSLop.RowHeadersVisible = false;
            GridView_DSLop.ReadOnly = true;
            GridView_DSLop.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            GridView_DSLop.CellClick += GridView_DSLop_CellClick;

            foreach(DataGridViewColumn column in GridView_DSLop.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

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

        void LoadDSMonHoc()
        {
            DataTable temp = monhoc.GetTatCaMonHoc();
            temp.Columns.Add("SoThuTu", typeof(int));

            int stt = 1;
            foreach (DataRow row in temp.Rows)
            {
                row["SoThuTu"] = stt;
                stt++;
            }

            GridView_DSMonHoc.DataSource = temp;
            GridView_DSMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_DSMonHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_DSMonHoc.RowHeadersVisible = false;
            GridView_DSMonHoc.ReadOnly = true;
            GridView_DSMonHoc.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            GridView_DSMonHoc.CellClick += GridView_DSMonHoc_CellClick;

            foreach(DataGridViewColumn column in GridView_DSMonHoc.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Edit theme
            GridView_DSMonHoc.BorderStyle = BorderStyle.FixedSingle;
            GridView_DSMonHoc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView_DSMonHoc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView_DSMonHoc.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            GridView_DSMonHoc.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView_DSMonHoc.BackgroundColor = Color.White;

            GridView_DSMonHoc.EnableHeadersVisualStyles = false;
            GridView_DSMonHoc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            GridView_DSMonHoc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GridView_DSMonHoc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void GridView_DSMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridView_DSMonHoc.Rows[e.RowIndex];
                currentMaMH = row.Cells[0].Value.ToString();
                TextBox_TenMonHoc.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        void LoadDSKhoi()
        {
            ComboBox_KhoiLop.DataSource = khoilop.GetTatCaKhoiLop();
            ComboBox_KhoiLop.DisplayMember = "TenKhoiLop";
            ComboBox_KhoiLop.ValueMember = "MaKhoiLop";
            currentKhoiLop = ComboBox_KhoiLop.SelectedValue.ToString();
            ComboBox_KhoiLop.SelectedValueChanged += ComboBox_KhoiLop_SelectedValueChanged;
        }

        private void ComboBox_KhoiLop_SelectedValueChanged(object sender, EventArgs e)
        {
            currentKhoiLop = ComboBox_KhoiLop.SelectedValue.ToString();
        }

        private void GridView_DSLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridView_DSLop.Rows[e.RowIndex];
                currentMaLop = row.Cells[1].Value.ToString();
                TextBox_TenLop.Text = row.Cells[2].Value.ToString();
                ComboBox_KhoiLop.SelectedValue = int.Parse(row.Cells[3].Value.ToString());
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void LoadDSHocKy()
        {
            DataTable temp = hocky.GetTatCaHK();
            temp.Columns.Add("SoThuTu", typeof(int));

            int stt = 1;
            foreach (DataRow row in temp.Rows)
            {
                row["SoThuTu"] = stt;
                stt++;
            }

            GridView_DSHocKy.DataSource = temp;
            GridView_DSHocKy.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridView_DSHocKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_DSHocKy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_DSHocKy.RowHeadersVisible = false;
            GridView_DSHocKy.ReadOnly = true;
            GridView_DSHocKy.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            GridView_DSHocKy.CellClick += GridView_DSHocKy_CellClick;

            foreach(DataGridViewColumn column in GridView_DSHocKy.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Edit theme
            GridView_DSHocKy.BorderStyle = BorderStyle.FixedSingle;
            GridView_DSHocKy.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView_DSHocKy.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView_DSHocKy.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            GridView_DSHocKy.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView_DSHocKy.BackgroundColor = Color.White;

            GridView_DSHocKy.EnableHeadersVisualStyles = false;
            GridView_DSHocKy.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            GridView_DSHocKy.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GridView_DSHocKy.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void GridView_DSHocKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridView_DSHocKy.Rows[e.RowIndex];
                currentHocKy = row.Cells[0].Value.ToString();
                TextBox_TenHocKy.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void LoadDSNamHoc()
        {
            DataTable temp = namhoc.GetTatCaNH();
            temp.Columns.Add("SoThuTu", typeof(int));

            int stt = 1;
            foreach (DataRow row in temp.Rows)
            {
                row["SoThuTu"] = stt;
                stt++;
            }

            GridView_DSNamHoc.DataSource = temp;
            GridView_DSNamHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_DSNamHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_DSNamHoc.RowHeadersVisible = false;
            GridView_DSNamHoc.ReadOnly = true;
            GridView_DSNamHoc.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            GridView_DSNamHoc.CellClick += GridView_DSNamHoc_CellClick;

            foreach(DataGridViewColumn column in GridView_DSNamHoc.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Edit theme
            GridView_DSNamHoc.BorderStyle = BorderStyle.FixedSingle;
            GridView_DSNamHoc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView_DSNamHoc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView_DSNamHoc.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            GridView_DSNamHoc.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView_DSNamHoc.BackgroundColor = Color.White;

            GridView_DSNamHoc.EnableHeadersVisualStyles = false;
            GridView_DSNamHoc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            GridView_DSNamHoc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GridView_DSNamHoc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void GridView_DSNamHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridView_DSNamHoc.Rows[e.RowIndex];
                currentNamHoc = row.Cells[0].Value.ToString();
                TextBox_NamBD.Text = row.Cells[1].Value.ToString();
                TextBox_NamKT.Text = row.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private int Check()
        {
            if (TextBox_TuoiMin.Text == "" || TextBox_TuoiMax.Text == "" || TextBox_SiSoMax.Text == "" ||
                TextBox_DiemMin.Text == "" || TextBox_DiemMax.Text == "" || TextBox_DiemDat.Text == "")
                return 0;

            int TuoiMin;
            int TuoiMax;
            int SiSoMax;
            double DiemMin;
            double DiemMax;
            double DiemDat;

            try
            {
                TuoiMin = int.Parse(TextBox_TuoiMin.Text);
                TuoiMax = int.Parse(TextBox_TuoiMax.Text);
                SiSoMax = int.Parse(TextBox_SiSoMax.Text);
                DiemMin = double.Parse(TextBox_DiemMin.Text);
                DiemMax = double.Parse(TextBox_DiemMax.Text);
                DiemDat = double.Parse(TextBox_DiemDat.Text);
            } catch
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Không thể lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            
            if (TuoiMin <= 0 || TuoiMax <= 0 || SiSoMax <= 0 || DiemMin < 0 || DiemMax <= 0 || DiemDat < 0 ||
                TuoiMax - TuoiMin < 0 || DiemMax - DiemMin < 0 || DiemDat > DiemMax || DiemDat < DiemMin)
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Không thể lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            if (SiSoMax < siso.GetSiSoMax())
            {
                MessageBox.Show("Vui lòng đảm bảo không tồn tại lớp có sĩ số lớn hơn sĩ số tối đa!", "Không thể lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            return 1;
        }
        private void Button_Luu_Click(object sender, EventArgs e)
        {
            if (Check() == 1)
            {
                int TuoiMin = int.Parse(TextBox_TuoiMin.Text);
                int TuoiMax = int.Parse(TextBox_TuoiMax.Text);
                int SiSoMax = int.Parse(TextBox_SiSoMax.Text);
                double DiemMin = double.Parse(TextBox_DiemMin.Text);
                double DiemMax = double.Parse(TextBox_DiemMax.Text);
                double DiemDat = double.Parse(TextBox_DiemDat.Text);
                double DiemDatMon = double.Parse(TextBox_DiemDatMon.Text);
                ThamSo temp = new ThamSo(TuoiMin, TuoiMax, SiSoMax, DiemMin, DiemMax, DiemDat, DiemDatMon);
                int? result = thamso.UpdateThamSo(temp);
                if (result == 1)
                {
                    MessageBox.Show("Dữ liệu đã được cập nhật", "Lưu thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else SetQuyDinh();
        }

        private void Button_ThemLop_Click(object sender, EventArgs e)
        {
            if (TextBox_TenLop.Text == "")
            {
                MessageBox.Show("Tên lớp không được để trống", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (danhsachlop.CheckTonTaiLop(TextBox_TenLop.Text) > 0)
            {
                MessageBox.Show("Đã tồn tại lớp này", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DanhSachLop dslop = new DanhSachLop();
            dslop.TenLop = TextBox_TenLop.Text;
            dslop.SiSo = 0;
            dslop.MaKhoiLop = long.Parse(currentKhoiLop);
            int? result = danhsachlop.Insert_Lop(dslop); 
            if (result == 1)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật", "Thêm thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDSLop();
            currentMaLop = "";
            GridView_DSLop.ClearSelection();
        }

        private void Button_SuaLop_Click(object sender, EventArgs e)
        {
            if (currentMaLop == "")
            {
                MessageBox.Show("Chưa chọn lớp", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextBox_TenLop.Text == "")
            {
                MessageBox.Show("Tên lớp không được để trống", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DanhSachLop dslop = new DanhSachLop();
            dslop.MaLop = long.Parse(currentMaLop);
            dslop.TenLop = TextBox_TenLop.Text;
            dslop.MaKhoiLop = long.Parse(ComboBox_KhoiLop.SelectedValue.ToString());
            int? result = danhsachlop.Update_Lop(dslop);
            if (result == 1)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật", "Cập nhật thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDSLop();
            currentMaLop = "";
            GridView_DSLop.ClearSelection();
        }

        private void Button_XoaLop_Click(object sender, EventArgs e)
        {
            if (currentMaLop == "")
            {
                MessageBox.Show("Chưa chọn lớp", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int? result = danhsachlop.Delete_Lop(currentMaLop);
            if (result == 1)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật", "Xóa thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDSLop();
            currentMaLop = "";
            GridView_DSLop.ClearSelection();
        }

        private void Button_ThemMon_Click(object sender, EventArgs e)
        {
            if (TextBox_TenMonHoc.Text == "")
            {
                MessageBox.Show("Chưa chọn môn học", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (monhoc.CheckTonTaiMonHoc(TextBox_TenMonHoc.Text) > 0)
            {
                MessageBox.Show("Đã tồn tại môn học này", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MonHoc mh = new MonHoc();
            mh.TenMonHoc = TextBox_TenMonHoc.Text;
            int? result = monhoc.Insert_MonHoc(mh); 
            if (result == 1)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật", "Thêm thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDSMonHoc();
            currentMaMH = "";
            GridView_DSMonHoc.ClearSelection();
        }

        private void Button_SuaMon_Click(object sender, EventArgs e)
        {
            if (currentMaMH == "")
            {
                MessageBox.Show("Chưa chọn môn học", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextBox_TenMonHoc.Text == "")
            {
                MessageBox.Show("Tên môn học không được để trống", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MonHoc mh = new MonHoc();
            mh.MaMonHoc = long.Parse(currentMaMH);
            mh.TenMonHoc = TextBox_TenMonHoc.Text;
            int? result = monhoc.Update_MonHoc(mh);
            if (result == 1)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật", "Cập nhật thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDSMonHoc();
            currentMaMH = "";
            GridView_DSMonHoc.ClearSelection();
        }

        private void Button_XoaMon_Click(object sender, EventArgs e)
        {
            if (currentMaMH == "")
            {
                MessageBox.Show("Chưa chọn môn học", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int? result = monhoc.Delete_MonHoc(currentMaMH);
            if (result == 1)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật", "Xóa thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDSMonHoc();
            currentMaMH = "";
            GridView_DSMonHoc.ClearSelection();
        }

        private void Button_ThemHK_Click(object sender, EventArgs e)
        {
            if (TextBox_TenHocKy.Text == "")
            {
                MessageBox.Show("Tên học kỳ không được để trống", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hocky.CheckTonTaiHocKy(TextBox_TenHocKy.Text) > 0)
            {
                MessageBox.Show("Đã tồn tại học kỳ này", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int? result = hocky.Insert_HocKy(TextBox_TenHocKy.Text);
            if (result == 1)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật", "Thêm thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDSHocKy();
            currentHocKy = "";
            GridView_DSHocKy.ClearSelection();
        }

        private void Button_SuaHK_Click(object sender, EventArgs e)
        {
            if (currentHocKy == "")
            {
                MessageBox.Show("Chưa chọn học kỳ", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextBox_TenHocKy.Text == "")
            {
                MessageBox.Show("Tên học kỳ không được để trống", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HocKy hk = new HocKy();
            hk.MaHocKy = long.Parse(currentHocKy);
            hk.TenHocKy = TextBox_TenHocKy.Text;
            int? result = hocky.Update_HocKy(hk);
            if (result == 1)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật", "Cập nhật thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDSHocKy();
            currentHocKy = "";
            GridView_DSHocKy.ClearSelection();
        }

        private void Button_XoaHK_Click(object sender, EventArgs e)
        {
            if (currentHocKy == "")
            {
                MessageBox.Show("Chưa chọn học kỳ", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int? result = hocky.Delete_HocKy(currentHocKy);
            if (result == 1)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật", "Xóa thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDSHocKy();
            currentHocKy = "";
            GridView_DSHocKy.ClearSelection();
        }

        private void Button_ThemNH_Click(object sender, EventArgs e)
        {
            if (TextBox_NamBD.Text == "" || TextBox_NamKT.Text == "")
            {
                MessageBox.Show("Năm học không được để trống", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (namhoc.CheckTonTaiNamHoc(TextBox_NamBD.Text, TextBox_NamKT.Text) > 0)
            {
                MessageBox.Show("Đã tồn tại năm học này", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int.Parse(TextBox_NamBD.Text);
                int.Parse(TextBox_NamKT.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int? result = namhoc.Insert_NamHoc(TextBox_NamBD.Text, TextBox_NamKT.Text);
            if (result == 1)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật", "Thêm thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDSNamHoc();
            currentNamHoc = "";
            GridView_DSNamHoc.ClearSelection();
        }

        private void Button_SuaNH_Click(object sender, EventArgs e)
        {
            if (currentNamHoc == "")
            {
                MessageBox.Show("Chưa chọn năm học", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextBox_NamBD.Text == "" || TextBox_NamKT.Text== "")
            {
                MessageBox.Show("Năm học không được để trống", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int.Parse(TextBox_NamBD.Text);
                int.Parse(TextBox_NamKT.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NamHoc nh = new NamHoc();
            nh.MaNamHoc = long.Parse(currentNamHoc);
            nh.NamBD = int.Parse(TextBox_NamBD.Text);
            nh.NamKT = int.Parse(TextBox_NamKT.Text);
            int? result = namhoc.Update_NamHoc(nh);
            if (result == 1)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật", "Cập nhật thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDSNamHoc();
            currentNamHoc = "";
            GridView_DSNamHoc.ClearSelection();
        }

        private void Button_XoaNH_Click(object sender, EventArgs e)
        {
            if (currentNamHoc == "")
            {
                MessageBox.Show("Chưa chọn năm học", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int? result = namhoc.Delete_NamHoc(currentNamHoc);
            if (result == 1)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật", "Xóa thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDSNamHoc();
            currentNamHoc = "";
            GridView_DSNamHoc.ClearSelection();
        }
    }
}
