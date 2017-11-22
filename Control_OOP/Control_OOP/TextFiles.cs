using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    class TextFiles : Files
    {
        private string _Content;

        public string Content
        {
            get { return _Content; }
            set { value = _Content; }
        }

        public string FileName()
        {
            return Name = "file.txt";
        }

        public string FileExtension()
        {
            return Extension = ".txt";
        }

        public string FileSize()
        {
            return Size = "6B";
        }        
    }
}
