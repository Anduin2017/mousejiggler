
namespace Anduin.MouseJiggler;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.components != null))
        {
            this.components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.jiggleTimer = new System.Windows.Forms.Timer(this.components);
            this.flpLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBase = new System.Windows.Forms.Panel();
            this.cmdTrayify = new System.Windows.Forms.Button();
            this.cbSettings = new System.Windows.Forms.CheckBox();
            this.cbJiggling = new System.Windows.Forms.CheckBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.lbPeriod = new System.Windows.Forms.Label();
            this.tbPeriod = new System.Windows.Forms.TrackBar();
            this.cbMinimize = new System.Windows.Forms.CheckBox();
            this.cbZen = new System.Windows.Forms.CheckBox();
            this.niTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.flpLayout.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // jiggleTimer
            // 
            this.jiggleTimer.Interval = 1000;
            this.jiggleTimer.Tick += new System.EventHandler(this.jiggleTimer_Tick);
            // 
            // flpLayout
            // 
            this.flpLayout.AutoSize = true;
            this.flpLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpLayout.Controls.Add(this.panelBase);
            this.flpLayout.Controls.Add(this.panelSettings);
            this.flpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLayout.Location = new System.Drawing.Point(0, 0);
            this.flpLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpLayout.Name = "flpLayout";
            this.flpLayout.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.flpLayout.Size = new System.Drawing.Size(347, 213);
            this.flpLayout.TabIndex = 2;
            // 
            // panelBase
            // 
            this.panelBase.Controls.Add(this.cmdTrayify);
            this.panelBase.Controls.Add(this.cbSettings);
            this.panelBase.Controls.Add(this.cbJiggling);
            this.panelBase.Location = new System.Drawing.Point(9, 11);
            this.panelBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(330, 37);
            this.panelBase.TabIndex = 3;
            // 
            // cmdTrayify
            // 
            this.cmdTrayify.Location = new System.Drawing.Point(279, 3);
            this.cmdTrayify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdTrayify.Name = "cmdTrayify";
            this.cmdTrayify.Size = new System.Drawing.Size(46, 31);
            this.cmdTrayify.TabIndex = 3;
            this.cmdTrayify.Text = "🔽";
            this.cmdTrayify.UseVisualStyleBackColor = true;
            this.cmdTrayify.Click += new System.EventHandler(this.cmdTrayify_Click);
            // 
            // cbSettings
            // 
            this.cbSettings.Location = new System.Drawing.Point(101, 7);
            this.cbSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSettings.Name = "cbSettings";
            this.cbSettings.Size = new System.Drawing.Size(88, 25);
            this.cbSettings.TabIndex = 1;
            this.cbSettings.Text = "Settings...";
            this.cbSettings.UseVisualStyleBackColor = true;
            this.cbSettings.CheckedChanged += new System.EventHandler(this.cbSettings_CheckedChanged);
            // 
            // cbJiggling
            // 
            this.cbJiggling.AutoSize = true;
            this.cbJiggling.Location = new System.Drawing.Point(11, 7);
            this.cbJiggling.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbJiggling.Name = "cbJiggling";
            this.cbJiggling.Size = new System.Drawing.Size(90, 24);
            this.cbJiggling.TabIndex = 0;
            this.cbJiggling.Text = "Jiggling?";
            this.cbJiggling.UseVisualStyleBackColor = true;
            this.cbJiggling.CheckedChanged += new System.EventHandler(this.cbJiggling_CheckedChanged);
            // 
            // panelSettings
            // 
            this.panelSettings.AutoSize = true;
            this.panelSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSettings.Controls.Add(this.lbPeriod);
            this.panelSettings.Controls.Add(this.tbPeriod);
            this.panelSettings.Controls.Add(this.cbMinimize);
            this.panelSettings.Controls.Add(this.cbZen);
            this.panelSettings.Location = new System.Drawing.Point(9, 56);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(330, 143);
            this.panelSettings.TabIndex = 2;
            this.panelSettings.Visible = false;
            // 
            // lbPeriod
            // 
            this.lbPeriod.AutoSize = true;
            this.lbPeriod.Location = new System.Drawing.Point(279, 55);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(27, 20);
            this.lbPeriod.TabIndex = 3;
            this.lbPeriod.Text = "1 s";
            // 
            // tbPeriod
            // 
            this.tbPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPeriod.Location = new System.Drawing.Point(5, 83);
            this.tbPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPeriod.Maximum = 60;
            this.tbPeriod.Minimum = 1;
            this.tbPeriod.Name = "tbPeriod";
            this.tbPeriod.Size = new System.Drawing.Size(321, 56);
            this.tbPeriod.TabIndex = 6;
            this.tbPeriod.TickFrequency = 2;
            this.tbPeriod.Value = 1;
            this.tbPeriod.ValueChanged += new System.EventHandler(this.tbPeriod_ValueChanged);
            // 
            // cbMinimize
            // 
            this.cbMinimize.AutoSize = true;
            this.cbMinimize.Location = new System.Drawing.Point(11, 49);
            this.cbMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMinimize.Name = "cbMinimize";
            this.cbMinimize.Size = new System.Drawing.Size(153, 24);
            this.cbMinimize.TabIndex = 5;
            this.cbMinimize.Text = "Minimize on start?";
            this.cbMinimize.UseVisualStyleBackColor = true;
            this.cbMinimize.CheckedChanged += new System.EventHandler(this.cbMinimize_CheckedChanged);
            // 
            // cbZen
            // 
            this.cbZen.AutoSize = true;
            this.cbZen.Location = new System.Drawing.Point(11, 15);
            this.cbZen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbZen.Name = "cbZen";
            this.cbZen.Size = new System.Drawing.Size(105, 24);
            this.cbZen.TabIndex = 4;
            this.cbZen.Text = "Zen jiggle?";
            this.cbZen.UseVisualStyleBackColor = true;
            this.cbZen.CheckedChanged += new System.EventHandler(this.cbZen_CheckedChanged);
            // 
            // niTray
            // 
            this.niTray.Icon = ((System.Drawing.Icon)(resources.GetObject("niTray.Icon")));
            this.niTray.Text = "Mouse Jiggler";
            this.niTray.DoubleClick += new System.EventHandler(this.niTray_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(347, 213);
            this.Controls.Add(this.flpLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mouse Jiggler";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.flpLayout.ResumeLayout(false);
            this.flpLayout.PerformLayout();
            this.panelBase.ResumeLayout(false);
            this.panelBase.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer jiggleTimer;
    private System.Windows.Forms.FlowLayoutPanel flpLayout;
    private System.Windows.Forms.Panel panelSettings;
    private System.Windows.Forms.TrackBar tbPeriod;
    private System.Windows.Forms.CheckBox cbMinimize;
    private System.Windows.Forms.CheckBox cbZen;
    private System.Windows.Forms.Panel panelBase;
    private System.Windows.Forms.CheckBox cbSettings;
    private System.Windows.Forms.CheckBox cbJiggling;
    private System.Windows.Forms.Label lbPeriod;
    private System.Windows.Forms.NotifyIcon niTray;
    private System.Windows.Forms.Button cmdTrayify;
}

