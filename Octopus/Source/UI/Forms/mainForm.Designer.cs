namespace Octopus
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel_top = new Guna.UI2.WinForms.Guna2GroupBox();
            this.controlbox_minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.controlbox_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dragg = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel_modules = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_settings = new Guna.UI2.WinForms.Guna2Button();
            this.btn_rightClicker = new Guna.UI2.WinForms.Guna2Button();
            this.btn_leftClicker = new Guna.UI2.WinForms.Guna2Button();
            this.panel_module = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.panel_modules.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_top.Controls.Add(this.controlbox_minimize);
            this.panel_top.Controls.Add(this.controlbox_close);
            this.panel_top.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.panel_top.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel_top.Font = new System.Drawing.Font("Segoe UI", 8.4F);
            this.panel_top.ForeColor = System.Drawing.Color.White;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(410, 25);
            this.panel_top.TabIndex = 0;
            this.panel_top.Text = "Octopus";
            this.panel_top.TextOffset = new System.Drawing.Point(0, -8);
            // 
            // controlbox_minimize
            // 
            this.controlbox_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlbox_minimize.Animated = true;
            this.controlbox_minimize.BackColor = System.Drawing.Color.Transparent;
            this.controlbox_minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.controlbox_minimize.FillColor = System.Drawing.Color.Transparent;
            this.controlbox_minimize.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.controlbox_minimize.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.controlbox_minimize.HoverState.IconColor = System.Drawing.Color.RoyalBlue;
            this.controlbox_minimize.IconColor = System.Drawing.Color.White;
            this.controlbox_minimize.Location = new System.Drawing.Point(357, 1);
            this.controlbox_minimize.Name = "controlbox_minimize";
            this.controlbox_minimize.PressedDepth = 0;
            this.controlbox_minimize.Size = new System.Drawing.Size(25, 23);
            this.controlbox_minimize.TabIndex = 2;
            // 
            // controlbox_close
            // 
            this.controlbox_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlbox_close.Animated = true;
            this.controlbox_close.BackColor = System.Drawing.Color.Transparent;
            this.controlbox_close.FillColor = System.Drawing.Color.Transparent;
            this.controlbox_close.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.controlbox_close.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.controlbox_close.HoverState.IconColor = System.Drawing.Color.Crimson;
            this.controlbox_close.IconColor = System.Drawing.Color.White;
            this.controlbox_close.Location = new System.Drawing.Point(384, 1);
            this.controlbox_close.Name = "controlbox_close";
            this.controlbox_close.PressedDepth = 0;
            this.controlbox_close.Size = new System.Drawing.Size(25, 23);
            this.controlbox_close.TabIndex = 1;
            // 
            // dragg
            // 
            this.dragg.DockIndicatorTransparencyValue = 0.6D;
            this.dragg.TargetControl = this.panel_top;
            this.dragg.TransparentWhileDrag = false;
            // 
            // panel_modules
            // 
            this.panel_modules.Controls.Add(this.btn_settings);
            this.panel_modules.Controls.Add(this.btn_rightClicker);
            this.panel_modules.Controls.Add(this.btn_leftClicker);
            this.panel_modules.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.panel_modules.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panel_modules.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_modules.Location = new System.Drawing.Point(0, 25);
            this.panel_modules.Name = "panel_modules";
            this.panel_modules.Size = new System.Drawing.Size(410, 35);
            this.panel_modules.TabIndex = 1;
            // 
            // btn_settings
            // 
            this.btn_settings.Animated = true;
            this.btn_settings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_settings.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_settings.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_settings.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_settings.CheckedState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_settings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_settings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_settings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_settings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_settings.FillColor = System.Drawing.Color.Transparent;
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 8.6F);
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_settings.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_settings.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_settings.Location = new System.Drawing.Point(269, 2);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.PressedDepth = 0;
            this.btn_settings.Size = new System.Drawing.Size(118, 31);
            this.btn_settings.TabIndex = 4;
            this.btn_settings.Text = "Settings";
            this.btn_settings.TextOffset = new System.Drawing.Point(0, -1);
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_rightClicker
            // 
            this.btn_rightClicker.Animated = true;
            this.btn_rightClicker.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_rightClicker.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_rightClicker.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_rightClicker.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_rightClicker.CheckedState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_rightClicker.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_rightClicker.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_rightClicker.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_rightClicker.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_rightClicker.FillColor = System.Drawing.Color.Transparent;
            this.btn_rightClicker.Font = new System.Drawing.Font("Segoe UI", 8.6F);
            this.btn_rightClicker.ForeColor = System.Drawing.Color.White;
            this.btn_rightClicker.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_rightClicker.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_rightClicker.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_rightClicker.Location = new System.Drawing.Point(145, 2);
            this.btn_rightClicker.Name = "btn_rightClicker";
            this.btn_rightClicker.PressedDepth = 0;
            this.btn_rightClicker.Size = new System.Drawing.Size(118, 31);
            this.btn_rightClicker.TabIndex = 3;
            this.btn_rightClicker.Text = "Right Clicker";
            this.btn_rightClicker.TextOffset = new System.Drawing.Point(0, -1);
            this.btn_rightClicker.Click += new System.EventHandler(this.btn_rightClicker_Click);
            // 
            // btn_leftClicker
            // 
            this.btn_leftClicker.Animated = true;
            this.btn_leftClicker.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_leftClicker.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_leftClicker.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_leftClicker.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_leftClicker.CheckedState.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_leftClicker.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_leftClicker.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_leftClicker.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_leftClicker.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_leftClicker.FillColor = System.Drawing.Color.Transparent;
            this.btn_leftClicker.Font = new System.Drawing.Font("Segoe UI", 8.6F);
            this.btn_leftClicker.ForeColor = System.Drawing.Color.White;
            this.btn_leftClicker.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_leftClicker.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_leftClicker.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_leftClicker.Location = new System.Drawing.Point(21, 2);
            this.btn_leftClicker.Name = "btn_leftClicker";
            this.btn_leftClicker.PressedDepth = 0;
            this.btn_leftClicker.Size = new System.Drawing.Size(118, 31);
            this.btn_leftClicker.TabIndex = 2;
            this.btn_leftClicker.Text = "Left Clicker";
            this.btn_leftClicker.TextOffset = new System.Drawing.Point(0, -1);
            this.btn_leftClicker.Click += new System.EventHandler(this.btn_leftClicker_Click);
            // 
            // panel_module
            // 
            this.panel_module.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_module.Location = new System.Drawing.Point(0, 60);
            this.panel_module.Name = "panel_module";
            this.panel_module.Size = new System.Drawing.Size(410, 285);
            this.panel_module.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(410, 345);
            this.ControlBox = false;
            this.Controls.Add(this.panel_module);
            this.Controls.Add(this.panel_modules);
            this.Controls.Add(this.panel_top);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Octopus";
            this.panel_top.ResumeLayout(false);
            this.panel_modules.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox panel_top;
        private Guna.UI2.WinForms.Guna2ControlBox controlbox_minimize;
        private Guna.UI2.WinForms.Guna2ControlBox controlbox_close;
        private Guna.UI2.WinForms.Guna2DragControl dragg;
        private Guna.UI2.WinForms.Guna2Panel panel_modules;
        private Guna.UI2.WinForms.Guna2Button btn_leftClicker;
        private Guna.UI2.WinForms.Guna2Button btn_rightClicker;
        private Guna.UI2.WinForms.Guna2Button btn_settings;
        private System.Windows.Forms.Panel panel_module;
    }
}

