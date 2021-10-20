using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgEdit
{
    public partial class LaunchForm : Form
    {
        public LaunchForm()
        {
            InitializeComponent();
        }

        //进度条时间事件
        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            pnlProgress.Width += 10;
            if (pnlProgress.Width >= 796)
            {
                tmrProgress.Stop();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
