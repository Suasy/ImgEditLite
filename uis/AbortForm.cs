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
    public partial class AbortForm : Form
    {
        public AbortForm()
        {
            InitializeComponent();
        }

        //关闭
        private void uibtnClose_Click(object sender, EventArgs e)
        {
            //关闭窗口
            this.Close();
        }
    }
}
