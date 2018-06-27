namespace ChamNet.GUI
{
    partial class FormBaoCaoDiem
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vwDSDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAll = new ChamNet.DataSetAll();
            this.btnthongke = new DevComponents.DotNetBar.ButtonX();
            this.btntatca = new DevComponents.DotNetBar.ButtonX();
            this.cbolop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rptdsdiem = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbonamhoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.vw_DSDiemTableAdapter = new ChamNet.DataSetAllTableAdapters.vw_DSDiemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vwDSDiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAll)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vwDSDiemBindingSource
            // 
            this.vwDSDiemBindingSource.DataMember = "vw_DSDiem";
            this.vwDSDiemBindingSource.DataSource = this.dataSetAll;
            // 
            // dataSetAll
            // 
            this.dataSetAll.DataSetName = "DataSetAll";
            this.dataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnthongke
            // 
            this.btnthongke.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthongke.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthongke.Location = new System.Drawing.Point(426, 14);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(75, 23);
            this.btnthongke.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthongke.TabIndex = 13;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // btntatca
            // 
            this.btntatca.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btntatca.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btntatca.Location = new System.Drawing.Point(541, 13);
            this.btntatca.Name = "btntatca";
            this.btntatca.Size = new System.Drawing.Size(75, 23);
            this.btntatca.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btntatca.TabIndex = 14;
            this.btntatca.Text = "Tất cả";
            this.btntatca.Click += new System.EventHandler(this.btntatca_Click);
            // 
            // cbolop
            // 
            this.cbolop.DisplayMember = "MaLop";
            this.cbolop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbolop.FormattingEnabled = true;
            this.cbolop.ItemHeight = 14;
            this.cbolop.Location = new System.Drawing.Point(260, 13);
            this.cbolop.Name = "cbolop";
            this.cbolop.Size = new System.Drawing.Size(107, 20);
            this.cbolop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbolop.TabIndex = 12;
            this.cbolop.ValueMember = "MaLop";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(231, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(34, 23);
            this.labelX2.TabIndex = 10;
            this.labelX2.Text = "Lớp:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(36, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(58, 23);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "Năm học:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rptdsdiem);
            this.panel1.Location = new System.Drawing.Point(1, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 380);
            this.panel1.TabIndex = 8;
            // 
            // rptdsdiem
            // 
            this.rptdsdiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vwDSDiemBindingSource;
            this.rptdsdiem.LocalReport.DataSources.Add(reportDataSource1);
            this.rptdsdiem.LocalReport.ReportEmbeddedResource = "ChamNet.Reports.rptDSDiem.rdlc";
            this.rptdsdiem.Location = new System.Drawing.Point(0, 0);
            this.rptdsdiem.Name = "rptdsdiem";
            this.rptdsdiem.Size = new System.Drawing.Size(889, 380);
            this.rptdsdiem.TabIndex = 0;
            // 
            // cbonamhoc
            // 
            this.cbonamhoc.DisplayMember = "Text";
            this.cbonamhoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbonamhoc.FormattingEnabled = true;
            this.cbonamhoc.ItemHeight = 14;
            this.cbonamhoc.Location = new System.Drawing.Point(91, 14);
            this.cbonamhoc.Name = "cbonamhoc";
            this.cbonamhoc.Size = new System.Drawing.Size(97, 20);
            this.cbonamhoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbonamhoc.TabIndex = 11;
            // 
            // vw_DSDiemTableAdapter
            // 
            this.vw_DSDiemTableAdapter.ClearBeforeFill = true;
            // 
            // FormBaoCaoDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(890, 462);
            this.Controls.Add(this.btnthongke);
            this.Controls.Add(this.btntatca);
            this.Controls.Add(this.cbolop);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbonamhoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaoCaoDiem";
            this.Text = "FormBaoCaoDiem";
            this.Load += new System.EventHandler(this.FormBaoCaoDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwDSDiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAll)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnthongke;
        private DevComponents.DotNetBar.ButtonX btntatca;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbolop;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbonamhoc;
        private Microsoft.Reporting.WinForms.ReportViewer rptdsdiem;
        private DataSetAll dataSetAll;
        private System.Windows.Forms.BindingSource vwDSDiemBindingSource;
        private DataSetAllTableAdapters.vw_DSDiemTableAdapter vw_DSDiemTableAdapter;
    }
}