
namespace BasicGroceryStore
{
    partial class UCBrowser
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
            this.pnlBrowser = new System.Windows.Forms.Panel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlBrowser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBrowser
            // 
            this.pnlBrowser.Controls.Add(this.webBrowser);
            this.pnlBrowser.Location = new System.Drawing.Point(3, 54);
            this.pnlBrowser.Name = "pnlBrowser";
            this.pnlBrowser.Size = new System.Drawing.Size(1344, 803);
            this.pnlBrowser.TabIndex = 0;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1344, 803);
            this.webBrowser.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnRedo);
            this.panel1.Controls.Add(this.btnUndo);
            this.panel1.Controls.Add(this.txtContent);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 45);
            this.panel1.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Black;
            this.btnFind.BackgroundImage = global::BasicGroceryStore.Properties.Resources.search_64px;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.Location = new System.Drawing.Point(1285, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(56, 34);
            this.btnFind.TabIndex = 8;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Black;
            this.btnReload.BackgroundImage = global::BasicGroceryStore.Properties.Resources.hexagon_reload_64px;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReload.Location = new System.Drawing.Point(189, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(56, 34);
            this.btnReload.TabIndex = 7;
            this.btnReload.UseVisualStyleBackColor = false;
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.Black;
            this.btnRedo.BackgroundImage = global::BasicGroceryStore.Properties.Resources.redo_64px;
            this.btnRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRedo.Location = new System.Drawing.Point(127, 5);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(56, 34);
            this.btnRedo.TabIndex = 6;
            this.btnRedo.UseVisualStyleBackColor = false;
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Black;
            this.btnUndo.BackgroundImage = global::BasicGroceryStore.Properties.Resources.go_back_64px;
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUndo.Location = new System.Drawing.Point(65, 5);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(56, 34);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.UseVisualStyleBackColor = false;
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(251, 5);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(1028, 29);
            this.txtContent.TabIndex = 4;
            this.txtContent.Text = "www.google.com";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.BackgroundImage = global::BasicGroceryStore.Properties.Resources.home_50px;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(3, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(56, 34);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // UCBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBrowser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MistyRose;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCBrowser";
            this.Size = new System.Drawing.Size(1350, 860);
            this.pnlBrowser.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBrowser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}
