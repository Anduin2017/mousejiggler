using Anduin.MouseJiggler;

// Prepare Windows Forms to run the application.
Application.SetHighDpiMode(highDpiMode: HighDpiMode.SystemAware);
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(defaultValue: false);

// Run the application.
var mainForm = new MainForm(jiggleOnStartup: true,
    minimizeOnStartup: false,
    zenJiggleEnabled: true,
    jigglePeriod: 1);

Application.Run(mainForm: mainForm);
