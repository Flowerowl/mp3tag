using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace 夜阑MP3标签修改器v1
{
    // 获取MP3文件的ID3 V1版本的TAG信息的类
    internal class Mp3TagID3V1
    {
        //流派分类，共有148种
        readonly string[] GENRE = 
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

        private string title = string.Empty;
        // 标题
        public string Title
        {	
            get { return title; }
            set	{}
        }
        private string artist = string.Empty;
        // 艺术家，演唱者
        public string Artist
        {
            get { return artist; }
        }

        private string album = string.Empty;
        // 所属专辑
        public string Album
        {
            get { return album; }
        }

        private string pubYear = string.Empty;
        // 发行年份
        public string PublishYear
        {
            get { return pubYear; }
        }

        private string comment = string.Empty;
        // 备注、说明
        public string Comment
        {
            get
            {
                if (comment.Length == 30)
                {
                    //如果是 ID3 V1.1的版本，那么comment只占前28个byte，第30个byte存放音轨信息
                    if (TagVersion(comment)) return comment.Substring(0, 28).TrimEnd();
                }

                return comment.TrimEnd();
            }
        }
        // 音轨
        public string Track
        {
            get
            {
                if (comment.Length == 30)
                {
                    //如果是 ID3 V1.1的版本，读取音轨信息
                    if (TagVersion(comment)) return ((int)comment[29]).ToString();
                }

                return string.Empty;
            }
        }

        private string genre;
        // 流派
        public string Genre
        {
            get { return genre; }
        }
        // 判断MP3的TAG信息的版本，是V1.0 还是 V1.1
        //true表示是 1.1，false表示是 1.0
        private bool TagVersion(string comment)
        {
            if (comment[28].Equals('\0') && comment[29] > 0 || comment[28] == 32 && comment[29] != 32)
                return true;
            return false;
        }

        //MP3文件的完整路径
        public Mp3TagID3V1(string mp3FilePath)
        {
            byte[] tagBody = new byte[128];
            string tagFlag;

            if (!File.Exists(mp3FilePath))
            throw new FileNotFoundException("指定的MP3文件不存在！", mp3FilePath);
            //读取MP3文件的最后128个字节的内容
            using (FileStream fs = new FileStream(mp3FilePath, FileMode.Open, FileAccess.Read,FileShare.ReadWrite))
            {
                fs.Seek(-128, SeekOrigin.End);
                fs.Read(tagBody, 0, 128);
                fs.Close();
            }

            //取TAG段的前三个字节
            tagFlag = Encoding.Default.GetString(tagBody, 0, 3);

            //如果没有TAG信息，则直接返回
            if (!"TAG".Equals(tagFlag, StringComparison.InvariantCultureIgnoreCase))
            {
                return;
                //throw new InvalidDataException("指定的MP3文件没有TAG信息！");
            }

            //按照MP3 ID3 V1 的tag定义，依次读取相关的信息
            this.title = Encoding.Default.GetString(tagBody, 3, 30).TrimEnd();
            this.artist = Encoding.Default.GetString(tagBody, 33, 30).TrimEnd();
            this.album = Encoding.Default.GetString(tagBody, 63, 30).TrimEnd();
            this.pubYear = Encoding.Default.GetString(tagBody, 93, 4).TrimEnd();
            this.comment = Encoding.Default.GetString(tagBody, 97, 30);
            Int16 g = (Int16)tagBody[127];
            this.genre = g >= GENRE.Length ? "Unknow" : GENRE[g];
        }
    }
}
