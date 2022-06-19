
namespace BasicGroceryStore
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.cbSetting = new System.Windows.Forms.ComboBox();
            this.lblTabShow = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlContainer.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlMain);
            this.pnlContainer.Controls.Add(this.pnlControl);
            this.pnlContainer.Controls.Add(this.pnlMove);
            this.pnlContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1600, 900);
            this.pnlContainer.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(250, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1350, 860);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.Gold;
            this.pnlControl.Controls.Add(this.btnCalendar);
            this.pnlControl.Controls.Add(this.btnBrowser);
            this.pnlControl.Controls.Add(this.lblTime);
            this.pnlControl.Controls.Add(this.monthCalendar1);
            this.pnlControl.Controls.Add(this.btnStaff);
            this.pnlControl.Controls.Add(this.btnStatistic);
            this.pnlControl.Controls.Add(this.btnImport);
            this.pnlControl.Controls.Add(this.btnOrder);
            this.pnlControl.Controls.Add(this.btnProduct);
            this.pnlControl.Controls.Add(this.btnHomePage);
            this.pnlControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlControl.Location = new System.Drawing.Point(0, 40);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(250, 860);
            this.pnlControl.TabIndex = 1;
            // 
            // btnCalendar
            // 
            this.btnCalendar.Enabled = false;
            this.btnCalendar.Image = global::BasicGroceryStore.Properties.Resources.icons8_Tear_Off_Calendar_32;
            this.btnCalendar.Location = new System.Drawing.Point(3, 390);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(241, 53);
            this.btnCalendar.TabIndex = 9;
            this.btnCalendar.Text = "LỊCH BIỂU";
            this.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Enabled = false;
            this.btnBrowser.Image = global::BasicGroceryStore.Properties.Resources.icons8_mint_browser_32;
            this.btnBrowser.Location = new System.Drawing.Point(3, 454);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(241, 53);
            this.btnBrowser.TabIndex = 8;
            this.btnBrowser.Text = "TRÌNH DUYỆT";
            this.btnBrowser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 804);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 24);
            this.lblTime.TabIndex = 7;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(11, 633);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // btnStaff
            // 
            this.btnStaff.Image = global::BasicGroceryStore.Properties.Resources.icons8_staff_32;
            this.btnStaff.Location = new System.Drawing.Point(3, 326);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(241, 53);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "NHÂN VIÊN";
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Image = global::BasicGroceryStore.Properties.Resources.icons8_plot_32;
            this.btnStatistic.Location = new System.Drawing.Point(3, 262);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(241, 53);
            this.btnStatistic.TabIndex = 4;
            this.btnStatistic.Text = "THỐNG KÊ";
            this.btnStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnImport
            // 
            this.btnImport.Image = global::BasicGroceryStore.Properties.Resources.icons8_import_32;
            this.btnImport.Location = new System.Drawing.Point(3, 198);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(241, 53);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "NHẬP HÀNG";
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Image = global::BasicGroceryStore.Properties.Resources.icons8_purchase_order_32;
            this.btnOrder.Location = new System.Drawing.Point(3, 134);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(241, 53);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "BÁN HÀNG";
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Image = global::BasicGroceryStore.Properties.Resources.icons8_product_32;
            this.btnProduct.Location = new System.Drawing.Point(3, 70);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(241, 53);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "SẢN PHẨM";
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Image = global::BasicGroceryStore.Properties.Resources.icons8_home_32;
            this.btnHomePage.Location = new System.Drawing.Point(3, 6);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(241, 53);
            this.btnHomePage.TabIndex = 0;
            this.btnHomePage.Text = "TRANG CHỦ";
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlMove.Controls.Add(this.cbSetting);
            this.pnlMove.Controls.Add(this.lblTabShow);
            this.pnlMove.Controls.Add(this.btnMinimize);
            this.pnlMove.Controls.Add(this.btnClose);
            this.pnlMove.Location = new System.Drawing.Point(0, 0);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(1600, 40);
            this.pnlMove.TabIndex = 0;
            this.pnlMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseDown);
            this.pnlMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseMove);
            this.pnlMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseUp);
            // 
            // cbSetting
            // 
            this.cbSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSetting.FormattingEnabled = true;
            this.cbSetting.Location = new System.Drawing.Point(1253, 4);
            this.cbSetting.Name = "cbSetting";
            this.cbSetting.Size = new System.Drawing.Size(216, 32);
            this.cbSetting.TabIndex = 3;
            this.cbSetting.SelectedIndexChanged += new System.EventHandler(this.cbSetting_SelectedIndexChanged);
            // 
            // lblTabShow
            // 
            this.lblTabShow.AutoSize = true;
            this.lblTabShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTabShow.Location = new System.Drawing.Point(12, 7);
            this.lblTabShow.Name = "lblTabShow";
            this.lblTabShow.Size = new System.Drawing.Size(187, 24);
            this.lblTabShow.TabIndex = 2;
            this.lblTabShow.Text = "Tab đang hiển thị: ";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::BasicGroceryStore.Properties.Resources.subtract_26px;
            this.btnMinimize.Location = new System.Drawing.Point(1475, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(58, 40);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::BasicGroceryStore.Properties.Resources.Close_26px;
            this.btnClose.Location = new System.Drawing.Point(1539, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.pnlContainer.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.pnlMove.ResumeLayout(false);
            this.pnlMove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Label lblTabShow;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.ComboBox cbSetting;
        private System.Windows.Forms.Button btnCalendar;
    }
}

