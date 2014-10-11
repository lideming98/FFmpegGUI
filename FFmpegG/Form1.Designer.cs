namespace FFmpegG
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBoxADD = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxCMD = new System.Windows.Forms.TextBox();
            this.contextMenuStripCMD = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清除CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripCMD.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button3
            // 
            this.Button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button3.Location = new System.Drawing.Point(73, 200);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(64, 22);
            this.Button3.TabIndex = 14;
            this.Button3.Text = "清除";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button2.Location = new System.Drawing.Point(3, 200);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(64, 22);
            this.Button2.TabIndex = 13;
            this.Button2.Text = "启动!";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 233);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(41, 12);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "输出 :";
            // 
            // Button1
            // 
            this.Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button1.Location = new System.Drawing.Point(392, 228);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(39, 22);
            this.Button1.TabIndex = 11;
            this.Button1.Text = "...";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(437, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 21);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = ".mp4";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            this.contextMenuStrip1.Text = "删除(&D)";
            // 
            // ToolStripMenuItemDel
            // 
            this.ToolStripMenuItemDel.Name = "ToolStripMenuItemDel";
            this.ToolStripMenuItemDel.Size = new System.Drawing.Size(92, 22);
            this.ToolStripMenuItemDel.Text = "移除(&D)";
            this.ToolStripMenuItemDel.Click += new System.EventHandler(this.ToolStripMenuItemDel_Click);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FilePath,
            this.Status,
            this.FileName});
            this.tableLayoutPanel1.SetColumnSpan(this.listView1, 5);
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(473, 191);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // FilePath
            // 
            this.FilePath.DisplayIndex = 2;
            this.FilePath.Text = "完整路径";
            this.FilePath.Width = 400;
            // 
            // Status
            // 
            this.Status.DisplayIndex = 0;
            this.Status.Text = "状态";
            this.Status.Width = 50;
            // 
            // FileName
            // 
            this.FileName.DisplayIndex = 1;
            this.FileName.Text = "文件名";
            this.FileName.Width = 300;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(437, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 22);
            this.button4.TabIndex = 21;
            this.button4.Text = "打开";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxADD, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 253);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // TextBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TextBox1, 2);
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox1.Location = new System.Drawing.Point(73, 228);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(313, 21);
            this.TextBox1.TabIndex = 10;
            // 
            // TextBoxADD
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TextBoxADD, 2);
            this.TextBoxADD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxADD.FormattingEnabled = true;
            this.TextBoxADD.Items.AddRange(new object[] {
            "-crf 23 -acodec copy",
            "-s 960x540 -crf 30 -ab 92k",
            "-vn -ab 256k"});
            this.TextBoxADD.Location = new System.Drawing.Point(143, 200);
            this.TextBoxADD.Name = "TextBoxADD";
            this.TextBoxADD.Size = new System.Drawing.Size(288, 20);
            this.TextBoxADD.TabIndex = 22;
            this.TextBoxADD.Text = "-crf 23 -acodec copy";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1MinSize = 120;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCMD);
            this.splitContainer1.Size = new System.Drawing.Size(479, 344);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 23;
            // 
            // textBoxCMD
            // 
            this.textBoxCMD.BackColor = System.Drawing.Color.Black;
            this.textBoxCMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCMD.ContextMenuStrip = this.contextMenuStripCMD;
            this.textBoxCMD.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxCMD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCMD.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCMD.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxCMD.Location = new System.Drawing.Point(0, 0);
            this.textBoxCMD.MaxLength = 0;
            this.textBoxCMD.Multiline = true;
            this.textBoxCMD.Name = "textBoxCMD";
            this.textBoxCMD.ReadOnly = true;
            this.textBoxCMD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCMD.Size = new System.Drawing.Size(479, 85);
            this.textBoxCMD.TabIndex = 0;
            this.textBoxCMD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCMD_KeyPress);
            // 
            // contextMenuStripCMD
            // 
            this.contextMenuStripCMD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清除CToolStripMenuItem});
            this.contextMenuStripCMD.Name = "contextMenuStripCMD";
            this.contextMenuStripCMD.Size = new System.Drawing.Size(117, 26);
            // 
            // 清除CToolStripMenuItem
            // 
            this.清除CToolStripMenuItem.Name = "清除CToolStripMenuItem";
            this.清除CToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.清除CToolStripMenuItem.Text = "清除(&C)";
            this.清除CToolStripMenuItem.Click += new System.EventHandler(this.清除CToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 352);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(500, 260);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFmpegG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripCMD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FilePath;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.ComboBox TextBoxADD;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxCMD;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCMD;
        private System.Windows.Forms.ToolStripMenuItem 清除CToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader FileName;
    }
}

