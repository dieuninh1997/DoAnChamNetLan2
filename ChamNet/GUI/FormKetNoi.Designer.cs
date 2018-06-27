namespace ChamNet.GUI
{
    partial class FormKetNoi
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
            this.cmbDatabase = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnKetNoi = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtServer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.DisplayMember = "Text";
            this.cmbDatabase.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.ItemHeight = 14;
            this.cmbDatabase.Location = new System.Drawing.Point(274, 84);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(153, 20);
            this.cmbDatabase.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbDatabase.TabIndex = 16;
            this.cmbDatabase.WatermarkText = "Tên database";
            this.cmbDatabase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDatabase_KeyDown);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(329, 157);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKetNoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnKetNoi.Location = new System.Drawing.Point(210, 157);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(75, 23);
            this.btnKetNoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnKetNoi.TabIndex = 14;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(190, 81);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "DataBase:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(190, 27);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "Server Name:";
            // 
            // txtServer
            // 
            // 
            // 
            // 
            this.txtServer.Border.Class = "TextBoxBorder";
            this.txtServer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtServer.Location = new System.Drawing.Point(274, 29);
            this.txtServer.Name = "txtServer";
            this.txtServer.PreventEnterBeep = true;
            this.txtServer.Size = new System.Drawing.Size(153, 20);
            this.txtServer.TabIndex = 17;
            this.txtServer.WatermarkText = "Tên server";
            this.txtServer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServer_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::ChamNet.Properties.Resources.database_29181;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormKetNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 215);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbDatabase);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtServer);
            this.Name = "FormKetNoi";
            this.Text = "FormKetNoi";
            this.Load += new System.EventHandler(this.FormKetNoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDatabase;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnKetNoi;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtServer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}