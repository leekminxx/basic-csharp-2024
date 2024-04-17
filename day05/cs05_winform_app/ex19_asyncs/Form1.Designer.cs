namespace ex19_asyncs
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            PrgCopy = new ProgressBar();
            TxtTarget = new TextBox();
            TxtSource = new TextBox();
            BtnCancel = new Button();
            BtnAsyncCopy = new Button();
            BtnSyncCopy = new Button();
            button3 = new Button();
            BtnGetSource = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(PrgCopy);
            groupBox1.Controls.Add(TxtTarget);
            groupBox1.Controls.Add(TxtSource);
            groupBox1.Controls.Add(BtnCancel);
            groupBox1.Controls.Add(BtnAsyncCopy);
            groupBox1.Controls.Add(BtnSyncCopy);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(BtnGetSource);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 164);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "비동기 전송";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 55);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "타켓 :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "소스 :";
            // 
            // PrgCopy
            // 
            PrgCopy.Location = new Point(18, 121);
            PrgCopy.Name = "PrgCopy";
            PrgCopy.Size = new Size(397, 30);
            PrgCopy.TabIndex = 3;
            // 
            // TxtTarget
            // 
            TxtTarget.Location = new Point(62, 51);
            TxtTarget.Name = "TxtTarget";
            TxtTarget.ReadOnly = true;
            TxtTarget.Size = new Size(312, 23);
            TxtTarget.TabIndex = 2;
            // 
            // TxtSource
            // 
            TxtSource.Location = new Point(62, 22);
            TxtSource.Name = "TxtSource";
            TxtSource.ReadOnly = true;
            TxtSource.Size = new Size(312, 23);
            TxtSource.TabIndex = 2;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(291, 80);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(124, 34);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "취소";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnAsyncCopy
            // 
            BtnAsyncCopy.Location = new Point(156, 80);
            BtnAsyncCopy.Name = "BtnAsyncCopy";
            BtnAsyncCopy.Size = new Size(129, 35);
            BtnAsyncCopy.TabIndex = 1;
            BtnAsyncCopy.Text = "비동기화 복사";
            BtnAsyncCopy.UseVisualStyleBackColor = true;
            BtnAsyncCopy.Click += BtnAsyncCopy_Click;
            // 
            // BtnSyncCopy
            // 
            BtnSyncCopy.Location = new Point(18, 80);
            BtnSyncCopy.Name = "BtnSyncCopy";
            BtnSyncCopy.Size = new Size(132, 35);
            BtnSyncCopy.TabIndex = 1;
            BtnSyncCopy.Text = "동기화 복사";
            BtnSyncCopy.UseVisualStyleBackColor = true;
            BtnSyncCopy.Click += BtnSyncCopy_Click;
            // 
            // button3
            // 
            button3.Location = new Point(380, 51);
            button3.Name = "button3";
            button3.Size = new Size(35, 23);
            button3.TabIndex = 1;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // BtnGetSource
            // 
            BtnGetSource.Location = new Point(380, 22);
            BtnGetSource.Name = "BtnGetSource";
            BtnGetSource.Size = new Size(35, 23);
            BtnGetSource.TabIndex = 1;
            BtnGetSource.Text = "...";
            BtnGetSource.UseVisualStyleBackColor = true;
            BtnGetSource.Click += BtnGetSource_Click_1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 186);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            Text = "비동기 파일복사";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnCancel;
        private Button BtnSyncCopy;
        private Button button3;
        private Button BtnGetSource;
        private Button BtnAsyncCopy;
        private ProgressBar PrgCopy;
        private TextBox TxtTarget;
        private TextBox TxtSource;
        private Label label2;
        private Label label1;
    }
}
