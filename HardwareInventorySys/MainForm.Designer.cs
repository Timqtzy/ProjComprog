namespace HardwareInventorySys
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
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MaximizeBtn = new System.Windows.Forms.Button();
            this.logoIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogoNameLabel = new System.Windows.Forms.Label();
            this.RestoreDownBtn = new System.Windows.Forms.Button();
            this.NavPanel = new System.Windows.Forms.Panel();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.SalesReportBtn = new System.Windows.Forms.Button();
            this.CategoryBtn = new System.Windows.Forms.Button();
            this.ProductBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.salesReportForm1 = new HardwareInventorySys.SalesReportForm();
            this.dashboardForm1 = new HardwareInventorySys.DashboardForm();
            this.productForm1 = new HardwareInventorySys.ProductForm();
            this.categoryForm1 = new HardwareInventorySys.Pages.CategoryForm();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoIcon)).BeginInit();
            this.NavPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.Transparent;
            this.UpperPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpperPanel.Controls.Add(this.MinimizeBtn);
            this.UpperPanel.Controls.Add(this.CloseBtn);
            this.UpperPanel.Controls.Add(this.MaximizeBtn);
            this.UpperPanel.Controls.Add(this.logoIcon);
            this.UpperPanel.Controls.Add(this.panel2);
            this.UpperPanel.Controls.Add(this.LogoNameLabel);
            this.UpperPanel.Controls.Add(this.RestoreDownBtn);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(1000, 30);
            this.UpperPanel.TabIndex = 0;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBtn.Image = global::HardwareInventorySys.Properties.Resources.icons8_minimize_161;
            this.MinimizeBtn.Location = new System.Drawing.Point(866, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(40, 30);
            this.MinimizeBtn.TabIndex = 1;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Image = global::HardwareInventorySys.Properties.Resources.icons8_close_161;
            this.CloseBtn.Location = new System.Drawing.Point(958, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(40, 30);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeBtn.FlatAppearance.BorderSize = 0;
            this.MaximizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBtn.Image = global::HardwareInventorySys.Properties.Resources.icons8_maximize_161;
            this.MaximizeBtn.Location = new System.Drawing.Point(912, 0);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Size = new System.Drawing.Size(40, 30);
            this.MaximizeBtn.TabIndex = 2;
            this.MaximizeBtn.UseVisualStyleBackColor = true;
            this.MaximizeBtn.Click += new System.EventHandler(this.MaximizeBtn_Click);
            // 
            // logoIcon
            // 
            this.logoIcon.Location = new System.Drawing.Point(7, 0);
            this.logoIcon.Name = "logoIcon";
            this.logoIcon.Size = new System.Drawing.Size(48, 30);
            this.logoIcon.TabIndex = 2;
            this.logoIcon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(200, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 570);
            this.panel2.TabIndex = 4;
            // 
            // LogoNameLabel
            // 
            this.LogoNameLabel.AutoSize = true;
            this.LogoNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoNameLabel.ForeColor = System.Drawing.Color.White;
            this.LogoNameLabel.Location = new System.Drawing.Point(61, 5);
            this.LogoNameLabel.Name = "LogoNameLabel";
            this.LogoNameLabel.Size = new System.Drawing.Size(204, 20);
            this.LogoNameLabel.TabIndex = 1;
            this.LogoNameLabel.Text = "Hardware Inventory System";
            // 
            // RestoreDownBtn
            // 
            this.RestoreDownBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreDownBtn.FlatAppearance.BorderSize = 0;
            this.RestoreDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreDownBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreDownBtn.Image = global::HardwareInventorySys.Properties.Resources.icons8_restore_down_162;
            this.RestoreDownBtn.Location = new System.Drawing.Point(912, 0);
            this.RestoreDownBtn.Name = "RestoreDownBtn";
            this.RestoreDownBtn.Size = new System.Drawing.Size(40, 30);
            this.RestoreDownBtn.TabIndex = 3;
            this.RestoreDownBtn.UseVisualStyleBackColor = true;
            this.RestoreDownBtn.Click += new System.EventHandler(this.RestoreDownBtn_Click);
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.NavPanel.Controls.Add(this.LogOutBtn);
            this.NavPanel.Controls.Add(this.SalesReportBtn);
            this.NavPanel.Controls.Add(this.CategoryBtn);
            this.NavPanel.Controls.Add(this.ProductBtn);
            this.NavPanel.Controls.Add(this.DashboardBtn);
            this.NavPanel.Controls.Add(this.panel1);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavPanel.Location = new System.Drawing.Point(0, 30);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(200, 570);
            this.NavPanel.TabIndex = 1;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogOutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogOutBtn.FlatAppearance.BorderSize = 0;
            this.LogOutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.ForeColor = System.Drawing.Color.White;
            this.LogOutBtn.Image = global::HardwareInventorySys.Properties.Resources.LogoutNew1;
            this.LogOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutBtn.Location = new System.Drawing.Point(0, 525);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LogOutBtn.Size = new System.Drawing.Size(200, 45);
            this.LogOutBtn.TabIndex = 5;
            this.LogOutBtn.Text = "          Logout";
            this.LogOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // SalesReportBtn
            // 
            this.SalesReportBtn.BackColor = System.Drawing.Color.Transparent;
            this.SalesReportBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalesReportBtn.FlatAppearance.BorderSize = 0;
            this.SalesReportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.SalesReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesReportBtn.ForeColor = System.Drawing.Color.White;
            this.SalesReportBtn.Image = global::HardwareInventorySys.Properties.Resources.SalesreportNew;
            this.SalesReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesReportBtn.Location = new System.Drawing.Point(0, 272);
            this.SalesReportBtn.Name = "SalesReportBtn";
            this.SalesReportBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SalesReportBtn.Size = new System.Drawing.Size(200, 45);
            this.SalesReportBtn.TabIndex = 4;
            this.SalesReportBtn.Text = "          Sales Report";
            this.SalesReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesReportBtn.UseVisualStyleBackColor = false;
            this.SalesReportBtn.Click += new System.EventHandler(this.SalesReportBtn_Click);
            // 
            // CategoryBtn
            // 
            this.CategoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.CategoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoryBtn.FlatAppearance.BorderSize = 0;
            this.CategoryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.CategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryBtn.ForeColor = System.Drawing.Color.White;
            this.CategoryBtn.Image = global::HardwareInventorySys.Properties.Resources.CategoryNew;
            this.CategoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CategoryBtn.Location = new System.Drawing.Point(0, 227);
            this.CategoryBtn.Name = "CategoryBtn";
            this.CategoryBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.CategoryBtn.Size = new System.Drawing.Size(200, 45);
            this.CategoryBtn.TabIndex = 3;
            this.CategoryBtn.Text = "          Category";
            this.CategoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CategoryBtn.UseVisualStyleBackColor = false;
            this.CategoryBtn.Click += new System.EventHandler(this.CategoryBtn_Click);
            // 
            // ProductBtn
            // 
            this.ProductBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProductBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductBtn.FlatAppearance.BorderSize = 0;
            this.ProductBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.ProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBtn.ForeColor = System.Drawing.Color.White;
            this.ProductBtn.Image = global::HardwareInventorySys.Properties.Resources.ProductNew;
            this.ProductBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductBtn.Location = new System.Drawing.Point(0, 182);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ProductBtn.Size = new System.Drawing.Size(200, 45);
            this.ProductBtn.TabIndex = 2;
            this.ProductBtn.Text = "          Product";
            this.ProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductBtn.UseVisualStyleBackColor = false;
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.DashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardBtn.FlatAppearance.BorderSize = 0;
            this.DashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.ForeColor = System.Drawing.Color.White;
            this.DashboardBtn.Image = global::HardwareInventorySys.Properties.Resources.DashboardNew;
            this.DashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBtn.Location = new System.Drawing.Point(0, 137);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.DashboardBtn.Size = new System.Drawing.Size(200, 45);
            this.DashboardBtn.TabIndex = 1;
            this.DashboardBtn.Text = "          Dashboard";
            this.DashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBtn.UseVisualStyleBackColor = false;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 137);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.panel3.Controls.Add(this.dashboardForm1);
            this.panel3.Controls.Add(this.productForm1);
            this.panel3.Controls.Add(this.categoryForm1);
            this.panel3.Controls.Add(this.salesReportForm1);
            this.panel3.Location = new System.Drawing.Point(200, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 570);
            this.panel3.TabIndex = 2;
            // 
            // salesReportForm1
            // 
            this.salesReportForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.salesReportForm1.Location = new System.Drawing.Point(0, 0);
            this.salesReportForm1.Name = "salesReportForm1";
            this.salesReportForm1.Size = new System.Drawing.Size(800, 570);
            this.salesReportForm1.TabIndex = 3;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.dashboardForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardForm1.Location = new System.Drawing.Point(0, 0);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(800, 570);
            this.dashboardForm1.TabIndex = 0;
            // 
            // productForm1
            // 
            this.productForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.productForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productForm1.Location = new System.Drawing.Point(0, 0);
            this.productForm1.Name = "productForm1";
            this.productForm1.Size = new System.Drawing.Size(800, 570);
            this.productForm1.TabIndex = 1;
            // 
            // categoryForm1
            // 
            this.categoryForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryForm1.Location = new System.Drawing.Point(0, 0);
            this.categoryForm1.Name = "categoryForm1";
            this.categoryForm1.Size = new System.Drawing.Size(800, 570);
            this.categoryForm1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.NavPanel);
            this.Controls.Add(this.UpperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoIcon)).EndInit();
            this.NavPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button MaximizeBtn;
        private System.Windows.Forms.PictureBox logoIcon;
        private System.Windows.Forms.Label LogoNameLabel;
        private System.Windows.Forms.Button RestoreDownBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button SalesReportBtn;
        private System.Windows.Forms.Button CategoryBtn;
        private System.Windows.Forms.Button ProductBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DashboardForm dashboardForm1;
        private ProductForm productForm1;
        private Pages.CategoryForm categoryForm1;
        private SalesReportForm salesReportForm1;
    }
}