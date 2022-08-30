namespace Anduin.MouseJiggler;

public partial class MainForm : Form
{
    private bool _moved = true;

    public MainForm() : this(zenJiggleEnabled: false)
    {
    }

    public MainForm(bool zenJiggleEnabled)
    {
        InitializeComponent();
        cbZen.Checked = zenJiggleEnabled;
    }

    private void jiggleTimer_Tick(object sender, EventArgs e)
    {
        if (cbZen.Checked)
            Helpers.Jiggle(delta: 0);
        else if (_moved)
            Helpers.Jiggle(delta: 4);
        else //zag
            Helpers.Jiggle(delta: -4);

        _moved = !_moved;
    }

    private void cmdTrayify_Click(object sender, EventArgs e)
    {
        Visible = false;
        ShowInTaskbar = false;
        niTray.Visible = true;
        if (jiggleTimer.Enabled)
        {
            var ww = cbZen.Checked ? "with" : "without";
            niTray.Text = $"Jiggling mouse, {ww} Zen.";
        }
        else
        {
            niTray.Text = "Not jiggling the mouse.";
        }
    }

    private void niTray_DoubleClick(object sender, EventArgs e)
    {
        Visible = true;
        ShowInTaskbar = true;
        niTray.Visible = false;
    }
}
