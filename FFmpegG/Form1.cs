using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace FFmpegG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            CreateOrReadADD();
            TextBox1.Text = Properties.Settings.Default.LastOutPath;
        }
        private void CreateOrReadADD() //创建、读取配置文件
        {
            FileStream fs = new FileStream("ADD.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            if (fs.Length == 0)//如果文件为空
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(@"-crf 23 -acodec copy
-s 960x540 -crf 30 -ab 92k
-vn -ab 256k");
                sw.Close();
            }
            else
            {
                TextBoxADD.Items.Clear();
                StreamReader sr = new StreamReader(fs);
                int i = 0;
                do
                {
                    i++;
                    string line = sr.ReadLine();
                    if (i == 1)
                    {//显示第一行

                        TextBoxADD.Items.Add(line);
                        TextBoxADD.Text = line;
                    }
                    else
                    {
                        TextBoxADD.Items.Add(line);
                    }

                } while (!sr.EndOfStream);
            }
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }

        }
        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Array files = (Array)e.Data.GetData(DataFormats.FileDrop);
                listView1.BeginUpdate();//ListView.ListViewItemCollection additems = new ListView.ListViewItemCollection(listView1);
                foreach (String s in files)
                {
                    if (File.Exists(s))
                    {
                        ListViewItem item = listView1.Items.Add(s);
                        item.SubItems.Add("未处理");
                        item.SubItems.Add(Path.GetFileName(s));
                    }
                }
            }
            finally
            {
                listView1.EndUpdate();//listView1.Items.AddRange(additems);
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                TextBox1.Text = fd.SelectedPath;
            }
        }

        private void Button2_Click(object sender, EventArgs e) //启动按钮 点击
        {
            if (running)
            {
                Stop(); return;
            }
            if (listView1.Items.Count < 1) //检测文件列表是否为空
            {
                MessageBox.Show("请先添加文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Directory.Exists(TextBox1.Text))
            {
                //MessageBox.Show("文件夹路径无效", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                try
                {
                    Directory.CreateDirectory(TextBox1.Text);
                }
                catch (Exception err)
                {
                    MessageBox.Show("输出路径无效。创建文件夹失败：\n" + err.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            NowOutfold = Path.GetDirectoryName(TextBox1.Text);
            NowFiles = listView1.Items;
            th = new Thread(run);
            th.Start();
            Button2.Text = "终止";

            Properties.Settings.Default.LastOutPath = NowOutfold;
        }
        bool running = false;
        bool stopping = false;
        Process pr;
        Thread th;
        ListView.ListViewItemCollection NowFiles;
        string NowOutfold;
        private void run()
        {
            if (running)
                return;
            running = true;
            //this.Text = "FFmpegG 运行中:" + running;
            //string CMD=null;
            foreach (ListViewItem item in NowFiles)
            {
                string i = item.SubItems[0].Text;
                string p = "-i \"" + i + "\"" + " " + TextBoxADD.Text + " \"" + NowOutfold + "\\" + Path.GetFileNameWithoutExtension(i) + textBox2.Text + "\"";
                pr = new System.Diagnostics.Process();
                item.SubItems[1].Text = "运行中";
                item.BackColor = Color.Cyan;
                listView1.EndUpdate();
                pr.StartInfo.FileName = "ffmpeg.exe";
                pr.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
                pr.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
                pr.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
                pr.StartInfo.RedirectStandardError = true;//重定向标准错误输出
                pr.StartInfo.CreateNoWindow = true;//不显示程序窗口
                //pr.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                pr.StartInfo.Arguments = p;
                pr.OutputDataReceived += new DataReceivedEventHandler(LineOutputGeted);
                pr.ErrorDataReceived += new DataReceivedEventHandler(LineOutputGeted);
                pr.Start();//启动程序
                pr.BeginOutputReadLine();
                pr.BeginErrorReadLine();
                pr.WaitForExit();
                //break;
                //pr.BeginOutputReadLine();
                //while (!prreader.EndOfStream)
                //{
                //    Text= prreader.ReadLine();
                //}

                listView1.BeginUpdate();
                if (stopping)//更新列表状态显示信息
                {
                    stopping = false;
                    item.SubItems[1].Text = "用户中断";
                    item.BackColor = Color.LightBlue;
                    break;
                }
                if (pr.ExitCode == 0)
                {
                    item.SubItems[1].Text = "结束";
                    item.BackColor = Color.LightGreen;
                }
                else
                {
                    item.SubItems[1].Text = "错误";
                    item.BackColor = Color.Yellow;
                }
            }
            listView1.EndUpdate();
            pr.Close();
            running = false;
            Button2.Text = "启动!";
            Text = "FFmpegG";
        }
        void Stop()
        {
            if (running)
            {
                if (MessageBox.Show(null, "确认要停止？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    //th.Abort();//杀死任务执行线程
                    if (pr.Id != 0)//判断ffmpeg是否运行中
                    {
                        //pr.Kill();//杀死ffmpeg程序
                        stopping = true;//设置停止状态
                        pr.StandardInput.Write("q");//发送q按键，正常结束编码进程
                        pr.WaitForExit(5000);//等待5秒
                        if (!pr.HasExited)//如果未退出
                        {
                            if (MessageBox.Show(null, "停止失败，是否强制杀死？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)//询问
                            {
                                pr.Kill();//强制结束
                            }
                        }
                    }
                }
                return;
            }
        }
        void LineOutputGeted(object sendingProcess,
    DataReceivedEventArgs outLine)
        {
            //if (!String.IsNullOrEmpty(outLine.Data))
            //{
            //    //Text = outLine.Data;

            //}
            Text = outLine.Data;
            textBoxCMD.AppendText(Text + "\n");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", TextBox1.Text);
        }

        private void ToolStripMenuItemDel_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listView1.SelectedItems)
            {
                i.Remove();
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && this.listView1.SelectedItems.Count > 0)
            {
                this.contextMenuStrip1.Show(this, e.Location);
            }
        }

        private void 清除CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxCMD.Clear();
        }

        private void textBoxCMD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (running && !pr.HasExited)
            {

                pr.StandardInput.Write(e.KeyChar);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (running)
            {
                if (MessageBox.Show(null, "FFmpeg正在运行，确认退出？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Stop();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            Properties.Settings.Default.Save();
        }


        //[DllImport("ntdll.dll")]
        //public static extern uint NtSuspendProcess(int hProcess);
        //[DllImport("ntdll.dll")]
        //public static extern uint NtResumeProcess(int hProcess);

    }

}
