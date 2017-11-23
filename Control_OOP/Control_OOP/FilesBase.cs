using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    abstract class FilesBase
    {
        private string _Name;
        private string _Extension;
        private string _Size;

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

        public string Split()
        {
            
            return $"{Name}, Extension: {Extension}, Size: {Size}";
        }
    }
}


