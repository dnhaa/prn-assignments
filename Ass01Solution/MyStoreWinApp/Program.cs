using BusinessObject;
using DataAccess;

namespace MyStoreWinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            frmLogin frmLogin = new frmLogin();
            Application.Run(frmLogin);

            
            if (frmLogin.IsLoggedIn)
            {
                if (frmLogin.IsLoggedInAsAdmin)
                {
                    Application.Run(new frmMemberManagement { IsAdmin = true });
                } else
                {
                    Application.Run(new frmMemberManagement { IsAdmin = false, CurrentMemberID = frmLogin.CurrentMemberID });
                }
            }
            
            /*Application.Run(new frmMemberManagement());
            Application.Run(new frmLogin());*/
            //Application.Run(new frmMemberDetails());
        }
    }
}