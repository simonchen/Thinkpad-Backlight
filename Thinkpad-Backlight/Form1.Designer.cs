namespace Thinkpad_Backlight
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BrightnessLabel = new System.Windows.Forms.Label();
            this.BrightnessComboBox = new System.Windows.Forms.ComboBox();
            this.OnStartupCheckBox = new System.Windows.Forms.CheckBox();
            this.OnKeyPressCheckBox = new System.Windows.Forms.CheckBox();
            this.TimerCheckBox = new System.Windows.Forms.CheckBox();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.SecondsNumeric = new System.Windows.Forms.NumericUpDown();
            this.SecondsDisplayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.AutoSize = true;
            this.BrightnessLabel.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BrightnessLabel.Location = new System.Drawing.Point(110, 9);
            this.BrightnessLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(64, 26);
            this.BrightnessLabel.TabIndex = 1;
            this.BrightnessLabel.Text = "亮度";
            // 
            // BrightnessComboBox
            // 
            this.BrightnessComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrightnessComboBox.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BrightnessComboBox.FormattingEnabled = true;
            this.BrightnessComboBox.Items.AddRange(new object[] {
            "低",
            "高"});
            this.BrightnessComboBox.Location = new System.Drawing.Point(185, 5);
            this.BrightnessComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BrightnessComboBox.Name = "BrightnessComboBox";
            this.BrightnessComboBox.Size = new System.Drawing.Size(218, 33);
            this.BrightnessComboBox.TabIndex = 2;
            // 
            // OnStartupCheckBox
            // 
            this.OnStartupCheckBox.AutoSize = true;
            this.OnStartupCheckBox.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OnStartupCheckBox.Location = new System.Drawing.Point(28, 49);
            this.OnStartupCheckBox.Margin = new System.Windows.Forms.Padding(0, 5, 6, 5);
            this.OnStartupCheckBox.Name = "OnStartupCheckBox";
            this.OnStartupCheckBox.Size = new System.Drawing.Size(350, 30);
            this.OnStartupCheckBox.TabIndex = 4;
            this.OnStartupCheckBox.Text = "当程序开始时打开键盘背光";
            this.OnStartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // OnKeyPressCheckBox
            // 
            this.OnKeyPressCheckBox.AutoSize = true;
            this.OnKeyPressCheckBox.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OnKeyPressCheckBox.Location = new System.Drawing.Point(28, 87);
            this.OnKeyPressCheckBox.Margin = new System.Windows.Forms.Padding(0, 5, 6, 5);
            this.OnKeyPressCheckBox.Name = "OnKeyPressCheckBox";
            this.OnKeyPressCheckBox.Size = new System.Drawing.Size(298, 30);
            this.OnKeyPressCheckBox.TabIndex = 5;
            this.OnKeyPressCheckBox.Text = "任意键按下时打开背光";
            this.OnKeyPressCheckBox.UseVisualStyleBackColor = true;
            // 
            // TimerCheckBox
            // 
            this.TimerCheckBox.AutoSize = true;
            this.TimerCheckBox.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimerCheckBox.Location = new System.Drawing.Point(28, 127);
            this.TimerCheckBox.Margin = new System.Windows.Forms.Padding(0, 5, 6, 5);
            this.TimerCheckBox.Name = "TimerCheckBox";
            this.TimerCheckBox.Size = new System.Drawing.Size(415, 30);
            this.TimerCheckBox.TabIndex = 6;
            this.TimerCheckBox.Text = "当键盘|鼠标不活动时关闭背光：";
            this.TimerCheckBox.UseVisualStyleBackColor = true;
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SecondsLabel.Location = new System.Drawing.Point(66, 176);
            this.SecondsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(116, 26);
            this.SecondsLabel.TabIndex = 7;
            this.SecondsLabel.Text = "延迟秒数";
            // 
            // SecondsNumeric
            // 
            this.SecondsNumeric.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SecondsNumeric.Location = new System.Drawing.Point(185, 171);
            this.SecondsNumeric.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SecondsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SecondsNumeric.Name = "SecondsNumeric";
            this.SecondsNumeric.Size = new System.Drawing.Size(190, 36);
            this.SecondsNumeric.TabIndex = 8;
            this.SecondsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SecondsDisplayLabel
            // 
            this.SecondsDisplayLabel.AutoSize = true;
            this.SecondsDisplayLabel.Location = new System.Drawing.Point(387, 163);
            this.SecondsDisplayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SecondsDisplayLabel.Name = "SecondsDisplayLabel";
            this.SecondsDisplayLabel.Size = new System.Drawing.Size(0, 21);
            this.SecondsDisplayLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 226);
            this.Controls.Add(this.SecondsDisplayLabel);
            this.Controls.Add(this.SecondsNumeric);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.TimerCheckBox);
            this.Controls.Add(this.OnKeyPressCheckBox);
            this.Controls.Add(this.OnStartupCheckBox);
            this.Controls.Add(this.BrightnessComboBox);
            this.Controls.Add(this.BrightnessLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.SecondsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label BrightnessLabel;
        private System.Windows.Forms.ComboBox BrightnessComboBox;
        private System.Windows.Forms.CheckBox OnStartupCheckBox;
        private System.Windows.Forms.CheckBox OnKeyPressCheckBox;
        private System.Windows.Forms.CheckBox TimerCheckBox;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.NumericUpDown SecondsNumeric;
        private System.Windows.Forms.Label SecondsDisplayLabel;
    }
}