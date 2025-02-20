using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickPad
{
    public partial class DebugWindow: Form
    {
        public DebugWindow()
        {
            InitializeComponent();
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
