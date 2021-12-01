namespace QuanLyHocSinh
{
    partial class Form_GioiThieu
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
            this.Panel_Image = new System.Windows.Forms.Panel();
            this.Label_AppName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Panel_Image
            // 
            this.Panel_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Image.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.student;
            this.Panel_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel_Image.Location = new System.Drawing.Point(143, 12);
            this.Panel_Image.Name = "Panel_Image";
            this.Panel_Image.Size = new System.Drawing.Size(508, 291);
            this.Panel_Image.TabIndex = 0;
            // 
            // Label_AppName
            // 
            this.Label_AppName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label_AppName.AutoSize = true;
            this.Label_AppName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AppName.Location = new System.Drawing.Point(250, 353);
            this.Label_AppName.Name = "Label_AppName";
            this.Label_AppName.Size = new System.Drawing.Size(317, 37);
            this.Label_AppName.TabIndex = 1;
            this.Label_AppName.Text = "QUẢN LÝ HỌC SINH";
            this.Label_AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_GioiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_AppName);
            this.Controls.Add(this.Panel_Image);
            this.DoubleBuffered = true;
            this.Name = "Form_GioiThieu";
            this.Text = "Form_GioiThieu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Image;
        private System.Windows.Forms.Label Label_AppName;
    }
}