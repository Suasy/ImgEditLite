using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgEdit
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //展示启动窗口
            LaunchForm launchForm = new LaunchForm();
            if (launchForm.ShowDialog() == DialogResult.OK)
                Application.Run(new FormImgEdit());
            else
                Application.Exit();
        }
    }
}
