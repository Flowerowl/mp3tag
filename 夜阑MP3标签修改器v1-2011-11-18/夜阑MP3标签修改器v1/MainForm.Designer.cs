/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/11/9
 * 时间: 15:05
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace 夜阑MP3标签修改器v1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.删除该项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.物理删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.删除全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.复制到ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.移动到ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBox21 = new System.Windows.Forms.TextBox();
			this.textBox20 = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.textBox19 = new System.Windows.Forms.TextBox();
			this.textBox18 = new System.Windows.Forms.TextBox();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			this.panel2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.AllowDrop = true;
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(6, 15);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(366, 580);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
			this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox1DragDrop);
			this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox1DragEnter);
			this.listBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.ListBox1DragOver);
			this.listBox1.DragLeave += new System.EventHandler(this.ListBox1DragLeave);
			this.listBox1.DoubleClick += new System.EventHandler(this.ListBox1DoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.删除该项ToolStripMenuItem,
									this.物理删除ToolStripMenuItem,
									this.删除全部ToolStripMenuItem,
									this.复制到ToolStripMenuItem,
									this.移动到ToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(153, 136);
			// 
			// 删除该项ToolStripMenuItem
			// 
			this.删除该项ToolStripMenuItem.Name = "删除该项ToolStripMenuItem";
			this.删除该项ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.删除该项ToolStripMenuItem.Text = "删除该项";
			this.删除该项ToolStripMenuItem.Click += new System.EventHandler(this.删除该项ToolStripMenuItemClick);
			// 
			// 物理删除ToolStripMenuItem
			// 
			this.物理删除ToolStripMenuItem.Name = "物理删除ToolStripMenuItem";
			this.物理删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.物理删除ToolStripMenuItem.Text = "物理删除";
			this.物理删除ToolStripMenuItem.Click += new System.EventHandler(this.物理删除ToolStripMenuItemClick);
			// 
			// 删除全部ToolStripMenuItem
			// 
			this.删除全部ToolStripMenuItem.Name = "删除全部ToolStripMenuItem";
			this.删除全部ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.删除全部ToolStripMenuItem.Text = "删除全部";
			this.删除全部ToolStripMenuItem.Click += new System.EventHandler(this.删除全部ToolStripMenuItemClick);
			// 
			// 复制到ToolStripMenuItem
			// 
			this.复制到ToolStripMenuItem.Name = "复制到ToolStripMenuItem";
			this.复制到ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.复制到ToolStripMenuItem.Text = "复制到...";
			this.复制到ToolStripMenuItem.Click += new System.EventHandler(this.复制到ToolStripMenuItemClick);
			// 
			// 移动到ToolStripMenuItem
			// 
			this.移动到ToolStripMenuItem.Name = "移动到ToolStripMenuItem";
			this.移动到ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.移动到ToolStripMenuItem.Text = "移动到...";
			this.移动到ToolStripMenuItem.Click += new System.EventHandler(this.移动到ToolStripMenuItemClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.progressBar1);
			this.groupBox1.Controls.Add(this.listBox1);
			this.groupBox1.Location = new System.Drawing.Point(2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(377, 610);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "歌曲列表";
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.progressBar1.Location = new System.Drawing.Point(6, 594);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.progressBar1.Size = new System.Drawing.Size(366, 10);
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar1.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Controls.Add(this.textBox12);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.textBox11);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.ForeColor = System.Drawing.Color.Black;
			this.groupBox2.Location = new System.Drawing.Point(380, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(271, 233);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "ID3V1";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(70, 154);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(198, 20);
			this.comboBox1.TabIndex = 14;
			// 
			// textBox12
			// 
			this.textBox12.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textBox12.Location = new System.Drawing.Point(191, 121);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(77, 21);
			this.textBox12.TabIndex = 13;
			// 
			// label12
			// 
			this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label12.Location = new System.Drawing.Point(157, 125);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(41, 23);
			this.label12.TabIndex = 12;
			this.label12.Text = "音轨：";
			// 
			// textBox11
			// 
			this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox11.Location = new System.Drawing.Point(70, 185);
			this.textBox11.Multiline = true;
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(198, 39);
			this.textBox11.TabIndex = 11;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(7, 188);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 23);
			this.label11.TabIndex = 10;
			this.label11.Text = "备注：";
			// 
			// textBox4
			// 
			this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox4.Location = new System.Drawing.Point(70, 121);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(85, 21);
			this.textBox4.TabIndex = 8;
			// 
			// textBox3
			// 
			this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox3.Location = new System.Drawing.Point(70, 89);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(198, 21);
			this.textBox3.TabIndex = 7;
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox2.Location = new System.Drawing.Point(70, 57);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(198, 21);
			this.textBox2.TabIndex = 6;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.textBox1.Location = new System.Drawing.Point(70, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(198, 21);
			this.textBox1.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(7, 156);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "风格：";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "年份：";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(5, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "专辑：";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "艺人：";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "歌名：";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.pictureBox1);
			this.groupBox3.Controls.Add(this.comboBox2);
			this.groupBox3.Controls.Add(this.textBox14);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.textBox13);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.textBox7);
			this.groupBox3.Controls.Add(this.textBox8);
			this.groupBox3.Controls.Add(this.textBox9);
			this.groupBox3.Controls.Add(this.textBox10);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Location = new System.Drawing.Point(380, 241);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(519, 275);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "ID3V2";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(277, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(231, 231);
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(68, 144);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(200, 20);
			this.comboBox2.TabIndex = 19;
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(68, 174);
			this.textBox14.Multiline = true;
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(200, 95);
			this.textBox14.TabIndex = 18;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(6, 177);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(58, 23);
			this.label14.TabIndex = 17;
			this.label14.Text = "备注：";
			// 
			// textBox13
			// 
			this.textBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox13.Location = new System.Drawing.Point(191, 113);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(77, 21);
			this.textBox13.TabIndex = 16;
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.Location = new System.Drawing.Point(153, 118);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(43, 23);
			this.label13.TabIndex = 15;
			this.label13.Text = "音轨：";
			// 
			// textBox7
			// 
			this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox7.Location = new System.Drawing.Point(68, 113);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(79, 21);
			this.textBox7.TabIndex = 13;
			// 
			// textBox8
			// 
			this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox8.Location = new System.Drawing.Point(68, 82);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(200, 21);
			this.textBox8.TabIndex = 12;
			// 
			// textBox9
			// 
			this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox9.Location = new System.Drawing.Point(68, 51);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(200, 21);
			this.textBox9.TabIndex = 11;
			// 
			// textBox10
			// 
			this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox10.Location = new System.Drawing.Point(69, 20);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(199, 21);
			this.textBox10.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(7, 147);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "风格：";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 118);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 23);
			this.label7.TabIndex = 8;
			this.label7.Text = "年份：";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(5, 85);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 23);
			this.label8.TabIndex = 7;
			this.label8.Text = "专辑：";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(5, 54);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(52, 23);
			this.label9.TabIndex = 6;
			this.label9.Text = "艺人：";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(6, 26);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 23);
			this.label10.TabIndex = 5;
			this.label10.Text = "歌名：";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
			this.panel1.Location = new System.Drawing.Point(385, 552);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(519, 54);
			this.panel1.TabIndex = 4;
			// 
			// axWindowsMediaPlayer1
			// 
			this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.axWindowsMediaPlayer1.Enabled = true;
			this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 3);
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
			this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(508, 48);
			this.axWindowsMediaPlayer1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.button9);
			this.panel2.Controls.Add(this.button8);
			this.panel2.Controls.Add(this.button7);
			this.panel2.Controls.Add(this.button6);
			this.panel2.Controls.Add(this.button5);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Location = new System.Drawing.Point(380, 517);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(508, 32);
			this.panel2.TabIndex = 5;
			// 
			// button9
			// 
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button9.Location = new System.Drawing.Point(448, 5);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(53, 27);
			this.button9.TabIndex = 8;
			this.button9.Text = "MORE<<";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button8
			// 
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button8.Location = new System.Drawing.Point(389, 5);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(53, 27);
			this.button8.TabIndex = 7;
			this.button8.Text = "V2->V1";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button7
			// 
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button7.Location = new System.Drawing.Point(330, 5);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(53, 27);
			this.button7.TabIndex = 6;
			this.button7.Text = "V1->V2";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button6
			// 
			this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button6.Location = new System.Drawing.Point(106, 5);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(43, 27);
			this.button6.TabIndex = 5;
			this.button6.Text = "SAVE";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button5
			// 
			this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.Location = new System.Drawing.Point(277, 5);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(47, 27);
			this.button5.TabIndex = 4;
			this.button5.Text = "—ALL";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button4
			// 
			this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Location = new System.Drawing.Point(216, 5);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(55, 27);
			this.button4.TabIndex = 3;
			this.button4.Text = "—ID3V2";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Location = new System.Drawing.Point(58, 5);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(42, 27);
			this.button3.TabIndex = 2;
			this.button3.Text = "DIR";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Location = new System.Drawing.Point(11, 5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(41, 27);
			this.button2.TabIndex = 1;
			this.button2.Text = "OPEN";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(155, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(55, 27);
			this.button1.TabIndex = 0;
			this.button1.Text = "—ID3V1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBox21);
			this.groupBox4.Controls.Add(this.textBox20);
			this.groupBox4.Controls.Add(this.label22);
			this.groupBox4.Controls.Add(this.textBox19);
			this.groupBox4.Controls.Add(this.textBox18);
			this.groupBox4.Controls.Add(this.textBox17);
			this.groupBox4.Controls.Add(this.textBox16);
			this.groupBox4.Controls.Add(this.textBox15);
			this.groupBox4.Controls.Add(this.textBox6);
			this.groupBox4.Controls.Add(this.textBox5);
			this.groupBox4.Controls.Add(this.label21);
			this.groupBox4.Controls.Add(this.label20);
			this.groupBox4.Controls.Add(this.label19);
			this.groupBox4.Controls.Add(this.label18);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Location = new System.Drawing.Point(657, 2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(242, 233);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "格式";
			// 
			// textBox21
			// 
			this.textBox21.Location = new System.Drawing.Point(44, 204);
			this.textBox21.Name = "textBox21";
			this.textBox21.ReadOnly = true;
			this.textBox21.Size = new System.Drawing.Size(187, 21);
			this.textBox21.TabIndex = 16;
			// 
			// textBox20
			// 
			this.textBox20.Location = new System.Drawing.Point(44, 178);
			this.textBox20.Name = "textBox20";
			this.textBox20.ReadOnly = true;
			this.textBox20.Size = new System.Drawing.Size(187, 21);
			this.textBox20.TabIndex = 15;
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(6, 207);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(41, 21);
			this.label22.TabIndex = 14;
			this.label22.Text = "近访：";
			// 
			// textBox19
			// 
			this.textBox19.Location = new System.Drawing.Point(44, 152);
			this.textBox19.Name = "textBox19";
			this.textBox19.ReadOnly = true;
			this.textBox19.Size = new System.Drawing.Size(187, 21);
			this.textBox19.TabIndex = 13;
			// 
			// textBox18
			// 
			this.textBox18.Location = new System.Drawing.Point(44, 126);
			this.textBox18.Name = "textBox18";
			this.textBox18.ReadOnly = true;
			this.textBox18.Size = new System.Drawing.Size(187, 21);
			this.textBox18.TabIndex = 12;
			// 
			// textBox17
			// 
			this.textBox17.Location = new System.Drawing.Point(44, 100);
			this.textBox17.Name = "textBox17";
			this.textBox17.ReadOnly = true;
			this.textBox17.Size = new System.Drawing.Size(187, 21);
			this.textBox17.TabIndex = 11;
			// 
			// textBox16
			// 
			this.textBox16.Location = new System.Drawing.Point(44, 74);
			this.textBox16.Name = "textBox16";
			this.textBox16.ReadOnly = true;
			this.textBox16.Size = new System.Drawing.Size(187, 21);
			this.textBox16.TabIndex = 10;
			// 
			// textBox15
			// 
			this.textBox15.Location = new System.Drawing.Point(44, 48);
			this.textBox15.Name = "textBox15";
			this.textBox15.ReadOnly = true;
			this.textBox15.Size = new System.Drawing.Size(187, 21);
			this.textBox15.TabIndex = 9;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(44, 22);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(187, 21);
			this.textBox6.TabIndex = 8;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(44, 638);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(187, 21);
			this.textBox5.TabIndex = 7;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(6, 181);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(41, 21);
			this.label21.TabIndex = 6;
			this.label21.Text = "修改：";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(6, 155);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(41, 21);
			this.label20.TabIndex = 5;
			this.label20.Text = "创建：";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(6, 129);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(41, 21);
			this.label19.TabIndex = 4;
			this.label19.Text = "码率：";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(6, 103);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(41, 21);
			this.label18.TabIndex = 3;
			this.label18.Text = "保护：";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(6, 77);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(41, 21);
			this.label17.TabIndex = 2;
			this.label17.Text = "长度：";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(6, 51);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(41, 21);
			this.label16.TabIndex = 1;
			this.label16.Text = "大小：";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(6, 25);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(41, 21);
			this.label15.TabIndex = 0;
			this.label15.Text = "类型：";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(904, 610);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "夜阑MP3标签修改器v1";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox textBox20;
		private System.Windows.Forms.TextBox textBox21;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.TextBox textBox19;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.ToolStripMenuItem 物理删除ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 移动到ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 复制到ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 删除全部ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 删除该项ToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox listBox1;
		

		


	}
}
