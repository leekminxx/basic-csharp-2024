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
            this.BtnUsers = new System.Windows.Forms.Button();
            this.BtnBmi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUsers
            // 
            this.BtnUsers.Location = new System.Drawing.Point(162, 152);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(190, 122);
            this.BtnUsers.TabIndex = 0;
            this.BtnUsers.Text = "회원관리";
            this.BtnUsers.UseVisualStyleBackColor = true;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnBmi
            // 
            this.BtnBmi.Location = new System.Drawing.Point(440, 152);
            this.BtnBmi.Name = "BtnBmi";
            this.BtnBmi.Size = new System.Drawing.Size(207, 122);
            this.BtnBmi.TabIndex = 0;
            this.BtnBmi.Text = "BMI";
            this.BtnBmi.UseVisualStyleBackColor = true;
            this.BtnBmi.Click += new System.EventHandler(this.BtnBmi_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBmi);
            this.Controls.Add(this.BtnUsers);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUsers;
        private System.Windows.Forms.Button BtnBmi;
    }
}

