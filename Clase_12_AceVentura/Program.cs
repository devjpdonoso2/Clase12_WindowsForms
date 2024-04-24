namespace Clase_12_AceVentura
{
    internal static class Program
    {
        /// <summary>
        /// Este es el punto inicial de mi Proyecto
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        }
    }
}