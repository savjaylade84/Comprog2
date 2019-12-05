namespace Comprog2Project
{
    partial class SearchStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchStudent));
            this.PicpathLBL = new System.Windows.Forms.Label();
            this.SectionCodeCmb = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.DateLBL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ReferenceLbl = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailLBL = new System.Windows.Forms.Label();
            this.SumOfAtndLBL = new System.Windows.Forms.Label();
            this.NameLBL = new System.Windows.Forms.Label();
            this.ConNoLBL = new System.Windows.Forms.Label();
            this.TestGridView = new System.Windows.Forms.DataGridView();
            this.StdntNoLBL = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TestGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PicpathLBL
            // 
            this.PicpathLBL.AutoSize = true;
            this.PicpathLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PicpathLBL.Location = new System.Drawing.Point(13, 62);
            this.PicpathLBL.Name = "PicpathLBL";
            this.PicpathLBL.Size = new System.Drawing.Size(125, 29);
            this.PicpathLBL.TabIndex = 45;
            this.PicpathLBL.Text = "Reference";
            // 
            // SectionCodeCmb
            // 
            this.SectionCodeCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionCodeCmb.FormattingEnabled = true;
            this.SectionCodeCmb.Location = new System.Drawing.Point(18, 29);
            this.SectionCodeCmb.Name = "SectionCodeCmb";
            this.SectionCodeCmb.Size = new System.Drawing.Size(290, 30);
            this.SectionCodeCmb.TabIndex = 43;
            this.SectionCodeCmb.Text = "Section Code";
            this.SectionCodeCmb.DropDown += new System.EventHandler(this.SelectSection);
            this.SectionCodeCmb.SelectedIndexChanged += new System.EventHandler(this.SelectSection);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(646, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 30);
            this.button3.TabIndex = 42;
            this.button3.Text = "&View all Students";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // DateLBL
            // 
            this.DateLBL.AutoSize = true;
            this.DateLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLBL.Location = new System.Drawing.Point(368, 27);
            this.DateLBL.Name = "DateLBL";
            this.DateLBL.Size = new System.Drawing.Size(63, 29);
            this.DateLBL.TabIndex = 41;
            this.DateLBL.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // ReferenceLbl
            // 
            this.ReferenceLbl.AutoSize = true;
            this.ReferenceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceLbl.Location = new System.Drawing.Point(305, 271);
            this.ReferenceLbl.Name = "ReferenceLbl";
            this.ReferenceLbl.Size = new System.Drawing.Size(125, 29);
            this.ReferenceLbl.TabIndex = 44;
            this.ReferenceLbl.Text = "Reference";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(304, 176);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(126, 33);
            this.radioButton4.TabIndex = 40;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "&Excused";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(304, 137);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 33);
            this.radioButton3.TabIndex = 39;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "&Late";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(304, 96);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(108, 33);
            this.radioButton2.TabIndex = 38;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "&Absent";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(557, 289);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 37);
            this.comboBox1.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(476, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 36;
            this.label6.Text = "Search:";
            // 
            // EmailLBL
            // 
            this.EmailLBL.AutoSize = true;
            this.EmailLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLBL.Location = new System.Drawing.Point(477, 204);
            this.EmailLBL.Name = "EmailLBL";
            this.EmailLBL.Size = new System.Drawing.Size(80, 29);
            this.EmailLBL.TabIndex = 35;
            this.EmailLBL.Text = "Email:";
            // 
            // SumOfAtndLBL
            // 
            this.SumOfAtndLBL.AutoSize = true;
            this.SumOfAtndLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumOfAtndLBL.Location = new System.Drawing.Point(476, 248);
            this.SumOfAtndLBL.Name = "SumOfAtndLBL";
            this.SumOfAtndLBL.Size = new System.Drawing.Size(272, 29);
            this.SumOfAtndLBL.TabIndex = 34;
            this.SumOfAtndLBL.Text = "Summary of Attendance:";
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLBL.Location = new System.Drawing.Point(476, 120);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(84, 29);
            this.NameLBL.TabIndex = 33;
            this.NameLBL.Text = "Name:";
            // 
            // ConNoLBL
            // 
            this.ConNoLBL.AutoSize = true;
            this.ConNoLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConNoLBL.Location = new System.Drawing.Point(476, 163);
            this.ConNoLBL.Name = "ConNoLBL";
            this.ConNoLBL.Size = new System.Drawing.Size(193, 29);
            this.ConNoLBL.TabIndex = 32;
            this.ConNoLBL.Text = "Contact Number:";
            // 
            // TestGridView
            // 
            this.TestGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestGridView.Location = new System.Drawing.Point(16, 402);
            this.TestGridView.Name = "TestGridView";
            this.TestGridView.RowTemplate.Height = 24;
            this.TestGridView.Size = new System.Drawing.Size(826, 398);
            this.TestGridView.TabIndex = 31;
            // 
            // StdntNoLBL
            // 
            this.StdntNoLBL.AutoSize = true;
            this.StdntNoLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdntNoLBL.Location = new System.Drawing.Point(475, 83);
            this.StdntNoLBL.Name = "StdntNoLBL";
            this.StdntNoLBL.Size = new System.Drawing.Size(194, 29);
            this.StdntNoLBL.TabIndex = 28;
            this.StdntNoLBL.Text = "Student Number:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(208, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 45);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(57, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 45);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Comprog2Project.Properties.Resources.people;
            this.pictureBox1.Location = new System.Drawing.Point(16, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // SearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 812);
            this.Controls.Add(this.PicpathLBL);
            this.Controls.Add(this.SectionCodeCmb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DateLBL);
            this.Controls.Add(this.ReferenceLbl);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmailLBL);
            this.Controls.Add(this.SumOfAtndLBL);
            this.Controls.Add(this.NameLBL);
            this.Controls.Add(this.ConNoLBL);
            this.Controls.Add(this.TestGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StdntNoLBL);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SearchStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchStudent";
            ((System.ComponentModel.ISupportInitialize)(this.TestGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PicpathLBL;
        private System.Windows.Forms.ComboBox SectionCodeCmb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label DateLBL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ReferenceLbl;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label EmailLBL;
        private System.Windows.Forms.Label SumOfAtndLBL;
        private System.Windows.Forms.Label NameLBL;
        private System.Windows.Forms.Label ConNoLBL;
        private System.Windows.Forms.DataGridView TestGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label StdntNoLBL;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}