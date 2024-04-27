namespace healthCheck
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TextBox textBox3;
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.tboxKG = new System.Windows.Forms.TextBox();
            this.tboxCM = new System.Windows.Forms.TextBox();
            this.RdoFemale = new System.Windows.Forms.RadioButton();
            this.RdoMale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblRet = new System.Windows.Forms.Label();
            this.tbarRet = new System.Windows.Forms.TrackBar();
            this.LblOverWeight = new System.Windows.Forms.Label();
            this.LblNormalWeight = new System.Windows.Forms.Label();
            this.LblLightWeight = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarRet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.BackColor = System.Drawing.SystemColors.Control;
            textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox3.ForeColor = System.Drawing.Color.Orange;
            textBox3.Location = new System.Drawing.Point(144, 29);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(132, 14);
            textBox3.TabIndex = 9;
            textBox3.Text = "← 직접 선택해주세요!!";
            textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DgvUsers
            // 
            this.DgvUsers.AllowUserToAddRows = false;
            this.DgvUsers.AllowUserToDeleteRows = false;
            this.DgvUsers.AllowUserToResizeColumns = false;
            this.DgvUsers.AllowUserToResizeRows = false;
            this.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvUsers.Location = new System.Drawing.Point(0, 0);
            this.DgvUsers.MultiSelect = false;
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.ReadOnly = true;
            this.DgvUsers.RowHeadersVisible = false;
            this.DgvUsers.RowTemplate.Height = 23;
            this.DgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsers.Size = new System.Drawing.Size(274, 425);
            this.DgvUsers.TabIndex = 2;
            this.DgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsers_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(textBox3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCal);
            this.groupBox1.Controls.Add(this.tboxKG);
            this.groupBox1.Controls.Add(this.tboxCM);
            this.groupBox1.Controls.Add(this.RdoFemale);
            this.groupBox1.Controls.Add(this.RdoMale);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 139);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(261, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 4;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(78, 58);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 21);
            this.txtGender.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "이름 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "성별 : ";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(380, 94);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 7;
            this.btnCal.Text = "계산";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // tboxKG
            // 
            this.tboxKG.Location = new System.Drawing.Point(261, 94);
            this.tboxKG.Name = "tboxKG";
            this.tboxKG.Size = new System.Drawing.Size(100, 21);
            this.tboxKG.TabIndex = 6;
            // 
            // tboxCM
            // 
            this.tboxCM.Location = new System.Drawing.Point(79, 94);
            this.tboxCM.Name = "tboxCM";
            this.tboxCM.Size = new System.Drawing.Size(100, 21);
            this.tboxCM.TabIndex = 5;
            // 
            // RdoFemale
            // 
            this.RdoFemale.AutoSize = true;
            this.RdoFemale.Location = new System.Drawing.Point(88, 27);
            this.RdoFemale.Name = "RdoFemale";
            this.RdoFemale.Size = new System.Drawing.Size(47, 16);
            this.RdoFemale.TabIndex = 2;
            this.RdoFemale.TabStop = true;
            this.RdoFemale.Text = "여자";
            this.RdoFemale.UseVisualStyleBackColor = true;
            this.RdoFemale.CheckedChanged += new System.EventHandler(this.RdoFemale_CheckedChanged);
            // 
            // RdoMale
            // 
            this.RdoMale.AutoSize = true;
            this.RdoMale.Location = new System.Drawing.Point(25, 27);
            this.RdoMale.Name = "RdoMale";
            this.RdoMale.Size = new System.Drawing.Size(47, 16);
            this.RdoMale.TabIndex = 1;
            this.RdoMale.TabStop = true;
            this.RdoMale.Text = "남자";
            this.RdoMale.UseVisualStyleBackColor = true;
            this.RdoMale.CheckedChanged += new System.EventHandler(this.RdoMale_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "몸무게(Kg):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "신장(CM) : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstResults);
            this.groupBox2.Controls.Add(this.lblRet);
            this.groupBox2.Controls.Add(this.tbarRet);
            this.groupBox2.Controls.Add(this.LblOverWeight);
            this.groupBox2.Controls.Add(this.LblNormalWeight);
            this.groupBox2.Controls.Add(this.LblLightWeight);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 329);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 12;
            this.lstResults.Location = new System.Drawing.Point(8, 160);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(448, 100);
            this.lstResults.TabIndex = 6;
            // 
            // lblRet
            // 
            this.lblRet.AutoSize = true;
            this.lblRet.Location = new System.Drawing.Point(21, 129);
            this.lblRet.Name = "lblRet";
            this.lblRet.Size = new System.Drawing.Size(59, 12);
            this.lblRet.TabIndex = 5;
            this.lblRet.Text = "신장(CM)";
            // 
            // tbarRet
            // 
            this.tbarRet.Enabled = false;
            this.tbarRet.Location = new System.Drawing.Point(6, 94);
            this.tbarRet.Maximum = 280;
            this.tbarRet.Minimum = 150;
            this.tbarRet.Name = "tbarRet";
            this.tbarRet.Size = new System.Drawing.Size(451, 45);
            this.tbarRet.TabIndex = 2;
            this.tbarRet.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbarRet.Value = 150;
            // 
            // LblOverWeight
            // 
            this.LblOverWeight.AutoSize = true;
            this.LblOverWeight.Location = new System.Drawing.Point(337, 31);
            this.LblOverWeight.Name = "LblOverWeight";
            this.LblOverWeight.Size = new System.Drawing.Size(23, 12);
            this.LblOverWeight.TabIndex = 1;
            this.LblOverWeight.Text = "---";
            // 
            // LblNormalWeight
            // 
            this.LblNormalWeight.AutoSize = true;
            this.LblNormalWeight.Location = new System.Drawing.Point(261, 33);
            this.LblNormalWeight.Name = "LblNormalWeight";
            this.LblNormalWeight.Size = new System.Drawing.Size(23, 12);
            this.LblNormalWeight.TabIndex = 1;
            this.LblNormalWeight.Text = "---";
            // 
            // LblLightWeight
            // 
            this.LblLightWeight.AutoSize = true;
            this.LblLightWeight.Location = new System.Drawing.Point(122, 34);
            this.LblLightWeight.Name = "LblLightWeight";
            this.LblLightWeight.Size = new System.Drawing.Size(23, 12);
            this.LblLightWeight.TabIndex = 1;
            this.LblLightWeight.Text = "---";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(348, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "비만";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(272, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "과체중";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.YellowGreen;
            this.label4.Location = new System.Drawing.Point(137, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "평균";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "저체중";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DgvUsers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(756, 425);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 6;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 425);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarRet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tboxKG;
        private System.Windows.Forms.TextBox tboxCM;
        private System.Windows.Forms.RadioButton RdoFemale;
        private System.Windows.Forms.RadioButton RdoMale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbarRet;
        private System.Windows.Forms.Label LblOverWeight;
        private System.Windows.Forms.Label LblNormalWeight;
        private System.Windows.Forms.Label LblLightWeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lblRet;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstResults;
    }
}

