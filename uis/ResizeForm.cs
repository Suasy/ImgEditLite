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
    public partial class ResizeForm : Form
    {

        //定义属性和字段
        private Bitmap img;               //当前的像素图

        //构造函数
        public ResizeForm()
        {
            InitializeComponent();
            //键盘弹起事件
            uitbxWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.uitbxWidth_KeyUp);
            uitbxHeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.uitbxHeight_KeyUp);
            //文本改变事件
            uitbxWidth.TextChanged += new System.EventHandler(this.uitbx_TextChanged);
            uitbxHeight.TextChanged += new System.EventHandler(this.uitbx_TextChanged);
        }

        //设置当前像素图
        public void setImg(Bitmap img)
        {
            this.img = img;
            uitbxWidth.Text = img.Width.ToString();
            uitbxHeight.Text = img.Height.ToString();
        }

        //宽度文本键盘弹起事件
        private void uitbxWidth_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (uicbxLock.Checked)
                    uitbxHeight.Text = Convert.ToInt32(Convert.ToInt32(uitbxWidth.Text) / Convert.ToDouble(img.Width) * img.Height).ToString();
                else
                    //测试转换是否会抛出异常
                    Convert.ToInt32(uitbxWidth.Text);
            }
            catch (Exception)
            {
                uitbxWidth.Text = "0";
                uitbxHeight.Text = "0";
            }
        }

        //高度文本键盘弹起事件
        private void uitbxHeight_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (uicbxLock.Checked)
                    uitbxWidth.Text = Convert.ToInt32(Convert.ToInt32(uitbxHeight.Text) / Convert.ToDouble(img.Height) * img.Width).ToString();
                else
                    //测试转换是否会抛出异常
                    Convert.ToInt32(uitbxHeight.Text);
            }
            catch (Exception)
            {
                uitbxWidth.Text = "0";
                uitbxHeight.Text = "0";
            }
        }

        //文本改变事件
        private void uitbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //测试转换是否会抛出异常
                Convert.ToInt32(uitbxWidth.Text);
                Convert.ToInt32(uitbxHeight.Text);
            }
            catch (Exception)
            {
                uitbxWidth.Text = "0";
                uitbxHeight.Text = "0";
            }
        }

        //确定
        private void uibtnConfirm_Click(object sender, EventArgs e)
        {
            //初始信息
            int width = Convert.ToInt32(uitbxWidth.Text);
            int height = Convert.ToInt32(uitbxHeight.Text);
            //更改图片大小
            this.img = new Bitmap(this.img, width, height);
            //传递图片给父窗体
            FormImgEdit f = this.Owner as FormImgEdit;
            f.applyImg(this.img);
            //关闭窗口
            this.Close();
        }

        //取消
        private void uibtnCancel_Click(object sender, EventArgs e)
        {
            //关闭窗口
            this.Close();
        }
    }
}
