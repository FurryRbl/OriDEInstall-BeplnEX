using System.Diagnostics;

namespace OriDEInstallBepInEx
{
    public partial class GuiMain : Form
    {
        public GuiMain()
        {
            InitializeComponent();
        }

        private void About_Click(object sender, EventArgs e)
        {
            new Gui.About.AboutMain().ShowDialog();
        }

        private void Install_Click(object sender, EventArgs e)
        {
            Install.Enabled = false; //禁用按钮
            Reinstall.Enabled = false;
            Remove.Enabled = false;
            About.Enabled = false;
            Core.Install(); //运行安装方法
            Install.Enabled = true; //启用按钮
            Reinstall.Enabled = true;
            Remove.Enabled = true;
            About.Enabled = true;
        }

        private void GuiMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill(); //这个代码没有什么，只是为了加快程序退出所写的.

        }
    }
}
