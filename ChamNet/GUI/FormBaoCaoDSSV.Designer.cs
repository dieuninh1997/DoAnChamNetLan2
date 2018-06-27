namespace ChamNet.GUI
{
    partial class FormBaoCaoDSSV
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
            this.dSSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBCDSSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBCDSSV = new ChamNet.DataSetBCDSSV();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnxemtatca = new DevComponents.DotNetBar.ButtonX();
            this.btnxem = new DevComponents.DotNetBar.ButtonX();
            this.cbolop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dSSVTableAdapter = new ChamNet.DataSetBCDSSVTableAdapters.DSSVTableAdapter();
            this.rpt_dssv = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dSSVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBCDSSVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBCDSSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dSSVBindingSource
            // 
            this.dSSVBindingSource.DataMember = "DSSV";
            this.dSSVBindingSource.DataSource = this.dataSetBCDSSVBindingSource;
            // 
            // dataSetBCDSSVBindingSource
            // 
            this.dataSetBCDSSVBindingSource.DataSource = this.dataSetBCDSSV;
            this.dataSetBCDSSVBindingSource.Position = 0;
            // 
            // dataSetBCDSSV
            // 
            this.dataSetBCDSSV.DataSetName = "DataSetBCDSSV";
            this.dataSetBCDSSV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(112, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "Chọn lớp học:";
            // 
            // btnxemtatca
            // 
            this.btnxemtatca.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxemtatca.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxemtatca.Location = new System.Drawing.Point(459, 12);
            this.btnxemtatca.Name = "btnxemtatca";
            this.btnxemtatca.Size = new System.Drawing.Size(75, 23);
            this.btnxemtatca.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxemtatca.TabIndex = 9;
            this.btnxemtatca.Text = "Xem tất cả";
            this.btnxemtatca.Click += new System.EventHandler(this.btnxemtatca_Click);
            // 
            // btnxem
            // 
            this.btnxem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxem.Location = new System.Drawing.Point(354, 12);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(75, 23);
            this.btnxem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxem.TabIndex = 8;
            this.btnxem.Text = "Xem";
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // cbolop
            // 
            this.cbolop.DisplayMember = "Text";
            this.cbolop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbolop.FormattingEnabled = true;
            this.cbolop.ItemHeight = 14;
            this.cbolop.Location = new System.Drawing.Point(200, 13);
            this.cbolop.Name = "cbolop";
            this.cbolop.Size = new System.Drawing.Size(121, 20);
            this.cbolop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbolop.TabIndex = 7;
            // 
            // dSSVTableAdapter
            // 
            this.dSSVTableAdapter.ClearBeforeFill = true;
            // 
            // rpt_dssv
            // 
            this.rpt_dssv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dSSVBindingSource;
            this.rpt_dssv.LocalReport.DataSources.Add(reportDataSource1);
            this.rpt_dssv.LocalReport.ReportEmbeddedResource = "ChamNet.Reports.rptDSSV.rdlc";
            this.rpt_dssv.Location = new System.Drawing.Point(1, 60);
            this.rpt_dssv.Name = "rpt_dssv";
            this.rpt_dssv.Size = new System.Drawing.Size(790, 386);
            this.rpt_dssv.TabIndex = 12;
            // 
            // FormBaoCaoDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(793, 447);
            this.Controls.Add(this.rpt_dssv);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnxemtatca);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.cbolop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaoCaoDSSV";
            this.Text = "FormBaoCaoDSSV";
            this.Load += new System.EventHandler(this.FormBaoCaoDSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSSVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBCDSSVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBCDSSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnxemtatca;
        private DevComponents.DotNetBar.ButtonX btnxem;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbolop;
        private Microsoft.Reporting.WinForms.ReportViewer rptdssv;
        private System.Windows.Forms.BindingSource dataSetBCDSSVBindingSource;
        private DataSetBCDSSV dataSetBCDSSV;
        private System.Windows.Forms.BindingSource dSSVBindingSource;
        private DataSetBCDSSVTableAdapters.DSSVTableAdapter dSSVTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpt_dssv;
    }
}