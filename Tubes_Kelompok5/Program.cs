using tubesAKHIR_Kelompok5;

namespace Tubes_Kelompok5
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

            /*
            FormAddExpend formExpend = new FormAddExpend();
            formExpend.userName = "Shielda";
            formExpend.ShowDialog();
            */
            
            FormAddIncome formAddIncome = new FormAddIncome();
            formAddIncome.userName = "Nadhifa";
            formAddIncome.ShowDialog();

            Regis n = new Regis();
            n.Show();




            

        }
    }
}