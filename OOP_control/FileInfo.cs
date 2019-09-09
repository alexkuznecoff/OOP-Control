using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_control
{
    public abstract class FileInfo
    {
        public string Name { get; private set; }
        public string Extension { get; private set; }
        public string Size { get; private set; }
        //public FileInfo(string name, string extension, string size)
        //{
        //    Name = name;
        //    _extension = extension;
        //    _size = size;
        //}
        public virtual void Parse(string input)
        {
            string[] splitInput = input.Split('(', ')', ';');
            string[] temp = splitInput[0].Split('.');
            string Name = splitInput[0];
            string Extension = temp[temp.Length -1];
            string Size = splitInput[1];

        }
        public override string ToString()
        {
            return $"Text:\n\t{Name} \n\tExtantion:{Extension}\n\t\tSize:{Size}";
        }

    }
   public class TextFile : FileInfo
    {
        public string SomeText { get; private set; }
        public override void Parse(string input)
        {
            base.Parse(input);
            string[] splitInput = input.Split(';');

            SomeText = splitInput[1];
        }
        public  override string ToString()
        {
            return $"{base.ToString()}\n\t\tContent{SomeText}"; 
        }

       
    }
    public class ImageInfo: FileInfo
    {
        public string Resolution { get; private set; }
        public override void Parse(string input)
        {
            base.Parse(input);

            string[] splitInput = input.Split(';');
            Resolution = splitInput[1];
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t\tContent{Resolution}";
        }
    }
    public class VideoInfo:ImageInfo
    {
        public string Duration { get; private set; }
        public override void Parse(string input)
        {
            base.Parse(input);
            string[] splitInput = input.Split(';');
            Duration = splitInput[1];
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t\tContent{Duration}";
        }
    }
}
