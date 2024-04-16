namespace ex18_winControlApp
{
    public partial class FrmMain : Form
    {
        Random rand = new Random(); // Ʈ���� ����̸����� ����� ������
        public FrmMain()
        {
            InitializeComponent();  // �����̳ʿ��� ������ ȭ�鱸�� �ʱ�ȭ 

            LsvDummy.Columns.Add("�̸�");
            LsvDummy.Columns.Add("����");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families; // ���� OS���� ��ġ�� ��Ʈ�� �ٰ����� 
            foreach (var font in Fonts)
            {
                CboFonts.Items.Add(font.Name);
            }
        }

        //����ü , ���� , ���Ÿ����� �����ϴ� �޼���
        void ChangeFont()
        {
            if (CboFonts.SelectedIndex < 0) // �ƹ��͵� ���þȵ�

                return;

            FontStyle style = FontStyle.Regular;    // �Ϲ� ���� (����X , ���Ÿ�X)�� �ʱ�ȭ

            if (Chkbold.Checked)   // ���� üũ�ڽ��� üũ�ϸ� 
                style |= FontStyle.Bold;

            if (ChkItalic.Checked) // ���Ÿ� üũ�ڽ��� üũ�ϸ�
                style |= FontStyle.Italic;

            TxtSampleText.Font = new Font((string)CboFonts.SelectedItem, 12, style);
        }

        void TreeToList()
        {
            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                TreeToList(node);
            }
        }

        private void TreeToList(TreeNode node)
        {
            //throw new NotImplementedException();
            LsvDummy.Items.Add( //fltmxmqbdp dkdlxpacnrk
                new ListViewItem(
                    new string[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() }
                    )
                );
            foreach (TreeNode subNode in node.Nodes)
            {
                TreeToList(subNode);
            }
        }


        private void CboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void Chkbold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        // Ʈ���� ��ũ�� �̺�Ʈ�ڵ鷯
        private void TrbDummy_Scroll(object sender, EventArgs e)
        {
            PrgDummy.Value = TrbDummy.Value;  // Ʈ���� �����͸� �ű�� ���α׷����� ���� ���� ����
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form FrmModal = new Form();
            FrmModal.Text = "���â";
            FrmModal.Width = 300;
            FrmModal.Height = 100;
            FrmModal.BackColor = Color.Red;
            FrmModal.ShowDialog(); // ���â ����

        }
        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form FrmModalless = new Form();
            FrmModalless.Text = "��޸���â";
            FrmModalless.Width = 300;
            FrmModalless.Height = 100;
            FrmModalless.BackColor = Color.Green;
            FrmModalless.Show(); // ��޸���â ����
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtSampleText.Text, "�޽����ڽ�", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnQuestion_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("���ƿ�?", "����", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("�� ���ƿ�!");
            }
            else if (res == DialogResult.No)
            {
                MessageBox.Show("�ƴ� ���� �Ⱦ��!!!");
            }
        }

        // ������ �����ư�� Ŭ�������� �߻��ϴ� �̺�Ʈ �ڵ鷯
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("���� �����Ͻðڽ��ϱ�", "���Ῡ��", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (res == DialogResult.No) e.Cancel = true;
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            TrvDummy.Nodes.Add(rand.Next().ToString());
            TreeToList();
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if (TrvDummy.SelectedNode == null)
            { // �θ��带 �������� ������
                MessageBox.Show("�����ѳ�尡 ����.", "���", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // ���̻� ������� �޼��� ����
            }

            TrvDummy.SelectedNode.Nodes.Add(rand.Next().ToString());
            TrvDummy.SelectedNode.Expand();
            TreeToList(); // ����Ʈ�並 �ٽ� �׷��ش�.
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            DlgOpenlmage.Title = "�̹��� ����";
            // Filter�� Ȯ���ڸ� �̹����θ� ����
            DlgOpenlmage.Filter = "Image Files(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            var res = DlgOpenlmage.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                //MessageBox.Show(DlgOpenImage.FileName.ToString());
                PicNormal.Image = Bitmap.FromFile(DlgOpenlmage.FileName);
            }
        }

        private void PicNormal_Click(object sender, EventArgs e)
        {
            if (PicNormal.SizeMode == PictureBoxSizeMode.Normal)
            {
                PicNormal.SizeMode = PictureBoxSizeMode.StretchImage;
            }else
            {
                PicNormal.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    
    }
}

