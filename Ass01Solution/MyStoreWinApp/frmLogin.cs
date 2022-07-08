using BusinessObject;
using DataAccess;
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        public bool IsLoggedIn { get; set; }
        public bool IsLoggedInAsAdmin { get; set; }
        public int CurrentMemberID { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int checkLogin = memberRepository.CheckLogin(txtEmail.Text, txtPassword.Text);
                this.Close();
                IsLoggedIn = true;
                frmMemberManagement frmMemberManagement = new frmMemberManagement();
                frmMemberManagement.Show();
                if (checkLogin == 0)
                {
                    IsLoggedInAsAdmin = true;
                } else
                {
                    CurrentMemberID = checkLogin;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Error");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}