namespace BMI_chek
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoFemale = new System.Windows.Forms.RadioButton();
            this.RdoMale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxKG = new System.Windows.Forms.TextBox();
            this.tboxCM = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRet = new System.Windows.Forms.Label();
            this.tbarRet = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblOverWeight = new System.Windows.Forms.Label();
            this.LblNormalWeight = new System.Windows.Forms.Label();
            this.LblLightWeight = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarRet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoFemale);
            this.groupBox1.Controls.Add(this.RdoMale);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxKG);
            this.groupBox1.Controls.Add(this.tboxCM);
            this.groupBox1.Controls.Add(this.btnCal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력";
            // 
            // RdoFemale
            // 
            this.RdoFemale.AutoSize = true;
            this.RdoFemale.Location = new System.Drawing.Point(111, 17);
            this.RdoFemale.Name = "RdoFemale";
            this.RdoFemale.Size = new System.Drawing.Size(47, 16);
            this.RdoFemale.TabIndex = 5;
            this.RdoFemale.Text = "여자";
            this.RdoFemale.UseVisualStyleBackColor = true;
            this.RdoFemale.CheckedChanged += new System.EventHandler(this.RdoFemale_CheckedChanged);
            // 
            // RdoMale
            // 
            this.RdoMale.AutoSize = true;
            this.RdoMale.Checked = true;
            this.RdoMale.Location = new System.Drawing.Point(59, 17);
            this.RdoMale.Name = "RdoMale";
            this.RdoMale.Size = new System.Drawing.Size(47, 16);
            this.RdoMale.TabIndex = 4;
            this.RdoMale.TabStop = true;
            this.RdoMale.Text = "남자";
            this.RdoMale.UseVisualStyleBackColor = true;
            this.RdoMale.CheckedChanged += new System.EventHandler(this.RdoMale_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "몸무게(kg)";
            // 
            // button1
            // 
            this.button1.Image = global::BMI_chek.Properties.Resources.search2;
            this.button1.Location = new System.Drawing.Point(400, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "키 (cm)";
            // 
            // tboxKG
            // 
            this.tboxKG.Location = new System.Drawing.Point(235, 43);
            this.tboxKG.Name = "tboxKG";
            this.tboxKG.Size = new System.Drawing.Size(100, 21);
            this.tboxKG.TabIndex = 1;
            // 
            // tboxCM
            // 
            this.tboxCM.Location = new System.Drawing.Point(55, 43);
            this.tboxCM.Name = "tboxCM";
            this.tboxCM.Size = new System.Drawing.Size(100, 21);
            this.tboxCM.TabIndex = 1;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(351, 41);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 0;
            this.btnCal.Text = "계산";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRet);
            this.groupBox2.Controls.Add(this.tbarRet);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.LblOverWeight);
            this.groupBox2.Controls.Add(this.LblNormalWeight);
            this.groupBox2.Controls.Add(this.LblLightWeight);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            // 
            // lblRet
            // 
            this.lblRet.AutoSize = true;
            this.lblRet.Location = new System.Drawing.Point(18, 113);
            this.lblRet.Name = "lblRet";
            this.lblRet.Size = new System.Drawing.Size(11, 12);
            this.lblRet.TabIndex = 3;
            this.lblRet.Text = "*";
            // 
            // tbarRet
            // 
            this.tbarRet.Enabled = false;
            this.tbarRet.Location = new System.Drawing.Point(8, 80);
            this.tbarRet.Maximum = 280;
            this.tbarRet.Minimum = 150;
            this.tbarRet.Name = "tbarRet";
            this.tbarRet.Size = new System.Drawing.Size(430, 45);
            this.tbarRet.TabIndex = 2;
            this.tbarRet.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbarRet.Value = 150;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(333, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "비만";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(262, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "과체중";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.YellowGreen;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(135, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "정상체중";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(8, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "저체중";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblOverWeight
            // 
            this.LblOverWeight.AutoSize = true;
            this.LblOverWeight.Location = new System.Drawing.Point(318, 32);
            this.LblOverWeight.Name = "LblOverWeight";
            this.LblOverWeight.Size = new System.Drawing.Size(11, 12);
            this.LblOverWeight.TabIndex = 0;
            this.LblOverWeight.Text = "-";
            // 
            // LblNormalWeight
            // 
            this.LblNormalWeight.AutoSize = true;
            this.LblNormalWeight.Location = new System.Drawing.Point(249, 32);
            this.LblNormalWeight.Name = "LblNormalWeight";
            this.LblNormalWeight.Size = new System.Drawing.Size(11, 12);
            this.LblNormalWeight.TabIndex = 0;
            this.LblNormalWeight.Text = "-";
            // 
            // LblLightWeight
            // 
            this.LblLightWeight.AutoSize = true;
            this.LblLightWeight.Location = new System.Drawing.Point(108, 32);
            this.LblLightWeight.Name = "LblLightWeight";
            this.LblLightWeight.Size = new System.Drawing.Size(11, 12);
            this.LblLightWeight.TabIndex = 0;
            this.LblLightWeight.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 250);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarRet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxKG;
        private System.Windows.Forms.TextBox tboxCM;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblOverWeight;
        private System.Windows.Forms.Label LblNormalWeight;
        private System.Windows.Forms.Label LblLightWeight;
        private System.Windows.Forms.TrackBar tbarRet;
        private System.Windows.Forms.Label lblRet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RdoFemale;
        private System.Windows.Forms.RadioButton RdoMale;
    }
}

