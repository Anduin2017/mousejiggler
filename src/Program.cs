using Anduin.MouseJiggler;

// Prepare Windows Forms to run the application.
Application.SetHighDpiMode(highDpiMode: HighDpiMode.SystemAware);
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(defaultValue: false);

// Run the application.
var mainForm = new MainForm(zenJiggleEnabled: true);
Application.Run(mainForm: mainForm);
