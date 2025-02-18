namespace QuickPad
{
    partial class DebugWindow
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
            debugPanelTitle = new Label();
            logList = new ListBox();
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
            hideBtn.Location = new Point(352, 12);
            hideBtn.Name = "hideBtn";
            hideBtn.Size = new Size(36, 44);
            hideBtn.TabIndex = 3;
            hideBtn.Text = "X";
            hideBtn.UseVisualStyleBackColor = true;
            hideBtn.Click += hideBtn_Click;
            // 
            // debugPanelTitle
            // 
            debugPanelTitle.AutoSize = true;
            debugPanelTitle.BackColor = Color.Transparent;
            debugPanelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            debugPanelTitle.ForeColor = Color.White;
            debugPanelTitle.Location = new Point(100, 9);
            debugPanelTitle.Name = "debugPanelTitle";
            debugPanelTitle.Size = new Size(196, 41);
            debugPanelTitle.TabIndex = 4;
            debugPanelTitle.Text = "Debug Panel";
            // 
            // logList
            // 
            logList.BackColor = Color.Black;
            logList.BorderStyle = BorderStyle.FixedSingle;
            logList.ForeColor = Color.White;
            logList.FormattingEnabled = true;
            logList.Location = new Point(12, 84);
            logList.Name = "logList";
            logList.Size = new Size(376, 102);
            logList.TabIndex = 5;
            // 
            // DebugWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(400, 200);
            Controls.Add(logList);
            Controls.Add(debugPanelTitle);
            Controls.Add(hideBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DebugWindow";
            Text = "QuickPad (v.beta) - Debug Panel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button hideBtn;
        private Label debugPanelTitle;
        public ListBox logList;
    }
}