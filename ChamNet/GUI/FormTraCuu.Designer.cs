namespace ChamNet.GUI
{
    partial class FormTraCuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTraCuu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.btntimkiem = new DevComponents.DotNetBar.ButtonItem();
            this.btnrefresh = new DevComponents.DotNetBar.ButtonX();
            this.bdntimkiem = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvtimkiem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.navigationPane1 = new DevComponents.DotNetBar.NavigationPane();
            this.navigationPanePanel1 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.cbochuyennganh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tblChuyenNganhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbolop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tblLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btntracuu = new DevComponents.DotNetBar.ButtonX();
            this.cbodieukienchuyennganh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.label3 = new System.Windows.Forms.Label();
            this.cbodieukienlop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.cbodieukienqq = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            ((System.ComponentModel.ISupportInitialize)(this.bdntimkiem)).BeginInit();
            this.bdntimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.navigationPane1.SuspendLayout();
            this.navigationPanePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblChuyenNganhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chuyên ngành:";
            // 
            // btntimkiem
            // 
            this.btntimkiem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btntimkiem.Checked = true;
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.OptionGroup = "navBar";
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnrefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnrefresh.Image = global::ChamNet.Properties.Resources.refresh;
            this.btnrefresh.Location = new System.Drawing.Point(273, 12);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnrefresh.Size = new System.Drawing.Size(79, 33);
            this.btnrefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnrefresh.TabIndex = 17;
            this.btnrefresh.Text = "Refresh ";
            this.btnrefresh.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnrefresh.Tooltip = "Refresh ";
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // bdntimkiem
            // 
            this.bdntimkiem.AddNewItem = null;
            this.bdntimkiem.CountItem = this.bindingNavigatorCountItem;
            this.bdntimkiem.DeleteItem = null;
            this.bdntimkiem.Dock = System.Windows.Forms.DockStyle.None;
            this.bdntimkiem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bdntimkiem.Location = new System.Drawing.Point(5, 16);
            this.bdntimkiem.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdntimkiem.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdntimkiem.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdntimkiem.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdntimkiem.Name = "bdntimkiem";
            this.bdntimkiem.PositionItem = this.bindingNavigatorPositionItem;
            this.bdntimkiem.Size = new System.Drawing.Size(209, 25);
            this.bdntimkiem.TabIndex = 2;
            this.bdntimkiem.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvtimkiem
            // 
            this.dgvtimkiem.AllowUserToAddRows = false;
            this.dgvtimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtimkiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtimkiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvtimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtimkiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtimkiem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtimkiem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvtimkiem.Location = new System.Drawing.Point(3, 66);
            this.dgvtimkiem.Name = "dgvtimkiem";
            this.dgvtimkiem.ReadOnly = true;
            this.dgvtimkiem.Size = new System.Drawing.Size(639, 359);
            this.dgvtimkiem.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSV";
            this.Column1.HeaderText = "Mã sinh viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.HeaderText = "Họ và tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgaySinh";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GioiTinh";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "QueQuan";
            this.Column5.HeaderText = "Quê quán";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TenLop";
            this.Column6.HeaderText = "Lớp";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenChuyenNganh";
            this.Column7.HeaderText = "Chuyên ngành";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "AND";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnrefresh);
            this.groupBox1.Controls.Add(this.bdntimkiem);
            this.groupBox1.Controls.Add(this.dgvtimkiem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(218, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 428);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tìm kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPanePanel1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.ItemPaddingBottom = 2;
            this.navigationPane1.ItemPaddingTop = 2;
            this.navigationPane1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btntimkiem});
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.NavigationBarHeight = 67;
            this.navigationPane1.Padding = new System.Windows.Forms.Padding(1);
            this.navigationPane1.Size = new System.Drawing.Size(218, 428);
            this.navigationPane1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationPane1.TabIndex = 3;
            // 
            // 
            // 
            this.navigationPane1.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPane1.TitlePanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.navigationPane1.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPane1.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPane1.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navigationPane1.TitlePanel.Name = "panelTitle";
            this.navigationPane1.TitlePanel.Size = new System.Drawing.Size(216, 24);
            this.navigationPane1.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPane1.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.navigationPane1.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.navigationPane1.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPane1.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navigationPane1.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPane1.TitlePanel.Style.GradientAngle = 90;
            this.navigationPane1.TitlePanel.Style.MarginLeft = 4;
            this.navigationPane1.TitlePanel.TabIndex = 0;
            this.navigationPane1.TitlePanel.Text = "Tìm kiếm";
            // 
            // navigationPanePanel1
            // 
            this.navigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel1.Controls.Add(this.cbochuyennganh);
            this.navigationPanePanel1.Controls.Add(this.cbolop);
            this.navigationPanePanel1.Controls.Add(this.btntracuu);
            this.navigationPanePanel1.Controls.Add(this.cbodieukienchuyennganh);
            this.navigationPanePanel1.Controls.Add(this.label3);
            this.navigationPanePanel1.Controls.Add(this.cbodieukienlop);
            this.navigationPanePanel1.Controls.Add(this.label2);
            this.navigationPanePanel1.Controls.Add(this.txtquequan);
            this.navigationPanePanel1.Controls.Add(this.txthoten);
            this.navigationPanePanel1.Controls.Add(this.cbodieukienqq);
            this.navigationPanePanel1.Controls.Add(this.label4);
            this.navigationPanePanel1.Controls.Add(this.label1);
            this.navigationPanePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.navigationPanePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel1.Location = new System.Drawing.Point(1, 25);
            this.navigationPanePanel1.Name = "navigationPanePanel1";
            this.navigationPanePanel1.ParentItem = this.btntimkiem;
            this.navigationPanePanel1.Size = new System.Drawing.Size(216, 335);
            this.navigationPanePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel1.Style.GradientAngle = 90;
            this.navigationPanePanel1.TabIndex = 2;
            // 
            // cbochuyennganh
            // 
            this.cbochuyennganh.DataSource = this.tblChuyenNganhBindingSource;
            this.cbochuyennganh.DisplayMember = "TenChuyenNganh";
            this.cbochuyennganh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbochuyennganh.FormattingEnabled = true;
            this.cbochuyennganh.ItemHeight = 14;
            this.cbochuyennganh.Location = new System.Drawing.Point(34, 239);
            this.cbochuyennganh.Name = "cbochuyennganh";
            this.cbochuyennganh.Size = new System.Drawing.Size(145, 20);
            this.cbochuyennganh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbochuyennganh.TabIndex = 19;
            this.cbochuyennganh.ValueMember = "MaChuyenNganh";
            // 
            // tblChuyenNganhBindingSource
            // 
            this.tblChuyenNganhBindingSource.DataMember = "tblChuyenNganh";
            // 
            // cbolop
            // 
            this.cbolop.DataSource = this.tblLopBindingSource;
            this.cbolop.DisplayMember = "TenLop";
            this.cbolop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbolop.FormattingEnabled = true;
            this.cbolop.ItemHeight = 14;
            this.cbolop.Location = new System.Drawing.Point(34, 165);
            this.cbolop.Name = "cbolop";
            this.cbolop.Size = new System.Drawing.Size(145, 20);
            this.cbolop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbolop.TabIndex = 18;
            this.cbolop.ValueMember = "MaLop";
            // 
            // tblLopBindingSource
            // 
            this.tblLopBindingSource.DataMember = "tblLop";
            // 
            // btntracuu
            // 
            this.btntracuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btntracuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btntracuu.Location = new System.Drawing.Point(34, 281);
            this.btntracuu.Name = "btntracuu";
            this.btntracuu.Size = new System.Drawing.Size(145, 23);
            this.btntracuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btntracuu.TabIndex = 17;
            this.btntracuu.Text = "Tìm kiếm danh sách";
            this.btntracuu.Click += new System.EventHandler(this.btntracuu_Click);
            // 
            // cbodieukienchuyennganh
            // 
            this.cbodieukienchuyennganh.DisplayMember = "Text";
            this.cbodieukienchuyennganh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbodieukienchuyennganh.FormattingEnabled = true;
            this.cbodieukienchuyennganh.ItemHeight = 14;
            this.cbodieukienchuyennganh.Items.AddRange(new object[] {
            this.comboItem7,
            this.comboItem8,
            this.comboItem9});
            this.cbodieukienchuyennganh.Location = new System.Drawing.Point(112, 201);
            this.cbodieukienchuyennganh.Name = "cbodieukienchuyennganh";
            this.cbodieukienchuyennganh.Size = new System.Drawing.Size(67, 20);
            this.cbodieukienchuyennganh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbodieukienchuyennganh.TabIndex = 15;
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "NONE";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "OR";
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "AND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lớp:";
            // 
            // cbodieukienlop
            // 
            this.cbodieukienlop.DisplayMember = "Text";
            this.cbodieukienlop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbodieukienlop.FormattingEnabled = true;
            this.cbodieukienlop.ItemHeight = 14;
            this.cbodieukienlop.Items.AddRange(new object[] {
            this.comboItem4,
            this.comboItem5,
            this.comboItem6});
            this.cbodieukienlop.Location = new System.Drawing.Point(90, 133);
            this.cbodieukienlop.Name = "cbodieukienlop";
            this.cbodieukienlop.Size = new System.Drawing.Size(89, 20);
            this.cbodieukienlop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbodieukienlop.TabIndex = 12;
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "NONE";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "OR";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "AND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quê quán:";
            // 
            // txtquequan
            // 
            this.txtquequan.Location = new System.Drawing.Point(34, 99);
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(145, 20);
            this.txtquequan.TabIndex = 10;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(34, 28);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(145, 20);
            this.txthoten.TabIndex = 7;
            // 
            // cbodieukienqq
            // 
            this.cbodieukienqq.DisplayMember = "Text";
            this.cbodieukienqq.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbodieukienqq.FormattingEnabled = true;
            this.cbodieukienqq.ItemHeight = 14;
            this.cbodieukienqq.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.cbodieukienqq.Location = new System.Drawing.Point(90, 62);
            this.cbodieukienqq.Name = "cbodieukienqq";
            this.cbodieukienqq.Size = new System.Drawing.Size(89, 20);
            this.cbodieukienqq.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbodieukienqq.TabIndex = 6;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "NONE";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "OR";
            // 
            // FormTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(863, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navigationPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTraCuu";
            this.Text = "FormTraCuu";
            this.Load += new System.EventHandler(this.FormTraCuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdntimkiem)).EndInit();
            this.bdntimkiem.ResumeLayout(false);
            this.bdntimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPanePanel1.ResumeLayout(false);
            this.navigationPanePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblChuyenNganhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.ButtonItem btntimkiem;
        private DevComponents.DotNetBar.ButtonX btnrefresh;
        private System.Windows.Forms.BindingNavigator bdntimkiem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvtimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label1;
        private DevComponents.Editors.ComboItem comboItem3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.NavigationPane navigationPane1;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbochuyennganh;
        private System.Windows.Forms.BindingSource tblChuyenNganhBindingSource;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbolop;
        private System.Windows.Forms.BindingSource tblLopBindingSource;
        private DevComponents.DotNetBar.ButtonX btntracuu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbodieukienchuyennganh;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.Editors.ComboItem comboItem8;
        private DevComponents.Editors.ComboItem comboItem9;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbodieukienlop;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.TextBox txthoten;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbodieukienqq;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
    }
}