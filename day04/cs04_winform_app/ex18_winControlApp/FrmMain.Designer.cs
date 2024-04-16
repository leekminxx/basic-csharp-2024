﻿namespace ex18_winControlApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            groupBox1 = new GroupBox();
            TxtSampleText = new TextBox();
            ChkItalic = new CheckBox();
            Chkbold = new CheckBox();
            CboFonts = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            PrgDummy = new ProgressBar();
            TrbDummy = new TrackBar();
            groupBox3 = new GroupBox();
            BtnQuestion = new Button();
            BtnMsgBox = new Button();
            BtnModaless = new Button();
            BtnModal = new Button();
            groupBox4 = new GroupBox();
            BtnAddChild = new Button();
            BtnAddRoot = new Button();
            LsvDummy = new ListView();
            TrvDummy = new TreeView();
            groupBox5 = new GroupBox();
            BtnLoad = new Button();
            PicNormal = new PictureBox();
            DlgOpenlmage = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbDummy).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicNormal).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtSampleText);
            groupBox1.Controls.Add(ChkItalic);
            groupBox1.Controls.Add(Chkbold);
            groupBox1.Controls.Add(CboFonts);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("나눔고딕", 8.999999F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 103);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "콤보박스 , 체크박스 , 텍스트박스";
            // 
            // TxtSampleText
            // 
            TxtSampleText.Font = new Font("나눔고딕", 8.999999F);
            TxtSampleText.Location = new Point(20, 51);
            TxtSampleText.Name = "TxtSampleText";
            TxtSampleText.Size = new Size(320, 21);
            TxtSampleText.TabIndex = 3;
            TxtSampleText.Text = "Hello, C#!";
            // 
            // ChkItalic
            // 
            ChkItalic.AutoSize = true;
            ChkItalic.Checked = true;
            ChkItalic.CheckState = CheckState.Checked;
            ChkItalic.Font = new Font("나눔고딕", 8.999999F);
            ChkItalic.Location = new Point(278, 21);
            ChkItalic.Name = "ChkItalic";
            ChkItalic.Size = new Size(59, 18);
            ChkItalic.TabIndex = 2;
            ChkItalic.Text = "이탤릭";
            ChkItalic.UseVisualStyleBackColor = true;
            ChkItalic.CheckedChanged += ChkItalic_CheckedChanged;
            // 
            // Chkbold
            // 
            Chkbold.AutoSize = true;
            Chkbold.Checked = true;
            Chkbold.CheckState = CheckState.Checked;
            Chkbold.Font = new Font("나눔고딕", 8.999999F);
            Chkbold.Location = new Point(222, 21);
            Chkbold.Name = "Chkbold";
            Chkbold.Size = new Size(51, 18);
            Chkbold.TabIndex = 2;
            Chkbold.Text = "굵게 ";
            Chkbold.UseVisualStyleBackColor = true;
            Chkbold.CheckedChanged += Chkbold_CheckedChanged;
            // 
            // CboFonts
            // 
            CboFonts.Font = new Font("나눔고딕", 8.999999F);
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(65, 22);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(151, 22);
            CboFonts.TabIndex = 1;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("나눔고딕", 8.999999F);
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(33, 14);
            label1.TabIndex = 0;
            label1.Text = "폰트:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PrgDummy);
            groupBox2.Controls.Add(TrbDummy);
            groupBox2.Location = new Point(12, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 124);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "트랙바 , 프로그레스바";
            // 
            // PrgDummy
            // 
            PrgDummy.Location = new Point(6, 73);
            PrgDummy.Maximum = 20;
            PrgDummy.Name = "PrgDummy";
            PrgDummy.Size = new Size(409, 23);
            PrgDummy.TabIndex = 1;
            // 
            // TrbDummy
            // 
            TrbDummy.Location = new Point(6, 22);
            TrbDummy.Maximum = 20;
            TrbDummy.Name = "TrbDummy";
            TrbDummy.Size = new Size(409, 45);
            TrbDummy.TabIndex = 0;
            TrbDummy.Scroll += TrbDummy_Scroll;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnQuestion);
            groupBox3.Controls.Add(BtnMsgBox);
            groupBox3.Controls.Add(BtnModaless);
            groupBox3.Controls.Add(BtnModal);
            groupBox3.Location = new Point(12, 251);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(421, 130);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "모달창 , 모달리스창";
            // 
            // BtnQuestion
            // 
            BtnQuestion.Location = new Point(317, 22);
            BtnQuestion.Name = "BtnQuestion";
            BtnQuestion.Size = new Size(77, 30);
            BtnQuestion.TabIndex = 4;
            BtnQuestion.Text = "...";
            BtnQuestion.UseVisualStyleBackColor = true;
            BtnQuestion.Click += BtnQuestion_Click;
            // 
            // BtnMsgBox
            // 
            BtnMsgBox.Location = new Point(198, 22);
            BtnMsgBox.Name = "BtnMsgBox";
            BtnMsgBox.Size = new Size(113, 30);
            BtnMsgBox.TabIndex = 0;
            BtnMsgBox.Text = "MeeasgeBox";
            BtnMsgBox.UseVisualStyleBackColor = true;
            BtnMsgBox.Click += BtnMsgBox_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(107, 22);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(79, 30);
            BtnModaless.TabIndex = 0;
            BtnModaless.Text = "Modaless";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(20, 22);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(81, 30);
            BtnModal.TabIndex = 0;
            BtnModal.Text = "Modal";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnAddChild);
            groupBox4.Controls.Add(BtnAddRoot);
            groupBox4.Controls.Add(LsvDummy);
            groupBox4.Controls.Add(TrvDummy);
            groupBox4.Location = new Point(12, 387);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(421, 219);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "트리뷰 , 리스트뷰 ";
            // 
            // BtnAddChild
            // 
            BtnAddChild.Location = new Point(107, 178);
            BtnAddChild.Name = "BtnAddChild";
            BtnAddChild.Size = new Size(84, 35);
            BtnAddChild.TabIndex = 2;
            BtnAddChild.Text = "자식추가";
            BtnAddChild.UseVisualStyleBackColor = true;
            BtnAddChild.Click += BtnAddChild_Click;
            // 
            // BtnAddRoot
            // 
            BtnAddRoot.Location = new Point(6, 178);
            BtnAddRoot.Name = "BtnAddRoot";
            BtnAddRoot.Size = new Size(87, 35);
            BtnAddRoot.TabIndex = 2;
            BtnAddRoot.Text = "루트추가";
            BtnAddRoot.UseVisualStyleBackColor = true;
            BtnAddRoot.Click += BtnAddRoot_Click;
            // 
            // LsvDummy
            // 
            LsvDummy.Location = new Point(216, 22);
            LsvDummy.Name = "LsvDummy";
            LsvDummy.Size = new Size(185, 150);
            LsvDummy.TabIndex = 1;
            LsvDummy.UseCompatibleStateImageBehavior = false;
            LsvDummy.View = View.Details;
            // 
            // TrvDummy
            // 
            TrvDummy.Location = new Point(6, 22);
            TrvDummy.Name = "TrvDummy";
            TrvDummy.Size = new Size(185, 150);
            TrvDummy.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(BtnLoad);
            groupBox5.Controls.Add(PicNormal);
            groupBox5.Location = new Point(439, 15);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(334, 591);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "픽처박스";
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(253, 286);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(75, 23);
            BtnLoad.TabIndex = 1;
            BtnLoad.Text = "로드";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // PicNormal
            // 
            PicNormal.BackColor = SystemColors.ActiveBorder;
            PicNormal.Location = new Point(6, 18);
            PicNormal.Name = "PicNormal";
            PicNormal.Size = new Size(322, 262);
            PicNormal.TabIndex = 0;
            PicNormal.TabStop = false;
            PicNormal.Click += PicNormal_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 688);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "컨트롤 예제";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrbDummy).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicNormal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox Chkbold;
        private ComboBox CboFonts;
        private Label label1;
        private TextBox TxtSampleText;
        private CheckBox ChkItalic;
        private GroupBox groupBox2;
        private ProgressBar PrgDummy;
        private TrackBar TrbDummy;
        private GroupBox groupBox3;
        private Button BtnMsgBox;
        private Button BtnModaless;
        private Button BtnModal;
        private Button BtnQuestion;
        private GroupBox groupBox4;
        private ListView LsvDummy;
        private TreeView TrvDummy;
        private Button BtnAddRoot;
        private Button BtnAddChild;
        private GroupBox groupBox5;
        private Button BtnLoad;
        private PictureBox PicNormal;
        private OpenFileDialog DlgOpenlmage;
    }
}
