namespace OriDEInstallBepInEx
{
    public class OriDEInstallBepInExMainMain
    {
        [STAThread]
        static void Main()
        {
            Console.WriteLine("安装程序启动!");
            ApplicationConfiguration.Initialize();
            Application.Run(new GuiMain());
        }
    }
}
