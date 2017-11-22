using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    class Movies : Files
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


    }
}
