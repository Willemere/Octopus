namespace Octopus
{
    partial class LeftClicker
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkbox_toggle = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackbar_average = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.checkbox_onlyingame = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkbox_blatant = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkbox_blockhit = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trackbar_blockhit = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.checkbox_jitter = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.trackbar_jitter = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkbox_shiftdisable = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.label_hotkey = new System.Windows.Forms.Label();
            this.checkbox_hotkey = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.label_average = new Guna.UI2.WinForms.Guna2Button();
            this.label_blockhit = new Guna.UI2.WinForms.Guna2Button();
            this.label_jitter = new Guna.UI2.WinForms.Guna2Button();
            this.clicker = new System.Windows.Forms.Timer(this.components);
            this.blockhit = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.checkbox_rmblock = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.jitter = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // checkbox_toggle
            // 
            this.checkbox_toggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_toggle.CheckedState.BorderRadius = 0;
            this.checkbox_toggle.CheckedState.BorderThickness = 1;
            this.checkbox_toggle.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_toggle.CheckedState.Parent = this.checkbox_toggle;
            this.checkbox_toggle.Location = new System.Drawing.Point(12, 12);
            this.checkbox_toggle.Name = "checkbox_toggle";
            this.checkbox_toggle.ShadowDecoration.Parent = this.checkbox_toggle;
            this.checkbox_toggle.Size = new System.Drawing.Size(20, 20);
            this.checkbox_toggle.TabIndex = 0;
            this.checkbox_toggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_toggle.UncheckedState.BorderRadius = 0;
            this.checkbox_toggle.UncheckedState.BorderThickness = 1;
            this.checkbox_toggle.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_toggle.UncheckedState.Parent = this.checkbox_toggle;
            this.checkbox_toggle.CheckedChanged += new System.EventHandler(this.checkbox_toggle_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toggle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Average CPS:";
            // 
            // trackbar_average
            // 
            this.trackbar_average.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.trackbar_average.BorderThickness = 1;
            this.trackbar_average.FillColor = System.Drawing.Color.Transparent;
            this.trackbar_average.Location = new System.Drawing.Point(12, 64);
            this.trackbar_average.Maximum = 200;
            this.trackbar_average.Name = "trackbar_average";
            this.trackbar_average.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.trackbar_average.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(52)))));
            this.trackbar_average.Size = new System.Drawing.Size(385, 20);
            this.trackbar_average.TabIndex = 4;
            this.trackbar_average.Text = "guna2ProgressBar1";
            this.trackbar_average.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.trackbar_average.Value = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Only in-game";
            // 
            // checkbox_onlyingame
            // 
            this.checkbox_onlyingame.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_onlyingame.CheckedState.BorderRadius = 0;
            this.checkbox_onlyingame.CheckedState.BorderThickness = 1;
            this.checkbox_onlyingame.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_onlyingame.CheckedState.Parent = this.checkbox_onlyingame;
            this.checkbox_onlyingame.Location = new System.Drawing.Point(12, 90);
            this.checkbox_onlyingame.Name = "checkbox_onlyingame";
            this.checkbox_onlyingame.ShadowDecoration.Parent = this.checkbox_onlyingame;
            this.checkbox_onlyingame.Size = new System.Drawing.Size(20, 20);
            this.checkbox_onlyingame.TabIndex = 5;
            this.checkbox_onlyingame.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_onlyingame.UncheckedState.BorderRadius = 0;
            this.checkbox_onlyingame.UncheckedState.BorderThickness = 1;
            this.checkbox_onlyingame.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_onlyingame.UncheckedState.Parent = this.checkbox_onlyingame;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(294, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Blatant";
            // 
            // checkbox_blatant
            // 
            this.checkbox_blatant.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_blatant.CheckedState.BorderRadius = 0;
            this.checkbox_blatant.CheckedState.BorderThickness = 1;
            this.checkbox_blatant.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_blatant.CheckedState.Parent = this.checkbox_blatant;
            this.checkbox_blatant.Location = new System.Drawing.Point(268, 90);
            this.checkbox_blatant.Name = "checkbox_blatant";
            this.checkbox_blatant.ShadowDecoration.Parent = this.checkbox_blatant;
            this.checkbox_blatant.Size = new System.Drawing.Size(20, 20);
            this.checkbox_blatant.TabIndex = 7;
            this.checkbox_blatant.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_blatant.UncheckedState.BorderRadius = 0;
            this.checkbox_blatant.UncheckedState.BorderThickness = 1;
            this.checkbox_blatant.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_blatant.UncheckedState.Parent = this.checkbox_blatant;
            this.checkbox_blatant.CheckedChanged += new System.EventHandler(this.checkbox_blatant_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Blockhit";
            // 
            // checkbox_blockhit
            // 
            this.checkbox_blockhit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_blockhit.CheckedState.BorderRadius = 0;
            this.checkbox_blockhit.CheckedState.BorderThickness = 1;
            this.checkbox_blockhit.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_blockhit.CheckedState.Parent = this.checkbox_blockhit;
            this.checkbox_blockhit.Location = new System.Drawing.Point(12, 116);
            this.checkbox_blockhit.Name = "checkbox_blockhit";
            this.checkbox_blockhit.ShadowDecoration.Parent = this.checkbox_blockhit;
            this.checkbox_blockhit.Size = new System.Drawing.Size(20, 20);
            this.checkbox_blockhit.TabIndex = 9;
            this.checkbox_blockhit.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_blockhit.UncheckedState.BorderRadius = 0;
            this.checkbox_blockhit.UncheckedState.BorderThickness = 1;
            this.checkbox_blockhit.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_blockhit.UncheckedState.Parent = this.checkbox_blockhit;
            this.checkbox_blockhit.CheckedChanged += new System.EventHandler(this.checkbox_blockhit_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Blockhit CPS:";
            // 
            // trackbar_blockhit
            // 
            this.trackbar_blockhit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.trackbar_blockhit.BorderThickness = 1;
            this.trackbar_blockhit.FillColor = System.Drawing.Color.Transparent;
            this.trackbar_blockhit.Location = new System.Drawing.Point(12, 168);
            this.trackbar_blockhit.Maximum = 200;
            this.trackbar_blockhit.Name = "trackbar_blockhit";
            this.trackbar_blockhit.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.trackbar_blockhit.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(52)))));
            this.trackbar_blockhit.Size = new System.Drawing.Size(385, 20);
            this.trackbar_blockhit.TabIndex = 13;
            this.trackbar_blockhit.Text = "guna2ProgressBar2";
            this.trackbar_blockhit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.trackbar_blockhit.Value = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Jitter";
            // 
            // checkbox_jitter
            // 
            this.checkbox_jitter.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_jitter.CheckedState.BorderRadius = 0;
            this.checkbox_jitter.CheckedState.BorderThickness = 1;
            this.checkbox_jitter.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_jitter.CheckedState.Parent = this.checkbox_jitter;
            this.checkbox_jitter.Location = new System.Drawing.Point(12, 194);
            this.checkbox_jitter.Name = "checkbox_jitter";
            this.checkbox_jitter.ShadowDecoration.Parent = this.checkbox_jitter;
            this.checkbox_jitter.Size = new System.Drawing.Size(20, 20);
            this.checkbox_jitter.TabIndex = 14;
            this.checkbox_jitter.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_jitter.UncheckedState.BorderRadius = 0;
            this.checkbox_jitter.UncheckedState.BorderThickness = 1;
            this.checkbox_jitter.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_jitter.UncheckedState.Parent = this.checkbox_jitter;
            this.checkbox_jitter.CheckedChanged += new System.EventHandler(this.checkbox_jitter_CheckedChanged);
            // 
            // trackbar_jitter
            // 
            this.trackbar_jitter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.trackbar_jitter.BorderThickness = 1;
            this.trackbar_jitter.FillColor = System.Drawing.Color.Transparent;
            this.trackbar_jitter.Location = new System.Drawing.Point(12, 246);
            this.trackbar_jitter.Maximum = 50;
            this.trackbar_jitter.Name = "trackbar_jitter";
            this.trackbar_jitter.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.trackbar_jitter.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(52)))));
            this.trackbar_jitter.Size = new System.Drawing.Size(385, 20);
            this.trackbar_jitter.TabIndex = 17;
            this.trackbar_jitter.Text = "guna2ProgressBar3";
            this.trackbar_jitter.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.trackbar_jitter.Value = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Jitter Range:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(169, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Shift Disable";
            // 
            // checkbox_shiftdisable
            // 
            this.checkbox_shiftdisable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_shiftdisable.CheckedState.BorderRadius = 0;
            this.checkbox_shiftdisable.CheckedState.BorderThickness = 1;
            this.checkbox_shiftdisable.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_shiftdisable.CheckedState.Parent = this.checkbox_shiftdisable;
            this.checkbox_shiftdisable.Location = new System.Drawing.Point(143, 90);
            this.checkbox_shiftdisable.Name = "checkbox_shiftdisable";
            this.checkbox_shiftdisable.ShadowDecoration.Parent = this.checkbox_shiftdisable;
            this.checkbox_shiftdisable.Size = new System.Drawing.Size(20, 20);
            this.checkbox_shiftdisable.TabIndex = 18;
            this.checkbox_shiftdisable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_shiftdisable.UncheckedState.BorderRadius = 0;
            this.checkbox_shiftdisable.UncheckedState.BorderThickness = 1;
            this.checkbox_shiftdisable.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_shiftdisable.UncheckedState.Parent = this.checkbox_shiftdisable;
            // 
            // label_hotkey
            // 
            this.label_hotkey.AutoSize = true;
            this.label_hotkey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_hotkey.ForeColor = System.Drawing.Color.White;
            this.label_hotkey.Location = new System.Drawing.Point(238, 116);
            this.label_hotkey.Name = "label_hotkey";
            this.label_hotkey.Size = new System.Drawing.Size(106, 20);
            this.label_hotkey.TabIndex = 21;
            this.label_hotkey.Text = "Hotkey [None]";
            // 
            // checkbox_hotkey
            // 
            this.checkbox_hotkey.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_hotkey.CheckedState.BorderRadius = 0;
            this.checkbox_hotkey.CheckedState.BorderThickness = 1;
            this.checkbox_hotkey.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_hotkey.CheckedState.Parent = this.checkbox_hotkey;
            this.checkbox_hotkey.Location = new System.Drawing.Point(212, 116);
            this.checkbox_hotkey.Name = "checkbox_hotkey";
            this.checkbox_hotkey.ShadowDecoration.Parent = this.checkbox_hotkey;
            this.checkbox_hotkey.Size = new System.Drawing.Size(20, 20);
            this.checkbox_hotkey.TabIndex = 20;
            this.checkbox_hotkey.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_hotkey.UncheckedState.BorderRadius = 0;
            this.checkbox_hotkey.UncheckedState.BorderThickness = 1;
            this.checkbox_hotkey.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_hotkey.UncheckedState.Parent = this.checkbox_hotkey;
            this.checkbox_hotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkbox_hotkey_KeyDown);
            // 
            // label_average
            // 
            this.label_average.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.label_average.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.label_average.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.label_average.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.label_average.FillColor = System.Drawing.Color.Transparent;
            this.label_average.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_average.ForeColor = System.Drawing.Color.White;
            this.label_average.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.label_average.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.label_average.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.label_average.Location = new System.Drawing.Point(284, 38);
            this.label_average.Name = "label_average";
            this.label_average.PressedDepth = 0;
            this.label_average.Size = new System.Drawing.Size(113, 20);
            this.label_average.TabIndex = 22;
            this.label_average.TabStop = false;
            this.label_average.Text = "12";
            this.label_average.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.label_average.TextOffset = new System.Drawing.Point(7, -2);
            // 
            // label_blockhit
            // 
            this.label_blockhit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.label_blockhit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.label_blockhit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.label_blockhit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.label_blockhit.FillColor = System.Drawing.Color.Transparent;
            this.label_blockhit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_blockhit.ForeColor = System.Drawing.Color.White;
            this.label_blockhit.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.label_blockhit.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.label_blockhit.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.label_blockhit.Location = new System.Drawing.Point(284, 142);
            this.label_blockhit.Name = "label_blockhit";
            this.label_blockhit.PressedDepth = 0;
            this.label_blockhit.Size = new System.Drawing.Size(113, 20);
            this.label_blockhit.TabIndex = 23;
            this.label_blockhit.TabStop = false;
            this.label_blockhit.Text = "1";
            this.label_blockhit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.label_blockhit.TextOffset = new System.Drawing.Point(7, -2);
            // 
            // label_jitter
            // 
            this.label_jitter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.label_jitter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.label_jitter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.label_jitter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.label_jitter.FillColor = System.Drawing.Color.Transparent;
            this.label_jitter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_jitter.ForeColor = System.Drawing.Color.White;
            this.label_jitter.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.label_jitter.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.label_jitter.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.label_jitter.Location = new System.Drawing.Point(284, 220);
            this.label_jitter.Name = "label_jitter";
            this.label_jitter.PressedDepth = 0;
            this.label_jitter.Size = new System.Drawing.Size(113, 20);
            this.label_jitter.TabIndex = 24;
            this.label_jitter.TabStop = false;
            this.label_jitter.Text = "1";
            this.label_jitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.label_jitter.TextOffset = new System.Drawing.Point(7, -2);
            // 
            // clicker
            // 
            this.clicker.Tick += new System.EventHandler(this.clicker_Tick);
            // 
            // blockhit
            // 
            this.blockhit.Tick += new System.EventHandler(this.blockhit_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(132, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "RMB Lock";
            // 
            // checkbox_rmblock
            // 
            this.checkbox_rmblock.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_rmblock.CheckedState.BorderRadius = 0;
            this.checkbox_rmblock.CheckedState.BorderThickness = 1;
            this.checkbox_rmblock.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_rmblock.CheckedState.Parent = this.checkbox_rmblock;
            this.checkbox_rmblock.Location = new System.Drawing.Point(106, 116);
            this.checkbox_rmblock.Name = "checkbox_rmblock";
            this.checkbox_rmblock.ShadowDecoration.Parent = this.checkbox_rmblock;
            this.checkbox_rmblock.Size = new System.Drawing.Size(20, 20);
            this.checkbox_rmblock.TabIndex = 25;
            this.checkbox_rmblock.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_rmblock.UncheckedState.BorderRadius = 0;
            this.checkbox_rmblock.UncheckedState.BorderThickness = 1;
            this.checkbox_rmblock.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_rmblock.UncheckedState.Parent = this.checkbox_rmblock;
            // 
            // jitter
            // 
            this.jitter.Interval = 10;
            this.jitter.Tick += new System.EventHandler(this.jitter_Tick);
            // 
            // LeftClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkbox_rmblock);
            this.Controls.Add(this.label_jitter);
            this.Controls.Add(this.label_blockhit);
            this.Controls.Add(this.label_average);
            this.Controls.Add(this.label_hotkey);
            this.Controls.Add(this.checkbox_hotkey);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkbox_shiftdisable);
            this.Controls.Add(this.trackbar_jitter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkbox_jitter);
            this.Controls.Add(this.trackbar_blockhit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkbox_blockhit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkbox_blatant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkbox_onlyingame);
            this.Controls.Add(this.trackbar_average);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkbox_toggle);
            this.Name = "LeftClicker";
            this.Size = new System.Drawing.Size(410, 285);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneCustomCheckBox checkbox_toggle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ProgressBar trackbar_average;
        private System.Windows.Forms.Label label3;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox checkbox_onlyingame;
        private System.Windows.Forms.Label label4;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox checkbox_blatant;
        private System.Windows.Forms.Label label5;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox checkbox_blockhit;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ProgressBar trackbar_blockhit;
        private System.Windows.Forms.Label label7;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox checkbox_jitter;
        private Guna.UI2.WinForms.Guna2ProgressBar trackbar_jitter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox checkbox_shiftdisable;
        private System.Windows.Forms.Label label_hotkey;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox checkbox_hotkey;
        private Guna.UI2.WinForms.Guna2Button label_average;
        private Guna.UI2.WinForms.Guna2Button label_blockhit;
        private Guna.UI2.WinForms.Guna2Button label_jitter;
        private System.Windows.Forms.Timer clicker;
        private System.Windows.Forms.Timer blockhit;
        private System.Windows.Forms.Label label11;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox checkbox_rmblock;
        private System.Windows.Forms.Timer jitter;
    }
}
