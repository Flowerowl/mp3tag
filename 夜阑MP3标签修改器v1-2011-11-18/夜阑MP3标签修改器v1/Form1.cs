/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/11/17
 * 时间: 12:53
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 夜阑MP3标签修改器v1
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			timer1.Enabled=true;
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{	
			
			timer1.Enabled=false;
			this.Close();
			
		}
	}
}
