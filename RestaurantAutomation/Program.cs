using RestaurantAutomation.UI.Forms;

namespace RestaurantAutomation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static MainForm MainFormInstance { get; private set; }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Show the login form
            using (LoginForm loginForm = new LoginForm())
            {
                Application.Run(loginForm);

                // If login is successful, show the main form
                if (loginForm.LoginSuccessful)
                {
                    MainFormInstance = new MainForm();
                    Application.Run(MainFormInstance);
                }
            }
        }
    }
}