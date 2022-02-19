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
            Core.Install(); //安装类
            Install.Enabled = true; //启用按钮
            Reinstall.Enabled = true;
            Remove.Enabled = true;
            About.Enabled = true;
        }
    }
}
