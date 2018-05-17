using System;
using System.Collections.Generic;
using System.Text;
using Uno;

namespace HiUnoApp.Shared.Model
{
#if __ANDROID__ || __IOS__ || __WASM__
    [Preserve]
#endif
    public class Video
    {
        public int VideoID { get; set; }
        public string VideoName { get; set; }
        public string Teacher { get; set; }
        public string VideoImage { get; set; }
    }

    public class VideoContent
    {
        public static IList<Video> GetVideoList()
        {
            var videos = new List<Video>
            {
                new Video { VideoID = 1, VideoName = "Demo1", Teacher = "A", VideoImage = "http://jpkc.gdou.com/wechatlive/content/img/cover/th1006402.png" },
                new Video { VideoID = 2, VideoName = "Demo2", Teacher = "B", VideoImage = "http://jpkc.gdou.com/wechatlive/content/img/cover/th1006402.png" },
                new Video { VideoID = 3, VideoName = "Demo3", Teacher = "C", VideoImage = "http://jpkc.gdou.com/wechatlive/content/img/cover/th1006402.png" }
            };

            return videos;
        }
    }
}
