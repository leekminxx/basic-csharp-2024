using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_chek
{
    public partial class c : Form
    {
        const float maleLightWeight = 18.5f;
        const float maleNormalWeight = 23;
        const float maleOverWeight = 25;
        const float femaleLightWeight = 17.5f;
        const float femaleNormalWeight = 22;
        const float femaleOverWeight = 24;

        double dRet = 0;
        public c()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblLightWeight.Text = maleLightWeight.ToString();
            LblNormalWeight.Text = maleNormalWeight.ToString();
            LblOverWeight.Text = maleOverWeight.ToString();
        }

        /// <summary>
        ///  BMI 계산
        /// </summary>
        /// <param name="dCM"></param>
        /// <param name="dKG"></param>
        private double fBMICal(double dCM , double dKG)
        {
            dRet = dKG / (dCM * dCM);

            return Math.Round( dRet , 1);  //소숫점 한자리까지만
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            var gender = "";
            if(RdoMale.Checked  == true)
            {
                gender = "남자";
            }
            else if(RdoFemale.Checked == true) 
            {
                gender = "여자";
            }
            MessageBox.Show(gender);

            try
            {
                // 1. 값을 받아온다
                double dCM = double.Parse(tboxCM.Text) / 100; //  미터변환
                double dKG = double.Parse(tboxKG.Text);

                // 2. 값을 계산한다
                double dRet = fBMICal(dCM, dKG);

                // 3. trackbar를 이동 시킨다

                int iRet = (int)(dRet * 10);

                // 기준이 over 했을 경우에
                if (iRet < 150) 
                {
                    iRet = 150;
                }
                else if (280 < iRet)
                {
                    iRet = 280;
                }

                tbarRet.Value = iRet;

                // 4. label 에 결과 값을 표시한다.
                // ex) BMI 지수 [31.4] 로 비만도 결과 [비만] 입니다.
                string strRet = fCalResult(dRet);
                lblRet.Text = $"BMI 지수 [{dRet}] 로 비만도 결과 [{strRet}]입니다.";

                string strsRet = "";
                lblRet.Text = $"BMI 지수 [{dRet}] 로 비만도 결과 [{strRet}]입니다.";

            } catch (Exception ex) 
              {
                lblRet.Text = ex.ToString();
                { 

              }
            }
        }

        private string fCalResult(double dRet)
        {
            string strRet = string.Empty;
            if(dRet <18.5)
            {
                strRet = "저체중";
                MessageBox.Show("조금 더 챙겨먹기 바랍니다");
            }
            else if (18.5 <= dRet && dRet < 23)
            {
                strRet = "정상";
                MessageBox.Show("정상 체중입니다");
            }
            else if (23 <= dRet && dRet < 25)
            {
                strRet = "과체중";
                MessageBox.Show("조금만 더 노력하세요");
            }
            else if (25 <= dRet)
            {
                strRet = "비만";
                MessageBox.Show("체중관리를 시작해야 합니다");
            }
            return  strRet ;
        }

        private void RdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            LblLightWeight.Text = femaleLightWeight.ToString();
            LblNormalWeight.Text = femaleNormalWeight.ToString();
            LblOverWeight.Text = femaleOverWeight.ToString();
        }

        private void RdoMale_CheckedChanged(object sender, EventArgs e)
        {
            LblLightWeight.Text = maleLightWeight.ToString();
            LblNormalWeight.Text = maleNormalWeight.ToString();
            LblOverWeight.Text = maleOverWeight.ToString();
        }
    }
}
