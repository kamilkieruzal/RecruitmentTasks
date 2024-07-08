using ExportReport.DAL;

namespace ExportReport
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
            var db = new ExportsDbContext();
            if (!db.ExportHistory.Any())
            {
                db.ExportHistory.AddRange(new FakeDataHelper().GetFakeExports());
                db.SaveChanges();
            }
            Application.Run(new Form1());
        }
    }
}