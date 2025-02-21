namespace QuickPad
{
    partial class QuickPadMain
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            title = new Label();
            closeBtn = new Button();
            minimizeBtn = new Button();
            menuBox = new GroupBox();
            deleteBtn = new Button();
            saveBtn = new Button();
            loadBtn = new Button();
            inputText = new RichTextBox();
            settingsBtn = new Button();
            infoBtn = new Button();
            version = new Label();
            appBox = new GroupBox();
            debugBtn = new Button();
            openDialog = new OpenFileDialog();
            saveDialog = new SaveFileDialog();
            menuBox.SuspendLayout();
            appBox.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(193, 50);
            title.TabIndex = 0;
            title.Text = "QuickPad";
            // 
            // closeBtn
            // 
            closeBtn.FlatAppearance.BorderColor = Color.White;
            closeBtn.FlatAppearance.BorderSize = 2;
            closeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            closeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold);
            closeBtn.ForeColor = Color.White;
            closeBtn.Location = new Point(743, 14);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(45, 45);
            closeBtn.TabIndex = 1;
            closeBtn.Text = "X";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // minimizeBtn
            // 
            minimizeBtn.FlatAppearance.BorderColor = Color.White;
            minimizeBtn.FlatAppearance.BorderSize = 2;
            minimizeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            minimizeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold);
            minimizeBtn.ForeColor = Color.White;
            minimizeBtn.Location = new Point(692, 14);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(45, 45);
            minimizeBtn.TabIndex = 1;
            minimizeBtn.Text = "-";
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // menuBox
            // 
            menuBox.Controls.Add(deleteBtn);
            menuBox.Controls.Add(saveBtn);
            menuBox.Controls.Add(loadBtn);
            menuBox.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuBox.ForeColor = Color.White;
            menuBox.Location = new Point(12, 62);
            menuBox.Name = "menuBox";
            menuBox.Size = new Size(193, 206);
            menuBox.TabIndex = 2;
            menuBox.TabStop = false;
            menuBox.Text = "Menu";
            // 
            // deleteBtn
            // 
            deleteBtn.FlatAppearance.BorderColor = Color.White;
            deleteBtn.FlatAppearance.BorderSize = 2;
            deleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            deleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(21, 141);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(143, 37);
            deleteBtn.TabIndex = 1;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.FlatAppearance.BorderColor = Color.White;
            saveBtn.FlatAppearance.BorderSize = 2;
            saveBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            saveBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(21, 98);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(143, 37);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // loadBtn
            // 
            loadBtn.FlatAppearance.BorderColor = Color.White;
            loadBtn.FlatAppearance.BorderSize = 2;
            loadBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            loadBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            loadBtn.FlatStyle = FlatStyle.Flat;
            loadBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadBtn.ForeColor = Color.White;
            loadBtn.Location = new Point(21, 55);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(143, 37);
            loadBtn.TabIndex = 1;
            loadBtn.Text = "Load";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // inputText
            // 
            inputText.BackColor = Color.Black;
            inputText.BorderStyle = BorderStyle.FixedSingle;
            inputText.ForeColor = Color.White;
            inputText.ImeMode = ImeMode.Off;
            inputText.Location = new Point(232, 79);
            inputText.Name = "inputText";
            inputText.Size = new Size(556, 359);
            inputText.TabIndex = 3;
            inputText.Text = "";
            inputText.TextChanged += inputText_TextChanged;
            // 
            // settingsBtn
            // 
            settingsBtn.FlatAppearance.BorderColor = Color.White;
            settingsBtn.FlatAppearance.BorderSize = 2;
            settingsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            settingsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingsBtn.ForeColor = Color.White;
            settingsBtn.Location = new Point(21, 54);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(143, 37);
            settingsBtn.TabIndex = 1;
            settingsBtn.Text = "Settings";
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // infoBtn
            // 
            infoBtn.FlatAppearance.BorderColor = Color.White;
            infoBtn.FlatAppearance.BorderSize = 2;
            infoBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            infoBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            infoBtn.FlatStyle = FlatStyle.Flat;
            infoBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            infoBtn.ForeColor = Color.White;
            infoBtn.Location = new Point(21, 97);
            infoBtn.Name = "infoBtn";
            infoBtn.Size = new Size(143, 37);
            infoBtn.TabIndex = 1;
            infoBtn.Text = "Info";
            infoBtn.UseVisualStyleBackColor = true;
            infoBtn.Click += infoBtn_Click;
            // 
            // version
            // 
            version.AutoSize = true;
            version.BackColor = Color.Transparent;
            version.Font = new Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            version.ForeColor = Color.White;
            version.Location = new Point(194, 31);
            version.Name = "version";
            version.Size = new Size(52, 23);
            version.TabIndex = 0;
            version.Text = "v.beta";
            // 
            // appBox
            // 
            appBox.Controls.Add(infoBtn);
            appBox.Controls.Add(settingsBtn);
            appBox.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appBox.ForeColor = Color.White;
            appBox.Location = new Point(12, 274);
            appBox.Name = "appBox";
            appBox.Size = new Size(193, 164);
            appBox.TabIndex = 2;
            appBox.TabStop = false;
            appBox.Text = "App";
            // 
            // debugBtn
            // 
            debugBtn.FlatAppearance.BorderColor = Color.White;
            debugBtn.FlatAppearance.BorderSize = 2;
            debugBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            debugBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            debugBtn.FlatStyle = FlatStyle.Flat;
            debugBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            debugBtn.ForeColor = Color.White;
            debugBtn.Location = new Point(543, 14);
            debugBtn.Name = "debugBtn";
            debugBtn.Size = new Size(143, 44);
            debugBtn.TabIndex = 1;
            debugBtn.Text = "Debug";
            debugBtn.UseVisualStyleBackColor = true;
            debugBtn.Click += debugBtn_Click;
            // 
            // openDialog
            // 
            openDialog.FileName = "openFileDialog1";
            // 
            // QuickPadMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(debugBtn);
            Controls.Add(inputText);
            Controls.Add(appBox);
            Controls.Add(menuBox);
            Controls.Add(minimizeBtn);
            Controls.Add(closeBtn);
            Controls.Add(version);
            Controls.Add(title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuickPadMain";
            Text = "QuickPad (v.beta)";
            menuBox.ResumeLayout(false);
            appBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Button closeBtn;
        private Button minimizeBtn;
        private GroupBox menuBox;
        private RichTextBox inputText;
        private Button infoBtn;
        private Button deleteBtn;
        private Button settingsBtn;
        private Button saveBtn;
        private Button loadBtn;
        private Label version;
        private GroupBox appBox;
        private Button debugBtn;
        private OpenFileDialog openDialog;
        private SaveFileDialog saveDialog;
    }
}
