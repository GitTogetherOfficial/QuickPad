namespace QuickPad
{
    partial class InfoWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoWindow));
            hideBtn = new Button();
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
            hideBtn.Location = new Point(437, 12);
            hideBtn.Name = "hideBtn";
            hideBtn.Size = new Size(36, 44);
            hideBtn.TabIndex = 4;
            hideBtn.Text = "X";
            hideBtn.UseVisualStyleBackColor = true;
            hideBtn.Click += hideBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(407, 120);
            label1.TabIndex = 5;
            label1.Text = resources.GetString("label1.Text");
            // 
            // InfoWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(485, 153);
            Controls.Add(label1);
            Controls.Add(hideBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfoWindow";
            Text = "InfoWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button hideBtn;
        private Label label1;
    }
}