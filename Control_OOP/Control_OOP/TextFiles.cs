using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    class TextFiles : FilesBase
    {
        private string _Content;

        public string Content
        {
            get { return _Content; }
        }

        
        public override string ToString()
        {
            return $"{Name} Extension: {Extension} Size: {Size} Content: {Content}";
        }
    }
}
