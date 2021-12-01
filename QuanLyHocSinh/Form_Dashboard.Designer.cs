namespace QuanLyHocSinh
{
    partial class Form_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.ScoreBtn = new System.Windows.Forms.Button();
            this.ClassBtn = new System.Windows.Forms.Button();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OptionsPanel.BackColor = System.Drawing.Color.Lavender;
            this.OptionsPanel.Location = new System.Drawing.Point(0, -1);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(72, 732);
            this.OptionsPanel.TabIndex = 0;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.Image = global::QuanLyHocSinh.Properties.Resources.SettingsButton1;
            this.SettingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.Location = new System.Drawing.Point(-1, 370);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(72, 75);
            this.SettingsBtn.TabIndex = 5;
            this.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            this.SettingsBtn.MouseLeave += new System.EventHandler(this.SettingsBtn_MouseLeave);
            this.SettingsBtn.MouseHover += new System.EventHandler(this.SettingsBtn_MouseHover);
            // 
            // ReportBtn
            // 
            this.ReportBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ReportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBtn.Image = global::QuanLyHocSinh.Properties.Resources.ReportButton1;
            this.ReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportBtn.Location = new System.Drawing.Point(-1, 296);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(72, 75);
            this.ReportBtn.TabIndex = 4;
            this.ReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReportBtn.UseVisualStyleBackColor = false;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            this.ReportBtn.MouseLeave += new System.EventHandler(this.ReportBtn_MouseLeave);
            this.ReportBtn.MouseHover += new System.EventHandler(this.ReportBtn_MouseHover);
            // 
            // ScoreBtn
            // 
            this.ScoreBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ScoreBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreBtn.Image = global::QuanLyHocSinh.Properties.Resources.ScoreButton_1_1;
            this.ScoreBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ScoreBtn.Location = new System.Drawing.Point(-1, 222);
            this.ScoreBtn.Name = "ScoreBtn";
            this.ScoreBtn.Size = new System.Drawing.Size(72, 75);
            this.ScoreBtn.TabIndex = 3;
            this.ScoreBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ScoreBtn.UseVisualStyleBackColor = false;
            this.ScoreBtn.Click += new System.EventHandler(this.ScoreBtn_Click);
            this.ScoreBtn.MouseLeave += new System.EventHandler(this.ScoreBtn_MouseLeave);
            this.ScoreBtn.MouseHover += new System.EventHandler(this.ScoreBtn_MouseHover);
            // 
            // ClassBtn
            // 
            this.ClassBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClassBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassBtn.Image = global::QuanLyHocSinh.Properties.Resources.ClassroomButton1;
            this.ClassBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClassBtn.Location = new System.Drawing.Point(-1, 148);
            this.ClassBtn.Name = "ClassBtn";
            this.ClassBtn.Size = new System.Drawing.Size(72, 75);
            this.ClassBtn.TabIndex = 2;
            this.ClassBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClassBtn.UseVisualStyleBackColor = false;
            this.ClassBtn.Click += new System.EventHandler(this.ClassBtn_Click);
            this.ClassBtn.MouseLeave += new System.EventHandler(this.ClassBtn_MouseLeave);
            this.ClassBtn.MouseHover += new System.EventHandler(this.ClassBtn_MouseHover);
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddStudentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentBtn.Image = global::QuanLyHocSinh.Properties.Resources.AddStudentButton1;
            this.AddStudentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddStudentBtn.Location = new System.Drawing.Point(-1, 0);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(72, 75);
            this.AddStudentBtn.TabIndex = 1;
            this.AddStudentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddStudentBtn.UseVisualStyleBackColor = false;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            this.AddStudentBtn.MouseLeave += new System.EventHandler(this.AddStudentBtn_MouseLeave);
            this.AddStudentBtn.MouseHover += new System.EventHandler(this.AddStudentBtn_MouseHover);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Image = global::QuanLyHocSinh.Properties.Resources.SearchButton_1_1;
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBtn.Location = new System.Drawing.Point(-1, 74);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(72, 75);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            this.SearchBtn.MouseLeave += new System.EventHandler(this.SearchBtn_MouseLeave);
            this.SearchBtn.MouseHover += new System.EventHandler(this.SearchBtn_MouseHover);
            // 
            // Main_Panel
            // 
            this.Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Main_Panel.Location = new System.Drawing.Point(74, -1);
            this.Main_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(1238, 732);
            this.Main_Panel.TabIndex = 1;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1314, 730);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.ReportBtn);
            this.Controls.Add(this.ScoreBtn);
            this.Controls.Add(this.ClassBtn);
            this.Controls.Add(this.AddStudentBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.OptionsPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Học Sinh";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ClassBtn;
        private System.Windows.Forms.Button ScoreBtn;
        private System.Windows.Forms.Button ReportBtn;
        private System.Windows.Forms.Button SettingsBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel Main_Panel;
    }
}

