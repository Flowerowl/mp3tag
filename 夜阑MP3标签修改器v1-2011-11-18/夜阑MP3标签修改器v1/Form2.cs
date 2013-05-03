/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/11/17
 * 时间: 20:38
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace 夜阑MP3标签修改器v1
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		Point p;
		public Form2()
		{
			InitializeComponent();
			
		}	
		void Form2Load(object sender, EventArgs e)
		{	
			MainForm Lazy_singerbox=(MainForm)this.Owner;
			string about=Lazy_singerbox.textBox2.Text;
			this.Text="关于"+" "+about;	

			p = new Point(Screen.PrimaryScreen.WorkingArea.Width,Screen.PrimaryScreen.WorkingArea.Height/2-this.Height/2);
            this.PointToScreen(p);
            this.Location = p;
            this.timer1.Start();
            webBrowser1.Url=new System.Uri("http://baike.baidu.com/s?wd="+about,System.UriKind.Absolute);
		}
		void Timer1Tick(object sender, EventArgs e)
		{
				p.X-=10;
		        this.Location = p;
		        if (this.Location.X <= Screen.PrimaryScreen.WorkingArea.Width-this.Width)
		        {
		        	timer1.Enabled=false;
		        }
		        
		}
	}
}
