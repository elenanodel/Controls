using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    class Parser
    {
        public TextFiles ParseText(string item)
        {
            string[] split1 = item.Split(new char[] { ';' });
            string[] split2 = split1[0].Split(new char[] { '(' });
            string[] split3 = split2[0].Split(new char[] { '.' });

            TextFiles textFile = new TextFiles(split2[0], split3[1], split2[1], split1[1]);
            return textFile;
        }

        public Movies ParseMovie (string item)
        {
            string[] split1 = item.Split(new char[] { ';' });
            string[] split2 = split1[0].Split(new char[] { '(' });
            string[] split3 = split2[0].Split(new char[] { '.' });

            Movies movies = new Movies(split2[0], split3[2], split2[1], split1[1], split1[2]);
            return movies;
        }

        public Images ParseImage (string item)
        {
            string[] split1 = item.Split(new char[] { ';' });
            string[] split2 = split1[0].Split(new char[] { '(' });
            string[] split3 = split2[0].Split(new char[] { '.' });

            Images images = new Images(split2[0], split3[1], split2[1], split1[1]);
            return images;
        }
    }
}
