using Anduin.MouseJiggler;

static class Program
{
    [STAThread]
    static void Main()
    {
        // see https://aka.ms/applicationconfiguration.
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.SetHighDpiMode(HighDpiMode.SystemAware);

        var mainForm = new MainForm(zenJiggleEnabled: true);
        Application.Run(mainForm: mainForm);
    }
}