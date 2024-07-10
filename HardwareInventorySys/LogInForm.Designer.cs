namespace HardwareInventorySys
{
    partial class LogInForm
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
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.HidePwordBtn = new System.Windows.Forms.Button();
            this.ShowPwordBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordWarnTxt = new System.Windows.Forms.Label();
            this.usernameWarnTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.BackColor = System.Drawing.Color.White;
            this.UsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(451, 167);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(291, 26);
            this.UsernameTxt.TabIndex = 0;
            this.UsernameTxt.TextChanged += new System.EventHandler(this.UsernameTxt_TextChanged);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BackColor = System.Drawing.Color.White;
            this.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(451, 239);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '•';
            this.PasswordTxt.Size = new System.Drawing.Size(291, 26);
            this.PasswordTxt.TabIndex = 1;
            this.PasswordTxt.TextChanged += new System.EventHandler(this.PasswordTxt_TextChanged);
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(153)))), ((int)(((byte)(234)))));
            this.LogInBtn.FlatAppearance.BorderSize = 0;
            this.LogInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInBtn.ForeColor = System.Drawing.Color.White;
            this.LogInBtn.Location = new System.Drawing.Point(523, 300);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(146, 34);
            this.LogInBtn.TabIndex = 2;
            this.LogInBtn.Text = "Login";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // HidePwordBtn
            // 
            this.HidePwordBtn.BackColor = System.Drawing.Color.White;
            this.HidePwordBtn.FlatAppearance.BorderSize = 0;
            this.HidePwordBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.HidePwordBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.HidePwordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HidePwordBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HidePwordBtn.Image = global::HardwareInventorySys.Properties.Resources.eye;
            this.HidePwordBtn.Location = new System.Drawing.Point(701, 241);
            this.HidePwordBtn.Name = "HidePwordBtn";
            this.HidePwordBtn.Size = new System.Drawing.Size(32, 22);
            this.HidePwordBtn.TabIndex = 0;
            this.HidePwordBtn.UseVisualStyleBackColor = false;
            this.HidePwordBtn.Click += new System.EventHandler(this.HidePwordBtn_Click);
            // 
            // ShowPwordBtn
            // 
            this.ShowPwordBtn.BackColor = System.Drawing.Color.White;
            this.ShowPwordBtn.FlatAppearance.BorderSize = 0;
            this.ShowPwordBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ShowPwordBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ShowPwordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPwordBtn.Image = global::HardwareInventorySys.Properties.Resources.hidden;
            this.ShowPwordBtn.Location = new System.Drawing.Point(701, 241);
            this.ShowPwordBtn.Name = "ShowPwordBtn";
            this.ShowPwordBtn.Size = new System.Drawing.Size(32, 22);
            this.ShowPwordBtn.TabIndex = 3;
            this.ShowPwordBtn.UseVisualStyleBackColor = false;
            this.ShowPwordBtn.Click += new System.EventHandler(this.ShowPwordBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(451, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(451, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // passwordWarnTxt
            // 
            this.passwordWarnTxt.AutoSize = true;
            this.passwordWarnTxt.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordWarnTxt.Location = new System.Drawing.Point(451, 268);
            this.passwordWarnTxt.Name = "passwordWarnTxt";
            this.passwordWarnTxt.Size = new System.Drawing.Size(0, 13);
            this.passwordWarnTxt.TabIndex = 6;
            // 
            // usernameWarnTxt
            // 
            this.usernameWarnTxt.AutoSize = true;
            this.usernameWarnTxt.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameWarnTxt.Location = new System.Drawing.Point(451, 196);
            this.usernameWarnTxt.Name = "usernameWarnTxt";
            this.usernameWarnTxt.Size = new System.Drawing.Size(0, 13);
            this.usernameWarnTxt.TabIndex = 7;
            this.usernameWarnTxt.Click += new System.EventHandler(this.usernameWarnTxt_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usernameWarnTxt);
            this.Controls.Add(this.passwordWarnTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowPwordBtn);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.HidePwordBtn);
            this.Controls.Add(this.PasswordTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Button ShowPwordBtn;
        private System.Windows.Forms.Button HidePwordBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label passwordWarnTxt;
        private System.Windows.Forms.Label usernameWarnTxt;
    }
}