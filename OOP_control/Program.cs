using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_control
{
    class Program
    {


        static void Main(string[] args)
        {
            List<FileInfo> result = new List<FileInfo>();

            string text = @"Text: file.txt(6B); Some string content
            Image: img.bmp(19MB); 1920х1080
            Text:data.txt(12B); Another string
            Text:data1.txt(7B); Yet another string
            Movie:logan.2017.mkv(19GB); 1920х1080; 2h12m";

            string[] file = text.Split(new string[] {Environment.NewLine} , StringSplitOptions.RemoveEmptyEntries);
            

            for (int i = 0; i < file.Length; i++)
            {
                string[] split = file[i].Split(':');
                string fileType = split[0].ToLower();

                switch (fileType)
                {
                    case "text":
                       TextFile textInfo = new TextFile();
                        textInfo.Parse(split[1]);
                        result.Add(textInfo);
                        break;
                    case "image":
                        ImageInfo imageInfo = new ImageInfo();
                        imageInfo.Parse(split[1]);
                        result.Add(imageInfo);
                        break;
                    case "video":
                       VideoInfo videoInfo = new VideoInfo();
                        videoInfo.Parse(split[1]);
                        result.Add(videoInfo);
                        break;

                }
              


            }
          foreach(FileInfo f in result)
            {
                Console.WriteLine(f);
            }

        }
    }
}
