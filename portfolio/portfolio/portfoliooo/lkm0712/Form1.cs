


using System.Windows.Forms;
namespace lkm0712
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ucPanel.ucScreen1 ucSc1 = new ucPanel.ucScreen1();
        ucPanel.ucScreen2 ucSc2 = new ucPanel.ucScreen2();
        ucPanel.ucScreen3 ucSc3 = new ucPanel.ucScreen3();
        ucPanel.ucScreen4 ucSc4 = new ucPanel.ucScreen4();


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100; // 타이머 간격 100m
            timer1.Start(); //타이머 시작



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("F"); // label1에 현재날짜시간 표시 F : 자세한 전체 날짜시간
        }

        private void Btns1_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(ucSc1);
        }
        #region 버튼 이벤트
        private void Btns2_Click(object sender, EventArgs e)
        {
           pMain.Controls.Clear();
            pMain.Controls.Add(ucSc2);
        }

        private void Btns3_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(ucSc3);
        }

        private void Btns4_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(ucSc4);
        }
        #endregion
    }
}
