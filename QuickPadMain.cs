using System.Windows.Forms;

namespace QuickPad
{
    public partial class QuickPadMain : Form
    {
        private DebugWindow debugWindow;
        private SettingsWindow settingsWindow;
        private InfoWindow infoWindow;
        private List<string> logEntries = new List<string>();
        public string filePath = "";
        public string fileContent = "";

        public QuickPadMain()
        {
            InitializeComponent();
            debugWindow = new DebugWindow();
            settingsWindow = new SettingsWindow();
            infoWindow = new InfoWindow();
            ;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            logWrite("Window minimized at " + DateTime.Now);
        }

        private void debugBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This area is only for developers and debuging purposes. If you're not a part of the developing team, please click no. Are you sure you want to continue ?", "DEVELOPERS ONLY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (debugWindow == null || debugWindow.IsDisposed)
                {
                    debugWindow = new DebugWindow();
                    foreach (var log in logEntries)
                    {
                        debugWindow.logList.Items.Add(log);
                    }
                }
                debugWindow.Show();
                logWrite("Debug window opened at " + DateTime.Now);
            }
        }

        public void logWrite(string log)
        {
            logEntries.Add(log);
            if (debugWindow != null && !debugWindow.IsDisposed)
            {
                debugWindow.logList.Items.Add(log);
            }
        }

        public void inputText_TextChanged(object sender, EventArgs e)
        {
            string log = "Text changed : " + inputText.Text + " at " + DateTime.Now;
            logWrite(log);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openDialog.FileName;
                string fileContent = System.IO.File.ReadAllText(filePath);
                inputText.Text = fileContent;
                logWrite("File " + openDialog.FileName + "loaded at " + DateTime.Now);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (filePath == "")
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog.Title = "Save Text File";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = saveFileDialog.FileName;
                        File.WriteAllText(filePath, inputText.Text);
                    }
                }
                logWrite("File " + saveDialog.FileName + "created at " + DateTime.Now);
            }
            else
            {
                File.WriteAllText(filePath, inputText.Text);
                logWrite("File " + filePath + "saved at " + DateTime.Now);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                File.Delete(filePath);
                inputText.Clear();
                filePath = "";
                logWrite("File deleted at " + DateTime.Now);
                MessageBox.Show("File deleted successfully.", "Delete File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No file to delete.", "Delete File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            if (settingsWindow == null || settingsWindow.IsDisposed)
            {
                settingsWindow = new SettingsWindow();
            }
            settingsWindow.Show();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            if (infoWindow == null || infoWindow.IsDisposed)
            {
                infoWindow = new InfoWindow();
            }
            infoWindow.Show();
        }
    }
}