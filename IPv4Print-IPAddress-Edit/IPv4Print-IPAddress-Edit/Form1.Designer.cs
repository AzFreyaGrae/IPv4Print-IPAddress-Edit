namespace IPv4Print_IPAddress_Edit
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Print_IPAddress = new System.Windows.Forms.GroupBox();
            this.Title_02 = new System.Windows.Forms.Label();
            this.Title_01 = new System.Windows.Forms.Label();
            this.IPAddress_NEW = new System.Windows.Forms.TextBox();
            this.IPAddress_OLD = new System.Windows.Forms.TextBox();
            this.Install_Print = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转到ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找和替换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于IPv4PrintIPAddressEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Port = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Start_Edit = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Prot_out = new System.Windows.Forms.Label();
            this.IPout = new System.Windows.Forms.Label();
            this.Print_name = new System.Windows.Forms.Label();
            this.Test_Out = new System.Windows.Forms.GroupBox();
            this.Val01 = new System.Windows.Forms.Label();
            this.InputIP = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.MessageTile = new System.Windows.Forms.Label();
            this.MessageTile1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.Print_IPAddress.SuspendLayout();
            this.Install_Print.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Port.SuspendLayout();
            this.Test_Out.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Print_IPAddress
            // 
            this.Print_IPAddress.Controls.Add(this.Title_02);
            this.Print_IPAddress.Controls.Add(this.Title_01);
            this.Print_IPAddress.Controls.Add(this.IPAddress_NEW);
            this.Print_IPAddress.Controls.Add(this.IPAddress_OLD);
            this.Print_IPAddress.Location = new System.Drawing.Point(9, 333);
            this.Print_IPAddress.Margin = new System.Windows.Forms.Padding(2);
            this.Print_IPAddress.Name = "Print_IPAddress";
            this.Print_IPAddress.Padding = new System.Windows.Forms.Padding(2);
            this.Print_IPAddress.Size = new System.Drawing.Size(217, 92);
            this.Print_IPAddress.TabIndex = 1;
            this.Print_IPAddress.TabStop = false;
            this.Print_IPAddress.Text = "IPv4端口";
            // 
            // Title_02
            // 
            this.Title_02.AutoSize = true;
            this.Title_02.Location = new System.Drawing.Point(4, 58);
            this.Title_02.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title_02.Name = "Title_02";
            this.Title_02.Size = new System.Drawing.Size(101, 12);
            this.Title_02.TabIndex = 3;
            this.Title_02.Text = "设置 IPv4 地址：";
            // 
            // Title_01
            // 
            this.Title_01.AutoSize = true;
            this.Title_01.Location = new System.Drawing.Point(4, 27);
            this.Title_01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title_01.Name = "Title_01";
            this.Title_01.Size = new System.Drawing.Size(101, 12);
            this.Title_01.TabIndex = 2;
            this.Title_01.Text = "选择 IPv4 地址：";
            // 
            // IPAddress_NEW
            // 
            this.IPAddress_NEW.Location = new System.Drawing.Point(106, 55);
            this.IPAddress_NEW.Margin = new System.Windows.Forms.Padding(2);
            this.IPAddress_NEW.MaxLength = 15;
            this.IPAddress_NEW.Name = "IPAddress_NEW";
            this.IPAddress_NEW.Size = new System.Drawing.Size(102, 21);
            this.IPAddress_NEW.TabIndex = 0;
            this.IPAddress_NEW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.IPAddress_NEW, "输入新的打印机IPv4地址。");
            this.IPAddress_NEW.WordWrap = false;
            this.IPAddress_NEW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IPAddress_NEW_KeyPress);
            // 
            // IPAddress_OLD
            // 
            this.IPAddress_OLD.Cursor = System.Windows.Forms.Cursors.No;
            this.IPAddress_OLD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IPAddress_OLD.Location = new System.Drawing.Point(106, 25);
            this.IPAddress_OLD.Margin = new System.Windows.Forms.Padding(2);
            this.IPAddress_OLD.MaxLength = 15;
            this.IPAddress_OLD.Name = "IPAddress_OLD";
            this.IPAddress_OLD.ReadOnly = true;
            this.IPAddress_OLD.ShortcutsEnabled = false;
            this.IPAddress_OLD.Size = new System.Drawing.Size(102, 21);
            this.IPAddress_OLD.TabIndex = 10;
            this.IPAddress_OLD.TabStop = false;
            this.IPAddress_OLD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.IPAddress_OLD, "在上方列表中选择打印机名称或端口。");
            this.IPAddress_OLD.WordWrap = false;
            // 
            // Install_Print
            // 
            this.Install_Print.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Install_Print.Controls.Add(this.listBox1);
            this.Install_Print.Location = new System.Drawing.Point(9, 6);
            this.Install_Print.Margin = new System.Windows.Forms.Padding(2);
            this.Install_Print.Name = "Install_Print";
            this.Install_Print.Padding = new System.Windows.Forms.Padding(2);
            this.Install_Print.Size = new System.Drawing.Size(365, 295);
            this.Install_Print.TabIndex = 3;
            this.Install_Print.TabStop = false;
            this.Install_Print.Text = "已安装的打印机";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(4, 19);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(357, 268);
            this.listBox1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.listBox1, "选择打印机，窗口会自动同步对应端口。");
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            this.listBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(646, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "菜单";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.新建ToolStripMenuItem.Text = "打开设备和打印机";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.打开ToolStripMenuItem.Text = "重启打印机服务";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.转到ToolStripMenuItem,
            this.查找和替换ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "调试";
            // 
            // 转到ToolStripMenuItem
            // 
            this.转到ToolStripMenuItem.Name = "转到ToolStripMenuItem";
            this.转到ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.转到ToolStripMenuItem.Text = "软件 内部测试 01";
            this.转到ToolStripMenuItem.Click += new System.EventHandler(this.转到ToolStripMenuItem_Click);
            // 
            // 查找和替换ToolStripMenuItem
            // 
            this.查找和替换ToolStripMenuItem.Name = "查找和替换ToolStripMenuItem";
            this.查找和替换ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.查找和替换ToolStripMenuItem.Text = "软件 内部测试 02";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助ToolStripMenuItem,
            this.关于IPv4PrintIPAddressEditToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 查看帮助ToolStripMenuItem
            // 
            this.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
            this.查看帮助ToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.查看帮助ToolStripMenuItem.Text = "查看帮助";
            this.查看帮助ToolStripMenuItem.Click += new System.EventHandler(this.查看帮助ToolStripMenuItem_Click);
            // 
            // 关于IPv4PrintIPAddressEditToolStripMenuItem
            // 
            this.关于IPv4PrintIPAddressEditToolStripMenuItem.Name = "关于IPv4PrintIPAddressEditToolStripMenuItem";
            this.关于IPv4PrintIPAddressEditToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.关于IPv4PrintIPAddressEditToolStripMenuItem.Text = "关于 IPv4Print-IPAddress-Edit";
            this.关于IPv4PrintIPAddressEditToolStripMenuItem.Click += new System.EventHandler(this.关于IPv4PrintIPAddressEditToolStripMenuItem_Click);
            // 
            // Port
            // 
            this.Port.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Port.Controls.Add(this.listBox2);
            this.Port.Location = new System.Drawing.Point(2, 6);
            this.Port.Margin = new System.Windows.Forms.Padding(2);
            this.Port.Name = "Port";
            this.Port.Padding = new System.Windows.Forms.Padding(2);
            this.Port.Size = new System.Drawing.Size(255, 295);
            this.Port.TabIndex = 5;
            this.Port.TabStop = false;
            this.Port.Text = "端口";
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(4, 19);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(247, 268);
            this.listBox2.TabIndex = 3;
            this.toolTip1.SetToolTip(this.listBox2, "选择端口，窗口会自动同步对应打印机。");
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.ListBox2_SelectedIndexChanged);
            // 
            // Start_Edit
            // 
            this.Start_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_Edit.Location = new System.Drawing.Point(230, 368);
            this.Start_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.Start_Edit.Name = "Start_Edit";
            this.Start_Edit.Size = new System.Drawing.Size(88, 58);
            this.Start_Edit.TabIndex = 6;
            this.Start_Edit.Text = "修改";
            this.Start_Edit.UseVisualStyleBackColor = true;
            this.Start_Edit.Click += new System.EventHandler(this.Start_Edit_Click);
            // 
            // Refresh
            // 
            this.Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh.Location = new System.Drawing.Point(230, 338);
            this.Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(88, 25);
            this.Refresh.TabIndex = 7;
            this.Refresh.Text = "刷新列表";
            this.toolTip1.SetToolTip(this.Refresh, "刷新已安装打印机与端口列表。");
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Prot_out
            // 
            this.Prot_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Prot_out.Location = new System.Drawing.Point(4, 38);
            this.Prot_out.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Prot_out.Name = "Prot_out";
            this.Prot_out.Size = new System.Drawing.Size(219, 12);
            this.Prot_out.TabIndex = 8;
            this.Prot_out.Text = "未选择端   口";
            // 
            // IPout
            // 
            this.IPout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IPout.Location = new System.Drawing.Point(4, 60);
            this.IPout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IPout.Name = "IPout";
            this.IPout.Size = new System.Drawing.Size(219, 12);
            this.IPout.TabIndex = 9;
            this.IPout.Text = "未找到端   口";
            // 
            // Print_name
            // 
            this.Print_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Print_name.Location = new System.Drawing.Point(4, 17);
            this.Print_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Print_name.Name = "Print_name";
            this.Print_name.Size = new System.Drawing.Size(219, 12);
            this.Print_name.TabIndex = 10;
            this.Print_name.Text = "未选择打印机";
            // 
            // Test_Out
            // 
            this.Test_Out.Controls.Add(this.Val01);
            this.Test_Out.Controls.Add(this.InputIP);
            this.Test_Out.Controls.Add(this.Time);
            this.Test_Out.Controls.Add(this.Print_name);
            this.Test_Out.Controls.Add(this.IPout);
            this.Test_Out.Controls.Add(this.Prot_out);
            this.Test_Out.Location = new System.Drawing.Point(652, 25);
            this.Test_Out.Margin = new System.Windows.Forms.Padding(2);
            this.Test_Out.Name = "Test_Out";
            this.Test_Out.Padding = new System.Windows.Forms.Padding(2);
            this.Test_Out.Size = new System.Drawing.Size(228, 401);
            this.Test_Out.TabIndex = 11;
            this.Test_Out.TabStop = false;
            this.Test_Out.Text = "测试输出";
            // 
            // Val01
            // 
            this.Val01.BackColor = System.Drawing.Color.Yellow;
            this.Val01.Location = new System.Drawing.Point(4, 125);
            this.Val01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Val01.Name = "Val01";
            this.Val01.Size = new System.Drawing.Size(219, 12);
            this.Val01.TabIndex = 23;
            this.Val01.Text = "Val01 数据校验";
            // 
            // InputIP
            // 
            this.InputIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.InputIP.Location = new System.Drawing.Point(4, 105);
            this.InputIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InputIP.Name = "InputIP";
            this.InputIP.Size = new System.Drawing.Size(219, 12);
            this.InputIP.TabIndex = 22;
            this.InputIP.Text = "InputIP 输入的IP";
            // 
            // Time
            // 
            this.Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Time.Location = new System.Drawing.Point(4, 82);
            this.Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(219, 12);
            this.Time.TabIndex = 21;
            this.Time.Text = "Time 时间";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(440, 338);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "前往精确租赁官网获取更多设备最新信息。");
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label20.Location = new System.Drawing.Point(325, 345);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 12);
            this.label20.TabIndex = 20;
            this.label20.Text = "xxxxxxx中心------";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(327, 413);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(309, 12);
            this.progressBar1.TabIndex = 21;
            // 
            // MessageTile
            // 
            this.MessageTile.BackColor = System.Drawing.Color.Yellow;
            this.MessageTile.Location = new System.Drawing.Point(327, 396);
            this.MessageTile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MessageTile.Name = "MessageTile";
            this.MessageTile.Size = new System.Drawing.Size(309, 13);
            this.MessageTile.TabIndex = 22;
            this.MessageTile.Text = "运行信息：等待操作...";
            // 
            // MessageTile1
            // 
            this.MessageTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MessageTile1.Location = new System.Drawing.Point(327, 380);
            this.MessageTile1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MessageTile1.Name = "MessageTile1";
            this.MessageTile1.Size = new System.Drawing.Size(309, 13);
            this.MessageTile1.TabIndex = 23;
            this.MessageTile1.Text = "菜单信息：等待操作...";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Install_Print);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Port);
            this.splitContainer1.Size = new System.Drawing.Size(645, 303);
            this.splitContainer1.SplitterDistance = 376;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(327, 360);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "TEL: xxx-xxx-xxx";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(646, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MessageTile1);
            this.Controls.Add(this.MessageTile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Test_Out);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Start_Edit);
            this.Controls.Add(this.Print_IPAddress);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label20);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(907, 480);
            this.MinimumSize = new System.Drawing.Size(662, 480);
            this.Name = "Form1";
            this.Text = "Printer Port Editing V1.1 -3.5";
            this.Print_IPAddress.ResumeLayout(false);
            this.Print_IPAddress.PerformLayout();
            this.Install_Print.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Port.ResumeLayout(false);
            this.Test_Out.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Print_IPAddress;
        private System.Windows.Forms.GroupBox Install_Print;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 转到ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找和替换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于IPv4PrintIPAddressEditToolStripMenuItem;
        private System.Windows.Forms.GroupBox Port;
        private System.Windows.Forms.Button Start_Edit;
        private new System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label Title_02;
        private System.Windows.Forms.Label Title_01;
        private System.Windows.Forms.TextBox IPAddress_NEW;
        private System.Windows.Forms.TextBox IPAddress_OLD;
        private System.Windows.Forms.Label Prot_out;
        private System.Windows.Forms.Label IPout;
        private System.Windows.Forms.GroupBox Test_Out;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label InputIP;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label MessageTile;
        private System.Windows.Forms.Label MessageTile1;
        private System.Windows.Forms.Label Print_name;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label Val01;
        private System.Windows.Forms.Label label1;
    }
}

