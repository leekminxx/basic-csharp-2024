namespace lkm0712
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100; // Ÿ�̸� ���� 100m
            timer1.Start(); //Ÿ�̸� ����
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("F"); // label1�� ���糯¥�ð� ǥ�� F : �ڼ��� ��ü ��¥�ð�
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
