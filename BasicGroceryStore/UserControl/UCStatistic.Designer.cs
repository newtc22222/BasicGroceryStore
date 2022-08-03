
namespace BasicGroceryStore
{
    partial class UCStatistic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gbMakeReport = new System.Windows.Forms.GroupBox();
            this.gbChooseReportInfor = new System.Windows.Forms.GroupBox();
            this.chbReportStaff = new System.Windows.Forms.CheckBox();
            this.chbReportSupplier = new System.Windows.Forms.CheckBox();
            this.chbReportProduct = new System.Windows.Forms.CheckBox();
            this.chbReportImport = new System.Windows.Forms.CheckBox();
            this.chbReportOrder = new System.Windows.Forms.CheckBox();
            this.chbReportAll = new System.Windows.Forms.CheckBox();
            this.chbReportSpending = new System.Windows.Forms.CheckBox();
            this.chbReportIncome = new System.Windows.Forms.CheckBox();
            this.gbTimeReport = new System.Windows.Forms.GroupBox();
            this.radReportAll = new System.Windows.Forms.RadioButton();
            this.radReport1year = new System.Windows.Forms.RadioButton();
            this.radReport3months = new System.Windows.Forms.RadioButton();
            this.radReport30days = new System.Windows.Forms.RadioButton();
            this.radReport7days = new System.Windows.Forms.RadioButton();
            this.radReportToday = new System.Windows.Forms.RadioButton();
            this.btnOutputReport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbCheckTypeProductChart = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTypeChartProduct = new System.Windows.Forms.ComboBox();
            this.gbCheckTimeProduct = new System.Windows.Forms.GroupBox();
            this.btnMakeChartProduct = new System.Windows.Forms.Button();
            this.rad12monthsProduct = new System.Windows.Forms.RadioButton();
            this.rad30daysProduct = new System.Windows.Forms.RadioButton();
            this.rad7daysProduct = new System.Windows.Forms.RadioButton();
            this.cbInformationPlus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbSales = new System.Windows.Forms.GroupBox();
            this.gbCheckTime = new System.Windows.Forms.GroupBox();
            this.btnCreateChart = new System.Windows.Forms.Button();
            this.rad6months = new System.Windows.Forms.RadioButton();
            this.rad5years = new System.Windows.Forms.RadioButton();
            this.rad7days = new System.Windows.Forms.RadioButton();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbImportHistory = new System.Windows.Forms.GroupBox();
            this.btnReloadImportHistory = new System.Windows.Forms.Button();
            this.dgvImportHistory = new System.Windows.Forms.DataGridView();
            this.gbSellingHistory = new System.Windows.Forms.GroupBox();
            this.btnReloadSellingHistory = new System.Windows.Forms.Button();
            this.dgvSellingHistory = new System.Windows.Forms.DataGridView();
            this.pnlMain.SuspendLayout();
            this.gbMakeReport.SuspendLayout();
            this.gbChooseReportInfor.SuspendLayout();
            this.gbTimeReport.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbCheckTypeProductChart.SuspendLayout();
            this.gbCheckTimeProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbInformationPlus)).BeginInit();
            this.gbSales.SuspendLayout();
            this.gbCheckTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.gbImportHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportHistory)).BeginInit();
            this.gbSellingHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellingHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pnlMain.Controls.Add(this.gbMakeReport);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.gbSales);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1350, 860);
            this.pnlMain.TabIndex = 2;
            // 
            // gbMakeReport
            // 
            this.gbMakeReport.BackColor = System.Drawing.Color.Aquamarine;
            this.gbMakeReport.Controls.Add(this.gbChooseReportInfor);
            this.gbMakeReport.Controls.Add(this.gbTimeReport);
            this.gbMakeReport.Controls.Add(this.btnOutputReport);
            this.gbMakeReport.Location = new System.Drawing.Point(809, 539);
            this.gbMakeReport.Name = "gbMakeReport";
            this.gbMakeReport.Size = new System.Drawing.Size(538, 318);
            this.gbMakeReport.TabIndex = 2;
            this.gbMakeReport.TabStop = false;
            this.gbMakeReport.Text = "Tạo báo cáo";
            // 
            // gbChooseReportInfor
            // 
            this.gbChooseReportInfor.BackColor = System.Drawing.Color.Turquoise;
            this.gbChooseReportInfor.Controls.Add(this.chbReportStaff);
            this.gbChooseReportInfor.Controls.Add(this.chbReportSupplier);
            this.gbChooseReportInfor.Controls.Add(this.chbReportProduct);
            this.gbChooseReportInfor.Controls.Add(this.chbReportImport);
            this.gbChooseReportInfor.Controls.Add(this.chbReportOrder);
            this.gbChooseReportInfor.Controls.Add(this.chbReportAll);
            this.gbChooseReportInfor.Controls.Add(this.chbReportSpending);
            this.gbChooseReportInfor.Controls.Add(this.chbReportIncome);
            this.gbChooseReportInfor.ForeColor = System.Drawing.Color.Black;
            this.gbChooseReportInfor.Location = new System.Drawing.Point(229, 30);
            this.gbChooseReportInfor.Name = "gbChooseReportInfor";
            this.gbChooseReportInfor.Size = new System.Drawing.Size(297, 241);
            this.gbChooseReportInfor.TabIndex = 7;
            this.gbChooseReportInfor.TabStop = false;
            this.gbChooseReportInfor.Text = "Chọn thông tin";
            // 
            // chbReportStaff
            // 
            this.chbReportStaff.AutoSize = true;
            this.chbReportStaff.Location = new System.Drawing.Point(6, 173);
            this.chbReportStaff.Name = "chbReportStaff";
            this.chbReportStaff.Size = new System.Drawing.Size(115, 28);
            this.chbReportStaff.TabIndex = 8;
            this.chbReportStaff.Text = "Nhân viên";
            this.chbReportStaff.UseVisualStyleBackColor = true;
            // 
            // chbReportSupplier
            // 
            this.chbReportSupplier.AutoSize = true;
            this.chbReportSupplier.Location = new System.Drawing.Point(6, 138);
            this.chbReportSupplier.Name = "chbReportSupplier";
            this.chbReportSupplier.Size = new System.Drawing.Size(148, 28);
            this.chbReportSupplier.TabIndex = 7;
            this.chbReportSupplier.Text = "Nhà cung cấp";
            this.chbReportSupplier.UseVisualStyleBackColor = true;
            // 
            // chbReportProduct
            // 
            this.chbReportProduct.AutoSize = true;
            this.chbReportProduct.Location = new System.Drawing.Point(6, 103);
            this.chbReportProduct.Name = "chbReportProduct";
            this.chbReportProduct.Size = new System.Drawing.Size(115, 28);
            this.chbReportProduct.TabIndex = 6;
            this.chbReportProduct.Text = "Sản phẩm";
            this.chbReportProduct.UseVisualStyleBackColor = true;
            // 
            // chbReportImport
            // 
            this.chbReportImport.AutoSize = true;
            this.chbReportImport.Location = new System.Drawing.Point(6, 68);
            this.chbReportImport.Name = "chbReportImport";
            this.chbReportImport.Size = new System.Drawing.Size(126, 28);
            this.chbReportImport.TabIndex = 5;
            this.chbReportImport.Text = "Phiếu nhập";
            this.chbReportImport.UseVisualStyleBackColor = true;
            // 
            // chbReportOrder
            // 
            this.chbReportOrder.AutoSize = true;
            this.chbReportOrder.Location = new System.Drawing.Point(6, 33);
            this.chbReportOrder.Name = "chbReportOrder";
            this.chbReportOrder.Size = new System.Drawing.Size(103, 28);
            this.chbReportOrder.TabIndex = 4;
            this.chbReportOrder.Text = "Hóa đơn";
            this.chbReportOrder.UseVisualStyleBackColor = true;
            // 
            // chbReportAll
            // 
            this.chbReportAll.AutoSize = true;
            this.chbReportAll.Location = new System.Drawing.Point(6, 208);
            this.chbReportAll.Name = "chbReportAll";
            this.chbReportAll.Size = new System.Drawing.Size(80, 28);
            this.chbReportAll.TabIndex = 3;
            this.chbReportAll.Text = "Tất cả";
            this.chbReportAll.UseVisualStyleBackColor = true;
            // 
            // chbReportSpending
            // 
            this.chbReportSpending.AutoSize = true;
            this.chbReportSpending.Enabled = false;
            this.chbReportSpending.Location = new System.Drawing.Point(168, 66);
            this.chbReportSpending.Name = "chbReportSpending";
            this.chbReportSpending.Size = new System.Drawing.Size(92, 28);
            this.chbReportSpending.TabIndex = 1;
            this.chbReportSpending.Text = "Chi tiêu";
            this.chbReportSpending.UseVisualStyleBackColor = true;
            // 
            // chbReportIncome
            // 
            this.chbReportIncome.AutoSize = true;
            this.chbReportIncome.Enabled = false;
            this.chbReportIncome.Location = new System.Drawing.Point(168, 30);
            this.chbReportIncome.Name = "chbReportIncome";
            this.chbReportIncome.Size = new System.Drawing.Size(111, 28);
            this.chbReportIncome.TabIndex = 0;
            this.chbReportIncome.Text = "Thu nhập";
            this.chbReportIncome.UseVisualStyleBackColor = true;
            // 
            // gbTimeReport
            // 
            this.gbTimeReport.BackColor = System.Drawing.Color.Turquoise;
            this.gbTimeReport.Controls.Add(this.radReportAll);
            this.gbTimeReport.Controls.Add(this.radReport1year);
            this.gbTimeReport.Controls.Add(this.radReport3months);
            this.gbTimeReport.Controls.Add(this.radReport30days);
            this.gbTimeReport.Controls.Add(this.radReport7days);
            this.gbTimeReport.Controls.Add(this.radReportToday);
            this.gbTimeReport.ForeColor = System.Drawing.Color.Black;
            this.gbTimeReport.Location = new System.Drawing.Point(12, 30);
            this.gbTimeReport.Name = "gbTimeReport";
            this.gbTimeReport.Size = new System.Drawing.Size(211, 282);
            this.gbTimeReport.TabIndex = 8;
            this.gbTimeReport.TabStop = false;
            this.gbTimeReport.Text = "Chọn Thời gian";
            // 
            // radReportAll
            // 
            this.radReportAll.AutoSize = true;
            this.radReportAll.Location = new System.Drawing.Point(6, 240);
            this.radReportAll.Name = "radReportAll";
            this.radReportAll.Size = new System.Drawing.Size(99, 28);
            this.radReportAll.TabIndex = 5;
            this.radReportAll.Text = "Toàn bộ";
            this.radReportAll.UseVisualStyleBackColor = true;
            // 
            // radReport1year
            // 
            this.radReport1year.AutoSize = true;
            this.radReport1year.Location = new System.Drawing.Point(6, 198);
            this.radReport1year.Name = "radReport1year";
            this.radReport1year.Size = new System.Drawing.Size(80, 28);
            this.radReport1year.TabIndex = 4;
            this.radReport1year.Text = "1 năm";
            this.radReport1year.UseVisualStyleBackColor = true;
            // 
            // radReport3months
            // 
            this.radReport3months.AutoSize = true;
            this.radReport3months.Location = new System.Drawing.Point(6, 156);
            this.radReport3months.Name = "radReport3months";
            this.radReport3months.Size = new System.Drawing.Size(168, 28);
            this.radReport3months.TabIndex = 3;
            this.radReport3months.Text = "3 tháng gần nhất";
            this.radReport3months.UseVisualStyleBackColor = true;
            // 
            // radReport30days
            // 
            this.radReport30days.AutoSize = true;
            this.radReport30days.Location = new System.Drawing.Point(6, 114);
            this.radReport30days.Name = "radReport30days";
            this.radReport30days.Size = new System.Drawing.Size(94, 28);
            this.radReport30days.TabIndex = 2;
            this.radReport30days.Text = "30 ngày";
            this.radReport30days.UseVisualStyleBackColor = true;
            // 
            // radReport7days
            // 
            this.radReport7days.AutoSize = true;
            this.radReport7days.Location = new System.Drawing.Point(6, 72);
            this.radReport7days.Name = "radReport7days";
            this.radReport7days.Size = new System.Drawing.Size(84, 28);
            this.radReport7days.TabIndex = 1;
            this.radReport7days.Text = "7 ngày";
            this.radReport7days.UseVisualStyleBackColor = true;
            // 
            // radReportToday
            // 
            this.radReportToday.AutoSize = true;
            this.radReportToday.Checked = true;
            this.radReportToday.Location = new System.Drawing.Point(6, 30);
            this.radReportToday.Name = "radReportToday";
            this.radReportToday.Size = new System.Drawing.Size(104, 28);
            this.radReportToday.TabIndex = 0;
            this.radReportToday.TabStop = true;
            this.radReportToday.Text = "Hôm nay";
            this.radReportToday.UseVisualStyleBackColor = true;
            this.radReportToday.CheckedChanged += new System.EventHandler(this.radReportToday_CheckedChanged);
            // 
            // btnOutputReport
            // 
            this.btnOutputReport.Location = new System.Drawing.Point(229, 276);
            this.btnOutputReport.Name = "btnOutputReport";
            this.btnOutputReport.Size = new System.Drawing.Size(303, 36);
            this.btnOutputReport.TabIndex = 4;
            this.btnOutputReport.Text = "Xuất báo cáo";
            this.btnOutputReport.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox2.Controls.Add(this.gbCheckTypeProductChart);
            this.groupBox2.Controls.Add(this.gbCheckTimeProduct);
            this.groupBox2.Controls.Add(this.cbInformationPlus);
            this.groupBox2.Location = new System.Drawing.Point(809, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 530);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm trong cửa hàng";
            // 
            // gbCheckTypeProductChart
            // 
            this.gbCheckTypeProductChart.BackColor = System.Drawing.Color.Turquoise;
            this.gbCheckTypeProductChart.Controls.Add(this.comboBox1);
            this.gbCheckTypeProductChart.Controls.Add(this.label1);
            this.gbCheckTypeProductChart.Controls.Add(this.cbTypeChartProduct);
            this.gbCheckTypeProductChart.ForeColor = System.Drawing.Color.Black;
            this.gbCheckTypeProductChart.Location = new System.Drawing.Point(6, 30);
            this.gbCheckTypeProductChart.Name = "gbCheckTypeProductChart";
            this.gbCheckTypeProductChart.Size = new System.Drawing.Size(526, 136);
            this.gbCheckTypeProductChart.TabIndex = 9;
            this.gbCheckTypeProductChart.TabStop = false;
            this.gbCheckTypeProductChart.Text = "Chọn dạng biểu đồ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(514, 32);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chi tiết tìm kiếm bổ sung";
            // 
            // cbTypeChartProduct
            // 
            this.cbTypeChartProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeChartProduct.FormattingEnabled = true;
            this.cbTypeChartProduct.Items.AddRange(new object[] {
            "Phần trăm sản phẩm nhập vào theo tên",
            "Phần trăm sản phẩm nhập vào theo loại",
            "Phần trăm sản phẩm bán ra theo tên",
            "Phần trăm sản phẩm bán ra theo loại",
            "Doanh số sản phẩm bán ra tùy chọn"});
            this.cbTypeChartProduct.Location = new System.Drawing.Point(6, 30);
            this.cbTypeChartProduct.Name = "cbTypeChartProduct";
            this.cbTypeChartProduct.Size = new System.Drawing.Size(514, 32);
            this.cbTypeChartProduct.TabIndex = 0;
            // 
            // gbCheckTimeProduct
            // 
            this.gbCheckTimeProduct.BackColor = System.Drawing.Color.Turquoise;
            this.gbCheckTimeProduct.Controls.Add(this.btnMakeChartProduct);
            this.gbCheckTimeProduct.Controls.Add(this.rad12monthsProduct);
            this.gbCheckTimeProduct.Controls.Add(this.rad30daysProduct);
            this.gbCheckTimeProduct.Controls.Add(this.rad7daysProduct);
            this.gbCheckTimeProduct.ForeColor = System.Drawing.Color.Black;
            this.gbCheckTimeProduct.Location = new System.Drawing.Point(6, 172);
            this.gbCheckTimeProduct.Name = "gbCheckTimeProduct";
            this.gbCheckTimeProduct.Size = new System.Drawing.Size(526, 70);
            this.gbCheckTimeProduct.TabIndex = 8;
            this.gbCheckTimeProduct.TabStop = false;
            this.gbCheckTimeProduct.Text = "Chọn Thời gian";
            // 
            // btnMakeChartProduct
            // 
            this.btnMakeChartProduct.Location = new System.Drawing.Point(355, 27);
            this.btnMakeChartProduct.Name = "btnMakeChartProduct";
            this.btnMakeChartProduct.Size = new System.Drawing.Size(165, 36);
            this.btnMakeChartProduct.TabIndex = 3;
            this.btnMakeChartProduct.Text = "Tạo biểu đồ";
            this.btnMakeChartProduct.UseVisualStyleBackColor = true;
            // 
            // rad12monthsProduct
            // 
            this.rad12monthsProduct.AutoSize = true;
            this.rad12monthsProduct.Location = new System.Drawing.Point(217, 30);
            this.rad12monthsProduct.Name = "rad12monthsProduct";
            this.rad12monthsProduct.Size = new System.Drawing.Size(100, 28);
            this.rad12monthsProduct.TabIndex = 2;
            this.rad12monthsProduct.Text = "12 tháng";
            this.rad12monthsProduct.UseVisualStyleBackColor = true;
            // 
            // rad30daysProduct
            // 
            this.rad30daysProduct.AutoSize = true;
            this.rad30daysProduct.Location = new System.Drawing.Point(105, 30);
            this.rad30daysProduct.Name = "rad30daysProduct";
            this.rad30daysProduct.Size = new System.Drawing.Size(94, 28);
            this.rad30daysProduct.TabIndex = 1;
            this.rad30daysProduct.Text = "30 ngày";
            this.rad30daysProduct.UseVisualStyleBackColor = true;
            // 
            // rad7daysProduct
            // 
            this.rad7daysProduct.AutoSize = true;
            this.rad7daysProduct.Checked = true;
            this.rad7daysProduct.Location = new System.Drawing.Point(6, 30);
            this.rad7daysProduct.Name = "rad7daysProduct";
            this.rad7daysProduct.Size = new System.Drawing.Size(84, 28);
            this.rad7daysProduct.TabIndex = 0;
            this.rad7daysProduct.TabStop = true;
            this.rad7daysProduct.Text = "7 ngày";
            this.rad7daysProduct.UseVisualStyleBackColor = true;
            // 
            // cbInformationPlus
            // 
            chartArea6.Name = "ChartArea1";
            this.cbInformationPlus.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.cbInformationPlus.Legends.Add(legend6);
            this.cbInformationPlus.Location = new System.Drawing.Point(6, 248);
            this.cbInformationPlus.Name = "cbInformationPlus";
            this.cbInformationPlus.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.cbInformationPlus.Series.Add(series9);
            this.cbInformationPlus.Size = new System.Drawing.Size(526, 273);
            this.cbInformationPlus.TabIndex = 1;
            this.cbInformationPlus.Text = " ";
            // 
            // gbSales
            // 
            this.gbSales.BackColor = System.Drawing.Color.Aquamarine;
            this.gbSales.Controls.Add(this.gbCheckTime);
            this.gbSales.Controls.Add(this.chartSales);
            this.gbSales.Controls.Add(this.gbImportHistory);
            this.gbSales.Controls.Add(this.gbSellingHistory);
            this.gbSales.Location = new System.Drawing.Point(3, 3);
            this.gbSales.Name = "gbSales";
            this.gbSales.Size = new System.Drawing.Size(800, 854);
            this.gbSales.TabIndex = 0;
            this.gbSales.TabStop = false;
            this.gbSales.Text = "Thống kê doanh thu";
            // 
            // gbCheckTime
            // 
            this.gbCheckTime.BackColor = System.Drawing.Color.Turquoise;
            this.gbCheckTime.Controls.Add(this.btnCreateChart);
            this.gbCheckTime.Controls.Add(this.rad6months);
            this.gbCheckTime.Controls.Add(this.rad5years);
            this.gbCheckTime.Controls.Add(this.rad7days);
            this.gbCheckTime.ForeColor = System.Drawing.Color.Black;
            this.gbCheckTime.Location = new System.Drawing.Point(6, 361);
            this.gbCheckTime.Name = "gbCheckTime";
            this.gbCheckTime.Size = new System.Drawing.Size(782, 64);
            this.gbCheckTime.TabIndex = 7;
            this.gbCheckTime.TabStop = false;
            this.gbCheckTime.Text = "Biểu đồ doanh thu";
            // 
            // btnCreateChart
            // 
            this.btnCreateChart.Location = new System.Drawing.Point(472, 24);
            this.btnCreateChart.Name = "btnCreateChart";
            this.btnCreateChart.Size = new System.Drawing.Size(304, 34);
            this.btnCreateChart.TabIndex = 8;
            this.btnCreateChart.Text = "Tạo biểu đồ";
            this.btnCreateChart.UseVisualStyleBackColor = true;
            this.btnCreateChart.Click += new System.EventHandler(this.btnCreateChart_Click);
            // 
            // rad6months
            // 
            this.rad6months.AutoSize = true;
            this.rad6months.Location = new System.Drawing.Point(153, 28);
            this.rad6months.Name = "rad6months";
            this.rad6months.Size = new System.Drawing.Size(90, 28);
            this.rad6months.TabIndex = 2;
            this.rad6months.Text = "6 tháng";
            this.rad6months.UseVisualStyleBackColor = true;
            // 
            // rad5years
            // 
            this.rad5years.AutoSize = true;
            this.rad5years.Location = new System.Drawing.Point(306, 28);
            this.rad5years.Name = "rad5years";
            this.rad5years.Size = new System.Drawing.Size(80, 28);
            this.rad5years.TabIndex = 1;
            this.rad5years.Text = "5 năm";
            this.rad5years.UseVisualStyleBackColor = true;
            // 
            // rad7days
            // 
            this.rad7days.AutoSize = true;
            this.rad7days.Checked = true;
            this.rad7days.Location = new System.Drawing.Point(6, 28);
            this.rad7days.Name = "rad7days";
            this.rad7days.Size = new System.Drawing.Size(84, 28);
            this.rad7days.TabIndex = 0;
            this.rad7days.TabStop = true;
            this.rad7days.Text = "7 ngày";
            this.rad7days.UseVisualStyleBackColor = true;
            // 
            // chartSales
            // 
            this.chartSales.BorderlineWidth = 4;
            chartArea5.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartSales.Legends.Add(legend5);
            this.chartSales.Location = new System.Drawing.Point(6, 431);
            this.chartSales.Name = "chartSales";
            this.chartSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series7.BorderWidth = 4;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Thu nhập";
            series8.BorderWidth = 4;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Chi tiêu";
            this.chartSales.Series.Add(series7);
            this.chartSales.Series.Add(series8);
            this.chartSales.Size = new System.Drawing.Size(788, 417);
            this.chartSales.TabIndex = 5;
            this.chartSales.Text = "Biểu đồ thu nhập";
            // 
            // gbImportHistory
            // 
            this.gbImportHistory.BackColor = System.Drawing.Color.Turquoise;
            this.gbImportHistory.Controls.Add(this.btnReloadImportHistory);
            this.gbImportHistory.Controls.Add(this.dgvImportHistory);
            this.gbImportHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbImportHistory.Location = new System.Drawing.Point(406, 30);
            this.gbImportHistory.Name = "gbImportHistory";
            this.gbImportHistory.Size = new System.Drawing.Size(388, 325);
            this.gbImportHistory.TabIndex = 3;
            this.gbImportHistory.TabStop = false;
            this.gbImportHistory.Text = "Lịch sử nhập hàng";
            // 
            // btnReloadImportHistory
            // 
            this.btnReloadImportHistory.Location = new System.Drawing.Point(6, 286);
            this.btnReloadImportHistory.Name = "btnReloadImportHistory";
            this.btnReloadImportHistory.Size = new System.Drawing.Size(370, 33);
            this.btnReloadImportHistory.TabIndex = 2;
            this.btnReloadImportHistory.Text = "Tải lại";
            this.btnReloadImportHistory.UseVisualStyleBackColor = true;
            this.btnReloadImportHistory.Click += new System.EventHandler(this.btnReloadImportHistory_Click);
            // 
            // dgvImportHistory
            // 
            this.dgvImportHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImportHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportHistory.Location = new System.Drawing.Point(6, 26);
            this.dgvImportHistory.Name = "dgvImportHistory";
            this.dgvImportHistory.ReadOnly = true;
            this.dgvImportHistory.RowHeadersVisible = false;
            this.dgvImportHistory.Size = new System.Drawing.Size(376, 254);
            this.dgvImportHistory.TabIndex = 0;
            this.dgvImportHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImportHistory_CellClick);
            // 
            // gbSellingHistory
            // 
            this.gbSellingHistory.BackColor = System.Drawing.Color.Turquoise;
            this.gbSellingHistory.Controls.Add(this.btnReloadSellingHistory);
            this.gbSellingHistory.Controls.Add(this.dgvSellingHistory);
            this.gbSellingHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSellingHistory.Location = new System.Drawing.Point(6, 30);
            this.gbSellingHistory.Name = "gbSellingHistory";
            this.gbSellingHistory.Size = new System.Drawing.Size(394, 325);
            this.gbSellingHistory.TabIndex = 0;
            this.gbSellingHistory.TabStop = false;
            this.gbSellingHistory.Text = "Lịch sử bán hàng";
            // 
            // btnReloadSellingHistory
            // 
            this.btnReloadSellingHistory.Location = new System.Drawing.Point(6, 286);
            this.btnReloadSellingHistory.Name = "btnReloadSellingHistory";
            this.btnReloadSellingHistory.Size = new System.Drawing.Size(380, 33);
            this.btnReloadSellingHistory.TabIndex = 2;
            this.btnReloadSellingHistory.Text = "Tải lại";
            this.btnReloadSellingHistory.UseVisualStyleBackColor = true;
            this.btnReloadSellingHistory.Click += new System.EventHandler(this.btnReloadSellingHistory_Click);
            // 
            // dgvSellingHistory
            // 
            this.dgvSellingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellingHistory.Location = new System.Drawing.Point(6, 26);
            this.dgvSellingHistory.Name = "dgvSellingHistory";
            this.dgvSellingHistory.ReadOnly = true;
            this.dgvSellingHistory.RowHeadersVisible = false;
            this.dgvSellingHistory.Size = new System.Drawing.Size(382, 254);
            this.dgvSellingHistory.TabIndex = 0;
            this.dgvSellingHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSellingHistory_CellClick);
            // 
            // UCStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UCStatistic";
            this.Size = new System.Drawing.Size(1350, 860);
            this.pnlMain.ResumeLayout(false);
            this.gbMakeReport.ResumeLayout(false);
            this.gbChooseReportInfor.ResumeLayout(false);
            this.gbChooseReportInfor.PerformLayout();
            this.gbTimeReport.ResumeLayout(false);
            this.gbTimeReport.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbCheckTypeProductChart.ResumeLayout(false);
            this.gbCheckTypeProductChart.PerformLayout();
            this.gbCheckTimeProduct.ResumeLayout(false);
            this.gbCheckTimeProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbInformationPlus)).EndInit();
            this.gbSales.ResumeLayout(false);
            this.gbCheckTime.ResumeLayout(false);
            this.gbCheckTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.gbImportHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportHistory)).EndInit();
            this.gbSellingHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellingHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox gbSales;
        private System.Windows.Forms.GroupBox gbMakeReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbSellingHistory;
        private System.Windows.Forms.Button btnCreateChart;
        private System.Windows.Forms.GroupBox gbCheckTime;
        private System.Windows.Forms.RadioButton rad6months;
        private System.Windows.Forms.RadioButton rad5years;
        private System.Windows.Forms.RadioButton rad7days;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.GroupBox gbImportHistory;
        private System.Windows.Forms.Button btnReloadImportHistory;
        private System.Windows.Forms.DataGridView dgvImportHistory;
        private System.Windows.Forms.Button btnReloadSellingHistory;
        private System.Windows.Forms.DataGridView dgvSellingHistory;
        private System.Windows.Forms.DataVisualization.Charting.Chart cbInformationPlus;
        private System.Windows.Forms.GroupBox gbCheckTypeProductChart;
        private System.Windows.Forms.GroupBox gbCheckTimeProduct;
        private System.Windows.Forms.RadioButton rad12monthsProduct;
        private System.Windows.Forms.RadioButton rad30daysProduct;
        private System.Windows.Forms.RadioButton rad7daysProduct;
        private System.Windows.Forms.ComboBox cbTypeChartProduct;
        private System.Windows.Forms.Button btnMakeChartProduct;
        private System.Windows.Forms.GroupBox gbChooseReportInfor;
        private System.Windows.Forms.CheckBox chbReportImport;
        private System.Windows.Forms.CheckBox chbReportOrder;
        private System.Windows.Forms.CheckBox chbReportAll;
        private System.Windows.Forms.CheckBox chbReportSpending;
        private System.Windows.Forms.CheckBox chbReportIncome;
        private System.Windows.Forms.GroupBox gbTimeReport;
        private System.Windows.Forms.RadioButton radReportAll;
        private System.Windows.Forms.RadioButton radReport1year;
        private System.Windows.Forms.RadioButton radReport3months;
        private System.Windows.Forms.RadioButton radReport30days;
        private System.Windows.Forms.RadioButton radReport7days;
        private System.Windows.Forms.RadioButton radReportToday;
        private System.Windows.Forms.Button btnOutputReport;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbReportStaff;
        private System.Windows.Forms.CheckBox chbReportSupplier;
        private System.Windows.Forms.CheckBox chbReportProduct;
    }
}
