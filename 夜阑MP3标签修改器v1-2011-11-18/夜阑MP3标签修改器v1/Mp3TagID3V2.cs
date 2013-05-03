using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace 夜阑MP3标签修改器v1
{

    class Mp3TagID3V2
    {      
        // 需要得到的mp3文件信息
        
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
            //public Bitmap Lazy_pic;
        }

        // 标签头结构
        
        private struct TagHeader 
        {
            public string  header;
            public char version;
            public char revision;
            public char flag;
            public int tagSize;
        }

        // 标签帧帧头结构

        private struct FrameHeader
        {
            public string  frameID;//帧标识
            public int frameSize;//帧内容大小
            //public string  storageFlags;//存放标记
        }
        
        //获取标签头信息
        
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


        public Mp3Info GetMp3Info(byte[] mp3Bytes) 
        {
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
                	//从第10位开始，读取mp3流。赋值给framreHeaderBytes
	                for (int i = 0; i < 10; i++) 
	                {
	                    frameHeaderBytes[i] = mp3Bytes[tagSizeCounter++];
	                }
                }
                catch{}
                FrameHeader frameHeader = new FrameHeader();
                //获取标签帧的标识,4位
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
                	case "TIT2": mp3Info.songName = ByteToString(frameContent);
                        break;
                    case "TAL":
                        //专辑
                    case "TALB": mp3Info.albumName = ByteToString(frameContent);
                        break;
                        //长度
                    case "TLEN": mp3Info.fileLength = ByteToString(frameContent);
                        break;
                        //时长
                    case "TIME": mp3Info.musicDuration = ByteToString(frameContent);
                        break;
                    case "TPE2": 
                        //艺人
                    case "TPE1": mp3Info.singerName = ByteToString(frameContent);
                        break;
                        //音轨
                	case "TRCK": mp3Info.track = ByteToString(frameContent);
                        break;
                        //备注
                    case "COMM": 
                        byte [] frameContent2= new byte[frameContent.LongLength-4];
                        for(int i=0;i<frameContent.Length-4;i++)
                        {
                        	frameContent2[i]=frameContent[4+i];
                        }
                        
                        mp3Info.comm = ByteToString(frameContent2);
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
        }
    }
}
