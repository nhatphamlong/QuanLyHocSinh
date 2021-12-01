using BUS;
using Microsoft.Office.Interop.Excel;
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
    public partial class Form_BaoCaoTongKet : Form
    {
        BUS_DanhSachLop danhsachlop = new BUS_DanhSachLop();
        BUS_HocKy hocky = new BUS_HocKy();
        BUS_NamHoc namhoc = new BUS_NamHoc();
        BUS_MonHoc monhoc = new BUS_MonHoc();
        BUS_BCHocKy bchocky = new BUS_BCHocKy();
        BUS_BCMon bcmon = new BUS_BCMon();

        string currentLop_HK = "";
        string currentHocKy_HK = "";
        string currentNamHoc_HK = "";

        string currentLop_MH = "";
        string currentHocKy_MH = "";
        string currentNamHoc_MH = "";
        string currentMonHoc_MH = "";

        Color hoverLastColor = new Color();

        public Form_BaoCaoTongKet()
        {
            InitializeComponent();

            init();

            LoadDanhSachHocKy();
            LoadDanhSachNamHoc();
            LoadDanhSachMonHoc();
            LoadBCHocKy();
            LoadBCMon();
        }

        void init()
        {
            TrackBar_CoChu_HK.Value = int.Parse(GridView_BCHocKy.Font.Size.ToString());
            TrackBar_CoChu_HK.ValueChanged += TrackBar_CoChu_HK_ValueChanged;

            TrackBar_CoChu_MH.Value = int.Parse(GridView_BCMonHoc.Font.Size.ToString());
            TrackBar_CoChu_MH.ValueChanged += TrackBar_CoChu_MH_ValueChanged;

            //ComboBox_CoChu_HK.Text = GridView_BCHocKy.Font.Size.ToString();
            //ComboBox_CoChu_HK.TextChanged += ComboBox_CoChu_HK_TextChanged;
        }

        private void TrackBar_CoChu_MH_ValueChanged(object sender, EventArgs e)
        {
            GridView_BCMonHoc.Font = new System.Drawing.Font(GridView_BCMonHoc.Font.FontFamily.ToString(), TrackBar_CoChu_MH.Value);
        }

        private void TrackBar_CoChu_HK_ValueChanged(object sender, EventArgs e)
        {
            GridView_BCHocKy.Font = new System.Drawing.Font(GridView_BCHocKy.Font.FontFamily.ToString(), TrackBar_CoChu_HK.Value);
        }

        /*private void ComboBox_CoChu_HK_TextChanged(object sender, EventArgs e)
        {
            if (ComboBox_CoChu_HK.Text == "") return;
            float cochu = float.Parse(ComboBox_CoChu_HK.Text);
            if (cochu <= 0 || cochu > 100)
            {
                ComboBox_CoChu_HK.Text = GridView_BCHocKy.Font.Size.ToString();
                return;
            }
            GridView_BCHocKy.Font = new Font(GridView_BCHocKy.Font.FontFamily, cochu);
        }*/

        void LoadBCHocKy()
        {
            if (currentHocKy_HK == "" | currentNamHoc_HK == "") return;

            GridView_BCHocKy.DataSource = bchocky.GetBCHocKy(currentHocKy_HK, currentNamHoc_HK);
            GridView_BCHocKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_BCHocKy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_BCHocKy.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GridView_BCHocKy.RowHeadersVisible = false;
            GridView_BCHocKy.ReadOnly = true;
            GridView_BCHocKy.DefaultCellStyle.SelectionBackColor = Color.LightGreen;

            foreach (DataGridViewColumn column in GridView_BCHocKy.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            GridView_BCHocKy.BorderStyle = BorderStyle.FixedSingle;
            GridView_BCHocKy.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView_BCHocKy.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView_BCHocKy.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            GridView_BCHocKy.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView_BCHocKy.BackgroundColor = Color.White;

            GridView_BCHocKy.EnableHeadersVisualStyles = false;
            GridView_BCHocKy.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            GridView_BCHocKy.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GridView_BCHocKy.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void LoadBCMon()
        {
            if (currentHocKy_MH == "" | currentNamHoc_MH == "") return;

            GridView_BCMonHoc.DataSource = bcmon.GetBCMon(currentHocKy_MH, currentNamHoc_MH, currentMonHoc_MH);
            GridView_BCMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_BCMonHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_BCMonHoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GridView_BCMonHoc.RowHeadersVisible = false;
            GridView_BCMonHoc.ReadOnly = true;
            GridView_BCMonHoc.DefaultCellStyle.SelectionBackColor = Color.LightGreen;

            foreach (DataGridViewColumn column in GridView_BCMonHoc.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            GridView_BCMonHoc.BorderStyle = BorderStyle.FixedSingle;
            GridView_BCMonHoc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView_BCMonHoc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView_BCMonHoc.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            GridView_BCMonHoc.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView_BCMonHoc.BackgroundColor = Color.White;

            GridView_BCMonHoc.EnableHeadersVisualStyles = false;
            GridView_BCMonHoc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            GridView_BCMonHoc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GridView_BCMonHoc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void LoadDanhSachHocKy()
        {
            System.Data.DataTable temp = hocky.GetTatCaHK();

            ComboBox_HocKy_HK.DataSource = temp;
            ComboBox_HocKy_HK.DisplayMember = "TenHocKy";
            ComboBox_HocKy_HK.ValueMember = "MaHocKy";

            currentHocKy_HK = ComboBox_HocKy_HK.SelectedValue.ToString();

            ComboBox_HocKy_HK.SelectedValueChanged += ComboBox_HocKy_HK_SelectedValueChanged;

            ComboBox_HocKy_MH.DataSource = temp;
            ComboBox_HocKy_MH.DisplayMember = "TenHocKy";
            ComboBox_HocKy_MH.ValueMember = "MaHocKy";

            currentHocKy_MH = ComboBox_HocKy_MH.SelectedValue.ToString();

            ComboBox_HocKy_MH.SelectedValueChanged += ComboBox_HocKy_MH_SelectedValueChanged;
        }

        private void ComboBox_HocKy_HK_SelectedValueChanged(object sender, EventArgs e)
        {
            currentHocKy_HK = ComboBox_HocKy_HK.SelectedValue.ToString();
            LoadBCHocKy();
        }

        private void ComboBox_HocKy_MH_SelectedValueChanged(object sender, EventArgs e)
        {
            currentHocKy_MH = ComboBox_HocKy_MH.SelectedValue.ToString();
            LoadBCMon();
        }

        void LoadDanhSachNamHoc()
        {
            System.Data.DataTable temp = namhoc.GetTatCaNH();
            temp.Columns.Add("Full_NamHoc", typeof(string), "NamBD + ' - ' + NamKT");
            ComboBox_NamHoc_HK.DataSource = temp;
            ComboBox_NamHoc_HK.DisplayMember = "Full_NamHoc";
            ComboBox_NamHoc_HK.ValueMember = "MaNamHoc";

            currentNamHoc_HK = ComboBox_NamHoc_HK.SelectedValue.ToString();

            ComboBox_NamHoc_HK.SelectedValueChanged += ComboBox_NamHoc_HK_SelectedValueChanged;

            ComboBox_NamHoc_MH.DataSource = temp;
            ComboBox_NamHoc_MH.DisplayMember = "Full_NamHoc";
            ComboBox_NamHoc_MH.ValueMember = "MaNamHoc";

            currentNamHoc_MH = ComboBox_NamHoc_MH.SelectedValue.ToString();

            ComboBox_NamHoc_MH.SelectedValueChanged += ComboBox_NamHoc_MH_SelectedValueChanged;
        }

        private void ComboBox_NamHoc_HK_SelectedValueChanged(object sender, EventArgs e)
        {
            currentNamHoc_HK = ComboBox_NamHoc_HK.SelectedValue.ToString();
            LoadBCHocKy();
        }

        private void ComboBox_NamHoc_MH_SelectedValueChanged(object sender, EventArgs e)
        {
            currentNamHoc_MH = ComboBox_NamHoc_MH.SelectedValue.ToString();
            LoadBCMon();
        }

        void LoadDanhSachMonHoc()
        {
            ComboBox_MonHoc_MH.DataSource = monhoc.GetTatCaMonHoc();
            ComboBox_MonHoc_MH.DisplayMember = "TenMonHoc";
            ComboBox_MonHoc_MH.ValueMember = "MaMonHoc";

            currentMonHoc_MH = ComboBox_NamHoc_MH.SelectedValue.ToString();

            ComboBox_MonHoc_MH.SelectedValueChanged += ComboBox_MonHoc_MH_SelectedValueChanged;
        }

        private void ComboBox_MonHoc_MH_SelectedValueChanged(object sender, EventArgs e)
        {
            currentMonHoc_MH = ComboBox_MonHoc_MH.SelectedValue.ToString();
            LoadBCMon();
        }

        private void ExcelExportBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                saveFile.FilterIndex = 2;
                saveFile.RestoreDirectory = true;

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    _Application app = new Microsoft.Office.Interop.Excel.Application();
                    _Workbook workbook = app.Workbooks.Add(Type.Missing);
                    _Worksheet worksheet = null;
                    app.Visible = false;
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = ComboBox_HocKy_HK.Text + " (" + ComboBox_NamHoc_HK.Text + ")";
                    worksheet.Cells[1, 1] = "BÁO CÁO TỔNG KẾT " + ComboBox_HocKy_HK.Text.ToUpper() + ", NĂM HỌC " + ComboBox_NamHoc_HK.Text.ToUpper();
                    worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, GridView_BCHocKy.Columns.Count - 1]].Merge();
                    worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 1]].Font.Bold = true;
                    worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 1]].HorizontalAlignment = HorizontalAlignment.Center;
                    for (int i = 1; i < GridView_BCHocKy.Columns.Count; i++)
                    {
                        worksheet.Cells[2, i] = GridView_BCHocKy.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < GridView_BCHocKy.Rows.Count; i++)
                    {
                        for (int j = 0; j < GridView_BCHocKy.Columns.Count - 1; j++)
                        {
                            worksheet.Cells[i + 3, j + 1] = GridView_BCHocKy.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    try
                    {
                        workbook.SaveAs(saveFile.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        app.Quit();
                    } catch
                    {
                        app.Quit();
                    }
                }
            }
        }

        private void ExcelExportBtn_MH_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                saveFile.FilterIndex = 2;
                saveFile.RestoreDirectory = true;

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    _Application app = new Microsoft.Office.Interop.Excel.Application();
                    _Workbook workbook = app.Workbooks.Add(Type.Missing);
                    _Worksheet worksheet = null;
                    app.Visible = false;
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = ComboBox_MonHoc_MH.Text + " - " + ComboBox_HocKy_HK.Text + " (" + ComboBox_NamHoc_HK.Text + ")";
                    worksheet.Cells[1, 1] = "BÁO CÁO TỔNG KẾT MÔN " + ComboBox_MonHoc_MH.Text + " - " + ComboBox_HocKy_MH.Text.ToUpper() + ", NĂM HỌC " + ComboBox_NamHoc_MH.Text.ToUpper();
                    worksheet.Cells[1, 1] = "BÁO CÁO TỔNG KẾT MÔN " + ComboBox_MonHoc_MH.Text + " - " + ComboBox_HocKy_MH.Text.ToUpper() + ", NĂM HỌC " + ComboBox_NamHoc_MH.Text.ToUpper();
                    worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, GridView_BCHocKy.Columns.Count - 1]].Merge();
                    worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 1]].Font.Bold = true;
                    worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 1]].HorizontalAlignment = HorizontalAlignment.Center;
                    for (int i = 1; i < GridView_BCMonHoc.Columns.Count; i++)
                    {
                        worksheet.Cells[2, i] = GridView_BCMonHoc.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < GridView_BCMonHoc.Rows.Count; i++)
                    {
                        for (int j = 0; j < GridView_BCMonHoc.Columns.Count - 1; j++)
                        {
                            worksheet.Cells[i + 3, j + 1] = GridView_BCMonHoc.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    try
                    {
                        workbook.SaveAs(saveFile.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        app.Quit();
                    }
                    catch
                    {
                        app.Quit();
                    }
                }
            }
        }
    }
}
