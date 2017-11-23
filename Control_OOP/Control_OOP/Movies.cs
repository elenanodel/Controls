using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    class Movies : FilesBase
    {
        private string _Resolution;
        private string _Length;

        public string Resolution
        {
            get { return _Resolution; }
        }

        public string Length
        {
            get { return _Length; }
        }

        public Movies(string name, string extension, string size, string resolution, string length) : base(name, extension, size)
        {
            _Resolution = resolution;
            _Length = length;
        }

        public override string ToString()
        {
            return $"\n\t{Name} \n\t\tExtension: {Extension} \n\t\tSize: {Size} \n\t\tResolution: {Resolution} \n\t\tLength: {Length}";
        }
    }
}
