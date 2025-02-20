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
            label1 = new Label();
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
            hideBtn.Location = new Point(252, 12);
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
            settingsTitle.Location = new Point(83, 9);
            settingsTitle.Name = "settingsTitle";
            settingsTitle.Size = new Size(134, 41);
            settingsTitle.TabIndex = 5;
            settingsTitle.Text = "Settings";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 78);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 6;
            label1.Text = "Not available on beta!";
            // 
            // SettingsWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(300, 150);
            Controls.Add(label1);
            Controls.Add(settingsTitle);
            Controls.Add(hideBtn);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsWindow";
            Text = "QuickPad (v.beta) - Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button hideBtn;
        private Label settingsTitle;
        private Label label1;
    }
}