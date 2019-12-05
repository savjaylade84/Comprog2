namespace Comprog2Project
{
    partial class SearchAndFindFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchAndFindFrm));
            this.SectionCodeCmb = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.excusedRBtn = new System.Windows.Forms.RadioButton();
            this.lateRBtn = new System.Windows.Forms.RadioButton();
            this.absentRBtn = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SumOfAtndLBL = new System.Windows.Forms.Label();
            this.TestGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseLbl = new System.Windows.Forms.Label();
            this.attendanceGB = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.lnameValue = new System.Windows.Forms.TextBox();
            this.lnameTitle = new System.Windows.Forms.TextBox();
            this.contactValue = new System.Windows.Forms.TextBox();
            this.mnameValue = new System.Windows.Forms.TextBox();
            this.fnameValue = new System.Windows.Forms.TextBox();
            this.fnameTitle = new System.Windows.Forms.TextBox();
            this.contactTitle = new System.Windows.Forms.TextBox();
            this.mnameTitle = new System.Windows.Forms.TextBox();
            this.emailTitle = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ControlTitleLbl = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TestGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.attendanceGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SectionCodeCmb
            // 
            this.SectionCodeCmb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionCodeCmb.FormattingEnabled = true;
            this.SectionCodeCmb.Location = new System.Drawing.Point(12, 197);
            this.SectionCodeCmb.Margin = new System.Windows.Forms.Padding(10);
            this.SectionCodeCmb.Name = "SectionCodeCmb";
            this.SectionCodeCmb.Size = new System.Drawing.Size(204, 31);
            this.SectionCodeCmb.TabIndex = 43;
            this.SectionCodeCmb.Text = "Section Code";
            this.SectionCodeCmb.DropDown += new System.EventHandler(this.SelectSection);
            this.SectionCodeCmb.SelectedIndexChanged += new System.EventHandler(this.SelectSection);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.White;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(319, 489);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(10);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(124, 37);
            this.saveBtn.TabIndex = 42;
            this.saveBtn.Text = "Save ";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // excusedRBtn
            // 
            this.excusedRBtn.AutoSize = true;
            this.excusedRBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excusedRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excusedRBtn.Location = new System.Drawing.Point(39, 99);
            this.excusedRBtn.Name = "excusedRBtn";
            this.excusedRBtn.Size = new System.Drawing.Size(126, 33);
            this.excusedRBtn.TabIndex = 40;
            this.excusedRBtn.TabStop = true;
            this.excusedRBtn.Text = "&Excused";
            this.excusedRBtn.UseVisualStyleBackColor = true;
            // 
            // lateRBtn
            // 
            this.lateRBtn.AutoSize = true;
            this.lateRBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lateRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lateRBtn.Location = new System.Drawing.Point(39, 62);
            this.lateRBtn.Name = "lateRBtn";
            this.lateRBtn.Size = new System.Drawing.Size(80, 33);
            this.lateRBtn.TabIndex = 39;
            this.lateRBtn.TabStop = true;
            this.lateRBtn.Text = "&Late";
            this.lateRBtn.UseVisualStyleBackColor = true;
            // 
            // absentRBtn
            // 
            this.absentRBtn.AutoSize = true;
            this.absentRBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.absentRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absentRBtn.Location = new System.Drawing.Point(39, 23);
            this.absentRBtn.Name = "absentRBtn";
            this.absentRBtn.Size = new System.Drawing.Size(108, 33);
            this.absentRBtn.TabIndex = 38;
            this.absentRBtn.TabStop = true;
            this.absentRBtn.Text = "&Absent";
            this.absentRBtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 239);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 31);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.Text = "Student No.";
            // 
            // SumOfAtndLBL
            // 
            this.SumOfAtndLBL.AutoSize = true;
            this.SumOfAtndLBL.Dock = System.Windows.Forms.DockStyle.Left;
            this.SumOfAtndLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumOfAtndLBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SumOfAtndLBL.Location = new System.Drawing.Point(0, 0);
            this.SumOfAtndLBL.Name = "SumOfAtndLBL";
            this.SumOfAtndLBL.Padding = new System.Windows.Forms.Padding(3);
            this.SumOfAtndLBL.Size = new System.Drawing.Size(272, 35);
            this.SumOfAtndLBL.TabIndex = 34;
            this.SumOfAtndLBL.Text = "Summary of Attendance\r\n";
            // 
            // TestGridView
            // 
            this.TestGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestGridView.Location = new System.Drawing.Point(260, 345);
            this.TestGridView.Name = "TestGridView";
            this.TestGridView.RowHeadersWidth = 51;
            this.TestGridView.RowTemplate.Height = 24;
            this.TestGridView.Size = new System.Drawing.Size(516, 138);
            this.TestGridView.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.CloseLbl);
            this.panel1.Controls.Add(this.SumOfAtndLBL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 39);
            this.panel1.TabIndex = 46;
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.BackColor = System.Drawing.Color.Transparent;
            this.CloseLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseLbl.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.CloseLbl.Location = new System.Drawing.Point(765, 0);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(34, 40);
            this.CloseLbl.TabIndex = 1;
            this.CloseLbl.Text = "x";
            this.CloseLbl.Click += new System.EventHandler(this.CloseForm);
            this.CloseLbl.MouseLeave += new System.EventHandler(this.NotHoverLeaveForm);
            this.CloseLbl.MouseHover += new System.EventHandler(this.HoverLeaveForm);
            // 
            // attendanceGB
            // 
            this.attendanceGB.Controls.Add(this.excusedRBtn);
            this.attendanceGB.Controls.Add(this.absentRBtn);
            this.attendanceGB.Controls.Add(this.lateRBtn);
            this.attendanceGB.Location = new System.Drawing.Point(12, 283);
            this.attendanceGB.Name = "attendanceGB";
            this.attendanceGB.Padding = new System.Windows.Forms.Padding(4);
            this.attendanceGB.Size = new System.Drawing.Size(204, 143);
            this.attendanceGB.TabIndex = 56;
            this.attendanceGB.TabStop = false;
            this.attendanceGB.Text = "Attendance";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(730, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 36);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(260, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 36);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // profilePic
            // 
            this.profilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePic.Dock = System.Windows.Forms.DockStyle.Top;
            this.profilePic.Image = global::Comprog2Project.Properties.Resources.people;
            this.profilePic.Location = new System.Drawing.Point(15, 15);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(201, 169);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 27;
            this.profilePic.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(144)))), ((int)(((byte)(99)))));
            this.panel2.Controls.Add(this.profilePic);
            this.panel2.Controls.Add(this.attendanceGB);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.SectionCodeCmb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(231, 516);
            this.panel2.TabIndex = 57;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(592, 490);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(10);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(124, 37);
            this.cancelBtn.TabIndex = 57;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // emailValue
            // 
            this.emailValue.BackColor = System.Drawing.Color.Gainsboro;
            this.emailValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailValue.Enabled = false;
            this.emailValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.emailValue.ForeColor = System.Drawing.Color.Black;
            this.emailValue.Location = new System.Drawing.Point(423, 291);
            this.emailValue.Margin = new System.Windows.Forms.Padding(8);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(349, 31);
            this.emailValue.TabIndex = 73;
            this.emailValue.Text = "(Email)";
            this.emailValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lnameValue
            // 
            this.lnameValue.BackColor = System.Drawing.Color.Gainsboro;
            this.lnameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnameValue.Enabled = false;
            this.lnameValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.lnameValue.ForeColor = System.Drawing.Color.Black;
            this.lnameValue.Location = new System.Drawing.Point(423, 197);
            this.lnameValue.Margin = new System.Windows.Forms.Padding(8);
            this.lnameValue.Name = "lnameValue";
            this.lnameValue.Size = new System.Drawing.Size(349, 31);
            this.lnameValue.TabIndex = 79;
            this.lnameValue.Text = "(Last Name)";
            this.lnameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lnameTitle
            // 
            this.lnameTitle.BackColor = System.Drawing.Color.LightGray;
            this.lnameTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnameTitle.Enabled = false;
            this.lnameTitle.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.lnameTitle.ForeColor = System.Drawing.Color.Black;
            this.lnameTitle.Location = new System.Drawing.Point(259, 197);
            this.lnameTitle.Margin = new System.Windows.Forms.Padding(8);
            this.lnameTitle.Name = "lnameTitle";
            this.lnameTitle.Size = new System.Drawing.Size(142, 31);
            this.lnameTitle.TabIndex = 78;
            this.lnameTitle.Text = "(Last Name)";
            this.lnameTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contactValue
            // 
            this.contactValue.BackColor = System.Drawing.Color.Gainsboro;
            this.contactValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactValue.Enabled = false;
            this.contactValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.contactValue.ForeColor = System.Drawing.Color.Black;
            this.contactValue.Location = new System.Drawing.Point(423, 244);
            this.contactValue.Margin = new System.Windows.Forms.Padding(8);
            this.contactValue.Name = "contactValue";
            this.contactValue.Size = new System.Drawing.Size(349, 31);
            this.contactValue.TabIndex = 72;
            this.contactValue.Text = "(Contact)";
            this.contactValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mnameValue
            // 
            this.mnameValue.BackColor = System.Drawing.Color.Gainsboro;
            this.mnameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mnameValue.Enabled = false;
            this.mnameValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.mnameValue.ForeColor = System.Drawing.Color.Black;
            this.mnameValue.Location = new System.Drawing.Point(423, 150);
            this.mnameValue.Margin = new System.Windows.Forms.Padding(8);
            this.mnameValue.Name = "mnameValue";
            this.mnameValue.Size = new System.Drawing.Size(349, 31);
            this.mnameValue.TabIndex = 77;
            this.mnameValue.Text = "(Middle Name)";
            this.mnameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fnameValue
            // 
            this.fnameValue.BackColor = System.Drawing.Color.Gainsboro;
            this.fnameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnameValue.Enabled = false;
            this.fnameValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.fnameValue.ForeColor = System.Drawing.Color.Black;
            this.fnameValue.Location = new System.Drawing.Point(423, 103);
            this.fnameValue.Margin = new System.Windows.Forms.Padding(8);
            this.fnameValue.Name = "fnameValue";
            this.fnameValue.Size = new System.Drawing.Size(349, 31);
            this.fnameValue.TabIndex = 76;
            this.fnameValue.Text = "(First Name)";
            this.fnameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fnameTitle
            // 
            this.fnameTitle.BackColor = System.Drawing.Color.LightGray;
            this.fnameTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnameTitle.Enabled = false;
            this.fnameTitle.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.fnameTitle.ForeColor = System.Drawing.Color.Black;
            this.fnameTitle.Location = new System.Drawing.Point(259, 103);
            this.fnameTitle.Margin = new System.Windows.Forms.Padding(8);
            this.fnameTitle.Name = "fnameTitle";
            this.fnameTitle.Size = new System.Drawing.Size(142, 31);
            this.fnameTitle.TabIndex = 74;
            this.fnameTitle.Text = "(First Name)";
            this.fnameTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contactTitle
            // 
            this.contactTitle.BackColor = System.Drawing.Color.LightGray;
            this.contactTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactTitle.Enabled = false;
            this.contactTitle.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.contactTitle.ForeColor = System.Drawing.Color.Black;
            this.contactTitle.Location = new System.Drawing.Point(259, 244);
            this.contactTitle.Margin = new System.Windows.Forms.Padding(8);
            this.contactTitle.Name = "contactTitle";
            this.contactTitle.Size = new System.Drawing.Size(142, 31);
            this.contactTitle.TabIndex = 70;
            this.contactTitle.Text = "(Contact)";
            this.contactTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mnameTitle
            // 
            this.mnameTitle.BackColor = System.Drawing.Color.LightGray;
            this.mnameTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mnameTitle.Enabled = false;
            this.mnameTitle.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.mnameTitle.ForeColor = System.Drawing.Color.Black;
            this.mnameTitle.Location = new System.Drawing.Point(259, 150);
            this.mnameTitle.Margin = new System.Windows.Forms.Padding(8);
            this.mnameTitle.Name = "mnameTitle";
            this.mnameTitle.Size = new System.Drawing.Size(142, 31);
            this.mnameTitle.TabIndex = 75;
            this.mnameTitle.Text = "(Middle Name)";
            this.mnameTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailTitle
            // 
            this.emailTitle.BackColor = System.Drawing.Color.LightGray;
            this.emailTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTitle.Enabled = false;
            this.emailTitle.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.emailTitle.ForeColor = System.Drawing.Color.Black;
            this.emailTitle.Location = new System.Drawing.Point(259, 291);
            this.emailTitle.Margin = new System.Windows.Forms.Padding(8);
            this.emailTitle.Name = "emailTitle";
            this.emailTitle.Size = new System.Drawing.Size(142, 31);
            this.emailTitle.TabIndex = 71;
            this.emailTitle.Text = "(Email)";
            this.emailTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(260, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 4);
            this.panel3.TabIndex = 81;
            // 
            // ControlTitleLbl
            // 
            this.ControlTitleLbl.AutoSize = true;
            this.ControlTitleLbl.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlTitleLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ControlTitleLbl.Location = new System.Drawing.Point(255, 57);
            this.ControlTitleLbl.Name = "ControlTitleLbl";
            this.ControlTitleLbl.Size = new System.Drawing.Size(146, 28);
            this.ControlTitleLbl.TabIndex = 80;
            this.ControlTitleLbl.Text = "Information";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Location = new System.Drawing.Point(455, 489);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(10);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(124, 37);
            this.searchBtn.TabIndex = 82;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // SearchAndFindFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(80)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(799, 555);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ControlTitleLbl);
            this.Controls.Add(this.emailValue);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lnameValue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lnameTitle);
            this.Controls.Add(this.contactValue);
            this.Controls.Add(this.TestGridView);
            this.Controls.Add(this.mnameValue);
            this.Controls.Add(this.fnameValue);
            this.Controls.Add(this.fnameTitle);
            this.Controls.Add(this.contactTitle);
            this.Controls.Add(this.emailTitle);
            this.Controls.Add(this.mnameTitle);
            this.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchAndFindFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchStudent";
            ((System.ComponentModel.ISupportInitialize)(this.TestGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.attendanceGB.ResumeLayout(false);
            this.attendanceGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox SectionCodeCmb;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.RadioButton excusedRBtn;
        private System.Windows.Forms.RadioButton lateRBtn;
        private System.Windows.Forms.RadioButton absentRBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label SumOfAtndLBL;
        private System.Windows.Forms.DataGridView TestGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.GroupBox attendanceGB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.TextBox lnameValue;
        private System.Windows.Forms.TextBox lnameTitle;
        private System.Windows.Forms.TextBox contactValue;
        private System.Windows.Forms.TextBox mnameValue;
        private System.Windows.Forms.TextBox fnameValue;
        private System.Windows.Forms.TextBox fnameTitle;
        private System.Windows.Forms.TextBox contactTitle;
        private System.Windows.Forms.TextBox mnameTitle;
        private System.Windows.Forms.TextBox emailTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ControlTitleLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button searchBtn;
    }
}