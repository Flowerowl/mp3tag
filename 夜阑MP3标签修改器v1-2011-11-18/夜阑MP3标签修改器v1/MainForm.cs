/*
 * 由SharpDevelop创建。
 * 用户： Flowerowl
 * 日期: 2011/11/9
 * 时间: 15:05
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
using Shell32;
namespace 夜阑MP3标签修改器v1
{
	public partial class MainForm : Form
	{
		int ID3v2_len;
		int ID3v2Frame_len;
		int I;
		int J;
		byte[] Other_Chi = {
		0x0,
		0x63,
		0x68,
		0x69,
		0x0

	};
		public string[] Lazy_list=new String[5000];
		//字符串数组 
		private int Lazy_num;
		//MP3歌曲数量
		public struct dragfile
		{
			public string filename;
			public string filepath;
			
		};
		//ID3V2 相关
		public struct Mp3Info 
        {
            public string songName;
            public string singerName;
            public string albumName;
            public string track;
            public string year;
            public string genre;
            public string comm;
            public string fileLength;
            public string musicDuration;
            public Bitmap Lazy_pic;
        }

        // 标签头结构
        
        public struct TagHeader 
        {
            public string  header;
            public char version;
            public char revision;
            public char flag;
            public int tagSize;
        }
        
        private struct mp3_ID3V2_Frame_Out
		{
			[VBFixedString(4), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 4)]
			public string Name;
			public int Size;
			public byte Flag1;
			public byte Flag2;
			public byte[] Bf_Data;
			public string Data;
		}
	    private struct mp3_ID3V2_HD
		{
			[VBFixedString(3), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 3)]
				//-- 3
			public string h_Tag;
				//-- 4
			public byte h_mVn;
				//-- 5
			public byte h_rVn;
				//-- 6
			public byte h_Flags;
			public int h_Size;
			//<VBFixedArray(3)> Dim h_Size() As Byte '--10
	
			//Public Sub Initialize()
			//   ReDim h_Size(3)
			//End Sub
		}
		mp3_ID3V2_HD ID3v2HD_Out;
        // 标签帧帧头结构
		
        public struct FrameHeader
        {
            public string  frameID;//帧标识
            public int frameSize;//帧内容大小
            public string  storageFlags;//存放标记
        }
        
        //曲风
			 string[] GENRE = 
        {
        	"Blues","Classic Rock","Country","Dance","Disco","Funk","Grunge","Hip-Hop",
			"Jazz","Metal","New Age","Oldies","Other","Pop","R&B","Rap","Reggae","Rock",
			"Techno","Industrial","Alternative","Ska","Death Metal","Pranks","Soundtrack",
			"Euro-Techno","Ambient","Trip Hop","Vocal","Jazz Funk","Fusion","Trance",
			"Classical","Instrumental","Acid","House","Game","Sound Clip","Gospel","Noise",
			"Alternative Rock","Bass","Soul","Punk","Space","Meditative","Instrumental Pop",
			"Instrumental Rock","Ethnic","Gothic","Darkwave","Techno-Industrial","Electronic",
			"Pop Folk","Eurodance","Dream","Southern Rock","Comedy","Cult","Gangsta","Top 40",
			"Christian Rap","Pop Funk","Jungle","Native American","Cabaret","New Wave",
			"Psychadelic","Rave","ShowTunes","Trailer","Lo-Fi","Tribal","Acid Punk","Acid Jazz",
			"Polka","Retro","Musical","Rock & Roll","Hard Rock","Folk","Folk Rock",
			"National Folk","Swing","Fast Fusion","Bebob","Latin","Revival","Celtic",
			"Bluegrass","Avantgarde","Gothic Rock","Progressive Rock","Psychedelic Rock",
			"Symphonic Rock","Slow Rock","Big Band","Chorus","Easy Listening","Acoustic",
			"Humour","Speech","Chanson","Opera","Chamber Music","Sonata","Symphony","Booty Bass",
			"Primus","Porn Groove","Satire","Slow Jam","Club","Tango","Samba","Folklore","Ballad",
			"Power Ballad","Rhytmic Soul","Freestyle","Duet","Punk Rock","Drum Solo","A Capella",
			"Euro House","Dance Hall","Goa","Drum & Bass","Club House","Hardcore","Terror",
			"Indie","BritPop","Negerpunk","Polsk Punk","Beat","Christian Gangsta Rap",
			"Heavy Metal","Black Metal","Crossover","Contemporary Christian","Christian Rock",
			"Merengue","Salsa","Trash Metal","Anime","JPop","SynthPop"
        };

		public MainForm()
		{
			InitializeComponent();
			Form1 lazy_form=new Form1();
			lazy_form.Show();
			Point p;
			p=new Point(100,Screen.PrimaryScreen.WorkingArea.Height/2-this.Height/2);
			this.PointToScreen(p);
			this.Location=p;
			for(int i=0;i<148;i++)
			{
				this.comboBox1.Items.Add(GENRE[i]);
				this.comboBox2.Items.Add(GENRE[i]);
			}
			
			System.Threading.Thread.Sleep(2000);
			
		}
		public void AddFile(string path)
			//自定义AddFile方法
		{
			if(Lazy_num<5000)
			{
				Lazy_num++;
				Lazy_list[Lazy_num]=path;
				
			}
		}
		private void AddFiles(string path,ListBox listbox1)
			//自定义AddFiles方法
		{
			try
			{
				DirectoryInfo dir=new DirectoryInfo(path);
				//定义DirectoryInfo实例
				foreach(FileInfo f in dir.GetFiles("*.mp3"))
				{
					AddFile(f.FullName);
					string Lazy_str =Convert.ToString(Lazy_num);
					Lazy_str+="  "+f.Name;
					this.listBox1.Items.Add(Lazy_str);
				}
				foreach(DirectoryInfo f in dir.GetDirectories())
				{
					AddFiles(f.FullName,listBox1);
				}
			}
			catch{}
		}
		public void DelFile(int selectNum)
			//自定义DelFile方法
		{
			for(int i=selectNum;i<Lazy_num-1;i++)
			{
				Lazy_list[i]=Lazy_list[i+1];
			}
			Lazy_num--;
		}
		public void PlaySong(int selectNum)
		{
			axWindowsMediaPlayer1.URL=Lazy_list[selectNum];	
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter="*.mp3|*.mp3";
			ShellClass sh=new ShellClass();
			
			if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
				//调用打开对话框
			{
				string path=this.openFileDialog1.FileName;
				//获取详细信息
				Folder dir = sh.NameSpace(Path.GetDirectoryName(path));  
				FolderItem item = dir.ParseName(Path.GetFileName(path));  
				FileInfo f=new FileInfo(path);
				StringBuilder sb = new StringBuilder(); 
				StringBuilder sb2 = new StringBuilder(); 
				StringBuilder sb3 = new StringBuilder(); 
				StringBuilder sb4 = new StringBuilder(); 
				StringBuilder sb5 = new StringBuilder(); 
				StringBuilder sb6 = new StringBuilder(); 
				StringBuilder sb7 = new StringBuilder(); 
				StringBuilder sb8 = new StringBuilder(); 
					//文件编码格式
	               sb.Append(dir.GetDetailsOf(item,2));  
	               string str = sb.ToString(); 
	               textBox6.Text= str;
	               //码率
	               sb2.Append(dir.GetDetailsOf(item,28));  
	                string str2 = sb2.ToString(); 
	               textBox18.Text= str2;
	               //长度
	               sb3.Append(dir.GetDetailsOf(item,27));  
	               string str3 = sb3.ToString(); 
	               textBox16.Text= str3;
	                //大小
	               sb4.Append(dir.GetDetailsOf(item,1));  
	               string str4 = sb4.ToString();
	               textBox15.Text= str4;
	                //创建时间
	               sb5.Append(dir.GetDetailsOf(item,4));  
	               string str5 = sb5.ToString();
	               textBox19.Text= str5;
	                //修改时间
	               sb6.Append(dir.GetDetailsOf(item,3));  
	               string str6 = sb6.ToString();
	               textBox20.Text= str6;
	               //最近访问
	               sb7.Append(dir.GetDetailsOf(item,5));  
	               string str7 = sb7.ToString();
	               textBox21.Text= str7;
	               //受保护
	               sb8.Append(dir.GetDetailsOf(item,29));  
	               string str8 = sb8.ToString();
	               textBox17.Text= str8;
	             
	            
            	//
				AddFile(f.FullName);
				string Lazy_str =Convert.ToString(Lazy_num);
				for(int i=1;i<5-Lazy_str.Length;i++)
					Lazy_str+="  "+f.Name;
				this.listBox1.Items.Add(Lazy_str);
				//在列表框显示添加的歌曲
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath="d:\\";
			//设置初始打开路径
			folderBrowserDialog1.ShowNewFolderButton=true;
			//显示“新建文件夹”按钮;
			folderBrowserDialog1.Description="请选择音乐文件目录";
			folderBrowserDialog1.ShowDialog();
			//显示对话框
			AddFiles(folderBrowserDialog1.SelectedPath,listBox1);
			//调用AddFiles方法
		}
		void ListBox1DoubleClick(object sender, EventArgs e)
		{
			
			int SelectOne;
			if(listBox1.SelectedIndex<0)
				SelectOne=1;
			else
				SelectOne=listBox1.SelectedIndex+1;
			if(listBox1.Items.Count<0)
				listBox1.SelectedIndex=0;
			PlaySong(SelectOne);
		}
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			ShellClass sh=new ShellClass();
			int SelectOne=0;
			if(listBox1.SelectedIndex<0)
				SelectOne=1;
			else
				SelectOne=listBox1.SelectedIndex+1;
			
			string MyFileName = Lazy_list[SelectOne];
				//ID3V2
				Mp3TagID3V2 mp3InfoManager = new Mp3TagID3V2();
	            Mp3TagID3V2.Mp3Info mp3Info = new Mp3TagID3V2.Mp3Info();
	            //实例化结构体
	            FileStream fs = new FileStream(MyFileName, FileMode.Open,FileAccess.ReadWrite,FileShare.ReadWrite);
	            Stream stream = fs;
	            byte[] bs = new byte[1000];
	            stream.Read(bs, 0,1000);
	            mp3Info = mp3InfoManager.GetMp3Info(bs); 
	            stream.Close();
	            textBox10.Text=mp3Info.songName;
	            textBox9.Text=mp3Info.singerName;
	            textBox8.Text=mp3Info.albumName;
	            textBox14.Text=mp3Info.comm;
	            textBox13.Text=mp3Info.track;
	            textBox7.Text=mp3Info.year;
	            comboBox2.Text=mp3Info.genre;
	            
	           //ID3V1 
			Mp3TagID3V1 mp3Tag = new Mp3TagID3V1(MyFileName);
			//获取详细信息
			
				Folder dir = sh.NameSpace(Path.GetDirectoryName(Lazy_list[SelectOne]));  
				FolderItem item = dir.ParseName(Path.GetFileName(Lazy_list[SelectOne]));
				FileInfo f=new FileInfo(Lazy_list[SelectOne]);
				StringBuilder sb = new StringBuilder(); 
				StringBuilder sb2 = new StringBuilder(); 
				StringBuilder sb3 = new StringBuilder(); 
				StringBuilder sb4 = new StringBuilder(); 
				StringBuilder sb5 = new StringBuilder(); 
				StringBuilder sb6 = new StringBuilder(); 
				StringBuilder sb7 = new StringBuilder(); 
				StringBuilder sb8 = new StringBuilder(); 
					//文件编码格式
	               sb.Append(dir.GetDetailsOf(item,2));  
	               string str = sb.ToString(); 
	               textBox6.Text= str;
	               //码率
	               sb2.Append(dir.GetDetailsOf(item,28));  
	                string str2 = sb2.ToString(); 
	               textBox18.Text= str2;
	               //长度
	               sb3.Append(dir.GetDetailsOf(item,27));  
	               string str3 = sb3.ToString(); 
	               textBox16.Text= str3;
	                //大小
	               sb4.Append(dir.GetDetailsOf(item,1));  
	               string str4 = sb4.ToString();
	               textBox15.Text= str4;
	                //创建时间
	               sb5.Append(dir.GetDetailsOf(item,4));  
	               string str5 = sb5.ToString();
	               textBox19.Text= str5;
	                //修改时间
	               sb6.Append(dir.GetDetailsOf(item,3));  
	               string str6 = sb6.ToString();
	               textBox20.Text= str6;
	               //最近访问
	               sb7.Append(dir.GetDetailsOf(item,5));  
	               string str7 = sb7.ToString();
	               textBox21.Text= str7;
	               //受保护
	               sb8.Append(dir.GetDetailsOf(item,29));  
	               string str8 = sb8.ToString();
	               textBox17.Text= str8;
	               //
			         //      MessageBox.Show(this,,"",MessageBoxButtons.OK,MessageBoxIcon.Information);
		            this.textBox1.Text = mp3Tag.Title;
		            this.textBox2.Text = mp3Tag.Artist;
		            this.textBox3.Text = mp3Tag.Album;
		            this.textBox4.Text = mp3Tag.PublishYear;
		            this.textBox11.Text = mp3Tag.Comment;
		            this.textBox12.Text = mp3Tag.Track;
		            this.comboBox1.Text=null;
		            this.comboBox1.SelectedText= mp3Tag.Genre;
		            fs.Close();
            stream.Close();
		}
		
		 private string GetTagData(Stream MyStream,int MyLength)
        {
            Byte[] MyBytes=new Byte[MyLength];
            MyStream.Read(MyBytes,0,MyLength);
            string MyTagData = System.Text.Encoding.Default.GetString(MyBytes);
            char[] MyTrimChars ={char.Parse(" ") };
            //将指定字符串的值转换为它的等效 Unicode 字符。
            MyTagData = MyTagData.Trim(MyTrimChars);
            return MyTagData ;
        }	

		public void Button1Click(object sender, EventArgs e)
		{  
			//try
			//{
				if (MessageBox.Show("是否删除ID3V1？", "夜阑温情提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
	            {
		            int SelectOne=0;
					if(listBox1.SelectedIndex<0)
						SelectOne=1;
					else
						SelectOne=listBox1.SelectedIndex+1;
					
					string MyFileName = Lazy_list[SelectOne];
					
					//清除ID3V1标签信息
					byte[] headb=new byte[3];
					char[] headc=new char[3];
					byte[] tagBodyb = new byte[125];
					char[] tagBodyc = new char[125];
					headb=new  byte[headc.Length];
					tagBodyc="\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0".ToCharArray();
					tagBodyb=new  byte[tagBodyc.Length];
					Encoder ec=Encoding.Default.GetEncoder();
					ec.GetBytes(tagBodyc,0,tagBodyc.Length,tagBodyb,0,true);
							
							FileStream fs = new FileStream(MyFileName, FileMode.Open, FileAccess.Write,FileShare.ReadWrite);
							fs.Seek(-128,SeekOrigin.End);
							fs.Write(headb,0,headb.Length);
							fs.Flush();
							
		                	fs.Seek(-125, SeekOrigin.End);
		                	fs.Write(tagBodyb, 0, tagBodyb.Length);
		                	fs.Flush();
		                	fs.Close();	
	            }
				else
				{}
			//}
			//catch
			//{
				//MessageBox.Show(this,"啊哦，看起来这里有点错误，请重试。","夜阑温情提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
			//}
			
	
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			//清除ID3V2标签信息
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("是否删除所有歌曲标签？", "夜阑温情提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
				byte[] tagBodyb = new byte[125];
				char[] tagBodyc = new char[125];
				tagBodyc="\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0".ToCharArray();
				tagBodyb=new  byte[tagBodyc.Length];
				Encoder ec=Encoding.Default.GetEncoder();
				ec.GetBytes(tagBodyc,0,tagBodyc.Length,tagBodyb,0,true);
				
				progressBar1.Value=0;
				//清除所有文件的标签信息
				progressBar1.Maximum=listBox1.Items.Count;
				for(int i=1;i<=listBox1.Items.Count;i++)
				{
					string MyFileName = Lazy_list[i];
					//清除ID3V1标签信息
					
					 using (FileStream fs = new FileStream(MyFileName, FileMode.Open, FileAccess.Write,FileShare.ReadWrite))
	            	{
	                	fs.Seek(-125, SeekOrigin.End);
	                	fs.Write(tagBodyb, 0, tagBodyb.Length);
	                	fs.Flush();
	                	fs.Close();	
	             	}
				    progressBar1.Value++;
				    if(progressBar1.Value==progressBar1.Maximum)
				    {
				    	MessageBox.Show(this,"搞定啦~","夜阑温情提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
				    }
				}
			}
			else{}
		}
		
		 public void Button6Click(object sender, EventArgs e)
		{
		 	
				int SelectOne=0;
				if(listBox1.SelectedIndex<0)
					SelectOne=1;
				else
					SelectOne=listBox1.SelectedIndex+1;
				string MyFileName = Lazy_list[SelectOne];
				FileStream fsFile = new FileStream(MyFileName, FileMode.Open,FileAccess.ReadWrite,FileShare.ReadWrite);

				//ID3V1写入
				byte[] headb=new byte[3];
				char[] headc=new char[3];
				string title="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
				string singer="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
				string album="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
				string comment="aaaaaaaaaaaaaaaaaaaaaaaaaaaa";
				string title3="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
				string singer3="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
				string album3="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
				string comm3="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
				byte[] titleb = new byte[Encoding.Default.GetByteCount(title)];
	       	    char[] titlec = new char[30];
	       	   	byte[] singerb = new byte[Encoding.Default.GetByteCount(title)];
	       	    char[] singerc = new char[30];
	       	    byte[] albumb = new byte[Encoding.Default.GetByteCount(title)];
	       	    char[] albumc = new char[30];
	       	    byte[] yearb = new byte[4];
	       	    char[] yearc = new char[4];
	       	    byte[] trackb = new byte[1];
	       	    char[] trackc = new char[1];
	       	    byte[] genreb = new byte[1];
	       	    byte[] commentb = new byte[Encoding.Default.GetByteCount(title)];
	       	    char[] commentc = new char[28];
	       	    	 headc="TAG".ToCharArray();
	                 titlec=textBox1.Text.ToCharArray();  
	                 singerc=textBox2.Text.ToCharArray();
	                 albumc=textBox3.Text.ToCharArray();
	                 yearc=textBox4.Text.ToCharArray();
	                 commentc=textBox11.Text.ToCharArray();
	                 trackc=textBox12.Text.ToCharArray();
	                 //string g=comboBox1.SelectedIndex.ToString();
	                 
	                 int a=comboBox1.SelectedIndex;
	                 if(a==-1)
	                 {
	                 	a=0;
	                 }
	                // MessageBox.Show(this,g,"提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
	                 char b=Convert.ToChar(a);
	                 char[] genrec =new char[]{b};
	                 headb=new  byte[headc.Length];
	           		 yearb=new  byte[yearc.Length];
	           		 trackb=new byte[trackc.Length];
	           		 genreb=new byte[genrec.Length];
					//将字符数组转换成字节数组
					 Encoder ec=Encoding.Default.GetEncoder();
					 ec.GetBytes(headc,0,headc.Length,headb,0,true);
					 ec.GetBytes(titlec,0,titlec.Length,titleb,0,true);
	           		 ec.GetBytes(singerc,0,singerc.Length,singerb,0,true); 
	           		 ec.GetBytes(albumc,0,albumc.Length,albumb,0,true);
	           		 ec.GetBytes(yearc,0,yearc.Length,yearb,0,true);
	           		 ec.GetBytes(commentc,0,commentc.Length,commentb,0,true);
	           		 ec.GetBytes(trackc,0,trackc.Length,trackb,0,true);
	           		 ec.GetBytes(genrec,0,1,genreb,0,true);
					//将指针设定起始位置
					fsFile.Seek(-128,SeekOrigin.End);
					fsFile.Write(headb,0,headb.Length);
					fsFile.Flush();
	           	 	fsFile.Seek(-125,SeekOrigin.End);
	            	fsFile.Write(titleb,0,titleb.Length);
	            	fsFile.Flush();
	            	//title
	            	fsFile.Seek(-95,SeekOrigin.End);
	            	fsFile.Write(singerb,0,singerb.Length);
	            	fsFile.Flush();	
	            	//singer
	            	fsFile.Seek(-65,SeekOrigin.End);
	            	fsFile.Write(albumb,0,albumb.Length);
	        		fsFile.Flush();
	            	//album
	            	fsFile.Seek(-35,SeekOrigin.End);
	            	fsFile.Write(yearb,0,yearb.Length);
	            	fsFile.Flush();
	            	//year
	            	
	            	if(commentc.Length>28)
	            	{
	                 	MessageBox.Show(this,"不允许超过28字符哦","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
	            	}
	                else
	            	{
		            	fsFile.Seek(-31,SeekOrigin.End);
		            	fsFile.Write(commentb,0,commentb.Length);
		            	fsFile.Flush();
	            	}
	            	//comment
	            	fsFile.Seek(-3,SeekOrigin.End);
	            	fsFile.Write(trackb,0,trackb.Length);
	            	fsFile.Flush();
	            	//track
	            	fsFile.Seek(-1,SeekOrigin.End);
	            	fsFile.Write(genreb,0,1);
	            	fsFile.Flush();
	            	//genre
	            	
	            	
	            	//ID3V2写入
	            	//标签头
	            	char [] head1=new char[3];
	            	byte [] head2=new byte[3];
	            	//歌名
	            	char [] title1=new char[100];
	            	//byte [] title2=new byte[100];
	            	byte[] title2 = new byte[Encoding.Default.GetByteCount(title3)];
	            	//艺人
	            	char [] singer1=new char[30];
	            	//byte [] singer2=new byte[30];
	            	byte[] singer2 = new byte[Encoding.Default.GetByteCount(singer3)];
	            	//专辑
	            	char [] album1=new char[30];
	            	//byte [] album2=new byte[30];
	            	byte[] album2 = new byte[Encoding.Default.GetByteCount(album3)];
	            	//音轨
	            	char [] track1 =new char[10];
	            	byte [] track2 =new byte[10];
	            	//年代
	            	char [] year1= new char[10];
	            	byte [] year2=new byte[10];
	            	//备注
	            	char [] comm1=new char[100];
	            	//byte [] comm2=new byte[1000];
	            	byte[] comm2 = new byte[Encoding.Default.GetByteCount(comm3)];
	            	//曲风
	            	
	            	byte [] genre2=new byte[1];
	            	
	            	 int c=comboBox2.SelectedIndex;
	                 if(c==-1)
	                 {
	                 	c=0;
	                 }
	                 
	                
	                 char d=Convert.ToChar(c);
	                 char[] genre1 =new char[]{d};
	                 
	                head1="ID3".ToCharArray(); 
	            	title1=textBox10.Text.ToCharArray();
	            	singer1=textBox9.Text.ToCharArray();
	            	album1=textBox8.Text.ToCharArray();
	            	year1=textBox7.Text.ToCharArray();
	            	track1=textBox13.Text.ToCharArray();
	            	comm1=textBox14.Text.ToCharArray();
	            	
					
					head2=new  byte[head1.Length];
					
					ec.GetBytes(head1,0,head1.Length,head2,0,true);
					ec.GetBytes(title1,0,title1.Length,title2,0,true);
					ec.GetBytes(singer1,0,singer1.Length,singer2,0,true);
					ec.GetBytes(album1,0,album1.Length,album2,0,true);
					ec.GetBytes(year1,0,year1.Length,year2,0,true);
					ec.GetBytes(track1,0,track1.Length,track2,0,true);
					ec.GetBytes(comm1,0,comm1.Length,comm2,0,true);
					Save();
					/*
					fsFile.Seek(0,SeekOrigin.Begin);
					fsFile.Write(head2,0,head2.Length);
					fsFile.Flush();
					*/
					//Stream stream = fsFile;
		            //byte[] bs = new byte[10000];
		            //stream.Read(bs, 0, 10000);
		            //PutMp3Info(bs,title2,singer2,album2,track2,year2,genre2,comm2); 
		            //stream.Close();
		 			fsFile.Close();
		 	
		}	
		
		void ListBox1DragOver(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
		}
		
		void ListBox1DragEnter(object sender, DragEventArgs e)
		{
			 e.Effect = DragDropEffects.All;
		}
		
		void ListBox1DragDrop(object sender, DragEventArgs e)
		{
			String[] path = (String[])e.Data.GetData(DataFormats.FileDrop);
       		foreach (String s in path)
		    {
       			FileInfo f=new FileInfo(s);
				AddFile(f.FullName);
				string Lazy_str =Convert.ToString(Lazy_num);
				for(int i=1;i<5-Lazy_str.Length;i++)
				Lazy_str+="  "+f.Name;
				this.listBox1.Items.Add(Lazy_str);  
		    }
			
		}
		
		void ListBox1DragLeave(object sender, EventArgs e)
		{
			
		}
		
		void 删除该项ToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(listBox1.SelectedIndex>=0)
            {
                DelFile(listBox1.SelectedIndex);
                 //调用DelFile方法
                 listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                 //删除listbox对应记录
             }
		}
		
		void 物理删除ToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void 删除全部ToolStripMenuItemClick(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
		}
		
		void 复制到ToolStripMenuItemClick(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath="d:\\";
			//设置初始打开路径
			folderBrowserDialog1.ShowNewFolderButton=true;
			//显示“新建文件夹”按钮;
			folderBrowserDialog1.Description="请选择音乐文件目录";
			folderBrowserDialog1.ShowDialog();
			string newfilepath = folderBrowserDialog1.SelectedPath + "\\" + listBox1.SelectedItem.ToString() + ".mp3";
			System.IO.File.Copy(Lazy_list[listBox1.SelectedIndex+1],newfilepath,false);//复制文件
              
		}
		
		void 移动到ToolStripMenuItemClick(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath="d:\\";
			//设置初始打开路径
			folderBrowserDialog1.ShowNewFolderButton=true;
			//显示“新建文件夹”按钮;
			folderBrowserDialog1.Description="请选择音乐文件目录";
			folderBrowserDialog1.ShowDialog();
			string newfilepath = folderBrowserDialog1.SelectedPath;
			File.Move(Lazy_list[listBox1.SelectedIndex+1], newfilepath + "/" + listBox1.SelectedItem.ToString());//移动文件
			DelFile(listBox1.SelectedIndex);
			 listBox1.Items.RemoveAt(listBox1.SelectedIndex);
		}
		
		
		//ID3V1->ID3V2
		void Button7Click(object sender, EventArgs e)
		{
			textBox10.Text=textBox1.Text;//歌曲
			textBox9.Text=textBox2.Text;//艺人
			textBox8.Text=textBox3.Text;//专辑
			textBox7.Text=textBox4.Text;//年份
			textBox13.Text=textBox12.Text;//音轨
			comboBox2.Text=comboBox1.Text;//风格
			textBox14.Text=textBox11.Text;//备注
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			Form2 Lazy_singerbox=new Form2();
			Lazy_singerbox.Owner=this;
			Lazy_singerbox.ShowDialog();
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			textBox1.Text=textBox10.Text;//歌曲
			textBox2.Text=textBox9.Text;//艺人
			textBox3.Text=textBox8.Text;//专辑
			textBox4.Text=textBox7.Text;//年份
			textBox12.Text=textBox13.Text;//音轨
			comboBox1.Text=comboBox2.Text;//风格
			textBox11.Text=textBox14.Text;//备注
		}
		//获得ID3V2标签信息
		private  TagHeader GetTagHeaderInfo(byte[] info) 
        {
            TagHeader tagHeaderInfo = new TagHeader();
            for (int i = 0; i < 3; i++)
            tagHeaderInfo.header+= (char)info[i];
            //最前端的ID3标示，3
            tagHeaderInfo.version = (char)info[3];
            //版本号，1
            tagHeaderInfo.revision = (char)info[4];
            //副版本号，1
            tagHeaderInfo.flag = (char)info[5];
            //存放标志，1
            tagHeaderInfo.tagSize = (info[6] & 0x7F) * 0x200000 + (info[7] & 0x7F) * 0x400 + (info[8] & 0x7F) * 0x80 + (info[9] & 0x7F);
            //标签大小，4
            return tagHeaderInfo;
        }
		
		//ID3V2字符串转换
        private string ByteToString(byte[] b)
        {

            if (b[0] <32)
            {
                byte[] tmp = new byte[b.Length - 1];
                for (int i = 0; i < b.Length - 1; i++)
                {
                    tmp[i] = b[i + 1];
                }
                Encoding enc = Encoding.GetEncoding("GB2312");
                string str = enc.GetString(tmp);
                str = str.Substring(0, str.IndexOf('\0') >= 0 ? str.IndexOf('\0') : str.Length);
                //去掉无用字符
                return str;
            }
            else
            {
                Encoding enc = Encoding.GetEncoding("GB2312");
                string str = enc.GetString(b);
                str = str.Substring(0, str.IndexOf('\0') >= 0 ? str.IndexOf('\0') : str.Length);
                //去掉无用字符
                return str;
            }
        }
        
        /*
        //改写ID3V2
        public Mp3Info PutMp3Info(byte[] mp3Bytes,byte[] title,byte[] singer,byte[] album,byte[] track,byte[] year,byte[] genre,byte[] comm)
        {
        	int SelectOne=0;
			if(listBox1.SelectedIndex<0)
				SelectOne=1;
			else
				SelectOne=listBox1.SelectedIndex+1;
			
			string MyFileName = Lazy_list[SelectOne];
			FileStream fsFile = new FileStream(MyFileName, FileMode.Open,FileAccess.ReadWrite,FileShare.ReadWrite);
            Mp3Info mp3Info = new Mp3Info();
            if (mp3Bytes.Length < 10) 
                return mp3Info;
            TagHeader tagHeaderInfo = new TagHeader();
            tagHeaderInfo = GetTagHeaderInfo(mp3Bytes);
            if (tagHeaderInfo.header != "ID3") 
                return mp3Info;
            int tagSize = tagHeaderInfo.tagSize;
            int tagSizeCounter = 10;
            while (tagSizeCounter <= tagSize && tagSizeCounter <= mp3Bytes.Length) 
            {
                //获取标签帧帧头
                byte[] frameHeaderBytes = new byte[10];
                try
                {
	                for (int i = 0; i < 10; i++) 
	                {
	                    frameHeaderBytes[i] = mp3Bytes[tagSizeCounter++];
	                }
                }
                catch{}
                FrameHeader frameHeader = new FrameHeader();
                //获取标签帧的标识
                for (int i = 0; i < 4; i++) 
                {
                    frameHeader.frameID += (char)frameHeaderBytes[i];
                }
                //获取标签帧的长度
                frameHeader.frameSize = frameHeaderBytes[4] * 0x1000000 + frameHeaderBytes[5] * 0x10000 + frameHeaderBytes[6] * 0x100 + frameHeaderBytes[7];
                //获取标签帧的内容
                byte[] frameContent=new byte[frameHeader.frameSize];
                try{
	                for (int i = 0; i < frameHeader.frameSize; i++)
	                {
	                    frameContent[i] = mp3Bytes[tagSizeCounter++];
	                }
                }
                catch{}
                switch (frameHeader.frameID)
                {
                		//标题
                	case "TIT2": 
		                		fsFile.Seek(100,SeekOrigin.Begin);
				            	fsFile.Write(title,0,title.Length);
				            	fsFile.Flush();	
                      		    break;
                    case "TAL":
                        //专辑
                    case "TALB":
                        
                       			fsFile.Seek(0,SeekOrigin.Begin);
				            	fsFile.Write(album,0,album.Length);
				            	fsFile.Flush();
                        break;
                        //长度
                    case "TLEN": 
                        break;
                        //时长
                    case "TIME": 
                        break;
                    case "TPE2": 
                        //艺人
                    case "TPE1": 
                        		fsFile.Seek(0,SeekOrigin.Begin);
				            	fsFile.Write(singer,0,singer.Length);
				            	fsFile.Flush();
                        
                        break;
                        //音轨
                	case "TRCK": 
                        		fsFile.Seek(0,SeekOrigin.Begin);
				            	fsFile.Write(track,0,track.Length);
				            	fsFile.Flush();
                       			break;
                        //备注
                    case "COMM": 
                        		fsFile.Seek(0,SeekOrigin.Begin);
				            	fsFile.Write(comm,0,comm.Length);
				            	fsFile.Flush();
                       			 break;
                        //年代
                    case "TYER": mp3Info.year = ByteToString(frameContent);
                        break;
                        //风格
                    case "TCON": mp3Info.genre= ByteToString(frameContent);
                        break;
                   // case "APIC": mp3Info.Lazy_pic= frameContent;
                     //   break;
                     
                }
            }
            return mp3Info;
            fsFile.Close();
        }
        */
       private void Save()
	{
			int SelectOne=0;
			if(listBox1.SelectedIndex<0)
				SelectOne=1;
			else
				SelectOne=listBox1.SelectedIndex+1;
			
			string MyFileName = Lazy_list[SelectOne];
			
			FileSystem.FileOpen(1, MyFileName, OpenMode.Binary,OpenAccess.ReadWrite,OpenShare.Shared);
			
			byte[] OutPut = null;
			byte[] Temp = null;
			int Len_Tmp = 0;
			int ID3v2_Len_Out = 0;
			int N = 0;
			string M = "";
			int Num = 0;
			int R_Tmp = 0;
			int R_t = 0;

			mp3_ID3V2_Frame_Out TIT2_Out = default(mp3_ID3V2_Frame_Out);
			//名称
			mp3_ID3V2_Frame_Out TPE1_Out = default(mp3_ID3V2_Frame_Out);
			//表演者
			mp3_ID3V2_Frame_Out TCOM_Out = default(mp3_ID3V2_Frame_Out);
			//作曲
			mp3_ID3V2_Frame_Out TALB_Out = default(mp3_ID3V2_Frame_Out);
			//专辑
			mp3_ID3V2_Frame_Out TRCK_Out = default(mp3_ID3V2_Frame_Out);
			//轨道
			mp3_ID3V2_Frame_Out TYER_Out = default(mp3_ID3V2_Frame_Out);
			//年份
			mp3_ID3V2_Frame_Out TCON_Out = default(mp3_ID3V2_Frame_Out);
			//类型
			mp3_ID3V2_Frame_Out COMM_Out = default(mp3_ID3V2_Frame_Out);
			//注释
			mp3_ID3V2_Frame_Out USLT_Out = default(mp3_ID3V2_Frame_Out);
			//歌词
			mp3_ID3V2_Frame_Out TENC_Out = default(mp3_ID3V2_Frame_Out);
			//编码方式
			mp3_ID3V2_Frame_Out TCOP_Out = default(mp3_ID3V2_Frame_Out);
			//版权
			mp3_ID3V2_Frame_Out WXXX_Out = default(mp3_ID3V2_Frame_Out);
			//URL链接
			//mp3_ID3V2_Frame_Out_Pic APIC_Out = default(mp3_ID3V2_Frame_Out_Pic);
			//封面图片
			//byte[] APIC_Other = null;
			//封面图片

		
			//构建ID3v2数据##########################################
			/*
				if (Kind_of_Pic == "JPG") {
					APIC_Other = Pic_Jpg;
				}
				if (Kind_of_Pic == "GIF") {
					APIC_Other = Pic_Gif;
				}
				if (Kind_of_Pic == "BMP") {
					APIC_Other = Pic_Bmp;
				}
				if (Kind_of_Pic == "PNG") {
					APIC_Other = Pic_Png;
				}
			*/
			/*
				textBox10.Text = textBox10.Text.TrimStart(" ");
				textBox10.Text = textBox10.Text.TrimEnd(" ");
				TPE1.Text = TPE1.Text.TrimStart(" ");
				TPE1.Text = TPE1.Text.TrimEnd(" ");
				TCOM.Text = TCOM.Text.TrimStart(" ");
				TCOM.Text = TCOM.Text.TrimEnd(" ");
				TALB.Text = TALB.Text.TrimStart(" ");
				TALB.Text = TALB.Text.TrimEnd(" ");
				TRCK.Text = TRCK.Text.TrimStart(" ");
				TRCK.Text = TRCK.Text.TrimEnd(" ");
				TYER.Text = TYER.Text.TrimStart(" ");
				TYER.Text = TYER.Text.TrimEnd(" ");
				COMM.Text = COMM.Text.TrimStart(" ");
				COMM.Text = COMM.Text.TrimEnd(" ");
				USLT.Text = USLT.Text.TrimStart(" ");
				USLT.Text = USLT.Text.TrimEnd(" ");
				TENC.Text = TENC.Text.TrimStart(" ");
				TENC.Text = TENC.Text.TrimEnd(" ");
				TCOP.Text = TCOP.Text.TrimStart(" ");
				TCOP.Text = TCOP.Text.TrimEnd(" ");
				WXXX.Text = WXXX.Text.TrimStart(" ");
				WXXX.Text = WXXX.Text.TrimEnd(" ");
*/
				//标题
				TIT2_Out.Name = "TIT2";
				TIT2_Out.Size = Swap_Out(CLen(textBox10.Text) + 1);
				TIT2_Out.Bf_Data = new byte[1];
				TIT2_Out.Bf_Data[0] = 0;
				TIT2_Out.Data = textBox10.Text;
				Len_Tmp += CLen(textBox10.Text) + 1;
				Len_Tmp += 10;

				//艺人
				TPE1_Out.Name = "TPE1";
				TPE1_Out.Size = Swap_Out(CLen(textBox9.Text) + 1);
				TPE1_Out.Bf_Data = new byte[1];
				TPE1_Out.Bf_Data[0] = 0;
				TPE1_Out.Data = textBox9.Text;
				Len_Tmp += CLen(textBox9.Text) + 1;
				Len_Tmp += 10;
				
				//TCOM
				TCOM_Out.Name = "TCOM";
				TCOM_Out.Size =  Swap_Out(CLen("") + 1);
				TCOM_Out.Bf_Data = new byte[1];
				TCOM_Out.Bf_Data[0] = 0;
				TCOM_Out.Data = "";
				Len_Tmp += CLen("") + 1;
				Len_Tmp += 10;

				//专辑
				TALB_Out.Name = "TALB";
				TALB_Out.Size =  Swap_Out(CLen(textBox8.Text) + 1);
				TALB_Out.Bf_Data = new byte[1];
				TALB_Out.Bf_Data[0] = 0;
				TALB_Out.Data = textBox8.Text;
				Len_Tmp += CLen(textBox8.Text) + 1;
				Len_Tmp += 10;

				//音轨
				TRCK_Out.Name = "TRCK";
				TRCK_Out.Size = Swap_Out(CLen(textBox13.Text) + 1);
				TRCK_Out.Bf_Data = new byte[1];
				TRCK_Out.Bf_Data[0] = 0;
				TRCK_Out.Data = textBox13.Text;
				Len_Tmp += CLen(textBox13.Text) + 1;
				Len_Tmp += 10;

				//年代
				TYER_Out.Name = "TYER";
				TYER_Out.Size =  Swap_Out(CLen(textBox7.Text) + 1);
				TYER_Out.Bf_Data = new byte[1];
				TYER_Out.Bf_Data[0] = 0;
				TYER_Out.Data = textBox7.Text;
				Len_Tmp += CLen(textBox7.Text) + 1;
				Len_Tmp += 10;
/*
				//风格
				TCON_Out.Name = "TCON";
				Num = Re_GenreList(comboBox2.SelectedIndex);
				while (Num > 0) {
					M = Strings.Chr(Num % 10 + Strings.Asc(0)) + M;
					Num = Num / 10;
				}
				M = "(" + M + ")";
				TCON_Out.Bf_Data = new byte[1];
				TCON_Out.Bf_Data[0] = 0;
				TCON_Out.Data = M;
				TCON_Out.Size = Swap_Out(Strings.Len(M) + 1);
				Len_Tmp += CLen(M) + 1;
				Len_Tmp += 10;
*/

				//备注
				COMM_Out.Name = "COMM";
				COMM_Out.Size =  Swap_Out(CLen(textBox14.Text) + 5);
				COMM_Out.Bf_Data = new byte[5];
				COMM_Out.Bf_Data = Other_Chi;
				COMM_Out.Data = textBox14.Text;
				Len_Tmp += CLen(textBox14.Text) + 5;
				Len_Tmp += 10;

				//USLT
				USLT_Out.Name = "USLT";
				USLT_Out.Size =  Swap_Out(CLen("") + 5);
				USLT_Out.Bf_Data = new byte[5];
				USLT_Out.Bf_Data = Other_Chi;
				USLT_Out.Data = "";
				Len_Tmp += CLen("") + 5;
				Len_Tmp += 10;

				//TENC
				TENC_Out.Name = "TENC";
				TENC_Out.Size =  Swap_Out(CLen("") + 1);
				TENC_Out.Bf_Data = new byte[1];
				TENC_Out.Bf_Data[0] = 0;
				TENC_Out.Data = "";
				Len_Tmp += CLen("") + 1;
				Len_Tmp += 10;

				//TCOP
				TCOP_Out.Name = "TCOP";
				TCOP_Out.Size =  Swap_Out(CLen("") + 1);;
				TCOP_Out.Bf_Data = new byte[1];
				TCOP_Out.Bf_Data[0] = 0;
				TCOP_Out.Data = "";
				Len_Tmp += CLen("") + 1;
				Len_Tmp += 10;

				//WXXX
				WXXX_Out.Name = "WXXX";
				WXXX_Out.Size =  Swap_Out(CLen("") + 1);;
				WXXX_Out.Bf_Data = new byte[1];
				WXXX_Out.Bf_Data[0] = 0;
				WXXX_Out.Data = "";
				Len_Tmp += CLen("") + 1;
				Len_Tmp += 10;
				/*
				//APIC
				if (!string.IsNullOrEmpty(PicAdr)) {
					int t_Num = 0;
					APIC_Out.Data = new byte[FileSystem.FileLen(PicAdr)];
					PictureBox1.Image.Dispose();
					PictureBox1.Image = null;
					FileSystem.FileOpen(3, PicAdr, OpenMode.Binary);
					APIC_Out.Name = "APIC";
					if (Kind_of_Pic == "JPG") {
						t_Num = FileSystem.FileLen(PicAdr) + 14;
						Len_Tmp += 14;
					} else {
						t_Num = FileSystem.FileLen(PicAdr) + 13;
						Len_Tmp += 13;
					}
					APIC_Out.Size = Swap_Out(t_Num);
					APIC_Out.Bf_Data = APIC_Other;
					if (ID3_Pic_Change == true) {
						FileSystem.FileGet(3, APIC_Out.Data);
					} else {
						APIC_Out.Data = Pic;
					}
					FileSystem.FileClose(3);
					PictureBox1.Image = Image.FromFile(PicAdr);

					Len_Tmp += FileSystem.FileLen(PicAdr);
					Len_Tmp += 10;
				}
				*/

				if (Len_Tmp <= ID3v2_len) {
					ID3v2_Len_Out = ID3v2_len;
				} else {
					ID3v2_Len_Out = (Len_Tmp / 1024 + 1) * 1024;
				}

				//建立ID3v2_Header****************************************
				ID3v2HD_Out.h_Tag = "ID3";
				ID3v2HD_Out.h_mVn = 3;
				ID3v2HD_Out.h_rVn = 0;
				ID3v2HD_Out.h_Flags = 0;

				ID3v2HD_Out.h_Size = Re_Swap_HD(ID3v2_Len_Out);


				//Wait.DefInstance.ProgressBar.EditValue = 0
				//Wait.DefInstance.ProgressBar.Properties.Maximum = ID3v2_Len_Out

				//写入ID3v2信息###########################################
				if (Len_Tmp < ID3v2_len) {
					FileSystem.Seek(1, 1);

					FileSystem.FilePut(1, ID3v2HD_Out.h_Tag);
					FileSystem.FilePut(1, ID3v2HD_Out.h_mVn);
					FileSystem.FilePut(1, ID3v2HD_Out.h_rVn);
					FileSystem.FilePut(1, ID3v2HD_Out.h_Flags);
					FileSystem.FilePut(1, ID3v2HD_Out.h_Size);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(1)

					FileSystem.FilePut(1, TIT2_Out.Name);
					//名称
					FileSystem.FilePut(1, TIT2_Out.Size);
					FileSystem.FilePut(1, TIT2_Out.Flag1);
					FileSystem.FilePut(1, TIT2_Out.Flag2);
					FileSystem.FilePut(1, TIT2_Out.Bf_Data);
					FileSystem.FilePut(1, TIT2_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(1)

					FileSystem.FilePut(1, TPE1_Out.Name);
					//表演者
					FileSystem.FilePut(1, TPE1_Out.Size);
					FileSystem.FilePut(1, TPE1_Out.Flag1);
					FileSystem.FilePut(1, TPE1_Out.Flag2);
					FileSystem.FilePut(1, TPE1_Out.Bf_Data);
					FileSystem.FilePut(1, TPE1_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(1)

					FileSystem.FilePut(1, TCOM_Out.Name);
					//作曲
					FileSystem.FilePut(1, TCOM_Out.Size);
					FileSystem.FilePut(1, TCOM_Out.Flag1);
					FileSystem.FilePut(1, TCOM_Out.Flag2);
					FileSystem.FilePut(1, TCOM_Out.Bf_Data);
					FileSystem.FilePut(1, TCOM_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(1)

					FileSystem.FilePut(1, TALB_Out.Name);
					//专辑
					FileSystem.FilePut(1, TALB_Out.Size);
					FileSystem.FilePut(1, TALB_Out.Flag1);
					FileSystem.FilePut(1, TALB_Out.Flag2);
					FileSystem.FilePut(1, TALB_Out.Bf_Data);
					FileSystem.FilePut(1, TALB_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(1)

					FileSystem.FilePut(1, TRCK_Out.Name);
					//轨道
					FileSystem.FilePut(1, TRCK_Out.Size);
					FileSystem.FilePut(1, TRCK_Out.Flag1);
					FileSystem.FilePut(1, TRCK_Out.Flag2);
					FileSystem.FilePut(1, TRCK_Out.Bf_Data);
					FileSystem.FilePut(1, TRCK_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(1)

					FileSystem.FilePut(1, TYER_Out.Name);
					//年份
					FileSystem.FilePut(1, TYER_Out.Size);
					FileSystem.FilePut(1, TYER_Out.Flag1);
					FileSystem.FilePut(1, TYER_Out.Flag2);
					FileSystem.FilePut(1, TYER_Out.Bf_Data);
					FileSystem.FilePut(1, TYER_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(1)

					FileSystem.FilePut(1, TCON_Out.Name);
					//类型
					FileSystem.FilePut(1, TCON_Out.Size);
					FileSystem.FilePut(1, TCON_Out.Flag1);
					FileSystem.FilePut(1, TCON_Out.Flag2);
					FileSystem.FilePut(1, TCON_Out.Bf_Data);
					FileSystem.FilePut(1, TCON_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(1)

					FileSystem.FilePut(1, COMM_Out.Name);
					//注释
					FileSystem.FilePut(1, COMM_Out.Size);
					FileSystem.FilePut(1, COMM_Out.Flag1);
					FileSystem.FilePut(1, COMM_Out.Flag2);
					FileSystem.FilePut(1, COMM_Out.Bf_Data);
					FileSystem.FilePut(1, COMM_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(1)

					FileSystem.FilePut(1, USLT_Out.Name);
					//歌词
					FileSystem.FilePut(1, USLT_Out.Size);
					FileSystem.FilePut(1, USLT_Out.Flag1);
					FileSystem.FilePut(1, USLT_Out.Flag2);
					FileSystem.FilePut(1, USLT_Out.Bf_Data);
					FileSystem.FilePut(1, USLT_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(1)

					FileSystem.FilePut(1, TENC_Out.Name);
					//编码方式
					FileSystem.FilePut(1, TENC_Out.Size);
					FileSystem.FilePut(1, TENC_Out.Flag1);
					FileSystem.FilePut(1, TENC_Out.Flag2);
					FileSystem.FilePut(1, TENC_Out.Bf_Data);
					FileSystem.FilePut(1, TENC_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(1)

					FileSystem.FilePut(1, TCOP_Out.Name);
					//版权
					FileSystem.FilePut(1, TCOP_Out.Size);
					FileSystem.FilePut(1, TCOP_Out.Flag1);
					FileSystem.FilePut(1, TCOP_Out.Flag2);
					FileSystem.FilePut(1, TCOP_Out.Bf_Data);
					FileSystem.FilePut(1, TCOP_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(1)

					FileSystem.FilePut(1, WXXX_Out.Name);
					//URL链接
					FileSystem.FilePut(1, WXXX_Out.Size);
					FileSystem.FilePut(1, WXXX_Out.Flag1);
					FileSystem.FilePut(1, WXXX_Out.Flag2);
					FileSystem.FilePut(1, WXXX_Out.Bf_Data);
					FileSystem.FilePut(1, WXXX_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(1)
					/*
					if (!string.IsNullOrEmpty(PicAdr)) {
						FileSystem.FilePut(1, APIC_Out.Name);
						FileSystem.FilePut(1, APIC_Out.Size);
						//封面图片
						FileSystem.FilePut(1, APIC_Out.Flag1);
						FileSystem.FilePut(1, APIC_Out.Flag2);
						if (APIC_Out.Size != 0) {
							FileSystem.FilePut(1, APIC_Out.Bf_Data);
							FileSystem.FilePut(1, APIC_Out.Data);
						}
					}
					*/
					while (FileSystem.Seek(1) <= ID3v2_Len_Out) {
						FileSystem.FilePut(1, 0);
					}
				//Wait.DefInstance.ProgressBar.EditValue = 'Wait.DefInstance.ProgressBar.Properties.Maximum
				} else {
					FileSystem.FileOpen(4, MyFileName, OpenMode.Binary,OpenAccess.ReadWrite,OpenShare.Shared);
					FileSystem.Seek(4, 1);

					//Wait.DefInstance.ProgressBar.EditValue = 0
					//Wait.DefInstance.ProgressBar.Properties.Maximum = ID3v2_len + FileLen(MyFileName) - ID3v2_len - 10

					FileSystem.FilePut(4, ID3v2HD_Out.h_Tag);
					FileSystem.FilePut(4, ID3v2HD_Out.h_mVn);
					FileSystem.FilePut(4, ID3v2HD_Out.h_rVn);
					FileSystem.FilePut(4, ID3v2HD_Out.h_Flags);
					FileSystem.FilePut(4, ID3v2HD_Out.h_Size);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(4)

					FileSystem.FilePut(4, TIT2_Out.Name);
					//名称
					FileSystem.FilePut(4, TIT2_Out.Size);
					FileSystem.FilePut(4, TIT2_Out.Flag1);
					FileSystem.FilePut(4, TIT2_Out.Flag2);
					FileSystem.FilePut(4, TIT2_Out.Bf_Data);
					FileSystem.FilePut(4, TIT2_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(4)

					FileSystem.FilePut(4, TPE1_Out.Name);
					//表演者
					FileSystem.FilePut(4, TPE1_Out.Size);
					FileSystem.FilePut(4, TPE1_Out.Flag1);
					FileSystem.FilePut(4, TPE1_Out.Flag2);
					FileSystem.FilePut(4, TPE1_Out.Bf_Data);
					FileSystem.FilePut(4, TPE1_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(4)

					FileSystem.FilePut(4, TCOM_Out.Name);
					//作曲
					FileSystem.FilePut(4, TCOM_Out.Size);
					FileSystem.FilePut(4, TCOM_Out.Flag1);
					FileSystem.FilePut(4, TCOM_Out.Flag2);
					FileSystem.FilePut(4, TCOM_Out.Bf_Data);
					FileSystem.FilePut(4, TCOM_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(4)

					FileSystem.FilePut(4, TALB_Out.Name);
					//专辑
					FileSystem.FilePut(4, TALB_Out.Size);
					FileSystem.FilePut(4, TALB_Out.Flag1);
					FileSystem.FilePut(4, TALB_Out.Flag2);
					FileSystem.FilePut(4, TALB_Out.Bf_Data);
					FileSystem.FilePut(4, TALB_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(4)

					FileSystem.FilePut(4, TRCK_Out.Name);
					//轨道
					FileSystem.FilePut(4, TRCK_Out.Size);
					FileSystem.FilePut(4, TRCK_Out.Flag1);
					FileSystem.FilePut(4, TRCK_Out.Flag2);
					FileSystem.FilePut(4, TRCK_Out.Bf_Data);
					FileSystem.FilePut(4, TRCK_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(4)

					FileSystem.FilePut(4, TYER_Out.Name);
					//年份
					FileSystem.FilePut(4, TYER_Out.Size);
					FileSystem.FilePut(4, TYER_Out.Flag1);
					FileSystem.FilePut(4, TYER_Out.Flag2);
					FileSystem.FilePut(4, TYER_Out.Bf_Data);
					FileSystem.FilePut(4, TYER_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(4)

					FileSystem.FilePut(4, TCON_Out.Name);
					//类型
					FileSystem.FilePut(4, TCON_Out.Size);
					FileSystem.FilePut(4, TCON_Out.Flag1);
					FileSystem.FilePut(4, TCON_Out.Flag2);
					FileSystem.FilePut(4, TCON_Out.Bf_Data);
					FileSystem.FilePut(4, TCON_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(4)

					FileSystem.FilePut(4, COMM_Out.Name);
					//注释
					FileSystem.FilePut(4, COMM_Out.Size);
					FileSystem.FilePut(4, COMM_Out.Flag1);
					FileSystem.FilePut(4, COMM_Out.Flag2);
					FileSystem.FilePut(4, COMM_Out.Bf_Data);
					FileSystem.FilePut(4, COMM_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(4)

					FileSystem.FilePut(4, USLT_Out.Name);
					//歌词
					FileSystem.FilePut(4, USLT_Out.Size);
					FileSystem.FilePut(4, USLT_Out.Flag1);
					FileSystem.FilePut(4, USLT_Out.Flag2);
					FileSystem.FilePut(4, USLT_Out.Bf_Data);
					FileSystem.FilePut(4, USLT_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(4)

					FileSystem.FilePut(4, TENC_Out.Name);
					//编码方式
					FileSystem.FilePut(4, TENC_Out.Size);
					FileSystem.FilePut(4, TENC_Out.Flag1);
					FileSystem.FilePut(4, TENC_Out.Flag2);
					FileSystem.FilePut(4, TENC_Out.Bf_Data);
					FileSystem.FilePut(4, TENC_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(4)

					FileSystem.FilePut(4, TCOP_Out.Name);
					//版权
					FileSystem.FilePut(4, TCOP_Out.Size);
					FileSystem.FilePut(4, TCOP_Out.Flag1);
					FileSystem.FilePut(4, TCOP_Out.Flag2);
					FileSystem.FilePut(4, TCOP_Out.Bf_Data);
					FileSystem.FilePut(4, TCOP_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(4)

					FileSystem.FilePut(4, WXXX_Out.Name);
					//URL链接
					FileSystem.FilePut(4, WXXX_Out.Size);
					FileSystem.FilePut(4, WXXX_Out.Flag1);
					FileSystem.FilePut(4, WXXX_Out.Flag2);
					FileSystem.FilePut(4, WXXX_Out.Bf_Data);
					FileSystem.FilePut(4, WXXX_Out.Data);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(4)

					//FileSystem.FilePut(4, APIC_Out.Name);
					
					//封面图片
					/*
					FileSystem.FilePut(4, APIC_Out.Size);
					FileSystem.FilePut(4, APIC_Out.Flag1);
					FileSystem.FilePut(4, APIC_Out.Flag2);
					if (APIC_Out.Size != 0) {
						FileSystem.FilePut(4, APIC_Out.Bf_Data);
						FileSystem.FilePut(4, APIC_Out.Data);
					}
					//Wait.DefInstance.ProgressBar.EditValue = Seek(4)

					while (FileSystem.Seek(4) <= ID3v2_Len_Out) {
						FileSystem.FilePut(4, 0);
					}
					//Wait.DefInstance.ProgressBar.Text = Seek(4)

					FileSystem.Seek(1, ID3v2_len + 11);
					OutPut = new byte[FileSystem.FileLen(MyFileName) - ID3v2_len - 10];
					FileSystem.FileGet(1, OutPut);
					FileSystem.FilePut(4, OutPut);
					//Wait.DefInstance.ProgressBar.EditValue = Seek(4)

					FileSystem.FileClose(1);
					FileSystem.FileClose(4);
					/*
					if (FileListBox1.Path[FileListBox1.Path.Length - 1] != "\\") {
						MyFileName = FileListBox1.Path + "\\" + FileListBox1.FileName;
					} else {
						MyFileName = FileListBox1.Path + FileListBox1.FileName;
					}

					R_t = 0;
					while ((R_t <= 3 & R_Tmp == 0)) {
						if (R_t != 0) {
							System.Threading.Thread.Sleep(1000);
						}
						R_t += 1;
						Del_tmp = MyFileName;
						R_Tmp = Del_MP3(Del_tmp);
					}
					Del_tmp = MyFileName;
					if (R_Tmp == 0) {
						Interaction.MsgBox("文件更替失败，请关闭正在打开该文件的程序后重新执行以上操作。", 16, "错误");
						FileSystem.Rename(Del_tmp + ".tmp", Del_tmp + ".Change.mp3");
					} else {
						FileSystem.Rename(Del_tmp + ".tmp", Del_tmp);
					}

				}
				*/
				//=================================================
				//Wait.DefInstance.ProgressBar.EditValue = 'Wait.DefInstance.ProgressBar.Properties.Maximum
			
			//Wait.DefInstance.hide()
			

					FileSystem.FileClose(1);
					FileSystem.FileClose(4);

				}
		}
	     
		private int Swap_Out(int OldSize)
	{
		byte[] BitArry = new byte[32];
		int NewSize = 0;
		byte Temp = 0;
		int T = 0;

		T = 1;
		NewSize = 0;


		for (I = 31; I >= 0; I += -1) {
			BitArry[I] = (byte)((OldSize & T) / T);
			T *= 2;
		}
		//Beep()
		for (I = 0; I <= 1; I += 1) {
			for (J = 0; J <= 7; J += 1) {
				Temp = BitArry[I * 8 + J];
				BitArry[I * 8 + J] = BitArry[31 - 7 - I * 8 + J];
				BitArry[31 - 7 - I * 8 + J] = Temp;
			}
		}
		//Beep()
		if (BitArry[0] == 0) {
			for (I = 0; I <= 31; I += 1) {
				NewSize = NewSize * 2 + BitArry[I];
			}
		} else {
			for (I = 0; I <= 31; I += 1) {
				BitArry[I] = (byte)Math.Pow((BitArry[I] - 1), 2);
			}
			for (I = 0; I <= 31; I += 1) {
				NewSize = NewSize * 2 + BitArry[I];
			}
			NewSize += 1;
			NewSize = -NewSize;
		}
		return NewSize;
	}
		
	private int CLen(string s_str)
	{

		int i_num = 0;
		int i_index = 0;
		int i_len = 0;
		i_len = Strings.Len(s_str);
		for (i_index = 1; i_index <= i_len; i_index++) {
			if (Strings.Asc(Strings.Mid(s_str, i_index, 1)) < 0) {
				i_num = i_num + 1;
			}
		}
		return i_len + i_num;

	}
		private int Re_Swap_HD(int OldSize)
	{
		byte[] BitArry_1 = new byte[28];
		byte[] BitArry_2 = new byte[32];
		int NewSize = 0;
		byte Temp = 0;
		int Eight = 0;
		int T = 0;
		T = 1;
		NewSize = 0;
		//------------

		for (I = 27; I >= 0; I += -1) {
			BitArry_1[I] =(byte) ((OldSize & T) / T);
			T *= 2;
		}
		//-----------
		J = 28;
		Eight = 1;
		for (I = 31; I >= 0; I += -1) {
			if (Eight != 8) {
				Eight = Eight + 1;
				J = J - 1;
				BitArry_2[I] = BitArry_1[J];
			} else {
				Eight = 1;
				BitArry_2[I] = 0;
			}
		}
		//----------
		for (I = 0; I <= 1; I += 1) {
			for (J = 0; J <= 7; J += 1) {
				Temp = BitArry_2[I * 8 + J];
				BitArry_2[I * 8 + J] = BitArry_2[31 - 7 - I * 8 + J];
				BitArry_2[31 - 7 - I * 8 + J] = Temp;
			}
		}
		//------------

		for (I = 0; I <= 31; I += 1) {
			NewSize = NewSize * 2 + BitArry_2[I];
		}

		return (int)NewSize;
	}
	}
}
