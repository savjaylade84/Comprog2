namespace Comprog2Project
{
    partial class LoginFrm
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
            this.CorouselTimer = new System.Windows.Forms.Timer(this.components);
            this.UsernameValue = new System.Windows.Forms.TextBox();
            this.PasswordValue = new System.Windows.Forms.TextBox();
            this.LoginTitle = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ShowHideChkbx = new System.Windows.Forms.CheckBox();
            this.MainLoginPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseLbl = new System.Windows.Forms.Label();
            this.ImageCorousel = new System.Windows.Forms.Panel();
            this.MainLoginPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ImageCorousel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CorouselTimer
            // 
            this.CorouselTimer.Enabled = true;
            this.CorouselTimer.Interval = 5000;
            this.CorouselTimer.Tick += new System.EventHandler(this.CouroselSlides);
            // 
            // UsernameValue
            // 
            this.UsernameValue.BackColor = System.Drawing.Color.DimGray;
            this.UsernameValue.Font = new System.Drawing.Font("Cambria", 12.2F);
            this.UsernameValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UsernameValue.Location = new System.Drawing.Point(50, 100);
            this.UsernameValue.MaxLength = 50;
            this.UsernameValue.Name = "UsernameValue";
            this.UsernameValue.Size = new System.Drawing.Size(314, 31);
            this.UsernameValue.TabIndex = 2;
            this.UsernameValue.Text = "Username";
            // 
            // PasswordValue
            // 
            this.PasswordValue.BackColor = System.Drawing.Color.DimGray;
            this.PasswordValue.Font = new System.Drawing.Font("Cambria", 12.2F);
            this.PasswordValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordValue.Location = new System.Drawing.Point(50, 165);
            this.PasswordValue.MaxLength = 50;
            this.PasswordValue.Name = "PasswordValue";
            this.PasswordValue.Size = new System.Drawing.Size(314, 31);
            this.PasswordValue.TabIndex = 3;
            this.PasswordValue.Text = "Password";
            this.PasswordValue.Click += new System.EventHandler(this.PasswordChoose);
            // 
            // LoginTitle
            // 
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoginTitle.Location = new System.Drawing.Point(12, 9);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(73, 28);
            this.LoginTitle.TabIndex = 4;
            this.LoginTitle.Text = "Login";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Location = new System.Drawing.Point(46, 255);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(318, 43);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            this.LoginBtn.MouseLeave += new System.EventHandler(this.ChangeColorMouseLeave);
            this.LoginBtn.MouseHover += new System.EventHandler(this.ChangeColorMouseOver);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Location = new System.Drawing.Point(46, 317);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(318, 43);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            this.CancelBtn.MouseLeave += new System.EventHandler(this.ChangeColorMouseLeave);
            this.CancelBtn.MouseHover += new System.EventHandler(this.ChangeColorMouseOver);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Cambria", 9.2F);
            this.linkLabel1.Location = new System.Drawing.Point(47, 221);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 19);
            this.linkLabel1.TabIndex = 7;
            // 
            // ShowHideChkbx
            // 
            this.ShowHideChkbx.AutoSize = true;
            this.ShowHideChkbx.Location = new System.Drawing.Point(304, 198);
            this.ShowHideChkbx.Name = "ShowHideChkbx";
            this.ShowHideChkbx.Size = new System.Drawing.Size(70, 24);
            this.ShowHideChkbx.TabIndex = 8;
            this.ShowHideChkbx.Text = "Show";
            this.ShowHideChkbx.UseVisualStyleBackColor = true;
            this.ShowHideChkbx.CheckedChanged += new System.EventHandler(this.ShowHideChkbx_CheckedChanged);
            // 
            // MainLoginPanel
            // 
            this.MainLoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.MainLoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainLoginPanel.Controls.Add(this.ShowHideChkbx);
            this.MainLoginPanel.Controls.Add(this.linkLabel1);
            this.MainLoginPanel.Controls.Add(this.CancelBtn);
            this.MainLoginPanel.Controls.Add(this.LoginBtn);
            this.MainLoginPanel.Controls.Add(this.LoginTitle);
            this.MainLoginPanel.Controls.Add(this.PasswordValue);
            this.MainLoginPanel.Controls.Add(this.UsernameValue);
            this.MainLoginPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLoginPanel.Name = "MainLoginPanel";
            this.MainLoginPanel.Padding = new System.Windows.Forms.Padding(15);
            this.MainLoginPanel.Size = new System.Drawing.Size(423, 449);
            this.MainLoginPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.CloseLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 31);
            this.panel1.TabIndex = 0;
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.BackColor = System.Drawing.Color.Transparent;
            this.CloseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseLbl.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.CloseLbl.Location = new System.Drawing.Point(572, 0);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(34, 40);
            this.CloseLbl.TabIndex = 1;
            this.CloseLbl.Text = "x";
            this.CloseLbl.Click += new System.EventHandler(this.CloseLbl_Click);
            this.CloseLbl.MouseLeave += new System.EventHandler(this.CloseLbl_MouseLeave);
            this.CloseLbl.MouseHover += new System.EventHandler(this.CloseLbl_MouseHover);
            // 
            // ImageCorousel
            // 
            this.ImageCorousel.BackgroundImage = global::Comprog2Project.Properties.Resources._545916;
            this.ImageCorousel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageCorousel.Controls.Add(this.panel1);
            this.ImageCorousel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageCorousel.Location = new System.Drawing.Point(423, 0);
            this.ImageCorousel.Name = "ImageCorousel";
            this.ImageCorousel.Size = new System.Drawing.Size(606, 449);
            this.ImageCorousel.TabIndex = 1;
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 449);
            this.Controls.Add(this.ImageCorousel);
            this.Controls.Add(this.MainLoginPanel);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MainLoginPanel.ResumeLayout(false);
            this.MainLoginPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ImageCorousel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer CorouselTimer;
        private System.Windows.Forms.TextBox UsernameValue;
        private System.Windows.Forms.TextBox PasswordValue;
        private System.Windows.Forms.Label LoginTitle;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox ShowHideChkbx;
        private System.Windows.Forms.Panel MainLoginPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.Panel ImageCorousel;
    }
}