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

            List<TextFiles> TextFilesList = new List<TextFiles>();
            List<Movies> MoviesList = new List<Movies>();
            List<Images> ImagesList = new List<Images>();
            Parser parse = new Parser();

            string[] strings = text.Split(new char[] {'\n'});
            foreach (string item in strings)
            {                              
                string[] type = item.Split(new char[] { ':' });

                if (type[0] == "Text")
                {
                    TextFilesList.Add(parse.ParseText(type[1]));
                }

                if (type[0] == "Movie")
                {
                    MoviesList.Add(parse.ParseMovie(type[1]));
                }     
                
                if (type[0] == "Image")
                {
                    ImagesList.Add(parse.ParseImage(type[1]));
                }                   
            }

            foreach(TextFiles text1 in TextFilesList)
            {
                Console.WriteLine(text1);
            }
            foreach (Movies movie1 in MoviesList)
            {
                Console.WriteLine(movie1);
            }
            foreach (Images image1 in ImagesList)
            {
                Console.WriteLine(image1);
            }
        }
    }
}
