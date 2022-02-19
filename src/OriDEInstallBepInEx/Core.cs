using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriDEInstallBepInEx
{
    public static class Core
    {
        public static void Install()
        {
            Console.WriteLine("选择程序位置...");
            System.Windows.Forms.FolderBrowserDialog Game = new System.Windows.Forms.FolderBrowserDialog();
            //Game.Description = "选择游戏目录";
            Game.ShowNewFolderButton = true;
            Game.RootFolder = Environment.SpecialFolder.ApplicationData;
            System.Windows.Forms.DialogResult result = Game.ShowDialog();
            Console.WriteLine("选择路径:" + Game.SelectedPath);
        }
    }
}
