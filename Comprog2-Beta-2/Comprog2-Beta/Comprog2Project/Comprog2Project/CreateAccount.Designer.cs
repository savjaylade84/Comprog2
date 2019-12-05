namespace Comprog2Project
{
    partial class CreateAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseLbl = new System.Windows.Forms.Label();
            this.SumOfAtndLBL = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AccTypeValue = new System.Windows.Forms.ComboBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.DateValue = new System.Windows.Forms.TextBox();
            this.AccountNoValue = new System.Windows.Forms.TextBox();
            this.profilepic = new System.Windows.Forms.PictureBox();
            this.MainInfoPanel = new System.Windows.Forms.Panel();
            this.AccCredentialPanel = new System.Windows.Forms.Panel();
            this.ACTitleLbl = new System.Windows.Forms.Label();
            this.PwordValue = new System.Windows.Forms.TextBox();
            this.UnameValue = new System.Windows.Forms.TextBox();
            this.PersonalInfoPanel = new System.Windows.Forms.Panel();
            this.PInfoTitleLbl = new System.Windows.Forms.Label();
            this.EmailTitleTxt = new System.Windows.Forms.TextBox();
            this.MnameTItleTxt = new System.Windows.Forms.TextBox();
            this.bdateValue = new System.Windows.Forms.TextBox();
            this.ContactTitleTxt = new System.Windows.Forms.TextBox();
            this.BDateTitleTxt = new System.Windows.Forms.TextBox();
            this.fnameTitleTxt = new System.Windows.Forms.TextBox();
            this.addressValue = new System.Windows.Forms.TextBox();
            this.fnameValue = new System.Windows.Forms.TextBox();
            this.AddressTitleTxt = new System.Windows.Forms.TextBox();
            this.mnameValue = new System.Windows.Forms.TextBox();
            this.contactValue = new System.Windows.Forms.TextBox();
            this.LnameTitleTxt = new System.Windows.Forms.TextBox();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.lnameValue = new System.Windows.Forms.TextBox();
            this.deptValue = new System.Windows.Forms.TextBox();
            this.DeptTItleTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).BeginInit();
            this.MainInfoPanel.SuspendLayout();
            this.AccCredentialPanel.SuspendLayout();
            this.PersonalInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CloseLbl);
            this.panel1.Controls.Add(this.SumOfAtndLBL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 49);
            this.panel1.TabIndex = 47;
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.BackColor = System.Drawing.Color.Transparent;
            this.CloseLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseLbl.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.CloseLbl.Location = new System.Drawing.Point(780, 0);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(34, 40);
            this.CloseLbl.TabIndex = 1;
            this.CloseLbl.Text = "x";
            this.CloseLbl.Click += new System.EventHandler(this.LeaveForm);
            this.CloseLbl.MouseLeave += new System.EventHandler(this.CloseLbl_MouseLeave);
            this.CloseLbl.MouseHover += new System.EventHandler(this.CloseLbl_MouseHover);
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
            this.SumOfAtndLBL.Size = new System.Drawing.Size(110, 35);
            this.SumOfAtndLBL.TabIndex = 34;
            this.SumOfAtndLBL.Text = "Register";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(144)))), ((int)(((byte)(99)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.AccTypeValue);
            this.panel2.Controls.Add(this.profilepic);
            this.panel2.Controls.Add(this.CreateBtn);
            this.panel2.Controls.Add(this.CancelBtn);
            this.panel2.Controls.Add(this.DateValue);
            this.panel2.Controls.Add(this.AccountNoValue);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(228, 544);
            this.panel2.TabIndex = 49;
            // 
            // AccTypeValue
            // 
            this.AccTypeValue.BackColor = System.Drawing.Color.LightGray;
            this.AccTypeValue.DropDownWidth = 100;
            this.AccTypeValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.AccTypeValue.FormattingEnabled = true;
            this.AccTypeValue.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.AccTypeValue.Location = new System.Drawing.Point(12, 303);
            this.AccTypeValue.Name = "AccTypeValue";
            this.AccTypeValue.Size = new System.Drawing.Size(196, 31);
            this.AccTypeValue.Sorted = true;
            this.AccTypeValue.TabIndex = 60;
            this.AccTypeValue.Text = "(Account Type)";
            this.AccTypeValue.SelectedValueChanged += new System.EventHandler(this.AccountTypeSwitch);
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBtn.Location = new System.Drawing.Point(15, 415);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(193, 43);
            this.CreateBtn.TabIndex = 50;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.MouseLeave += new System.EventHandler(this.ChangeColorMouseLeave);
            this.CreateBtn.MouseHover += new System.EventHandler(this.ChangeColorMouseOver);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Location = new System.Drawing.Point(15, 473);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(193, 43);
            this.CancelBtn.TabIndex = 51;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.MouseLeave += new System.EventHandler(this.ChangeColorMouseLeave);
            this.CancelBtn.MouseHover += new System.EventHandler(this.ChangeColorMouseOver);
            // 
            // DateValue
            // 
            this.DateValue.BackColor = System.Drawing.Color.LightGray;
            this.DateValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateValue.Enabled = false;
            this.DateValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.DateValue.ForeColor = System.Drawing.Color.Black;
            this.DateValue.Location = new System.Drawing.Point(15, 206);
            this.DateValue.Margin = new System.Windows.Forms.Padding(8);
            this.DateValue.Name = "DateValue";
            this.DateValue.Size = new System.Drawing.Size(196, 31);
            this.DateValue.TabIndex = 59;
            this.DateValue.Text = "(Date)";
            this.DateValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AccountNoValue
            // 
            this.AccountNoValue.BackColor = System.Drawing.Color.LightGray;
            this.AccountNoValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountNoValue.Enabled = false;
            this.AccountNoValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.AccountNoValue.ForeColor = System.Drawing.Color.Black;
            this.AccountNoValue.Location = new System.Drawing.Point(15, 253);
            this.AccountNoValue.Margin = new System.Windows.Forms.Padding(8);
            this.AccountNoValue.Name = "AccountNoValue";
            this.AccountNoValue.Size = new System.Drawing.Size(196, 31);
            this.AccountNoValue.TabIndex = 56;
            this.AccountNoValue.Text = "(ID NO.)";
            this.AccountNoValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // profilepic
            // 
            this.profilepic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilepic.Dock = System.Windows.Forms.DockStyle.Top;
            this.profilepic.Enabled = false;
            this.profilepic.Image = global::Comprog2Project.Properties.Resources.people;
            this.profilepic.Location = new System.Drawing.Point(15, 15);
            this.profilepic.Name = "profilepic";
            this.profilepic.Size = new System.Drawing.Size(196, 180);
            this.profilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilepic.TabIndex = 48;
            this.profilepic.TabStop = false;
            // 
            // MainInfoPanel
            // 
            this.MainInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainInfoPanel.Controls.Add(this.PersonalInfoPanel);
            this.MainInfoPanel.Controls.Add(this.AccCredentialPanel);
            this.MainInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainInfoPanel.Location = new System.Drawing.Point(228, 49);
            this.MainInfoPanel.Name = "MainInfoPanel";
            this.MainInfoPanel.Padding = new System.Windows.Forms.Padding(15);
            this.MainInfoPanel.Size = new System.Drawing.Size(588, 544);
            this.MainInfoPanel.TabIndex = 78;
            // 
            // AccCredentialPanel
            // 
            this.AccCredentialPanel.Controls.Add(this.deptValue);
            this.AccCredentialPanel.Controls.Add(this.DeptTItleTxt);
            this.AccCredentialPanel.Controls.Add(this.ACTitleLbl);
            this.AccCredentialPanel.Controls.Add(this.PwordValue);
            this.AccCredentialPanel.Controls.Add(this.UnameValue);
            this.AccCredentialPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AccCredentialPanel.Location = new System.Drawing.Point(15, 389);
            this.AccCredentialPanel.Name = "AccCredentialPanel";
            this.AccCredentialPanel.Size = new System.Drawing.Size(556, 138);
            this.AccCredentialPanel.TabIndex = 78;
            this.AccCredentialPanel.Visible = false;
            // 
            // ACTitleLbl
            // 
            this.ACTitleLbl.AutoSize = true;
            this.ACTitleLbl.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACTitleLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ACTitleLbl.Location = new System.Drawing.Point(172, 50);
            this.ACTitleLbl.Name = "ACTitleLbl";
            this.ACTitleLbl.Size = new System.Drawing.Size(222, 28);
            this.ACTitleLbl.TabIndex = 90;
            this.ACTitleLbl.Text = "Account Credential";
            // 
            // PwordValue
            // 
            this.PwordValue.BackColor = System.Drawing.Color.Gainsboro;
            this.PwordValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PwordValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.PwordValue.ForeColor = System.Drawing.Color.Black;
            this.PwordValue.Location = new System.Drawing.Point(289, 86);
            this.PwordValue.Margin = new System.Windows.Forms.Padding(8);
            this.PwordValue.Name = "PwordValue";
            this.PwordValue.Size = new System.Drawing.Size(250, 31);
            this.PwordValue.TabIndex = 89;
            this.PwordValue.Text = "(Password)";
            this.PwordValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UnameValue
            // 
            this.UnameValue.BackColor = System.Drawing.Color.Gainsboro;
            this.UnameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnameValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.UnameValue.ForeColor = System.Drawing.Color.Black;
            this.UnameValue.Location = new System.Drawing.Point(23, 86);
            this.UnameValue.Margin = new System.Windows.Forms.Padding(8);
            this.UnameValue.Name = "UnameValue";
            this.UnameValue.Size = new System.Drawing.Size(250, 31);
            this.UnameValue.TabIndex = 88;
            this.UnameValue.Text = "(Username)";
            this.UnameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PersonalInfoPanel
            // 
            this.PersonalInfoPanel.Controls.Add(this.PInfoTitleLbl);
            this.PersonalInfoPanel.Controls.Add(this.EmailTitleTxt);
            this.PersonalInfoPanel.Controls.Add(this.MnameTItleTxt);
            this.PersonalInfoPanel.Controls.Add(this.bdateValue);
            this.PersonalInfoPanel.Controls.Add(this.ContactTitleTxt);
            this.PersonalInfoPanel.Controls.Add(this.BDateTitleTxt);
            this.PersonalInfoPanel.Controls.Add(this.fnameTitleTxt);
            this.PersonalInfoPanel.Controls.Add(this.addressValue);
            this.PersonalInfoPanel.Controls.Add(this.fnameValue);
            this.PersonalInfoPanel.Controls.Add(this.AddressTitleTxt);
            this.PersonalInfoPanel.Controls.Add(this.mnameValue);
            this.PersonalInfoPanel.Controls.Add(this.contactValue);
            this.PersonalInfoPanel.Controls.Add(this.LnameTitleTxt);
            this.PersonalInfoPanel.Controls.Add(this.emailValue);
            this.PersonalInfoPanel.Controls.Add(this.lnameValue);
            this.PersonalInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonalInfoPanel.Location = new System.Drawing.Point(15, 15);
            this.PersonalInfoPanel.Name = "PersonalInfoPanel";
            this.PersonalInfoPanel.Size = new System.Drawing.Size(556, 374);
            this.PersonalInfoPanel.TabIndex = 79;
            // 
            // PInfoTitleLbl
            // 
            this.PInfoTitleLbl.AutoSize = true;
            this.PInfoTitleLbl.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PInfoTitleLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PInfoTitleLbl.Location = new System.Drawing.Point(18, 17);
            this.PInfoTitleLbl.Name = "PInfoTitleLbl";
            this.PInfoTitleLbl.Size = new System.Drawing.Size(248, 28);
            this.PInfoTitleLbl.TabIndex = 88;
            this.PInfoTitleLbl.Text = "Personal Information";
            // 
            // EmailTitleTxt
            // 
            this.EmailTitleTxt.BackColor = System.Drawing.Color.LightGray;
            this.EmailTitleTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTitleTxt.Enabled = false;
            this.EmailTitleTxt.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.EmailTitleTxt.ForeColor = System.Drawing.Color.Black;
            this.EmailTitleTxt.Location = new System.Drawing.Point(22, 241);
            this.EmailTitleTxt.Margin = new System.Windows.Forms.Padding(8);
            this.EmailTitleTxt.Name = "EmailTitleTxt";
            this.EmailTitleTxt.Size = new System.Drawing.Size(142, 31);
            this.EmailTitleTxt.TabIndex = 79;
            this.EmailTitleTxt.Text = "(Email)";
            this.EmailTitleTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MnameTItleTxt
            // 
            this.MnameTItleTxt.BackColor = System.Drawing.Color.LightGray;
            this.MnameTItleTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MnameTItleTxt.Enabled = false;
            this.MnameTItleTxt.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.MnameTItleTxt.ForeColor = System.Drawing.Color.Black;
            this.MnameTItleTxt.Location = new System.Drawing.Point(22, 100);
            this.MnameTItleTxt.Margin = new System.Windows.Forms.Padding(8);
            this.MnameTItleTxt.Name = "MnameTItleTxt";
            this.MnameTItleTxt.Size = new System.Drawing.Size(142, 31);
            this.MnameTItleTxt.TabIndex = 83;
            this.MnameTItleTxt.Text = "(Middle Name)";
            this.MnameTItleTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bdateValue
            // 
            this.bdateValue.BackColor = System.Drawing.Color.Gainsboro;
            this.bdateValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bdateValue.Enabled = false;
            this.bdateValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.bdateValue.ForeColor = System.Drawing.Color.Black;
            this.bdateValue.Location = new System.Drawing.Point(189, 335);
            this.bdateValue.Margin = new System.Windows.Forms.Padding(8);
            this.bdateValue.Name = "bdateValue";
            this.bdateValue.Size = new System.Drawing.Size(349, 31);
            this.bdateValue.TabIndex = 93;
            this.bdateValue.Text = "(Birthdate)";
            this.bdateValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ContactTitleTxt
            // 
            this.ContactTitleTxt.BackColor = System.Drawing.Color.LightGray;
            this.ContactTitleTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactTitleTxt.Enabled = false;
            this.ContactTitleTxt.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.ContactTitleTxt.ForeColor = System.Drawing.Color.Black;
            this.ContactTitleTxt.Location = new System.Drawing.Point(22, 194);
            this.ContactTitleTxt.Margin = new System.Windows.Forms.Padding(8);
            this.ContactTitleTxt.Name = "ContactTitleTxt";
            this.ContactTitleTxt.Size = new System.Drawing.Size(142, 31);
            this.ContactTitleTxt.TabIndex = 78;
            this.ContactTitleTxt.Text = "(Contact)";
            this.ContactTitleTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BDateTitleTxt
            // 
            this.BDateTitleTxt.BackColor = System.Drawing.Color.LightGray;
            this.BDateTitleTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BDateTitleTxt.Enabled = false;
            this.BDateTitleTxt.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.BDateTitleTxt.ForeColor = System.Drawing.Color.Black;
            this.BDateTitleTxt.Location = new System.Drawing.Point(22, 335);
            this.BDateTitleTxt.Margin = new System.Windows.Forms.Padding(8);
            this.BDateTitleTxt.Name = "BDateTitleTxt";
            this.BDateTitleTxt.Size = new System.Drawing.Size(142, 31);
            this.BDateTitleTxt.TabIndex = 92;
            this.BDateTitleTxt.Text = "(Birthdate)";
            this.BDateTitleTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fnameTitleTxt
            // 
            this.fnameTitleTxt.BackColor = System.Drawing.Color.LightGray;
            this.fnameTitleTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnameTitleTxt.Enabled = false;
            this.fnameTitleTxt.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.fnameTitleTxt.ForeColor = System.Drawing.Color.Black;
            this.fnameTitleTxt.Location = new System.Drawing.Point(22, 53);
            this.fnameTitleTxt.Margin = new System.Windows.Forms.Padding(8);
            this.fnameTitleTxt.Name = "fnameTitleTxt";
            this.fnameTitleTxt.Size = new System.Drawing.Size(142, 31);
            this.fnameTitleTxt.TabIndex = 82;
            this.fnameTitleTxt.Text = "(First Name)";
            this.fnameTitleTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addressValue
            // 
            this.addressValue.BackColor = System.Drawing.Color.Gainsboro;
            this.addressValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressValue.Enabled = false;
            this.addressValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.addressValue.ForeColor = System.Drawing.Color.Black;
            this.addressValue.Location = new System.Drawing.Point(189, 288);
            this.addressValue.Margin = new System.Windows.Forms.Padding(8);
            this.addressValue.Name = "addressValue";
            this.addressValue.Size = new System.Drawing.Size(349, 31);
            this.addressValue.TabIndex = 91;
            this.addressValue.Text = "(Address)";
            this.addressValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fnameValue
            // 
            this.fnameValue.BackColor = System.Drawing.Color.Gainsboro;
            this.fnameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnameValue.Enabled = false;
            this.fnameValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.fnameValue.ForeColor = System.Drawing.Color.Black;
            this.fnameValue.Location = new System.Drawing.Point(189, 53);
            this.fnameValue.Margin = new System.Windows.Forms.Padding(8);
            this.fnameValue.Name = "fnameValue";
            this.fnameValue.Size = new System.Drawing.Size(349, 31);
            this.fnameValue.TabIndex = 84;
            this.fnameValue.Text = "(First Name)";
            this.fnameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddressTitleTxt
            // 
            this.AddressTitleTxt.BackColor = System.Drawing.Color.LightGray;
            this.AddressTitleTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressTitleTxt.Enabled = false;
            this.AddressTitleTxt.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.AddressTitleTxt.ForeColor = System.Drawing.Color.Black;
            this.AddressTitleTxt.Location = new System.Drawing.Point(22, 288);
            this.AddressTitleTxt.Margin = new System.Windows.Forms.Padding(8);
            this.AddressTitleTxt.Name = "AddressTitleTxt";
            this.AddressTitleTxt.Size = new System.Drawing.Size(142, 31);
            this.AddressTitleTxt.TabIndex = 90;
            this.AddressTitleTxt.Text = "(Address)";
            this.AddressTitleTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mnameValue
            // 
            this.mnameValue.BackColor = System.Drawing.Color.Gainsboro;
            this.mnameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mnameValue.Enabled = false;
            this.mnameValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.mnameValue.ForeColor = System.Drawing.Color.Black;
            this.mnameValue.Location = new System.Drawing.Point(189, 100);
            this.mnameValue.Margin = new System.Windows.Forms.Padding(8);
            this.mnameValue.Name = "mnameValue";
            this.mnameValue.Size = new System.Drawing.Size(349, 31);
            this.mnameValue.TabIndex = 85;
            this.mnameValue.Text = "(Middle Name)";
            this.mnameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contactValue
            // 
            this.contactValue.BackColor = System.Drawing.Color.Gainsboro;
            this.contactValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactValue.Enabled = false;
            this.contactValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.contactValue.ForeColor = System.Drawing.Color.Black;
            this.contactValue.Location = new System.Drawing.Point(189, 194);
            this.contactValue.Margin = new System.Windows.Forms.Padding(8);
            this.contactValue.Name = "contactValue";
            this.contactValue.Size = new System.Drawing.Size(349, 31);
            this.contactValue.TabIndex = 80;
            this.contactValue.Text = "(Contact)";
            this.contactValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LnameTitleTxt
            // 
            this.LnameTitleTxt.BackColor = System.Drawing.Color.LightGray;
            this.LnameTitleTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LnameTitleTxt.Enabled = false;
            this.LnameTitleTxt.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.LnameTitleTxt.ForeColor = System.Drawing.Color.Black;
            this.LnameTitleTxt.Location = new System.Drawing.Point(22, 147);
            this.LnameTitleTxt.Margin = new System.Windows.Forms.Padding(8);
            this.LnameTitleTxt.Name = "LnameTitleTxt";
            this.LnameTitleTxt.Size = new System.Drawing.Size(142, 31);
            this.LnameTitleTxt.TabIndex = 86;
            this.LnameTitleTxt.Text = "(Last Name)";
            this.LnameTitleTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailValue
            // 
            this.emailValue.BackColor = System.Drawing.Color.Gainsboro;
            this.emailValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailValue.Enabled = false;
            this.emailValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.emailValue.ForeColor = System.Drawing.Color.Black;
            this.emailValue.Location = new System.Drawing.Point(189, 241);
            this.emailValue.Margin = new System.Windows.Forms.Padding(8);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(349, 31);
            this.emailValue.TabIndex = 81;
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
            this.lnameValue.Location = new System.Drawing.Point(189, 147);
            this.lnameValue.Margin = new System.Windows.Forms.Padding(8);
            this.lnameValue.Name = "lnameValue";
            this.lnameValue.Size = new System.Drawing.Size(349, 31);
            this.lnameValue.TabIndex = 87;
            this.lnameValue.Text = "(Last Name)";
            this.lnameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deptValue
            // 
            this.deptValue.BackColor = System.Drawing.Color.Gainsboro;
            this.deptValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deptValue.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.deptValue.ForeColor = System.Drawing.Color.Black;
            this.deptValue.Location = new System.Drawing.Point(189, 0);
            this.deptValue.Margin = new System.Windows.Forms.Padding(8);
            this.deptValue.Name = "deptValue";
            this.deptValue.Size = new System.Drawing.Size(349, 31);
            this.deptValue.TabIndex = 97;
            this.deptValue.Text = "(Department)";
            this.deptValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeptTItleTxt
            // 
            this.DeptTItleTxt.BackColor = System.Drawing.Color.LightGray;
            this.DeptTItleTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeptTItleTxt.Enabled = false;
            this.DeptTItleTxt.Font = new System.Drawing.Font("Cambria", 11.8F);
            this.DeptTItleTxt.ForeColor = System.Drawing.Color.Black;
            this.DeptTItleTxt.Location = new System.Drawing.Point(22, 0);
            this.DeptTItleTxt.Margin = new System.Windows.Forms.Padding(8);
            this.DeptTItleTxt.Name = "DeptTItleTxt";
            this.DeptTItleTxt.Size = new System.Drawing.Size(142, 31);
            this.DeptTItleTxt.TabIndex = 96;
            this.DeptTItleTxt.Text = "(Department)";
            this.DeptTItleTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(816, 593);
            this.Controls.Add(this.MainInfoPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateStudent";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).EndInit();
            this.MainInfoPanel.ResumeLayout(false);
            this.AccCredentialPanel.ResumeLayout(false);
            this.AccCredentialPanel.PerformLayout();
            this.PersonalInfoPanel.ResumeLayout(false);
            this.PersonalInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.Label SumOfAtndLBL;
        private System.Windows.Forms.PictureBox profilepic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox AccountNoValue;
        private System.Windows.Forms.TextBox DateValue;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.ComboBox AccTypeValue;
        private System.Windows.Forms.Panel MainInfoPanel;
        private System.Windows.Forms.Panel PersonalInfoPanel;
        private System.Windows.Forms.Label PInfoTitleLbl;
        private System.Windows.Forms.TextBox EmailTitleTxt;
        private System.Windows.Forms.TextBox MnameTItleTxt;
        private System.Windows.Forms.TextBox bdateValue;
        private System.Windows.Forms.TextBox ContactTitleTxt;
        private System.Windows.Forms.TextBox BDateTitleTxt;
        private System.Windows.Forms.TextBox fnameTitleTxt;
        private System.Windows.Forms.TextBox addressValue;
        private System.Windows.Forms.TextBox fnameValue;
        private System.Windows.Forms.TextBox AddressTitleTxt;
        private System.Windows.Forms.TextBox mnameValue;
        private System.Windows.Forms.TextBox contactValue;
        private System.Windows.Forms.TextBox LnameTitleTxt;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.TextBox lnameValue;
        private System.Windows.Forms.Panel AccCredentialPanel;
        private System.Windows.Forms.TextBox deptValue;
        private System.Windows.Forms.TextBox DeptTItleTxt;
        private System.Windows.Forms.Label ACTitleLbl;
        private System.Windows.Forms.TextBox PwordValue;
        private System.Windows.Forms.TextBox UnameValue;
    }
}