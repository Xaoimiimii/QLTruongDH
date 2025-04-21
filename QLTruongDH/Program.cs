namespace QLTruongDH
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            bool isLoggedOut;

            do
            {
                isLoggedOut = false;

                using (Login loginForm = new Login())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        string username = loginForm.username;
                        string password = loginForm.password;
                        List<string> roles = loginForm.roles;

                        Form mainForm;
                        if (roles.Contains("DBA"))
                        {
                            mainForm = new Admin_MainForm(username, password);
                        }
                        else
                        {
                            mainForm = new MainForm(username, password, roles);
                        }

                        // Gắn event Logout
                        if (mainForm is ILogoutable logoutableForm)
                        {
                            logoutableForm.LogoutRequested += () => isLoggedOut = true;
                        }

                        Application.Run(mainForm); // Chạy form tương ứng
                    }
                    else
                    {
                        break;
                    }
                }

            } while (isLoggedOut);

        }
    }
}