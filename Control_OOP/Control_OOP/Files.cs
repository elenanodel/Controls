using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    class Files
    {
        private string _Text;
        private string _Name;
        private string _Extension;
        private string _Size;        

        public string Text
        {
            get { return _Text; }
            
        }
        public string Name
        {
            get { return _Name; }
            set { value = _Name; }           
        }
        public string Extension
        {
            get { return _Extension; }
            set { value = _Extension; }
        }
        public string Size
        {
            get { return _Size; }
            set { value = _Size; }
        }

        public string TextFile()
        {
            return _Text = @"Text: file.txt(6B); Some string content;
                           Image: img.bmp(19MB); 1920х1080;
                           Text:data.txt(12B); Another string;
                           Text:data1.txt(7B); Yet another string;
                           Movie:logan.2017.mkv(19GB); 1920х1080; 2h12m";
        }

        public string Texts()
        {
            char separator = ';';
            string[] textFiles = Text.Split(separator);
            return Text;
        }
    }

}
