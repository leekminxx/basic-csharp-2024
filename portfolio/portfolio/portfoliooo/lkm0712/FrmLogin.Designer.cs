namespace lkm0712
{
    partial class FrmLogin
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            TxtUserId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtPassword = new TextBox();
            BtnLogin = new Button();
            panel5 = new Panel();
            BtnCancel = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(28, 340);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 1);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(31, 340);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 1);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Location = new Point(25, 340);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(215, 1);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.Location = new Point(28, 413);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(215, 1);
            panel4.TabIndex = 2;
            // 
            // TxtUserId
            // 
            TxtUserId.BackColor = SystemColors.Control;
            TxtUserId.Location = new Point(28, 315);
            TxtUserId.Margin = new Padding(3, 4, 3, 4);
            TxtUserId.Name = "TxtUserId";
            TxtUserId.Size = new Size(209, 23);
            TxtUserId.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(28, 286);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(29, 369);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = SystemColors.Control;
            TxtPassword.Location = new Point(28, 388);
            TxtPassword.Margin = new Padding(3, 4, 3, 4);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(209, 23);
            TxtPassword.TabIndex = 6;
            // 
            // BtnLogin
            // 
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.ForeColor = Color.Teal;
            BtnLogin.Location = new Point(58, 456);
            BtnLogin.Margin = new Padding(3, 4, 3, 4);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(75, 29);
            BtnLogin.TabIndex = 7;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.BK01;
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(20, 60);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(260, 212);
            panel5.TabIndex = 8;
            // 
            // BtnCancel
            // 
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.ForeColor = Color.Teal;
            BtnCancel.Location = new Point(149, 456);
            BtnCancel.Margin = new Padding(3, 4, 3, 4);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 29);
            BtnCancel.TabIndex = 7;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click_1;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 562);
            Controls.Add(panel5);
            Controls.Add(BtnCancel);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtUserId);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmLogin";
            Text = "쇼핑몰 로그인";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxtUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnCancel;
    }
}

