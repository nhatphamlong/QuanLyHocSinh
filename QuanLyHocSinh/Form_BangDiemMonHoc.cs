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
    public partial class Form_BangDiemMonHoc : Form
    {
        BUS_KhoiLop khoilop = new BUS_KhoiLop();
        BUS_DanhSachLop danhsachlop = new BUS_DanhSachLop();
        BUS_HocKy hocky = new BUS_HocKy();
        BUS_NamHoc namhoc = new BUS_NamHoc();
        BUS_MonHoc monhoc = new BUS_MonHoc();
        BUS_HocSinh hocsinh = new BUS_HocSinh();
        BUS_BangDiemMon bangdiemmon = new BUS_BangDiemMon();
        BUS_Diem diem = new BUS_Diem();
        BUS_ThamSo thamso = new BUS_ThamSo();

        ThamSo listThamSo;
        string lastScore;

        string currentHocSinh = "";
        string currentKhoiLop = "";
        string currentLop = "";
        string currentHocKy = "";
        string currentNamHoc = "";
        string currentMonHoc = "";
        public Form_BangDiemMonHoc()
        {
            InitializeComponent();

            init();
            LoadDanhSachKhoiLop();
            LoadDanhSachLop();
            LoadDanhSachHocKy();
            LoadDanhSachNamHoc();
            LoadDanhSachMonHoc();
            LoadBangDiem();
        }

        private void init()
        {
            listThamSo = thamso.GetThamSo();

            TrackBar_CoChu.Value = int.Parse(GridView_BangDiem.Font.Size.ToString());
            TrackBar_CoChu.ValueChanged += TrackBar_CoChu_ValueChanged;


            //ComboBox_CoChu.Text = GridView_BangDiem.Font.Size.ToString();
            //ComboBox_CoChu.TextChanged += ComboBox_CoChu_TextChanged;
        }

        private void TrackBar_CoChu_ValueChanged(object sender, EventArgs e)
        {
            GridView_BangDiem.Font = new Font(GridView_BangDiem.Font.FontFamily.ToString(), TrackBar_CoChu.Value);
        }

        /*
        private void ComboBox_CoChu_TextChanged(object sender, EventArgs e)
        {
           if (ComboBox_CoChu.Text == "") return;
           float cochu = float.Parse(ComboBox_CoChu.Text);
           if (cochu <= 0 || cochu > 100)
           {
               ComboBox_CoChu.Text = GridView_BangDiem.Font.Size.ToString();
               return;
           }
           GridView_BangDiem.Font = new Font(GridView_BangDiem.Font.FontFamily, cochu);
        }*/

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

            if (temp.Rows.Count == 0) return;

            ComboBox_Lop.SelectedValueChanged += ComboBox_Lop_SelectedValueChanged;
        }

        private void ComboBox_Lop_SelectedValueChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(currentLop);
            LoadBangDiem();
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
            LoadBangDiem();
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
            LoadBangDiem();
        }

        void LoadDanhSachMonHoc()
        {
            ComboBox_MonHoc.DataSource = monhoc.GetTatCaMonHoc();
            ComboBox_MonHoc.DisplayMember = "TenMonHoc";
            ComboBox_MonHoc.ValueMember = "MaMonHoc";

            currentMonHoc = ComboBox_MonHoc.SelectedValue.ToString();

            ComboBox_MonHoc.SelectedValueChanged += ComboBox_MonHoc_SelectedValueChanged;
        }

        private void ComboBox_MonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadBangDiem();
        }

        void LoadBangDiem()
        {
            currentLop = ComboBox_Lop.SelectedValue.ToString();
            currentHocKy = ComboBox_HocKy.SelectedValue.ToString();
            currentNamHoc = ComboBox_NamHoc.SelectedValue.ToString();

            if (currentLop == "" | currentHocKy == "" | currentNamHoc == "")
            {
                GridView_BangDiem.DataSource = null;
                return;
            }
            GridView_BangDiem.DataSource = bangdiemmon.GetBangDiem(currentLop, currentHocKy, currentNamHoc, currentMonHoc);
            GridView_BangDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_BangDiem.SelectionMode = DataGridViewSelectionMode.CellSelect;
            GridView_BangDiem.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GridView_BangDiem.RowHeadersVisible = false;

            GridView_BangDiem.CellBeginEdit += GridView_BangDiem_CellBeginEdit;
            GridView_BangDiem.CellEndEdit += GridView_BangDiem_CellEndEdit;
            

            foreach(DataGridViewColumn column in GridView_BangDiem.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Edit theme
            GridView_BangDiem.BorderStyle = BorderStyle.FixedSingle;
            GridView_BangDiem.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView_BangDiem.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView_BangDiem.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            GridView_BangDiem.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView_BangDiem.BackgroundColor = Color.White;

            GridView_BangDiem.EnableHeadersVisualStyles = false;
            GridView_BangDiem.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            GridView_BangDiem.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GridView_BangDiem.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void GridView_BangDiem_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            lastScore = GridView_BangDiem.Rows[row].Cells[column].Value.ToString();
        }

        private void reverseCurrentCell()
        {
            if (lastScore == "")
            {
                GridView_BangDiem.CurrentCell.Value = DBNull.Value;
                return;
            }
            GridView_BangDiem.CurrentCell.Value = lastScore.ToString();
        }

        private void GridView_BangDiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            currentHocSinh = GridView_BangDiem.Rows[row].Cells[0].Value.ToString();
            string MaLoaiKT = GridView_BangDiem.Columns[column].DataPropertyName.ToString();
            //Console.WriteLine(MaLoaiKT);
            /*
            double? d;
            if (GridView_BangDiem.Rows[row].Cells[column].Value == DBNull.Value)
                d = null;
            else
                d = double.Parse(GridView_BangDiem.Rows[row].Cells[column].Value.ToString());

            // Console.WriteLine(diem.ToString());

            if (d < listThamSo.DiemToiThieu || d > listThamSo.DiemToiDa)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ " + listThamSo.DiemToiThieu + " đến " + listThamSo.DiemToiDa, "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reverseCurrentCell();
                return;
            }
            
            int? result = null;
            
            if (d != null)
            {
                if (diem.GetDiem(currentHocSinh, currentHocKy, currentNamHoc, currentMonHoc, MaLoaiKT) == null)
                {
                    result = diem.Insert_Diem(currentHocSinh, currentLop, currentHocKy, currentNamHoc, currentMonHoc, MaLoaiKT, d);
                } 
                else
                {
                    result = diem.Update_Diem(currentHocSinh, currentLop, currentHocKy, currentNamHoc, currentMonHoc, MaLoaiKT, d);
                }
            }
            else
            {
                if (diem.GetDiem(currentHocSinh, currentHocKy, currentNamHoc, currentMonHoc, MaLoaiKT) != null)
                {
                    result = diem.Delete_Diem(currentHocSinh, currentLop, currentHocKy, currentNamHoc, currentMonHoc, MaLoaiKT);
                }
            }

            if (result != 1)
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            //int? result = null;

            string d;
            if (GridView_BangDiem.Rows[row].Cells[column].Value == DBNull.Value)
                d = null;
            else
                d = GridView_BangDiem.Rows[row].Cells[column].Value.ToString();

            if (d == null)
            {
                if (diem.GetDiem(currentHocSinh, currentHocKy, currentNamHoc, currentMonHoc, MaLoaiKT) != null)
                {
                    diem.Delete_Diem(currentHocSinh, currentLop, currentHocKy, currentNamHoc, currentMonHoc, MaLoaiKT);
                }
            }
            else
            {
                List<double> listDiem = getListDiem(d);
                foreach(double p in listDiem) 
                    if (p == -1)
                    {
                        MessageBox.Show("Không đúng định dạng", "Đã xảy ra lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadBangDiem();
                        return;
                    }
                if (diem.GetDiem(currentHocSinh, currentHocKy, currentNamHoc, currentMonHoc, MaLoaiKT) == null)
                {
                    foreach (double p in listDiem)
                    {
                        diem.Insert_Diem(currentHocSinh, currentLop, currentHocKy, currentNamHoc, currentMonHoc, MaLoaiKT, p);
                    }
                }
                else
                {
                    diem.Delete_Diem(currentHocSinh, currentLop, currentHocKy, currentNamHoc, currentMonHoc, MaLoaiKT);
                    foreach(double p in listDiem)
                    {
                        diem.Insert_Diem(currentHocSinh, currentLop, currentHocKy, currentNamHoc, currentMonHoc, MaLoaiKT, p);
                    }
                }
            }

            LoadBangDiem();
        }

        private List<double> getListDiem(string d) 
        {
            List<double> result = new List<double>();

            string s = "";
            for(int i = 0; i < d.Length; i++)
            {
                if (d[i] == ';' || d[i] == ' ') continue;
                if (i == d.Length - 1 || d[i + 1] == ';' || d[i + 1] == ' ')
                {
                    s += d[i].ToString();
                    double parseResult = 0;
                    if (double.TryParse(s, out parseResult))
                    {
                        result.Add(parseResult);
                    }
                    else
                    {
                        result.Add(-1);
                    }
                    s = "";
                    continue;
                }
                if (i == 0 || d[i - 1] == ';' || d[i - 1] == ' ')
                {
                    s = d[i].ToString();
                }
                else
                {
                    s += d[i].ToString();
                }
            }

            return result;
        }

        private void ComboBox_Lop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_MonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_HocKy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
