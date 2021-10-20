namespace ImgEdit
{
    partial class ResizeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResizeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.uitbxWidth = new Sunny.UI.UITextBox();
            this.uitbxHeight = new Sunny.UI.UITextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uibtnConfirm = new Sunny.UI.UIButton();
            this.uibtnCancel = new Sunny.UI.UIButton();
            this.uicbxLock = new Sunny.UI.UICheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "修改尺寸";
            // 
            // uitbxWidth
            // 
            this.uitbxWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitbxWidth.FillColor = System.Drawing.Color.White;
            this.uitbxWidth.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uitbxWidth.Location = new System.Drawing.Point(92, 108);
            this.uitbxWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitbxWidth.Maximum = 2147483647D;
            this.uitbxWidth.Minimum = -2147483648D;
            this.uitbxWidth.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitbxWidth.Name = "uitbxWidth";
            this.uitbxWidth.Padding = new System.Windows.Forms.Padding(5);
            this.uitbxWidth.Size = new System.Drawing.Size(209, 29);
            this.uitbxWidth.TabIndex = 25;
            this.uitbxWidth.Text = "0";
            this.uitbxWidth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uitbxHeight
            // 
            this.uitbxHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitbxHeight.FillColor = System.Drawing.Color.White;
            this.uitbxHeight.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uitbxHeight.Location = new System.Drawing.Point(92, 159);
            this.uitbxHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitbxHeight.Maximum = 2147483647D;
            this.uitbxHeight.Minimum = -2147483648D;
            this.uitbxHeight.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitbxHeight.Name = "uitbxHeight";
            this.uitbxHeight.Padding = new System.Windows.Forms.Padding(5);
            this.uitbxHeight.Size = new System.Drawing.Size(209, 29);
            this.uitbxHeight.TabIndex = 26;
            this.uitbxHeight.Text = "0";
            this.uitbxHeight.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(313, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "像素";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(313, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "像素";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(31, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "高度";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(31, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "宽度";
            // 
            // uibtnConfirm
            // 
            this.uibtnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnConfirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uibtnConfirm.Location = new System.Drawing.Point(40, 329);
            this.uibtnConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnConfirm.Name = "uibtnConfirm";
            this.uibtnConfirm.Radius = 10;
            this.uibtnConfirm.Size = new System.Drawing.Size(184, 35);
            this.uibtnConfirm.TabIndex = 41;
            this.uibtnConfirm.Text = "应用";
            this.uibtnConfirm.Click += new System.EventHandler(this.uibtnConfirm_Click);
            // 
            // uibtnCancel
            // 
            this.uibtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnCancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uibtnCancel.Location = new System.Drawing.Point(272, 329);
            this.uibtnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnCancel.Name = "uibtnCancel";
            this.uibtnCancel.Radius = 10;
            this.uibtnCancel.Size = new System.Drawing.Size(100, 35);
            this.uibtnCancel.TabIndex = 40;
            this.uibtnCancel.Text = "取消";
            this.uibtnCancel.Click += new System.EventHandler(this.uibtnCancel_Click);
            // 
            // uicbxLock
            // 
            this.uicbxLock.Checked = true;
            this.uicbxLock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicbxLock.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uicbxLock.Location = new System.Drawing.Point(35, 218);
            this.uicbxLock.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicbxLock.Name = "uicbxLock";
            this.uicbxLock.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicbxLock.Size = new System.Drawing.Size(144, 29);
            this.uicbxLock.TabIndex = 42;
            this.uicbxLock.Text = "锁定长度比例";
            // 
            // ResizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(421, 394);
            this.Controls.Add(this.uicbxLock);
            this.Controls.Add(this.uibtnConfirm);
            this.Controls.Add(this.uibtnCancel);
            this.Controls.Add(this.uitbxWidth);
            this.Controls.Add(this.uitbxHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ResizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改尺寸";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Sunny.UI.UITextBox uitbxWidth;
        private Sunny.UI.UITextBox uitbxHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIButton uibtnConfirm;
        private Sunny.UI.UIButton uibtnCancel;
        private Sunny.UI.UICheckBox uicbxLock;
    }
}