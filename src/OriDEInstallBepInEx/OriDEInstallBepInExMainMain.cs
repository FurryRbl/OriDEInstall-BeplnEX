namespace OriDEInstallBepInEx
{
    public class OriDEInstallBepInExMainMain
    {
        static void Main()
        {
            if (Core.Bit() != "32")
            {
                if (Core.Bit() != "64")
                {
                    Console.WriteLine("不兼容的CPU架构");
                    MessageBox.Show("很抱歉的告诉您,您的CPU架构无法兼容BeplnEX，因此没有运行此程序的必要，此程序将退出", "兼容性问题");
                }
            }
            else { }
            Console.WriteLine("临时目录:" + Core.TmepFile);
            Console.WriteLine("安装程序启动!");
            Thread ThreadMain = new Thread(() =>
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new GuiMain());
            });
            ThreadMain.SetApartmentState(ApartmentState.STA);
            ThreadMain.Start();
        }
    }
}
