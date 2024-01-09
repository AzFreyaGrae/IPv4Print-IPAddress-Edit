using System;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ServiceProcess;
using Microsoft.Win32;
using System.Net;
using System.Threading;
using System.Net.NetworkInformation;
using System.ComponentModel;

namespace IPv4Print_IPAddress_Edit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            StartPrintService(); //启动打印服务
            InitializeComponent(); //初始化窗口
            GetPrinterInfo(); //获取本地打印机
            TimeOn(); //首次运行时间 - 随设置刷新
            progressBar1.Minimum = 0; //设置进度条最小值
            progressBar1.Maximum = 8; //设置进度条最大值
            progressBar1.Value = 0; //初始值0
        }

        // 刷新 ListBox1 & ListBox2 列表内容
        private void GetPrinterInfo()
        {
            // 清空列表框
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            // 创建一个 ManagementObjectSearcher 对象，用于执行 WMI 查询
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Printer");

            // 遍历查询结果
            foreach (ManagementObject printer in searcher.Get())
            {
                // 将打印机名称添加到 listbox1
                listBox1.Items.Add(printer["Name"]);

                // 将打印机端口添加到 listbox2
                listBox2.Items.Add(printer["PortName"]);
            }
        }

        // ListBox1 窗口同步选项
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 当用户选择 listBox1 中的项时，同步更新 listBox2 的选中项
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < listBox2.Items.Count)
            {
                listBox2.SelectedIndex = selectedIndex;
                Prot_out.Text = listBox2.Items[selectedIndex].ToString();
                Print_name.Text = listBox1.Items[selectedIndex].ToString();
                
                // 提取IP地址并输出到 IPout.Text
                string ipAddress = ExtractIpAddress(Prot_out.Text);
                IPout.Text = ipAddress;
            }
            if (IPout.Text == "未找到端   口")
            {
                IPAddress_OLD.Text = "";
                TimeOn();
            }
            else if (IPout.Text != "未找到端   口")
            {
                IPAddress_OLD.Text = IPout.Text;
                TimeOn();
            }
        }

        // ListBox2 窗口同步选项
        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 当用户选择 listBox2 中的项时，同步更新 listBox1 的选中项
            int selectedIndex = listBox2.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < listBox1.Items.Count)
            {
                listBox1.SelectedIndex = selectedIndex;
                Prot_out.Text = listBox2.Items[selectedIndex].ToString();
                Print_name.Text = listBox1.Items[selectedIndex].ToString();
            }
            if (IPout.Text == "未找到端   口")
            {
                IPAddress_OLD.Text = "";
                TimeOn();
            }
            else if (IPout.Text != "未找到端   口")
            {
                IPAddress_OLD.Text = IPout.Text;
                TimeOn();
            }
        }

        // ListBox2 IP端口 筛选
        private string ExtractIpAddress(string input)
        {
            string pattern = @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}";
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                return match.Value;
            }
            else
            {
                return "无效的IPv4地址。";
            }
            
        }

        // 模块功能 - 重启打印机服务
        private void RestartPrintService()
        {
            string serviceName = "Spooler"; // 打印机服务的服务名称

            try
            {
                ServiceController sc = new ServiceController(serviceName);

                if (sc.Status == ServiceControllerStatus.Running)
                {
                    var bw = new BackgroundWorker();
                    bw.DoWork += (sender, e) =>
                    {
                        // 停止打印机服务
                        sc.Stop();
                        sc.WaitForStatus(ServiceControllerStatus.Stopped);
                        System.Threading.Thread.Sleep(1000); // 延时1秒

                        // 启动打印机服务
                        sc.Start();
                        sc.WaitForStatus(ServiceControllerStatus.Running);

                        // 在UI线程上更新消息并添加延时
                        this.Invoke((Action)(() =>
                        {
                            MessageTile1.Text = "菜单信息：打印机服务已停止...";
                        }));
                        System.Threading.Thread.Sleep(1000); // 延时1秒
                        this.Invoke((Action)(() =>
                        {
                            MessageTile1.Text = "菜单信息：打印机服务已启动...";
                            GetPrinterInfo(); //刷新列表信息
                            Refresh.Enabled = true; //打开刷新按钮
                            Start_Edit.Enabled = true; //打开执行按钮
                            IPAddress_OLD.Clear(); //清空打印机 地址按钮
                            IPAddress_NEW.Clear(); //清空输入的 地址按钮
                        }));
                    };

                    bw.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("打印机服务当前未运行，无需重启.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常: " + ex.Message);
            }
            
        }

        // 模块功能 - 启动打印机服务
        private void StartPrintService()
        {
            ServiceController service = new ServiceController("Spooler");

            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(5000);

                if (service.Status == ServiceControllerStatus.Stopped || service.Status == ServiceControllerStatus.StopPending)
                {
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                }
            }
            catch (Exception e)
            {
                // Handle exceptions here.
                Console.WriteLine(e.Message);
            }
        }

        // 模块功能 - 清除 端口 注册表项
        private void DeleteRegistryKey()
        {
            string keyPath = @"SYSTEM\CurrentControlSet\Control\Print\Monitors\Standard TCP/IP Port\Ports\" + IPAddress_NEW.Text;
            RegistryKey baseKey = Registry.LocalMachine;
            RegistryKey subKey = baseKey.OpenSubKey(keyPath, true);

            if (subKey != null)
            {
                baseKey.DeleteSubKeyTree(keyPath);
                this.Invoke((MethodInvoker)delegate
                {
                    MessageTile.Text = "运行信息：注册表项更新成功...";
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    MessageTile.Text = "运行信息：注册表项数据未找到...";
                });
            }

            baseKey.Close();
        }

        // 模块功能 - 更新 打印机 注册表项
        private void AddRegistrySubKey()
        {
            // 注册表项路径
            string keyPath1 = @"SYSTEM\CurrentControlSet\Control\Print\Printers\" + Print_name.Text;
            string keyPath2 = @"SYSTEM\CurrentControlSet\Control\Print\Printers\" + Print_name.Text + "\\DsSpooler";
            string keyPath3 = @"SYSTEM\CurrentControlSet\Control\Print\Printers\" + Print_name.Text + "\\PrinterDriverData";
            try
            {
                // 创建或打开注册表基项
                RegistryKey baseKey = Registry.LocalMachine;

                // 设置键值
                baseKey.CreateSubKey(keyPath1)?.SetValue("Port","IP_" + IPAddress_NEW.Text + "_10");
                baseKey.CreateSubKey(keyPath2)?.SetValue("portName", "IP_" + IPAddress_NEW.Text + "_10");
                baseKey.CreateSubKey(keyPath3)?.SetValue("IPAddress",IPAddress_NEW.Text);

                baseKey.Close();

                Console.WriteLine("运行信息：端口添加成功...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("发生异常: " + ex.Message);
            }
        }

        // 模块功能 - 添加 端口 注册表项
        private void AddSpecificSubKeys01()
        {
            try
            {
                // 打开指定的注册表路径
                RegistryKey baseKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\ControlSet001\Control\Print\Monitors\Standard TCP/IP Port\Ports\", true);
                if (baseKey != null)
                {
                    // 添加新的项，假设textBox1.Text包含了你想要的项的名称
                    baseKey.CreateSubKey(IPAddress_NEW.Text);

                    // 关闭基础项
                    baseKey.Close();
                }
            }
            catch (Exception ex)
            {
                // 异常处理
                Console.WriteLine("An error occurred: {0}", ex.Message);
            }
        }

        // 模块功能 - 添加 端口 注册表键001
        private void AddRegeditSubKeys02()
        {
            try
            {
                string keyPath = @"SYSTEM\ControlSet001\Control\Print\Monitors\Standard TCP/IP Port\Ports\" + "IP_" + IPAddress_NEW.Text + "_10";
                RegistryKey key = Registry.LocalMachine.CreateSubKey(keyPath);

                if (key != null)
                {
                    // 创建并设置 REG_SZ 类型的键值
                    key.SetValue("HostName", IPAddress_NEW.Text, RegistryValueKind.String);
                    key.SetValue("HWAddress", "", RegistryValueKind.String);
                    key.SetValue("IPAddress", "", RegistryValueKind.String);
                    key.SetValue("SNMP Community", "public", RegistryValueKind.String);
                    key.SetValue("Queue", "print", RegistryValueKind.String);

                    // 创建并设置 REG_DWORD 类型的键值
                    key.SetValue("Double Spool", 0, RegistryValueKind.DWord);
                    key.SetValue("PortMonMibPortIndex", 0, RegistryValueKind.DWord);
                    key.SetValue("PortNumber", 9100, RegistryValueKind.DWord);
                    key.SetValue("Protocol", 1, RegistryValueKind.DWord);
                    key.SetValue("SNMP Enabled", 1, RegistryValueKind.DWord);
                    key.SetValue("SNMP Index", 1, RegistryValueKind.DWord);
                    key.SetValue("Version", 2, RegistryValueKind.DWord);

                    // 关闭主键
                    key.Close();
                }
            }
            catch (Exception ex)
            {
                // 异常处理
                Console.WriteLine("An error occurred: {0}", ex.Message);
            }
        }

        // 模块功能 - 添加 端口 注册表项
        private void AddSpecificSubKeys1()
        {
            try
            {
                // 打开指定的注册表路径
                RegistryKey baseKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Print\Monitors\Standard TCP/IP Port\Ports\", true);
                if (baseKey != null)
                {
                    // 添加新的项，假设textBox1.Text包含了你想要的项的名称
                    baseKey.CreateSubKey(IPAddress_NEW.Text);

                    // 关闭基础项
                    baseKey.Close();
                }
            }
            catch (Exception ex)
            {
                // 异常处理
                Console.WriteLine("An error occurred: {0}", ex.Message);
            }
        }

        // 模块功能 - 添加 端口 注册表键001
        private void AddRegeditSubKeys2()
        {
            try
            {
                string keyPath = @"SYSTEM\CurrentControlSet\Control\Print\Monitors\Standard TCP/IP Port\Ports\" + "IP_" + IPAddress_NEW.Text + "_10";
                RegistryKey key = Registry.LocalMachine.CreateSubKey(keyPath);

                if (key != null)
                {
                    // 创建并设置 REG_SZ 类型的键值
                    key.SetValue("HostName", IPAddress_NEW.Text, RegistryValueKind.String);
                    key.SetValue("HWAddress", "", RegistryValueKind.String);
                    key.SetValue("IPAddress", "", RegistryValueKind.String);
                    key.SetValue("SNMP Community", "public", RegistryValueKind.String);
                    key.SetValue("Queue", "print", RegistryValueKind.String);

                    // 创建并设置 REG_DWORD 类型的键值
                    key.SetValue("Double Spool", 0, RegistryValueKind.DWord);
                    key.SetValue("PortMonMibPortIndex", 0, RegistryValueKind.DWord);
                    key.SetValue("PortNumber", 9100, RegistryValueKind.DWord);
                    key.SetValue("Protocol", 1, RegistryValueKind.DWord);
                    key.SetValue("SNMP Enabled", 1, RegistryValueKind.DWord);
                    key.SetValue("SNMP Index", 1, RegistryValueKind.DWord);
                    key.SetValue("Version", 2, RegistryValueKind.DWord);

                    // 关闭主键
                    key.Close();
                }
            }
            catch (Exception ex)
            {
                // 异常处理
                Console.WriteLine("An error occurred: {0}", ex.Message);
            }
        }

        // 执行按钮 - 初始化确定数据
        private void Start_Edit_Click(object sender, EventArgs e)
        {
            Refresh.Enabled = false;
            Start_Edit.Enabled = false;
            if (IPAddress_NEW.Text == IPAddress_OLD.Text)
            {
                MessageBox.Show(" - 选择的打印机IPv4与修改的地址相同！", " - 设置 IPAddress Warning - ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Refresh.Enabled = true;
                Start_Edit.Enabled = true;
                IPAddress_NEW.Clear();
            }
            else
            {
                Test_IPAddress_NEW();
                if (Val01.Text == "1")
                {
                    // 创建一个 BackgroundWorker 实例
                    BackgroundWorker bw = new BackgroundWorker
                    {
                        // 设置 BackgroundWorker 可以报告进度和支持异步取消操作
                        WorkerReportsProgress = true,
                        WorkerSupportsCancellation = true
                    };

                    // 添加 DoWork 事件处理程序，其中包含要在后台执行的操作
                    bw.DoWork += (sender1, e1) =>
                    {
                        DeleteRegistryKey();  // 清除注册端口
                        bw.ReportProgress(1, "运行信息：清除注册端口...");
                        System.Threading.Thread.Sleep(1000); // 延时1秒

                        AddSpecificSubKeys01(); // 添加注册表项
                        bw.ReportProgress(2, "运行信息：添加注册表项...");
                        System.Threading.Thread.Sleep(1000); // 延时1秒

                        AddSpecificSubKeys1(); // 添加注册表项
                        bw.ReportProgress(3, "运行信息：添加注册表项...");
                        System.Threading.Thread.Sleep(1000); // 延时1秒

                        AddRegeditSubKeys02();  // 添加注册表键
                        bw.ReportProgress(4, "运行信息：添加注册表键...");
                        System.Threading.Thread.Sleep(1000); // 延时1秒

                        AddRegeditSubKeys2();  // 添加注册表键
                        bw.ReportProgress(5, "运行信息：添加注册表键...");
                        System.Threading.Thread.Sleep(1000); // 延时1秒

                        AddRegistrySubKey();  // 更新打印端口
                        bw.ReportProgress(6, "运行信息：更新打印端口...");
                        System.Threading.Thread.Sleep(1000); // 延时1秒

                        RestartPrintService();// 重启打印服务
                        bw.ReportProgress(7, "运行信息：重启打印服务...");
                        System.Threading.Thread.Sleep(1000); // 延时1秒
                        
                        bw.ReportProgress(8, "运行信息：已修改完成...");
                        System.Threading.Thread.Sleep(1000); // 延时1秒
                    };

                    // 添加 ProgressChanged 事件处理程序，其中包含要在报告进度时执行的操作
                    bw.ProgressChanged += (sender2, e2) =>
                    {
                        progressBar1.Value = e2.ProgressPercentage;
                        MessageTile.Text = e2.UserState.ToString();
                    };

                    // 启动 BackgroundWorker
                    bw.RunWorkerAsync();
                }
            }
        }

        // 模块功能 - 刷新列表
        private void Refresh_Click(object sender, EventArgs e)
        {
            GetPrinterInfo();
        }

        // 帮助选项 - 查看帮助
        private void 查看帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" - 1.选择需要修改的打印机。" + "\n" + " - 2.填写新的IP地址。" + "\n" + " - 3.点击修改。", " - 使用帮助 - ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 帮助选项 - 关于 IPv4Print_IPAddress_Edit
        private void 关于IPv4PrintIPAddressEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" - 本软件仅可修改已安装打印机的IPv4地址。" + "\n" + " - 软件是为了在更换打印机IPv4地址后，快速便捷的修改本地电脑打印机IPv4地址。", " - 关于 IPv4Print IPAddress Edit - ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 模块功能 - IPAddress_NEW 输入规范
        private void IPAddress_NEW_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允许输入数字和.
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }
        }

        // 模块功能 - IPAddress_NEW 规范检查 01
        private void Test_IPAddress_NEW()
        {
            string ipAddressString = IPAddress_NEW.Text;
            if (IsIPv4Address(ipAddressString))
            {
                InputIP.Text = IPAddress_NEW.Text;
                Val01.Text = "1";
            }
            else
            {
                InputIP.Text = "不是一个有效的 IP 地址";
                IPAddress_NEW.Text = "";
                MessageBox.Show(" -  未输入 IPv4 地址\n" + " - " + ipAddressString + " 输入的 IPv4 地址不是有效的\n" + " -  请重新输入 IPv4 地址", " - 设置 IPAddress Error - ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Refresh.Enabled = true;
                Start_Edit.Enabled = true;
                IPAddress_NEW.Clear();
                Val01.Text = "0";
            }
        }

        // 模块功能 - IPAddress_NEW 规范检查 02
        private bool IsIPv4Address(string input)
        {
            string ipv4Pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            return Regex.IsMatch(input, ipv4Pattern);
        }

        // 触发事件 - LOGO跳转网页
        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                string url = "https://www.baidu.com/";
                Process.Start(url);
            }
        }

        // 模块功能 - 获取当前时间
        private void TimeOn()
        {
            DateTime currentTime = DateTime.Now;
            string timeText = currentTime.ToString();

            Time.Text = timeText;
        }

        // 模块功能 - Ping选中的打印机
        private void TestPing_Click(object sender, EventArgs e)
        {
            string ipAddress = IPout.Text;

            // 检查是否是有效的IP地址
            if (!IPAddress.TryParse(ipAddress, out IPAddress ip))
            {
                MessageBox.Show(Print_name.Text + ipAddress + " 不是一个有效的IP地址", " - 测试 SelectPrint IPAddress -", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Ping pingSender = new Ping();
            PingReply reply = pingSender.Send(ipAddress);

            if (reply.Status == IPStatus.Success)
            {
                MessageBox.Show(Print_name.Text + "  " + ipAddress + " 可以连接", " - 测试 SelectPrint IPAddress -", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Print_name.Text + "  " + ipAddress + " 无法连接", " - 测试 SelectPrint IPAddress -", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 调试选项 - 内部测试 01
        private void 转到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeOn();
            MessageBox.Show(" - 当前选定的打印机："+ Print_name.Text + "\n" + " - 当前对应的端口名：" + Prot_out.Text + "\n" + " - 当前对应的端   口："+ IPout.Text + "\n" + " - 测试时间：" + Time.Text, " - 内部测试 01 - ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 菜单选项 - 打开设备的打印机
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("control", "printers");
        }

        // 菜单选项 - 重启打印机服务
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartPrintService();
        }

        // ListBox1 鼠标选中 事件 - 内容的操作
        private void ListBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // 如果是鼠标右键单击
            if (e.Button == MouseButtons.Right)
            {
                int index = listBox1.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    listBox1.SelectedIndex = index;
                    ContextMenu contextMenu = new ContextMenu();

                    MenuItem setDefaultMenuItem = new MenuItem("设置为默认打印机");
                    setDefaultMenuItem.Click += SetDefaultMenuItem_Click;
                    contextMenu.MenuItems.Add(setDefaultMenuItem);

                    MenuItem printTestPageMenuItem = new MenuItem("打印选中打印机的测试页");
                    printTestPageMenuItem.Click += PrintTestPageMenuItem_Click;
                    contextMenu.MenuItems.Add(printTestPageMenuItem);

                    MenuItem OpenPrintQueueMenuItem = new MenuItem("查看正在打印什么");
                    OpenPrintQueueMenuItem.Click += OpenPrintQueueMenuItem_Click;
                    contextMenu.MenuItems.Add(OpenPrintQueueMenuItem);
                    
                    MenuItem TestPingItem = new MenuItem("测试选中打印机的IP");
                    TestPingItem.Click += TestPing_Click; // 注意这里应该是TestPingItem.Click，而不是OpenPrintQueueMenuItem.Click
                    contextMenu.MenuItems.Add(TestPingItem);

                    contextMenu.Show(listBox1, e.Location);
                }
            }
        }
        
        // ListBox1 鼠标右键选项 - 打印测试页
        private void PrintTestPageMenuItem_Click(object sender, EventArgs e)
        {
            string printerName = listBox1.SelectedItem.ToString().Replace("->", "").Trim();
            ThreadPool.QueueUserWorkItem(_ =>
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Printer"))
                {
                    foreach (ManagementObject printer in searcher.Get())
                    {
                        if (printer["Name"].ToString() == printerName)
                        {
                            printer.InvokeMethod("PrintTestPage", null);
                            break;
                        }
                    }
                }
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show("测试页已发送到 [ " + printerName + " ] 打印机。", " - 发送 Print Test Page -", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            });
        }

        // ListBox1 鼠标右键选项 - 设置为默认打印机
        private void SetDefaultMenuItem_Click(object sender, EventArgs e)
        {
            string printerName = listBox1.SelectedItem.ToString().Replace("->", "").Trim();
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Printer"))
            {
                foreach (ManagementObject printer in searcher.Get())
                {
                    if (printer["Name"].ToString() == printerName)
                    {
                        printer.InvokeMethod("SetDefaultPrinter", null);
                        MessageBox.Show("已将 [ " + printerName + " ] 设置为默认打印机", " - 设置 DefaultPrint -", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
        }

        // ListBox1 鼠标右键选项 - 打开选中的打印队列
        private void OpenPrintQueueMenuItem_Click(object sender, EventArgs e)
        {
            string printerName = listBox1.SelectedItem.ToString().Replace("->", "").Trim();
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Printer"))
            {
                foreach (ManagementObject printer in searcher.Get())
                {
                    if (printer["Name"].ToString() == printerName)
                    {
                        ProcessStartInfo psi = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            Arguments = string.Format("/c rundll32 printui.dll,PrintUIEntry /o /n \"{0}\"", printerName),
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };
                        Process p = new Process
                        {
                            StartInfo = psi
                        };
                        p.Start();
                        Thread t = new Thread(() => p.WaitForExit())
                        {
                            IsBackground = true
                        };
                        t.Start();
                        break;
                    }
                }
            }
        }
    }
}
