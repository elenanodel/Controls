using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            

            String text = @"Text: file.txt(6B); Some string content
                           Image: img.bmp(19MB); 1920х1080
                           Text:data.txt(12B); Another string
                           Text:data1.txt(7B); Yet another string
                           Movie:logan.2017.mkv(19GB); 1920х1080; 2h12m";

            
            string[] strings = text.Split(new char[] {'\n'});
            foreach (string item in strings)
            {
                Console.WriteLine(item);

                switch (item)
                {
                    case ("Text:"):
                        {
                            TextFiles textFile = new TextFiles();
                            textFile.ToString();
                            Console.WriteLine(textFile);
                            break;
                        }
                    case ("Movie:"):
                        {
                            Movies movie = new Movies();
                            movie.ToString();
                            Console.WriteLine(movie);
                            break;
                        }
                    case ("Image:"):
                        {
                            Images image = new Images();
                            image.ToString();
                            Console.WriteLine(image);
                            break;
                        }
                }
            }
        }
    }
}
