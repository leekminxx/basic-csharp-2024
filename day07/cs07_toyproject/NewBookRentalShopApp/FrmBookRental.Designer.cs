﻿namespace NewBookRentalShopApp
{
    partial class FrmBookRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookRental));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DgvResult = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSearchMember = new System.Windows.Forms.Button();
            this.TxtBookIdx = new System.Windows.Forms.TextBox();
            this.TxtMemberIdx = new System.Windows.Forms.TextBox();
            this.TxtBookNames = new MetroFramework.Controls.MetroTextBox();
            this.DtpRentalDate = new MetroFramework.Controls.MetroDateTime();
            this.DtpReturnDate = new MetroFramework.Controls.MetroDateTime();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.TxtMemNames = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TxtRentalIdx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TxtBookIdx2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DgvResult);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(760, 370);
            this.splitContainer1.SplitterDistance = 385;
            this.splitContainer1.TabIndex = 0;
            // 
            // DgvResult
            // 
            this.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvResult.Location = new System.Drawing.Point(0, 0);
            this.DgvResult.Name = "DgvResult";
            this.DgvResult.RowTemplate.Height = 23;
            this.DgvResult.Size = new System.Drawing.Size(385, 370);
            this.DgvResult.TabIndex = 0;
            this.DgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResult_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BtnSearchMember);
            this.groupBox1.Controls.Add(this.TxtBookIdx);
            this.groupBox1.Controls.Add(this.TxtMemberIdx);
            this.groupBox1.Controls.Add(this.TxtBookNames);
            this.groupBox1.Controls.Add(this.DtpRentalDate);
            this.groupBox1.Controls.Add(this.DtpReturnDate);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.TxtMemNames);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.TxtRentalIdx);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.TxtBookIdx2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "대출정보 입력항목";
            // 
            // button1
            // 
            this.button1.Image = global::NewBookRentalShopApp.Properties.Resources.search2;
            this.button1.Location = new System.Drawing.Point(301, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSearchMember
            // 
            this.BtnSearchMember.Image = global::NewBookRentalShopApp.Properties.Resources.search2;
            this.BtnSearchMember.Location = new System.Drawing.Point(301, 48);
            this.BtnSearchMember.Name = "BtnSearchMember";
            this.BtnSearchMember.Size = new System.Drawing.Size(23, 23);
            this.BtnSearchMember.TabIndex = 4;
            this.BtnSearchMember.UseVisualStyleBackColor = true;
            this.BtnSearchMember.Click += new System.EventHandler(this.BtnSearchMember_Click);
            // 
            // TxtBookIdx
            // 
            this.TxtBookIdx.Location = new System.Drawing.Point(112, 80);
            this.TxtBookIdx.Name = "TxtBookIdx";
            this.TxtBookIdx.Size = new System.Drawing.Size(57, 21);
            this.TxtBookIdx.TabIndex = 5;
            // 
            // TxtMemberIdx
            // 
            this.TxtMemberIdx.Location = new System.Drawing.Point(112, 50);
            this.TxtMemberIdx.Name = "TxtMemberIdx";
            this.TxtMemberIdx.Size = new System.Drawing.Size(57, 21);
            this.TxtMemberIdx.TabIndex = 2;
            // 
            // TxtBookNames
            // 
            // 
            // 
            // 
            this.TxtBookNames.CustomButton.Image = null;
            this.TxtBookNames.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.TxtBookNames.CustomButton.Name = "";
            this.TxtBookNames.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBookNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBookNames.CustomButton.TabIndex = 1;
            this.TxtBookNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBookNames.CustomButton.UseSelectable = true;
            this.TxtBookNames.CustomButton.Visible = false;
            this.TxtBookNames.Lines = new string[0];
            this.TxtBookNames.Location = new System.Drawing.Point(175, 80);
            this.TxtBookNames.MaxLength = 32767;
            this.TxtBookNames.Name = "TxtBookNames";
            this.TxtBookNames.PasswordChar = '\0';
            this.TxtBookNames.PromptText = "책 제목 선택";
            this.TxtBookNames.ReadOnly = true;
            this.TxtBookNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBookNames.SelectedText = "";
            this.TxtBookNames.SelectionLength = 0;
            this.TxtBookNames.SelectionStart = 0;
            this.TxtBookNames.ShortcutsEnabled = true;
            this.TxtBookNames.Size = new System.Drawing.Size(120, 23);
            this.TxtBookNames.TabIndex = 6;
            this.TxtBookNames.UseSelectable = true;
            this.TxtBookNames.WaterMark = "책 제목 선택";
            this.TxtBookNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBookNames.WaterMarkFont = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // DtpRentalDate
            // 
            this.DtpRentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpRentalDate.Location = new System.Drawing.Point(110, 109);
            this.DtpRentalDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpRentalDate.Name = "DtpRentalDate";
            this.DtpRentalDate.Size = new System.Drawing.Size(215, 29);
            this.DtpRentalDate.TabIndex = 8;
            // 
            // DtpReturnDate
            // 
            this.DtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpReturnDate.Location = new System.Drawing.Point(110, 144);
            this.DtpReturnDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpReturnDate.Name = "DtpReturnDate";
            this.DtpReturnDate.Size = new System.Drawing.Size(215, 29);
            this.DtpReturnDate.TabIndex = 9;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(189, 258);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(70, 35);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(112, 258);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(70, 35);
            this.BtnNew.TabIndex = 10;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // TxtMemNames
            // 
            // 
            // 
            // 
            this.TxtMemNames.CustomButton.Image = null;
            this.TxtMemNames.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.TxtMemNames.CustomButton.Name = "";
            this.TxtMemNames.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMemNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMemNames.CustomButton.TabIndex = 1;
            this.TxtMemNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMemNames.CustomButton.UseSelectable = true;
            this.TxtMemNames.CustomButton.Visible = false;
            this.TxtMemNames.Lines = new string[0];
            this.TxtMemNames.Location = new System.Drawing.Point(175, 49);
            this.TxtMemNames.MaxLength = 32767;
            this.TxtMemNames.Name = "TxtMemNames";
            this.TxtMemNames.PasswordChar = '\0';
            this.TxtMemNames.PromptText = "회원명 선택";
            this.TxtMemNames.ReadOnly = true;
            this.TxtMemNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMemNames.SelectedText = "";
            this.TxtMemNames.SelectionLength = 0;
            this.TxtMemNames.SelectionStart = 0;
            this.TxtMemNames.ShortcutsEnabled = true;
            this.TxtMemNames.Size = new System.Drawing.Size(120, 23);
            this.TxtMemNames.TabIndex = 3;
            this.TxtMemNames.UseSelectable = true;
            this.TxtMemNames.WaterMark = "회원명 선택";
            this.TxtMemNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMemNames.WaterMarkFont = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(53, 115);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "대출일";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(53, 150);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "반납일";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtRentalIdx
            // 
            // 
            // 
            // 
            this.TxtRentalIdx.CustomButton.Image = null;
            this.TxtRentalIdx.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.TxtRentalIdx.CustomButton.Name = "";
            this.TxtRentalIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtRentalIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRentalIdx.CustomButton.TabIndex = 1;
            this.TxtRentalIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRentalIdx.CustomButton.UseSelectable = true;
            this.TxtRentalIdx.CustomButton.Visible = false;
            this.TxtRentalIdx.Lines = new string[0];
            this.TxtRentalIdx.Location = new System.Drawing.Point(109, 20);
            this.TxtRentalIdx.MaxLength = 32767;
            this.TxtRentalIdx.Name = "TxtRentalIdx";
            this.TxtRentalIdx.PasswordChar = '\0';
            this.TxtRentalIdx.ReadOnly = true;
            this.TxtRentalIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRentalIdx.SelectedText = "";
            this.TxtRentalIdx.SelectionLength = 0;
            this.TxtRentalIdx.SelectionStart = 0;
            this.TxtRentalIdx.ShortcutsEnabled = true;
            this.TxtRentalIdx.Size = new System.Drawing.Size(215, 23);
            this.TxtRentalIdx.TabIndex = 1;
            this.TxtRentalIdx.UseSelectable = true;
            this.TxtRentalIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRentalIdx.WaterMarkFont = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(50, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "책 제목";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(53, 53);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "회원명";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBookIdx2
            // 
            this.TxtBookIdx2.AutoSize = true;
            this.TxtBookIdx2.Location = new System.Drawing.Point(39, 24);
            this.TxtBookIdx2.Name = "TxtBookIdx2";
            this.TxtBookIdx2.Size = new System.Drawing.Size(65, 19);
            this.TxtBookIdx2.TabIndex = 1;
            this.TxtBookIdx2.Text = "대출순번";
            this.TxtBookIdx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmBookRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBookRental";
            this.Text = "대출";
            this.Load += new System.EventHandler(this.FrmLoginUser_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DgvResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox TxtMemNames;
        private MetroFramework.Controls.MetroTextBox TxtRentalIdx;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel TxtBookIdx2;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime DtpReturnDate;
        private MetroFramework.Controls.MetroDateTime DtpRentalDate;
        private MetroFramework.Controls.MetroTextBox TxtBookNames;
        private System.Windows.Forms.TextBox TxtMemberIdx;
        private System.Windows.Forms.Button BtnSearchMember;
        private System.Windows.Forms.TextBox TxtBookIdx;
        private System.Windows.Forms.Button button1;
    }
}