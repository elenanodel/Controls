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

        public TextFiles(string name, string extension, string size, string content): base(name, extension, size)
        {
            _Content = content;
        }

        
        public override string ToString()
        {
            return $"\n\t{Name} \n\t\tExtension: {Extension} \n\t\tSize: {Size} \n\t\tContent: {Content}";
        }
    }
}
