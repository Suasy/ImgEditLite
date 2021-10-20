namespace ImgEdit
{
    partial class FormImgEdit
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImgEdit));
            this.lblESizeValue = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemRZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRSelfAdp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemRSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemResize = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uibtnESelfAdp = new Sunny.UI.UIButton();
            this.uibtnRotationL = new Sunny.UI.UIButton();
            this.uibtnRotationR = new Sunny.UI.UIButton();
            this.uibtnFlip = new Sunny.UI.UIButton();
            this.uitkbESize = new Sunny.UI.UITrackBar();
            this.uiPanelBottom = new Sunny.UI.UIPanel();
            this.pbxImg = new System.Windows.Forms.PictureBox();
            this.uiPanelImg = new Sunny.UI.UIPanel();
            this.uigbxFilter = new Sunny.UI.UIGroupBox();
            this.uirbtJM = new Sunny.UI.UIRadioButton();
            this.uirbtMH = new Sunny.UI.UIRadioButton();
            this.uirbtQC = new Sunny.UI.UIRadioButton();
            this.uirbtFD = new Sunny.UI.UIRadioButton();
            this.uirbtZR = new Sunny.UI.UIRadioButton();
            this.uirbtHB = new Sunny.UI.UIRadioButton();
            this.uitkbSW = new Sunny.UI.UITrackBar();
            this.uitkbBHD = new Sunny.UI.UITrackBar();
            this.uitkbDBD = new Sunny.UI.UITrackBar();
            this.uitkbLD = new Sunny.UI.UITrackBar();
            this.lblSWValue = new System.Windows.Forms.Label();
            this.lblBHDValue = new System.Windows.Forms.Label();
            this.lblDBDValue = new System.Windows.Forms.Label();
            this.lblLDValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.uiPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            this.uiPanelImg.SuspendLayout();
            this.uigbxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblESizeValue
            // 
            this.lblESizeValue.AutoSize = true;
            this.lblESizeValue.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblESizeValue.Location = new System.Drawing.Point(98, 30);
            this.lblESizeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblESizeValue.Name = "lblESizeValue";
            this.lblESizeValue.Size = new System.Drawing.Size(51, 21);
            this.lblESizeValue.TabIndex = 4;
            this.lblESizeValue.Text = "100%";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemRZoomIn,
            this.ToolStripMenuItemRZoomOut,
            this.ToolStripMenuItemRSelfAdp,
            this.toolStripSeparator1,
            this.ToolStripMenuItemRSave});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 98);
            // 
            // ToolStripMenuItemRZoomIn
            // 
            this.ToolStripMenuItemRZoomIn.Name = "ToolStripMenuItemRZoomIn";
            this.ToolStripMenuItemRZoomIn.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemRZoomIn.Text = "放大";
            this.ToolStripMenuItemRZoomIn.Click += new System.EventHandler(this.ToolStripMenuItemRZoomIn_Click);
            // 
            // ToolStripMenuItemRZoomOut
            // 
            this.ToolStripMenuItemRZoomOut.Name = "ToolStripMenuItemRZoomOut";
            this.ToolStripMenuItemRZoomOut.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemRZoomOut.Text = "缩小";
            this.ToolStripMenuItemRZoomOut.Click += new System.EventHandler(this.ToolStripMenuItemRZoomOut_Click);
            // 
            // ToolStripMenuItemRSelfAdp
            // 
            this.ToolStripMenuItemRSelfAdp.Name = "ToolStripMenuItemRSelfAdp";
            this.ToolStripMenuItemRSelfAdp.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemRSelfAdp.Text = "自适应";
            this.ToolStripMenuItemRSelfAdp.Click += new System.EventHandler(this.ToolStripMenuItemRSelfAdp_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // ToolStripMenuItemRSave
            // 
            this.ToolStripMenuItemRSave.Name = "ToolStripMenuItemRSave";
            this.ToolStripMenuItemRSave.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemRSave.Text = "保存";
            this.ToolStripMenuItemRSave.Click += new System.EventHandler(this.ToolStripMenuItemRSave_Click);
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNew,
            this.ToolStripMenuItemOpen,
            this.ToolStripMenuItemSave,
            this.ToolStripMenuItemSaveAs});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(47, 23);
            this.ToolStripMenuItemFile.Text = "文件";
            // 
            // ToolStripMenuItemNew
            // 
            this.ToolStripMenuItemNew.Name = "ToolStripMenuItemNew";
            this.ToolStripMenuItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ToolStripMenuItemNew.Size = new System.Drawing.Size(205, 24);
            this.ToolStripMenuItemNew.Text = "新建";
            this.ToolStripMenuItemNew.Click += new System.EventHandler(this.ToolStripMenuItemNew_Click);
            // 
            // ToolStripMenuItemOpen
            // 
            this.ToolStripMenuItemOpen.Name = "ToolStripMenuItemOpen";
            this.ToolStripMenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ToolStripMenuItemOpen.Size = new System.Drawing.Size(205, 24);
            this.ToolStripMenuItemOpen.Text = "打开";
            this.ToolStripMenuItemOpen.Click += new System.EventHandler(this.ToolStripMenuItemOpen_Click);
            // 
            // ToolStripMenuItemSave
            // 
            this.ToolStripMenuItemSave.Name = "ToolStripMenuItemSave";
            this.ToolStripMenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ToolStripMenuItemSave.Size = new System.Drawing.Size(205, 24);
            this.ToolStripMenuItemSave.Text = "保存";
            this.ToolStripMenuItemSave.Click += new System.EventHandler(this.ToolStripMenuItemSave_Click);
            // 
            // ToolStripMenuItemSaveAs
            // 
            this.ToolStripMenuItemSaveAs.Name = "ToolStripMenuItemSaveAs";
            this.ToolStripMenuItemSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.ToolStripMenuItemSaveAs.Size = new System.Drawing.Size(205, 24);
            this.ToolStripMenuItemSaveAs.Text = "另存为";
            this.ToolStripMenuItemSaveAs.Click += new System.EventHandler(this.ToolStripMenuItemSaveAs_Click);
            // 
            // ToolStripMenuItemEdit
            // 
            this.ToolStripMenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemUndo,
            this.ToolStripMenuItemRedo,
            this.toolStripSeparator2,
            this.ToolStripMenuItemResize});
            this.ToolStripMenuItemEdit.Name = "ToolStripMenuItemEdit";
            this.ToolStripMenuItemEdit.Size = new System.Drawing.Size(47, 23);
            this.ToolStripMenuItemEdit.Text = "编辑";
            // 
            // ToolStripMenuItemUndo
            // 
            this.ToolStripMenuItemUndo.Name = "ToolStripMenuItemUndo";
            this.ToolStripMenuItemUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ToolStripMenuItemUndo.Size = new System.Drawing.Size(153, 24);
            this.ToolStripMenuItemUndo.Text = "撤销";
            this.ToolStripMenuItemUndo.Click += new System.EventHandler(this.ToolStripMenuItemUndo_Click);
            // 
            // ToolStripMenuItemRedo
            // 
            this.ToolStripMenuItemRedo.Name = "ToolStripMenuItemRedo";
            this.ToolStripMenuItemRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.ToolStripMenuItemRedo.Size = new System.Drawing.Size(153, 24);
            this.ToolStripMenuItemRedo.Text = "恢复";
            this.ToolStripMenuItemRedo.Click += new System.EventHandler(this.ToolStripMenuItemRedo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // ToolStripMenuItemResize
            // 
            this.ToolStripMenuItemResize.Name = "ToolStripMenuItemResize";
            this.ToolStripMenuItemResize.Size = new System.Drawing.Size(153, 24);
            this.ToolStripMenuItemResize.Text = "修改尺寸";
            this.ToolStripMenuItemResize.Click += new System.EventHandler(this.ToolStripMenuItemResize_Click);
            // 
            // ToolStripMenuItemHelp
            // 
            this.ToolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAbout});
            this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(47, 23);
            this.ToolStripMenuItemHelp.Text = "帮助";
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(173, 24);
            this.ToolStripMenuItemAbout.Text = "关于 图片处理器";
            this.ToolStripMenuItemAbout.Click += new System.EventHandler(this.ToolStripMenuItemAbout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemEdit,
            this.ToolStripMenuItemHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1246, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uibtnESelfAdp
            // 
            this.uibtnESelfAdp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnESelfAdp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uibtnESelfAdp.Location = new System.Drawing.Point(460, 663);
            this.uibtnESelfAdp.Margin = new System.Windows.Forms.Padding(2);
            this.uibtnESelfAdp.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnESelfAdp.Name = "uibtnESelfAdp";
            this.uibtnESelfAdp.Radius = 10;
            this.uibtnESelfAdp.Size = new System.Drawing.Size(95, 34);
            this.uibtnESelfAdp.TabIndex = 13;
            this.uibtnESelfAdp.Text = "自适应";
            this.uibtnESelfAdp.Click += new System.EventHandler(this.uibtnESelfAdp_Click);
            // 
            // uibtnRotationL
            // 
            this.uibtnRotationL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnRotationL.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uibtnRotationL.Location = new System.Drawing.Point(801, 663);
            this.uibtnRotationL.Margin = new System.Windows.Forms.Padding(2);
            this.uibtnRotationL.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnRotationL.Name = "uibtnRotationL";
            this.uibtnRotationL.Radius = 10;
            this.uibtnRotationL.Size = new System.Drawing.Size(95, 34);
            this.uibtnRotationL.TabIndex = 14;
            this.uibtnRotationL.Text = "左旋";
            this.uibtnRotationL.Click += new System.EventHandler(this.uibtnRotationL_Click);
            // 
            // uibtnRotationR
            // 
            this.uibtnRotationR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnRotationR.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uibtnRotationR.Location = new System.Drawing.Point(937, 663);
            this.uibtnRotationR.Margin = new System.Windows.Forms.Padding(2);
            this.uibtnRotationR.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnRotationR.Name = "uibtnRotationR";
            this.uibtnRotationR.Radius = 10;
            this.uibtnRotationR.Size = new System.Drawing.Size(95, 34);
            this.uibtnRotationR.TabIndex = 15;
            this.uibtnRotationR.Text = "右旋";
            this.uibtnRotationR.Click += new System.EventHandler(this.uibtnRotationR_Click);
            // 
            // uibtnFlip
            // 
            this.uibtnFlip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnFlip.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uibtnFlip.Location = new System.Drawing.Point(1068, 663);
            this.uibtnFlip.Margin = new System.Windows.Forms.Padding(2);
            this.uibtnFlip.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnFlip.Name = "uibtnFlip";
            this.uibtnFlip.Radius = 10;
            this.uibtnFlip.Size = new System.Drawing.Size(95, 34);
            this.uibtnFlip.TabIndex = 16;
            this.uibtnFlip.Text = "翻转";
            this.uibtnFlip.Click += new System.EventHandler(this.uibtnFlip_Click);
            // 
            // uitkbESize
            // 
            this.uitkbESize.DisableColor = System.Drawing.Color.Silver;
            this.uitkbESize.Enabled = false;
            this.uitkbESize.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uitkbESize.Location = new System.Drawing.Point(189, 668);
            this.uitkbESize.Margin = new System.Windows.Forms.Padding(2);
            this.uitkbESize.Maximum = 500;
            this.uitkbESize.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitkbESize.Name = "uitkbESize";
            this.uitkbESize.Size = new System.Drawing.Size(112, 23);
            this.uitkbESize.Style = Sunny.UI.UIStyle.Custom;
            this.uitkbESize.TabIndex = 17;
            this.uitkbESize.Text = "uiTrackBar1";
            this.uitkbESize.Value = 100;
            this.uitkbESize.ValueChanged += new System.EventHandler(this.uitkbESize_ValueChanged);
            // 
            // uiPanelBottom
            // 
            this.uiPanelBottom.Controls.Add(this.lblESizeValue);
            this.uiPanelBottom.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelBottom.Location = new System.Drawing.Point(26, 639);
            this.uiPanelBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelBottom.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelBottom.Name = "uiPanelBottom";
            this.uiPanelBottom.Radius = 20;
            this.uiPanelBottom.Size = new System.Drawing.Size(1192, 91);
            this.uiPanelBottom.TabIndex = 19;
            this.uiPanelBottom.Text = null;
            this.uiPanelBottom.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxImg
            // 
            this.pbxImg.BackColor = System.Drawing.Color.Transparent;
            this.pbxImg.ContextMenuStrip = this.contextMenuStrip1;
            this.pbxImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxImg.Image = ((System.Drawing.Image)(resources.GetObject("pbxImg.Image")));
            this.pbxImg.Location = new System.Drawing.Point(0, 0);
            this.pbxImg.Margin = new System.Windows.Forms.Padding(2);
            this.pbxImg.Name = "pbxImg";
            this.pbxImg.Size = new System.Drawing.Size(900, 600);
            this.pbxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImg.TabIndex = 5;
            this.pbxImg.TabStop = false;
            this.pbxImg.SizeChanged += new System.EventHandler(this.pbxImg_SizeChanged);
            this.pbxImg.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pbxImg_MouseWheel);
            // 
            // uiPanelImg
            // 
            this.uiPanelImg.Controls.Add(this.pbxImg);
            this.uiPanelImg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelImg.Location = new System.Drawing.Point(311, 21);
            this.uiPanelImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelImg.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelImg.Name = "uiPanelImg";
            this.uiPanelImg.Radius = 0;
            this.uiPanelImg.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiPanelImg.Size = new System.Drawing.Size(900, 600);
            this.uiPanelImg.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanelImg.TabIndex = 20;
            this.uiPanelImg.Text = null;
            this.uiPanelImg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uigbxFilter
            // 
            this.uigbxFilter.Controls.Add(this.uirbtJM);
            this.uigbxFilter.Controls.Add(this.uirbtMH);
            this.uigbxFilter.Controls.Add(this.uirbtQC);
            this.uigbxFilter.Controls.Add(this.uirbtFD);
            this.uigbxFilter.Controls.Add(this.uirbtZR);
            this.uigbxFilter.Controls.Add(this.uirbtHB);
            this.uigbxFilter.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uigbxFilter.Location = new System.Drawing.Point(42, 321);
            this.uigbxFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uigbxFilter.MinimumSize = new System.Drawing.Size(1, 1);
            this.uigbxFilter.Name = "uigbxFilter";
            this.uigbxFilter.Padding = new System.Windows.Forms.Padding(0, 26, 0, 0);
            this.uigbxFilter.Size = new System.Drawing.Size(206, 218);
            this.uigbxFilter.TabIndex = 54;
            this.uigbxFilter.Text = "滤镜";
            this.uigbxFilter.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uirbtJM
            // 
            this.uirbtJM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uirbtJM.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uirbtJM.Location = new System.Drawing.Point(125, 160);
            this.uirbtJM.MinimumSize = new System.Drawing.Size(1, 1);
            this.uirbtJM.Name = "uirbtJM";
            this.uirbtJM.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uirbtJM.Size = new System.Drawing.Size(74, 29);
            this.uirbtJM.TabIndex = 17;
            this.uirbtJM.Text = "静谧";
            this.uirbtJM.CheckedChanged += new System.EventHandler(this.uiRadioButton_CheckedChanged);
            // 
            // uirbtMH
            // 
            this.uirbtMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uirbtMH.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uirbtMH.Location = new System.Drawing.Point(26, 160);
            this.uirbtMH.MinimumSize = new System.Drawing.Size(1, 1);
            this.uirbtMH.Name = "uirbtMH";
            this.uirbtMH.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uirbtMH.Size = new System.Drawing.Size(74, 29);
            this.uirbtMH.TabIndex = 16;
            this.uirbtMH.Text = "模糊";
            this.uirbtMH.CheckedChanged += new System.EventHandler(this.uiRadioButton_CheckedChanged);
            // 
            // uirbtQC
            // 
            this.uirbtQC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uirbtQC.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uirbtQC.Location = new System.Drawing.Point(125, 102);
            this.uirbtQC.MinimumSize = new System.Drawing.Size(1, 1);
            this.uirbtQC.Name = "uirbtQC";
            this.uirbtQC.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uirbtQC.Size = new System.Drawing.Size(74, 29);
            this.uirbtQC.TabIndex = 15;
            this.uirbtQC.Text = "青春";
            this.uirbtQC.CheckedChanged += new System.EventHandler(this.uiRadioButton_CheckedChanged);
            // 
            // uirbtFD
            // 
            this.uirbtFD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uirbtFD.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uirbtFD.Location = new System.Drawing.Point(26, 102);
            this.uirbtFD.MinimumSize = new System.Drawing.Size(1, 1);
            this.uirbtFD.Name = "uirbtFD";
            this.uirbtFD.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uirbtFD.Size = new System.Drawing.Size(74, 29);
            this.uirbtFD.TabIndex = 14;
            this.uirbtFD.Text = "浮雕";
            this.uirbtFD.CheckedChanged += new System.EventHandler(this.uiRadioButton_CheckedChanged);
            // 
            // uirbtZR
            // 
            this.uirbtZR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uirbtZR.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uirbtZR.Location = new System.Drawing.Point(125, 45);
            this.uirbtZR.MinimumSize = new System.Drawing.Size(1, 1);
            this.uirbtZR.Name = "uirbtZR";
            this.uirbtZR.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uirbtZR.Size = new System.Drawing.Size(74, 29);
            this.uirbtZR.TabIndex = 13;
            this.uirbtZR.Text = "自然";
            this.uirbtZR.CheckedChanged += new System.EventHandler(this.uiRadioButton_CheckedChanged);
            // 
            // uirbtHB
            // 
            this.uirbtHB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uirbtHB.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uirbtHB.Location = new System.Drawing.Point(26, 45);
            this.uirbtHB.MinimumSize = new System.Drawing.Size(1, 1);
            this.uirbtHB.Name = "uirbtHB";
            this.uirbtHB.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uirbtHB.Size = new System.Drawing.Size(74, 29);
            this.uirbtHB.TabIndex = 12;
            this.uirbtHB.Text = "黑白";
            this.uirbtHB.CheckedChanged += new System.EventHandler(this.uiRadioButton_CheckedChanged);
            // 
            // uitkbSW
            // 
            this.uitkbSW.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uitkbSW.Location = new System.Drawing.Point(115, 244);
            this.uitkbSW.Maximum = 10;
            this.uitkbSW.Minimum = -10;
            this.uitkbSW.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitkbSW.Name = "uitkbSW";
            this.uitkbSW.Size = new System.Drawing.Size(102, 29);
            this.uitkbSW.TabIndex = 52;
            this.uitkbSW.Text = "色温";
            this.uitkbSW.ValueChanged += new System.EventHandler(this.uitkbSW_ValueChanged);
            this.uitkbSW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uiTrackBar_MouseUp);
            // 
            // uitkbBHD
            // 
            this.uitkbBHD.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uitkbBHD.Location = new System.Drawing.Point(115, 194);
            this.uitkbBHD.Maximum = 10;
            this.uitkbBHD.Minimum = -10;
            this.uitkbBHD.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitkbBHD.Name = "uitkbBHD";
            this.uitkbBHD.Size = new System.Drawing.Size(102, 29);
            this.uitkbBHD.TabIndex = 51;
            this.uitkbBHD.Text = "饱和度";
            this.uitkbBHD.ValueChanged += new System.EventHandler(this.uitkbBHD_ValueChanged);
            this.uitkbBHD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uiTrackBar_MouseUp);
            // 
            // uitkbDBD
            // 
            this.uitkbDBD.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uitkbDBD.Location = new System.Drawing.Point(115, 147);
            this.uitkbDBD.Maximum = 10;
            this.uitkbDBD.Minimum = -10;
            this.uitkbDBD.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitkbDBD.Name = "uitkbDBD";
            this.uitkbDBD.Size = new System.Drawing.Size(102, 29);
            this.uitkbDBD.TabIndex = 50;
            this.uitkbDBD.Text = "对比度";
            this.uitkbDBD.ValueChanged += new System.EventHandler(this.uitkbDBD_ValueChanged);
            this.uitkbDBD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uiTrackBar_MouseUp);
            // 
            // uitkbLD
            // 
            this.uitkbLD.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uitkbLD.Location = new System.Drawing.Point(116, 100);
            this.uitkbLD.Maximum = 10;
            this.uitkbLD.Minimum = -10;
            this.uitkbLD.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitkbLD.Name = "uitkbLD";
            this.uitkbLD.Size = new System.Drawing.Size(102, 29);
            this.uitkbLD.TabIndex = 49;
            this.uitkbLD.Text = "亮度";
            this.uitkbLD.ValueChanged += new System.EventHandler(this.uitkbLD_ValueChanged);
            this.uitkbLD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uiTrackBar_MouseUp);
            // 
            // lblSWValue
            // 
            this.lblSWValue.AutoSize = true;
            this.lblSWValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSWValue.Location = new System.Drawing.Point(226, 248);
            this.lblSWValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSWValue.Name = "lblSWValue";
            this.lblSWValue.Size = new System.Drawing.Size(19, 21);
            this.lblSWValue.TabIndex = 48;
            this.lblSWValue.Text = "0";
            // 
            // lblBHDValue
            // 
            this.lblBHDValue.AutoSize = true;
            this.lblBHDValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBHDValue.Location = new System.Drawing.Point(227, 198);
            this.lblBHDValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBHDValue.Name = "lblBHDValue";
            this.lblBHDValue.Size = new System.Drawing.Size(19, 21);
            this.lblBHDValue.TabIndex = 47;
            this.lblBHDValue.Text = "0";
            // 
            // lblDBDValue
            // 
            this.lblDBDValue.AutoSize = true;
            this.lblDBDValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDBDValue.Location = new System.Drawing.Point(227, 151);
            this.lblDBDValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDBDValue.Name = "lblDBDValue";
            this.lblDBDValue.Size = new System.Drawing.Size(19, 21);
            this.lblDBDValue.TabIndex = 46;
            this.lblDBDValue.Text = "0";
            // 
            // lblLDValue
            // 
            this.lblLDValue.AutoSize = true;
            this.lblLDValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLDValue.Location = new System.Drawing.Point(227, 103);
            this.lblLDValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLDValue.Name = "lblLDValue";
            this.lblLDValue.Size = new System.Drawing.Size(19, 21);
            this.lblLDValue.TabIndex = 45;
            this.lblLDValue.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(50, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "色   温";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(50, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "饱和度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(49, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "对比度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "亮   度";
            // 
            // FormImgEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1246, 744);
            this.Controls.Add(this.uigbxFilter);
            this.Controls.Add(this.uitkbSW);
            this.Controls.Add(this.uitkbBHD);
            this.Controls.Add(this.uitkbDBD);
            this.Controls.Add(this.uitkbLD);
            this.Controls.Add(this.lblSWValue);
            this.Controls.Add(this.lblBHDValue);
            this.Controls.Add(this.lblDBDValue);
            this.Controls.Add(this.lblLDValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiPanelImg);
            this.Controls.Add(this.uitkbESize);
            this.Controls.Add(this.uibtnFlip);
            this.Controls.Add(this.uibtnRotationR);
            this.Controls.Add(this.uibtnRotationL);
            this.Controls.Add(this.uibtnESelfAdp);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.uiPanelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormImgEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片编辑器";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.uiPanelBottom.ResumeLayout(false);
            this.uiPanelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            this.uiPanelImg.ResumeLayout(false);
            this.uigbxFilter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblESizeValue;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemResize;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUndo;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveAs;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRedo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRZoomIn;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRZoomOut;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRSelfAdp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRSave;
        private Sunny.UI.UIButton uibtnESelfAdp;
        private Sunny.UI.UIButton uibtnRotationL;
        private Sunny.UI.UIButton uibtnRotationR;
        private Sunny.UI.UIButton uibtnFlip;
        private Sunny.UI.UITrackBar uitkbESize;
        private Sunny.UI.UIPanel uiPanelBottom;
        private System.Windows.Forms.PictureBox pbxImg;
        private Sunny.UI.UIPanel uiPanelImg;
        private Sunny.UI.UIGroupBox uigbxFilter;
        private Sunny.UI.UIRadioButton uirbtJM;
        private Sunny.UI.UIRadioButton uirbtMH;
        private Sunny.UI.UIRadioButton uirbtQC;
        private Sunny.UI.UIRadioButton uirbtFD;
        private Sunny.UI.UIRadioButton uirbtZR;
        private Sunny.UI.UIRadioButton uirbtHB;
        private Sunny.UI.UITrackBar uitkbSW;
        private Sunny.UI.UITrackBar uitkbBHD;
        private Sunny.UI.UITrackBar uitkbDBD;
        private Sunny.UI.UITrackBar uitkbLD;
        private System.Windows.Forms.Label lblSWValue;
        private System.Windows.Forms.Label lblBHDValue;
        private System.Windows.Forms.Label lblDBDValue;
        private System.Windows.Forms.Label lblLDValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

