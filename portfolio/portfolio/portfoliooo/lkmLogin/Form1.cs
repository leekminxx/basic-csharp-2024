using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lkmLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            TxtUserId.Text = string.Empty;
            TxtPassword.Text = string.Empty;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
            //db연계
            
        }
    }
}
