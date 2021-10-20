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
    public partial class NewForm : Form
    {

        //定义属性和字段
        private Bitmap img;               //当前的像素图
        Color customColor;                //自定义颜色

        //构造函数
        public NewForm()
        {
            InitializeComponent();
        }

        //设置当前像素图
        public void setImg(Bitmap img)
        {
            this.img = img;
        }

        //自定义颜色
        private void uirbtCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (uirbtCustom.Checked)
            {
                //显示颜色对话框
                ColorDialog colorDialog = new ColorDialog();
                //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    this.customColor = colorDialog.Color;
                    lblCustom.Text = "";
                    lblCustom.BackColor = colorDialog.Color;
                    lblCustom.Size = new Size(58, 21);
                }
            }
        }

        //应用
        private void uibtnConfirm_Click(object sender, EventArgs e)
        {
            //初始信息
            int width = Convert.ToInt32(uitbxWidth.Text);
            int height = Convert.ToInt32(uitbxHeight.Text);
            //创建图片
            Bitmap bmp = new Bitmap(width, height);
            //更改颜色
            if (uirbtWhite.Checked)
            {
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        bmp.SetPixel(x, y, Color.White);
                    }
                }
            }
            else if (uirbtTransparent.Checked)
            {
                bmp.MakeTransparent();
            }
            else
            {
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        bmp.SetPixel(x, y, customColor);
                    }
                }
            }
            //显示和保存图片
            this.img = bmp;
            //传递图片给父窗体
            FormImgEdit f = this.Owner as FormImgEdit;
            f.newImg();
            f.applyImg(this.img);
            f.initToningValue();
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
