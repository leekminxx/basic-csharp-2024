using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace healthCheck
{
    public partial class FrmLogin : MetroForm
    {
        private bool isLogin = false;

        public bool IsLogin
        {  // 로그인 성공여부 저장 변수
            get { return isLogin; }
            set { isLogin = value; }
        }

        public FrmLogin()
        {
            InitializeComponent();

            TxtUserId.Text = string.Empty;
            TxtPassword.Text = string.Empty;
        }

        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0); // 무조건 종료
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool isFail = false;
            string errMsg = string.Empty;

            if (string.IsNullOrEmpty(TxtUserId.Text))
            {
                isFail = true;
                errMsg += "아이디를 입력하세요\n";
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                isFail = true;
                errMsg += " 패스워드를 입력하세요\n";
            }

            if (isFail == true)
            {
                MessageBox.Show(errMsg, " 오류 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IsLogin = LoginProcess(); // 로그인 성공하면  True , 실패하면 False 리턴
            if (IsLogin) this.Close(); // 현재 로그인창 닫기.

        }
        private bool LoginProcess()
        {
            var md5Hash = MD5.Create();

            string userId = TxtUserId.Text;
            string password = TxtPassword.Text;
            string chkUserId = string.Empty;  //DB에서 넘어온 값
            string chkPassword = string.Empty;

            using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
            {
                conn.Open();

                string query = @"SELECT [userId]
                                        ,[password]
                                    FROM [usertbl]
                                  WHERE userId = @userId
                                    AND[password] = @password ";
                SqlCommand cmd = new SqlCommand(query, conn);
                // @userId, @password 파라미터 할당
                SqlParameter prmUserId = new SqlParameter("@userId", userId);
                SqlParameter prmPassword = new SqlParameter("@password", password);
                cmd.Parameters.Add(prmUserId);
                cmd.Parameters.Add(prmPassword);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    chkUserId = reader["userId"] != null ? reader["userId"].ToString() : "-"; // 유저아이디가 null일때 - 변경
                    chkPassword = reader["password"] != null ? reader["password"].ToString() : "-";  // 패스워드가 null 이면 - 로 변경
                    Helper.Common.LoginId = chkUserId;  // 로그인된 아이디

                    return true;
                }
                else
                {
                    MessageBox.Show("로그인 정보가 없습니다.", "DB오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }

        }

        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 키보드를 입력(keyPress) 한 값 (KeyChar) 이 Enter(=13) 이면
            {
                BtnLogin_Click(sender, e); //  BtnLogin_Click 이벤트핸들러 실행 
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 키보드를 입력(keyPress) 한 값 (KeyChar) 이 Enter(=13) 이면
            {
                TxtPassword.Focus();    // 패스워드로 포커스 이동
            }
        }

    }

}





