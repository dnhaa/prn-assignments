using System;
using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int resultLogin = memberRepository.CheckLogin(txtEmail.Text, txtPassword.Text);
                if (resultLogin == 0)
                {
                    frmMain frmMain = new frmMain
                    {
                        MemberInfo = null
                    };
                    txtEmail.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    frmMain.ShowDialog();
                } else
                {
                    frmMain frmMain = new frmMain
                    {
                        MemberInfo = memberRepository.GetMemberByEmail(txtEmail.Text)
                    };
                    txtEmail.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    frmMain.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
