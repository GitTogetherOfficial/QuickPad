namespace QuickPad
{
    partial class SettingsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hideBtn = new Button();
            settingsTitle = new Label();
            font = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)font).BeginInit();
            SuspendLayout();
            // 
            // hideBtn
            // 
            hideBtn.FlatAppearance.BorderColor = Color.White;
            hideBtn.FlatAppearance.BorderSize = 2;
            hideBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            hideBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            hideBtn.FlatStyle = FlatStyle.Flat;
            hideBtn.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold);
            hideBtn.ForeColor = Color.White;
            hideBtn.Location = new Point(552, 12);
            hideBtn.Name = "hideBtn";
            hideBtn.Size = new Size(36, 44);
            hideBtn.TabIndex = 4;
            hideBtn.Text = "X";
            hideBtn.UseVisualStyleBackColor = true;
            hideBtn.Click += hideBtn_Click;
            // 
            // settingsTitle
            // 
            settingsTitle.AutoSize = true;
            settingsTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingsTitle.Location = new Point(248, 15);
            settingsTitle.Name = "settingsTitle";
            settingsTitle.Size = new Size(134, 41);
            settingsTitle.TabIndex = 5;
            settingsTitle.Text = "Settings";
            // 
            // font
            // 
            font.Location = new Point(121, 89);
            font.Name = "font";
            font.Size = new Size(150, 27);
            font.TabIndex = 6;
            font.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 84);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 7;
            label1.Text = "Text Size :";
            // 
            // SettingsWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(600, 300);
            Controls.Add(label1);
            Controls.Add(font);
            Controls.Add(settingsTitle);
            Controls.Add(hideBtn);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsWindow";
            Text = "QuickPad (v.beta) - Settings";
            ((System.ComponentModel.ISupportInitialize)font).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button hideBtn;
        private Label settingsTitle;
        private NumericUpDown font;
        private Label label1;
    }
}