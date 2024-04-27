using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace healthCheck
{
    public partial class FrmMain : Form
    {

        public static readonly string connString = "Data Source=localhost;" +
                                    "Initial Catalog=healthCheck;" +
                                    "Persist Security Info=True;" +
                                    "User ID=sa;Encrypt=False;Password=mssql_p@ss";


        const float maleLightWeight = 18.5f;
        const float maleNormalWeight = 23;
        const float maleOverWeight = 25;
        const float femaleLightWeight = 17.5f;
        const float femaleNormalWeight = 22;
        const float femaleOverWeight = 24;
        
        double dRet = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RefreshData();

            LblLightWeight.Text = maleLightWeight.ToString();
            LblNormalWeight.Text = maleNormalWeight.ToString();
            LblOverWeight.Text = maleOverWeight.ToString();

            FrmLogin frm = new FrmLogin();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.TopMost = true; // 가장 윈도우화면 상단에
            frm.ShowDialog();
        }


        /// <summary>
        ///  BMI 계산
        /// </summary>
        /// <param name="dCM"></param>
        /// <param name="dKG"></param>
        private double fBMICal(double dCM, double dKG)
        {
            dRet = dKG / (dCM * dCM);

            return Math.Round(dRet, 1);  //소숫점 한자리까지만
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            var gender = "";
            if (RdoMale.Checked == true)
            {
                gender = "남자";
            }
            else if (RdoFemale.Checked == true)
            {
                gender = "여자";
            }
            
            try
            {

             // 1. 값을 받아온다
            double dCM = double.Parse(tboxCM.Text)  / 100;
            double dKG = double.Parse(tboxKG.Text); 

            // 2. 값을 계산 한다
            double dRet = fBMICal((double)dCM, dKG);

            // 3. trackbar 를 이동시킨다.
            int iRet =(int) (dRet * 10);

            // 4. label 에 결과 값을 표시한다.
            if (iRet < 150)
            {
                iRet = 150;
            }
            else if (280 < iRet)
            {
                iRet = 280;
            }

            tbarRet.Value = iRet;

            string strRet = fCalResult(dRet);
            lblRet.Text = $"BMI 지수[{dRet}]로 비만도 결과[{strRet}]입니다.";
            //string userName = GetUserNameFromDatabase();
            string userName = txtName.Text;

                //string userName = GetUserNameFromDatabase();
                //string strRet = "";
                //lblRet.Text = $"BMI 지수[{dRet}]로 비만도 결과[{strRet}]입니다.";

                // string resultText = $"성별: {gender}, BMI 지수: {dRet}, 비만도 결과: {strRet}";
                //lstResults.Items.Add(resultText);

                string resultText = $"{userName} - 성별: {gender}, BMI 지수: {dRet}, 비만도 결과: {strRet}";
                lstResults.Items.Add(resultText);

            }
            catch (Exception ex)
            {
                lblRet.Text = ex.ToString();
            }
        }

        private string fCalResult(double dRet)
        {
            string strRet = string.Empty;
            if (dRet < 18.5)
            {
                strRet = "저체중";
                MessageBox.Show("조금 더 챙겨먹기 바랍니다");
            }
            else if (18.5 <= dRet && dRet < 23)
            {
                strRet = "정상체중";
                MessageBox.Show("정상 체중입니다");
            }
            else if (23 <= dRet && dRet < 25)
            {
                strRet = "과체중 입니다";
                MessageBox.Show("조금만 더 노력하세요");
            }
            else if (25 <= dRet)
            {
                strRet = "비만";
                MessageBox.Show("체중관리를 시작해야 합니다");
            }
            return strRet; 
        }

        private string GetUserNameFromDatabase()
        {
            string userName = ""; // 사용자 이름을 저장할 변수
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                // 여기에서 데이터베이스 쿼리를 사용하여 사용자 이름을 가져오는 코드를 작성
                // 이 예제에서는 단순히 "이경민"을 반환하도록 하겠습니다.
                // 실제로는 데이터베이스에서 사용자의 이름을 가져와야 합니다.
                string query = "SELECT [MemberNames] FROM [Membertbl]";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    userName = reader["MemberNames"].ToString();
                }
            }
            return userName;
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

        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var query = @"SELECT [MemberIdx]
                                    ,[MemberGender]
                                    ,[MemberNames]
                                    ,[MemberKg]
                                    ,[MemberCm]
                                FROM [Membertbl]"; // 화면에 필요한 테이블 쿼리 변경
                                                   // 화면에 필요한 테이블 쿼리 변경

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Membertbl");

                DgvUsers.DataSource = ds.Tables[0];
                DgvUsers.ReadOnly = true; // 수정불가
                DgvUsers.Columns[0].HeaderText = "ID";
                DgvUsers.Columns[1].HeaderText = "성별";
                DgvUsers.Columns[2].HeaderText = "고객명";
                DgvUsers.Columns[3].HeaderText = "몸무게";
                DgvUsers.Columns[4].HeaderText = "키";

                DgvUsers.Columns[0].Width = 20;
                DgvUsers.Columns[1].Width = 30;
                DgvUsers.Columns[2].Width = 74;
                DgvUsers.Columns[3].Width = 74;
                DgvUsers.Columns[4].Width = 74;
            }
        }

        private void DgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // 유효한 행을 클릭한 경우
            {
                DataGridViewRow row = DgvUsers.Rows[e.RowIndex];

                // 각 텍스트 상자에 해당하는 열의 데이터 설정
                txtGender.Text = row.Cells["MemberGender"].Value.ToString();
                txtName.Text = row.Cells["MemberNames"].Value.ToString();
                tboxCM.Text = row.Cells["MemberCm"].Value.ToString();
                tboxKG.Text = row.Cells["MemberKg"].Value.ToString();

                if (txtGender.Text == "남자")
                {
                    RdoMale.Checked = true;
                }
                else
                {
                    RdoFemale.Checked = true;
                }
            }
        }
    }
}
