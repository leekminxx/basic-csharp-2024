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
            timer1.Interval = 100; // 타이머 간격 100m
            timer1.Start(); //타이머 시작
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("F"); // label1에 현재날짜시간 표시 F : 자세한 전체 날짜시간
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
