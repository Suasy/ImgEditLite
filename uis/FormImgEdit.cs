using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace ImgEdit
{
    public partial class FormImgEdit : Form
    {
        //定义属性和字段
        private string fName;                              //当前打开的文件名
        private Bitmap img;                                //当前的像素图
        private Stack stack = Stack.getStack();            //用于撤销恢复的栈

        private int pbxWidth = 900;                        //pbxImg原宽度
        private int pbxHeight = 600;                       //pbxImg原高度

        private int pbxLeft = 0;                           //pbxImg原Left
        private int pbxTop = 0;                            //pbxImg原Top

        private int minWidth = 100;                        //pbxImg最小宽度
        private int minHeight = 100;                       //pbxImg最小高度

        //构造函数
        public FormImgEdit()
        {
            InitializeComponent();
            //读入测试图片
            fName = @".\img\background.jpg";
            //将图片保存和显示
            img = (Bitmap)Image.FromFile(fName);
            pbxImg.Image = img;
            //将图片入栈
            stack.push(new StackImg(
                Convert.ToInt32(lblLDValue.Text),
                Convert.ToInt32(lblDBDValue.Text),
                Convert.ToInt32(lblBHDValue.Text),
                Convert.ToInt32(lblSWValue.Text),
                img));
        }

        //应用图片
        public void applyImg(Bitmap img)
        {
            //将图片保存和显示
            this.img = img;
            pbxImg.Image = this.img;
            //将图片入栈
            stack.push(new StackImg(
                Convert.ToInt32(lblLDValue.Text),
                Convert.ToInt32(lblDBDValue.Text),
                Convert.ToInt32(lblBHDValue.Text),
                Convert.ToInt32(lblSWValue.Text),
                this.img));
        }

        //设置初始调色值
        public void initToningValue()
        {
            //设置初始调色值
            uitkbLD.Value = 0;
            lblLDValue.Text = "0";
            uitkbDBD.Value = 0;
            lblDBDValue.Text = "0";
            uitkbBHD.Value = 0;
            lblBHDValue.Text = "0";
            uitkbSW.Value = 0;
            lblSWValue.Text = "0";
        }

        //新建图片
        public void newImg()
        {
            this.fName = @".\img\new.png";
        }

        /// <summary>
        /// 菜单控件
        /// </summary>
        //新建
        private void ToolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm();
            newForm.ShowDialog(this);
        }
        //打开
        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "所有支持的图片格式|*.jpg;*jpeg;*.jpe;*.bmp;*.gif;*.png;*.raw;*.arw;*.nef;*.crw;*.mrw;*.raf;*.erf;*.3fr;*.dcr;*.dng;*.pef;*.cr2;*.st2;*.mef;*.orf;*.psd" + "|" + 
                "JPG 格式|*.jpg;*.jpeg;*.jpe|BMP 格式|*.bmp|GIF 格式|*.gif|PNG 格式|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //读入图片
                this.fName = openFileDialog.FileName;
                //将图片保存和显示
                try
                {
                    //使用Image.FromFile创建图像对象
                    this.img = (Bitmap)Image.FromFile(fName);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                pbxImg.Image = this.img;
                //设置初始调色值
                uitkbLD.Value = 0;
                lblLDValue.Text = "0";
                uitkbDBD.Value = 0;
                lblDBDValue.Text = "0";
                uitkbBHD.Value = 0;
                lblBHDValue.Text = "0";
                uitkbSW.Value = 0;
                lblSWValue.Text = "0";
                //将图片入栈
                stack.push(new StackImg(
                    Convert.ToInt32(lblLDValue.Text),
                    Convert.ToInt32(lblDBDValue.Text),
                    Convert.ToInt32(lblBHDValue.Text),
                    Convert.ToInt32(lblSWValue.Text),
                    this.img));
            }
        }
        //保存
        private void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            //获取扩展名
            string ext = Path.GetExtension(this.fName);
            //生成保存路径
            string fName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\IMG_" + string.Format("{0:yyyyMMdd_HHmmss}", DateTime.Now) + ext;
            //保存图片
            switch (ext)
            {
                case ".gif":
                    this.img.Save(fName, System.Drawing.Imaging.ImageFormat.Gif);
                    break;
                case ".jpg":
                    this.img.Save(fName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
                case ".bmp":
                    this.img.Save(fName, System.Drawing.Imaging.ImageFormat.Bmp);
                    break;
                default:
                    this.img.Save(fName, System.Drawing.Imaging.ImageFormat.Png);
                    break;
            }
        }
        //另存为
        private void ToolStripMenuItemSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.Filter = "JPG 格式|*.jpg|PNG 格式|*.png|BMP 格式|*.bmp";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //获取文件路径
                string fName = saveFileDialog.FileName;
                //获取扩展名
                string ext = Path.GetExtension(fName);
                //保存图片
                switch (ext)
                {
                    case ".gif":
                        this.img.Save(fName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case ".jpg":
                        this.img.Save(fName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case ".bmp":
                        this.img.Save(fName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    default:
                        this.img.Save(fName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
            }
        }
        //撤销
        private void ToolStripMenuItemUndo_Click(object sender, EventArgs e)
        {
            if (stack.isUndoable())
            {
                StackImg s = stack.pop();
                this.img = s.img;
                pbxImg.Image = this.img;
                uitkbLD.Value = s.LD;
                lblLDValue.Text = Convert.ToString(s.LD);
                uitkbDBD.Value = s.DBD;
                lblDBDValue.Text = Convert.ToString(s.DBD);
                uitkbBHD.Value = s.BHD;
                lblBHDValue.Text = Convert.ToString(s.BHD);
                uitkbSW.Value = s.SW;
                lblSWValue.Text = Convert.ToString(s.SW);
            }
        }
        //恢复
        private void ToolStripMenuItemRedo_Click(object sender, EventArgs e)
        {
            if (stack.isRedoable())
            {
                StackImg s = stack.redo();
                this.img = s.img;
                pbxImg.Image = this.img;
                uitkbLD.Value = s.LD;
                lblLDValue.Text = Convert.ToString(s.LD);
                uitkbDBD.Value = s.DBD;
                lblDBDValue.Text = Convert.ToString(s.DBD);
                uitkbBHD.Value = s.BHD;
                lblBHDValue.Text = Convert.ToString(s.BHD);
                uitkbSW.Value = s.SW;
                lblSWValue.Text = Convert.ToString(s.SW);
            }
        }
        //修改尺寸
        private void ToolStripMenuItemResize_Click(object sender, EventArgs e)
        {
            ResizeForm resizeForm = new ResizeForm();
            resizeForm.setImg(this.img);
            resizeForm.ShowDialog(this);
        }
        //关于
        private void ToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            AbortForm abortForm = new AbortForm();
            abortForm.ShowDialog(this);
        }

        /// <summary>
        /// 滑动条滑动事件
        /// </summary>
        //亮度滑动条
        private void uitkbLD_ValueChanged(object sender, EventArgs e)
        {
            lblLDValue.Text = uitkbLD.Value.ToString();
        }
        //对比度滑动条
        private void uitkbDBD_ValueChanged(object sender, EventArgs e)
        {
            lblDBDValue.Text = uitkbDBD.Value.ToString();
        }
        //饱和度滑动条
        private void uitkbBHD_ValueChanged(object sender, EventArgs e)
        {
            lblBHDValue.Text = uitkbBHD.Value.ToString();
        }
        //色调滑动条
        private void uitkbSW_ValueChanged(object sender, EventArgs e)
        {
            lblSWValue.Text = uitkbSW.Value.ToString();
        }
        //编辑大小滑动条
        private void uitkbESize_ValueChanged(object sender, EventArgs e)
        {
            lblESizeValue.Text = uitkbESize.Value.ToString() + "%";
        }

        /// <summary>
        /// 右键菜单
        /// </summary>
        //放大
        private void ToolStripMenuItemRZoomIn_Click(object sender, EventArgs e)
        {
            int i = 100;
            if ((pbxImg.Width > this.minWidth && pbxImg.Height > this.minHeight) || (i > 0))
            {
                pbxImg.Width = pbxImg.Width + i;          //增加picturebox的宽度
                pbxImg.Height = pbxImg.Height + i;
                pbxImg.Left = pbxImg.Left - i / 2;        //使picturebox的中心位于窗体的中心
                pbxImg.Top = pbxImg.Top - i / 2;          //进而缩放时图片也位于窗体的中心
            }
        }
        //缩小
        private void ToolStripMenuItemRZoomOut_Click(object sender, EventArgs e)
        {
            int i = -100;
            if ((pbxImg.Width > this.minWidth && pbxImg.Height > this.minHeight) || (i > 0))
            {
                pbxImg.Width = pbxImg.Width + i;          //增加picturebox的宽度
                pbxImg.Height = pbxImg.Height + i;
                pbxImg.Left = pbxImg.Left - i / 2;        //使picturebox的中心位于窗体的中心
                pbxImg.Top = pbxImg.Top - i / 2;          //进而缩放时图片也位于窗体的中心
            }
        }
        //自适应
        private void ToolStripMenuItemRSelfAdp_Click(object sender, EventArgs e)
        {
            int addW = this.pbxWidth - pbxImg.Width;
            int addH = this.pbxHeight - pbxImg.Height;
            pbxImg.Width = pbxImg.Width + addW;          //增加picturebox的宽度
            pbxImg.Height = pbxImg.Height + addH;
            pbxImg.Left = pbxImg.Left - addW / 2;        //使picturebox的中心位于窗体的中心
            pbxImg.Top = pbxImg.Top - addH / 2;          //进而缩放时图片也位于窗体的中心
        }
        //保存
        private void ToolStripMenuItemRSave_Click(object sender, EventArgs e)
        {
            //获取扩展名
            string ext = Path.GetExtension(this.fName);
            //生成保存路径
            string fName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\IMG_" + string.Format("{0:yyyyMMdd_HHmmss}", DateTime.Now) + ext;
            //保存图片
            switch (ext)
            {
                case ".gif":
                    this.img.Save(fName, System.Drawing.Imaging.ImageFormat.Gif);
                    break;
                case ".jpg":
                    this.img.Save(fName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
                case ".bmp":
                    this.img.Save(fName, System.Drawing.Imaging.ImageFormat.Bmp);
                    break;
                default:
                    this.img.Save(fName, System.Drawing.Imaging.ImageFormat.Png);
                    break;
            }
        }

        /// <summary>
        /// 调色
        /// </summary>
        private void uiTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is UITrackBar)
            {
                UITrackBar uiTrackBar = sender as UITrackBar;

                Toning toning = ToningFactory.getToning(uiTrackBar.Text);
                this.img = toning.DoToning(this.img, uiTrackBar.Value);

                pbxImg.Image = this.img;
                stack.push(new StackImg(
                    Convert.ToInt32(lblLDValue.Text),
                    Convert.ToInt32(lblDBDValue.Text),
                    Convert.ToInt32(lblBHDValue.Text),
                    Convert.ToInt32(lblSWValue.Text),
                    this.img));
            }
        }

        /// <summary>
        /// 滤镜
        /// </summary>
        private void uiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is UIRadioButton)
            {
                UIRadioButton uiRadioButton = sender as UIRadioButton;
                if (uiRadioButton.Checked)
                {
                    Filter filter = FilterFactory.getFilter(uiRadioButton.Text);
                    this.img = filter.DoFilter(this.img);

                    pbxImg.Image = this.img;
                    stack.push(new StackImg(
                        Convert.ToInt32(lblLDValue.Text),
                        Convert.ToInt32(lblDBDValue.Text),
                        Convert.ToInt32(lblBHDValue.Text),
                        Convert.ToInt32(lblSWValue.Text),
                        this.img));
                }
            }
        }

        /// <summary>
        /// 基本处理
        /// </summary>
        //自适应
        private void uibtnESelfAdp_Click(object sender, EventArgs e)
        {
            pbxImg.Width = this.pbxWidth;
            pbxImg.Height = this.pbxHeight;
            pbxImg.Left = this.pbxLeft;
            pbxImg.Top = this.pbxTop;
        }
        //向左旋转
        private void uibtnRotationL_Click(object sender, EventArgs e)
        {
            this.img = new Bitmap(this.img);
            this.img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbxImg.Image = this.img;
            stack.push(new StackImg(
                Convert.ToInt32(lblLDValue.Text),
                Convert.ToInt32(lblDBDValue.Text),
                Convert.ToInt32(lblBHDValue.Text),
                Convert.ToInt32(lblSWValue.Text),
                this.img));
        }
        //向右旋转
        private void uibtnRotationR_Click(object sender, EventArgs e)
        {
            this.img = new Bitmap(this.img);
            this.img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbxImg.Image = this.img;
            stack.push(new StackImg(
                Convert.ToInt32(lblLDValue.Text),
                Convert.ToInt32(lblDBDValue.Text),
                Convert.ToInt32(lblBHDValue.Text),
                Convert.ToInt32(lblSWValue.Text),
                this.img));
        }
        //翻转
        private void uibtnFlip_Click(object sender, EventArgs e)
        {
            this.img = new Bitmap(this.img);
            this.img.RotateFlip(RotateFlipType.Rotate180FlipY);
            pbxImg.Image = this.img;
            stack.push(new StackImg(
                Convert.ToInt32(lblLDValue.Text),
                Convert.ToInt32(lblDBDValue.Text),
                Convert.ToInt32(lblBHDValue.Text),
                Convert.ToInt32(lblSWValue.Text),
                this.img));
        }

        /// <summary>
        /// 关于图片控件的事件
        /// </summary>
        //鼠标滚轮事件
        private void pbxImg_MouseWheel(object sender, MouseEventArgs e)
        {
            int i = e.Delta * SystemInformation.MouseWheelScrollLines / 5;
            if ((pbxImg.Width > this.minWidth && pbxImg.Height > this.minHeight) || (i > 0))
            {
                pbxImg.Width = pbxImg.Width + i;          //增加picturebox的宽度
                pbxImg.Height = pbxImg.Height + i;
                pbxImg.Left = pbxImg.Left - i / 2;        //使picturebox的中心位于窗体的中心
                pbxImg.Top = pbxImg.Top - i / 2;          //进而缩放时图片也位于窗体的中心
            }
        }
        //图片控件大小改变事件
        private void pbxImg_SizeChanged(object sender, EventArgs e)
        {
            int n = pbxImg.Width * 100 / this.pbxWidth;
            if (n > 500)
            {
                uitkbESize.Value = 500;
            }
            else
            {
                uitkbESize.Value = n;
            }
        }
    }
}
