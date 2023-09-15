namespace SoftwareGestion_Myla
{
    using Dominio;
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           User ADMIN = new User();
            ADMIN.Id = 1;
            ADMIN.Usuario = "nicolas";
            ADMIN.Password = "password";
            ADMIN.Admin = true;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmPrincipal(ADMIN));

        }
    }
}