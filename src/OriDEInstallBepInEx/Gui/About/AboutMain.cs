using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OriDEInstallBepInEx.Gui.About
{
    public partial class AboutMain : Form
    {
        public AboutMain()
        {
            InitializeComponent();
        }

        private void BeplnEXText13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/Bepln/Bepln");
        }

        private void OriDEInstallBepInExTest3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/FurryRbl/OriDEInstallBepInEx");
        }
    }
}
