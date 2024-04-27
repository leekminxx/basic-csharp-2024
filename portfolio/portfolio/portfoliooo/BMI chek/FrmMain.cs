using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
namespace BMI_chek
{
    public partial class FrmMain : MetroForm
    {
        // 각 화면을 초기화
        FrmLoginsUser frmLoginsUser =null; // 객체를 메서드로 생성
        FrmBmi frmbmi = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLoginsUser = ShowActiveForm(frmLoginsUser , typeof(FrmLoginsUser)) as FrmLoginsUser
        }

        Form ShowActiveForm(Form form, Type type)
        {
            if (form == null)  // 화면이 한번도 안열였으면
            {
                form = Activator.CreateInstance(type) as Form; // 타입은 클래스 타입 
                form.MdiParent = this; // 자식창의 부모는 FrmMain
                form.WindowState = FormWindowState.Normal;
                form.Show();
            }
            else
            {
                if (form.IsDisposed)
                {
                    form = Activator.CreateInstance(type) as Form; // 타입은 클래스 타입 
                    form.MdiParent = this; // 자식창의 부모는 FrmMain
                    form.WindowState = FormWindowState.Normal;
                    form.Show();
                }
                else // 창을 그냥 최소화
                {
                    form.Activate(); //화면에 열려있는 창을 활성화
                }
            }
            return form;
        }
}
