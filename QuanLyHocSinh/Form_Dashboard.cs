using QuanLyHocSinh.Properties;
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
    public partial class Form_Dashboard : Form
    {
        private int PanelMinimumWidth = 72;
        private int PanelMaximumWidth = 282;

        // Default color
        Color defaultColor = Color.LightSkyBlue;
        // Color when focused
        Color focusedColor = Color.RoyalBlue;

        private bool[] panelStatus = { false, false, false, false, false, false };
        public Form_Dashboard()
        {
            InitializeComponent();

            Init();
            SetButtonColor(6);
        }

        private void Init()
        {
            Main_Panel.Controls.Clear();
            Form_GioiThieu form = new Form_GioiThieu();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Main_Panel.Controls.Add(form);
            form.Show();
        }

        private void SetButtonColor(int pos)
        {
            AddStudentBtn.BackColor = defaultColor;
            SearchBtn.BackColor = defaultColor;
            ClassBtn.BackColor = defaultColor;
            ScoreBtn.BackColor = defaultColor;
            ReportBtn.BackColor = defaultColor;
            SettingsBtn.BackColor = defaultColor;
            switch (pos)
            {
                case 0:
                    AddStudentBtn.BackColor = focusedColor;
                    break;
                case 1:
                    SearchBtn.BackColor = focusedColor;
                    break;
                case 2:
                    ClassBtn.BackColor = focusedColor;
                    break;
                case 3:
                    ScoreBtn.BackColor = focusedColor;
                    break;
                case 4:
                    ReportBtn.BackColor = focusedColor;
                    break;
                case 5:
                    SettingsBtn.BackColor = focusedColor;
                    break;
                default:
                    break;
            }
        }
        
        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            SetButtonColor(0);     
       
            Main_Panel.Controls.Clear();
            Form_TiepNhanHS form = new Form_TiepNhanHS();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Main_Panel.Controls.Add(form);
            form.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SetButtonColor(1);

            Main_Panel.Controls.Clear();
            Form_TraCuuHocSinh form = new Form_TraCuuHocSinh();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Main_Panel.Controls.Add(form);
            form.Show();
        }

        private void ClassBtn_Click(object sender, EventArgs e)
        {
            SetButtonColor(2);

            Main_Panel.Controls.Clear();
            Form_LapDSLop form = new Form_LapDSLop();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Main_Panel.Controls.Add(form);
            form.Show();
        }

        private void ScoreBtn_Click(object sender, EventArgs e)
        {
            SetButtonColor(3);

            Main_Panel.Controls.Clear();
            Form_BangDiemMonHoc form = new Form_BangDiemMonHoc();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Main_Panel.Controls.Add(form);
            form.Show();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            SetButtonColor(4);

            Main_Panel.Controls.Clear();
            Form_BaoCaoTongKet form = new Form_BaoCaoTongKet();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Main_Panel.Controls.Add(form);
            form.Show();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SetButtonColor(5);

            Main_Panel.Controls.Clear();
            Form_ThietLap form = new Form_ThietLap();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Main_Panel.Controls.Add(form);
            form.Show();
        }

        private void AddStudentBtn_MouseHover(object sender, EventArgs e)
        {
            panelStatus[0] = true;
            Timer t = new Timer();
            t.Interval = 10;
            t.Start();
            t.Tick += delegate
            {
                if (AddStudentBtn.Width < PanelMaximumWidth && panelStatus[0] == true)
                {
                    AddStudentBtn.Width += 10;
                    if (AddStudentBtn.Width > PanelMaximumWidth / 1.7 && AddStudentBtn.Text == "")
                        AddStudentBtn.Text = "Tiếp nhận học sinh";
                }                
                else
                    t.Stop();
            };
        }

        private void AddStudentBtn_MouseLeave(object sender, EventArgs e)
        {
            panelStatus[0] = false;
            Timer t = new Timer();
            t.Interval = 10;
            t.Start();
            t.Tick += delegate
            {
                if (AddStudentBtn.Width > PanelMinimumWidth && panelStatus[0] == false)
                {
                    AddStudentBtn.Width -= 10;
                    if (AddStudentBtn.Width < PanelMinimumWidth * 2.3)
                        AddStudentBtn.Text = "";
                }
                else
                    t.Stop();
            };
        }

        private void SearchBtn_MouseHover(object sender, EventArgs e)
        {
            panelStatus[1] = true;
            Timer t = new Timer();
            t.Interval = 10;
            t.Start();
            t.Tick += delegate
            {
                if (SearchBtn.Width < PanelMaximumWidth && panelStatus[1] == true)
                {
                    SearchBtn.Width += 10;
                    if (SearchBtn.Width > PanelMaximumWidth / 1.7 && SearchBtn.Text == "")
                        SearchBtn.Text = "Tra cứu học sinh";
                }
                else
                    t.Stop();
            };
        }

        private void SearchBtn_MouseLeave(object sender, EventArgs e)
        {
            panelStatus[1] = false;
            Timer t = new Timer();
            t.Interval = 10;
            t.Start();
            t.Tick += delegate
            {
                if (SearchBtn.Width > PanelMinimumWidth && panelStatus[1] == false)
                {
                    SearchBtn.Width -= 10;
                    if (SearchBtn.Width < PanelMinimumWidth * 2.3)
                        SearchBtn.Text = "";
                }
                else
                    t.Stop();
            };
        }

        private void ClassBtn_MouseHover(object sender, EventArgs e)
        {
            panelStatus[2] = true;
            Timer t = new Timer();
            t.Interval = 10;
            t.Start();
            t.Tick += delegate
            {
                if (ClassBtn.Width < PanelMaximumWidth && panelStatus[2] == true)
                {
                    ClassBtn.Width += 10;
                    if (ClassBtn.Width > PanelMaximumWidth / 1.7 && ClassBtn.Text == "")
                        ClassBtn.Text = "Lập danh sách lớp";
                }
                else
                    t.Stop();
            };
        }

        private void ClassBtn_MouseLeave(object sender, EventArgs e)
        {
            panelStatus[2] = false;
            Timer t = new Timer();
            t.Interval = 10;
            t.Start();
            t.Tick += delegate
            {
                if (ClassBtn.Width > PanelMinimumWidth && panelStatus[2] == false)
                {
                    ClassBtn.Width -= 10;
                    if (ClassBtn.Width < PanelMinimumWidth * 2.3)
                        ClassBtn.Text = "";
                }
                else
                    t.Stop();
            };
        }

        private void ScoreBtn_MouseHover(object sender, EventArgs e)
        {
            panelStatus[3] = true;
            Timer t = new Timer();
            t.Interval = 10;
            t.Start();
            t.Tick += delegate
            {
                if (ScoreBtn.Width < PanelMaximumWidth && panelStatus[3] == true)
                {
                    ScoreBtn.Width += 10;
                    if (ScoreBtn.Width > PanelMaximumWidth / 1.7 && ScoreBtn.Text == "")
                        ScoreBtn.Text = "Bảng điểm môn học";
                }
                else
                    t.Stop();
            };
        }

        private void ScoreBtn_MouseLeave(object sender, EventArgs e)
        {
            panelStatus[3] = false;
            Timer t = new Timer();
            t.Interval = 10;
            t.Start();
            t.Tick += delegate
            {
                if (ScoreBtn.Width > PanelMinimumWidth && panelStatus[3] == false)
                {
                    ScoreBtn.Width -= 10;
                    if (ScoreBtn.Width < PanelMinimumWidth * 2.3)
                        ScoreBtn.Text = "";
                }
                else
                    t.Stop();
            };
        }

        private void ReportBtn_MouseHover(object sender, EventArgs e)
        {
            panelStatus[4] = true;
            Timer t = new Timer();
            t.Interval = 10;
            t.Start();
            t.Tick += delegate
            {
                if (ReportBtn.Width < PanelMaximumWidth && panelStatus[4] == true)
                {
                    ReportBtn.Width += 10;
                    if (ReportBtn.Width > PanelMaximumWidth / 1.7 && ReportBtn.Text == "")
                        ReportBtn.Text = "Báo cáo tổng kết";
                }
                else
                    t.Stop();
            };
        }

        private void ReportBtn_MouseLeave(object sender, EventArgs e)
        {
            panelStatus[4] = false;
            Timer t = new Timer();
            t.Interval = 10;
            t.Start();
            t.Tick += delegate
            {
                if (ReportBtn.Width > PanelMinimumWidth && panelStatus[4] == false)
                {
                    ReportBtn.Width -= 10;
                    if (ReportBtn.Width < PanelMinimumWidth * 2.3)
                        ReportBtn.Text = "";
                }
                else
                    t.Stop();
            };
        }

        private void SettingsBtn_MouseHover(object sender, EventArgs e)
        {
            panelStatus[5] = true;
            Timer t = new Timer();
            t.Interval = 10;
            t.Start();
            t.Tick += delegate
            {
                if (SettingsBtn.Width < PanelMaximumWidth && panelStatus[5] == true)
                {
                    SettingsBtn.Width += 10;
                    if (SettingsBtn.Width > PanelMaximumWidth / 1.7 && SettingsBtn.Text == "")
                        SettingsBtn.Text = "Thiết lập";
                }
                else
                    t.Stop();
            };
        }

        private void SettingsBtn_MouseLeave(object sender, EventArgs e)
        {
            panelStatus[5] = false;
            Timer t = new Timer();
            t.Interval = 10;
            t.Start();
            t.Tick += delegate
            {
                if (SettingsBtn.Width > PanelMinimumWidth && panelStatus[5] == false)
                {
                    SettingsBtn.Width -= 10;
                    if (SettingsBtn.Width < PanelMinimumWidth * 2.3)
                        SettingsBtn.Text = "";
                }
                else
                    t.Stop();
            };
        }
    }
}
