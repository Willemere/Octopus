namespace Octopus
{
    partial class RightClicker
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
            this.label_average = new Guna.UI2.WinForms.Guna2Button();
            this.label_hotkey = new System.Windows.Forms.Label();
            this.checkbox_hotkey = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkbox_shiftdisable = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkbox_blatant = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkbox_onlyingame = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.trackbar_average = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkbox_toggle = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.clicker = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.checkbox_eatbow = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.SuspendLayout();
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
            this.label_average.TabIndex = 47;
            this.label_average.TabStop = false;
            this.label_average.Text = "12";
            this.label_average.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.label_average.TextOffset = new System.Drawing.Point(7, -2);
            // 
            // label_hotkey
            // 
            this.label_hotkey.AutoSize = true;
            this.label_hotkey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_hotkey.ForeColor = System.Drawing.Color.White;
            this.label_hotkey.Location = new System.Drawing.Point(143, 116);
            this.label_hotkey.Name = "label_hotkey";
            this.label_hotkey.Size = new System.Drawing.Size(106, 20);
            this.label_hotkey.TabIndex = 46;
            this.label_hotkey.Text = "Hotkey [None]";
            // 
            // checkbox_hotkey
            // 
            this.checkbox_hotkey.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_hotkey.CheckedState.BorderRadius = 0;
            this.checkbox_hotkey.CheckedState.BorderThickness = 1;
            this.checkbox_hotkey.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_hotkey.CheckedState.Parent = this.checkbox_hotkey;
            this.checkbox_hotkey.Location = new System.Drawing.Point(117, 116);
            this.checkbox_hotkey.Name = "checkbox_hotkey";
            this.checkbox_hotkey.ShadowDecoration.Parent = this.checkbox_hotkey;
            this.checkbox_hotkey.Size = new System.Drawing.Size(20, 20);
            this.checkbox_hotkey.TabIndex = 45;
            this.checkbox_hotkey.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_hotkey.UncheckedState.BorderRadius = 0;
            this.checkbox_hotkey.UncheckedState.BorderThickness = 1;
            this.checkbox_hotkey.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_hotkey.UncheckedState.Parent = this.checkbox_hotkey;
            this.checkbox_hotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkbox_hotkey_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(169, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 44;
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
            this.checkbox_shiftdisable.TabIndex = 43;
            this.checkbox_shiftdisable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_shiftdisable.UncheckedState.BorderRadius = 0;
            this.checkbox_shiftdisable.UncheckedState.BorderThickness = 1;
            this.checkbox_shiftdisable.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_shiftdisable.UncheckedState.Parent = this.checkbox_shiftdisable;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(294, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 34;
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
            this.checkbox_blatant.TabIndex = 33;
            this.checkbox_blatant.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_blatant.UncheckedState.BorderRadius = 0;
            this.checkbox_blatant.UncheckedState.BorderThickness = 1;
            this.checkbox_blatant.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_blatant.UncheckedState.Parent = this.checkbox_blatant;
            this.checkbox_blatant.CheckedChanged += new System.EventHandler(this.checkbox_blatant_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 32;
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
            this.checkbox_onlyingame.TabIndex = 31;
            this.checkbox_onlyingame.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_onlyingame.UncheckedState.BorderRadius = 0;
            this.checkbox_onlyingame.UncheckedState.BorderThickness = 1;
            this.checkbox_onlyingame.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_onlyingame.UncheckedState.Parent = this.checkbox_onlyingame;
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
            this.trackbar_average.TabIndex = 30;
            this.trackbar_average.Text = "guna2ProgressBar1";
            this.trackbar_average.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.trackbar_average.Value = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Average CPS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Toggle";
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
            this.checkbox_toggle.TabIndex = 27;
            this.checkbox_toggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_toggle.UncheckedState.BorderRadius = 0;
            this.checkbox_toggle.UncheckedState.BorderThickness = 1;
            this.checkbox_toggle.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_toggle.UncheckedState.Parent = this.checkbox_toggle;
            this.checkbox_toggle.CheckedChanged += new System.EventHandler(this.checkbox_toggle_CheckedChanged);
            // 
            // clicker
            // 
            this.clicker.Tick += new System.EventHandler(this.clicker_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Eat / Bow";
            // 
            // checkbox_eatbow
            // 
            this.checkbox_eatbow.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_eatbow.CheckedState.BorderRadius = 0;
            this.checkbox_eatbow.CheckedState.BorderThickness = 1;
            this.checkbox_eatbow.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_eatbow.CheckedState.Parent = this.checkbox_eatbow;
            this.checkbox_eatbow.Location = new System.Drawing.Point(12, 116);
            this.checkbox_eatbow.Name = "checkbox_eatbow";
            this.checkbox_eatbow.ShadowDecoration.Parent = this.checkbox_eatbow;
            this.checkbox_eatbow.Size = new System.Drawing.Size(20, 20);
            this.checkbox_eatbow.TabIndex = 52;
            this.checkbox_eatbow.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_eatbow.UncheckedState.BorderRadius = 0;
            this.checkbox_eatbow.UncheckedState.BorderThickness = 1;
            this.checkbox_eatbow.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_eatbow.UncheckedState.Parent = this.checkbox_eatbow;
            // 
            // RightClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkbox_eatbow);
            this.Controls.Add(this.label_average);
            this.Controls.Add(this.label_hotkey);
            this.Controls.Add(this.checkbox_hotkey);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkbox_shiftdisable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkbox_blatant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkbox_onlyingame);
            this.Controls.Add(this.trackbar_average);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkbox_toggle);
            this.Name = "RightClicker";
            this.Size = new System.Drawing.Size(410, 285);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button label_average;
        private System.Windows.Forms.Label label_hotkey;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox checkbox_hotkey;
        private System.Windows.Forms.Label label9;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox checkbox_shiftdisable;
        private System.Windows.Forms.Label label4;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox checkbox_blatant;
        private System.Windows.Forms.Label label3;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox checkbox_onlyingame;
        private Guna.UI2.WinForms.Guna2ProgressBar trackbar_average;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox checkbox_toggle;
        private System.Windows.Forms.Timer clicker;
        private System.Windows.Forms.Label label5;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox checkbox_eatbow;
    }
}
