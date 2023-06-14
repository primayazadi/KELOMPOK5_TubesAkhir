using tubesAKHIR_Kelompok5.Forms;

namespace tubesAKHIR_1302210001
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
            //Application.Run(new Form1());

            
            FormAddExpend formExpend = new FormAddExpend();
            formExpend.userName = "Shielda";
            formExpend.ShowDialog();
            
            

        }
    }
}