using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    class Images : FilesBase
    {
        private string _Resolution;

        public string Resolution
        {
            get { return _Resolution; }
        }

        public Images(string name, string extension, string size, string resolution) : base(name, extension, size)
        {
            _Resolution = resolution;            
        }

        public override string ToString()
        {
            return $"\n\t{Name}\n\t\t Extension: {Extension}\n\t\t Size: {Size}\n\t\t Resolution: {Resolution}";
        }
    }
}
