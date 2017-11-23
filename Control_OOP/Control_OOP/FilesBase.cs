using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    class FilesBase
    {
        protected string _Name;
        protected string _Extension;
        protected string _Size;

        public string Name
        {
            get { return _Name; }
        }

        public string Extension
        {
            get { return _Extension; }
        }

        public string Size
        {
            get { return _Size; }
        }

        public FilesBase(string name, string extension, string size)
        {
            _Name = name;
            _Extension = extension;
            _Size = size;    
        }

        public string Split()
        {
            
            return $"{Name}, Extension: {Extension}, Size: {Size}";
        }
    }
}


