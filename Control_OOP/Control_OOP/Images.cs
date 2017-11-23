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

        public override string ToString()
        {
            return $"{Name} Extension: {Extension} Size: {Size} Resolution: {Resolution}";
        }
    }
}
