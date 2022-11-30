using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Information[] informations =new Information[3];
            informations[0].nositel = "fgrt";
            informations[0].volume = 54;
            informations[0].name = "gfvbhjnkm";
            informations[0].author = "fghjk";

            informations[1].nositel = "fgrt";
            informations[1].volume = 54;
            informations[1].name = "gfvbhjnkm";
            informations[1].author = "fghjk";

            informations[2].nositel = "fgrt";
            informations[2].volume = 54;
            informations[2].name = "gfvbhjnkm";
            informations[2].author = "fghjk";

            foreach (Information i in informations)
            {
                i.Info();
            }
            Console.ReadLine();
        }
    }
    struct Information
    {
        public string nositel;
        public double volume;
        public string name;
        public string author;
        public void Info()
        {
            Console.WriteLine("Носитель '{0}' {1}(автор {2}) на {3} GB", nositel, name, author, volume);
        }
    }
}