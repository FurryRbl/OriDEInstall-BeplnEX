using System.IO.Compression;
using System.Reflection;

namespace OriDEInstallBepInEx
{
    public static class Core
    {
        public static FolderBrowserDialog GameDir = new FolderBrowserDialog();
        public static String TmepFile = System.IO.Path.GetTempPath() + "OriDEInstallBepInEx-" + System.Guid.NewGuid() + @"\";
        public static String Bit() //获取操作系统位数(也有可能是获取进程的)
        {
            if (IntPtr.Size == 4)
            {
                return "32";
            }
            else if (IntPtr.Size == 8)
            {
                return "64";
            }
            else
            {
                return "err";
            }
        }

        public static void FreedFile(String resource, String path) //提取文件,代码:https://juejin.cn/post/6989143365862293534
        {
            Thread ThreadFreedFileMain = new Thread(() =>
            {
                BufferedStream input = new BufferedStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(resource));
                FileStream output = new FileStream(path, FileMode.Create);
                byte[] data = new byte[1024];
                int lengthEachRead;
                while ((lengthEachRead = input.Read(data, 0, data.Length)) > 0)
                {
                    output.Write(data, 0, lengthEachRead);
                }
                output.Flush();
                output.Close();
            });
            ThreadFreedFileMain.Start();
        }

        public static void FreedFileAI()
        {
            FreedFile("OriDEInstallBepInEx.Resources.mono.DebugMono.dll", TmepFile + "DebugMono.dll");
            FreedFile("OriDEInstallBepInEx.Resources.mono.GameMono.dll", TmepFile + "GameMono.dll");
            FreedFile("OriDEInstallBepInEx.Resources.BepInEx.BepInEx_x" + Bit() + ".zip", TmepFile + "BepInEx.zip");
        }
        public static void Install()
        {
            Console.WriteLine("选择游戏目录...");
            System.Windows.Forms.DialogResult ShowDialogOK = GameDir.ShowDialog();
            if (ShowDialogOK == System.Windows.Forms.DialogResult.OK)
            {
                Console.WriteLine("选择路径:" + GameDir.SelectedPath);
                if (Directory.Exists(GameDir.SelectedPath) && Directory.Exists(GameDir.SelectedPath + @"\oriDE_Data") && Directory.Exists(GameDir.SelectedPath + @"\oriDE_Data\mono"))
                {
                    Console.WriteLine("正在提取文件...");
                    Directory.CreateDirectory(TmepFile);

                    Thread ThreadMain = new Thread(FreedFileAI);
                    ThreadMain.Start();
                    ThreadMain.Join();

                    //FreedFileAI(); //提取文件
                    if (File.Exists(TmepFile + "DebugMono.dll") && File.Exists(TmepFile + "GameMono.dll") && File.Exists(TmepFile + "BepInEx.zip"))
                    {
                        Console.WriteLine("正在安装...");
                        ZipFile.ExtractToDirectory(TmepFile + @"\BepInEx.zip", GameDir.SelectedPath);
                        Console.WriteLine("正在清理残留...");
                        new DirectoryInfo(TmepFile).Delete(true);
                        Console.WriteLine("安装完成!.");
                        MessageBox.Show("BepnEX安装完成! \n 请按照常规方式打开游戏即可!", "安装完成");
                    }
                    else
                    {
                        Console.WriteLine("操作中断:尝试提取文件失败\n警告:你不应该看到此错误,而是程序崩溃");
                        MessageBox.Show("操作中断:尝试提取文件失败\n警告:你不应该看到此错误,而是程序崩溃", "错误");
                    }
                }
                else
                {
                    Console.WriteLine("操作中断:可能以下目录不存在 \n 你选择的游戏目录 \n 游戏目录下不存在OriDE_Data文件夹 \n OriDE_Dat下不存在mono文件夹");
                    MessageBox.Show("操作中断:可能以下目录不存在 \n 你选择的游戏目录 \n 游戏目录下不存在OriDE_Data文件夹 \n OriDE_Dat下不存在mono文件夹", "错误");
                }
            }
            else
            {
                Console.WriteLine("用户中断操作:未选择任何目录");
                MessageBox.Show("用户中断操作:未选择任何目录", "错误");
            }
        }
    }
}
