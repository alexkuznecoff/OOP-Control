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
            Name = splitInput[0];
            Extension = temp[temp.Length - 1];
            Size = splitInput[1];

        }
        public override string ToString()
        {
            return $"Info:\t{Name} \t\n\t\tExtantion:  {Extension}\n\t\tSize:        {Size}";
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
        public override string ToString()
        {
            return $"{base.ToString()}\n\t\tSome Text:  {SomeText}";
        }


    }
    public class ImageInfo : FileInfo
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
            return $"{base.ToString()}\t\n\t\tResolution:{Resolution}"; 
        }
    }
    public class VideoInfo : ImageInfo
    {
        public string Duration { get; private set; }
        public override void Parse(string input)
        {
            base.Parse(input);
            string[] splitInput = input.Split(';');
            Duration = splitInput[2];
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t\tDuration:   {Duration}";
        }
    }
}
