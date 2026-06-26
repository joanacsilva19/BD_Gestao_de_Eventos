using System;
using System.Windows.Forms;

namespace FormsProjeto
{
    internal static class Program
    {
        public static string DbUser = "p7g1";
        public static string DbPassword = "-1683641040@BD";

        public static string ConnectionString = $"Server=192.168.182.10;Database=p7g1;User Id={DbUser};Password={DbPassword};TrustServerCertificate=True;";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1());
        }
    }
}