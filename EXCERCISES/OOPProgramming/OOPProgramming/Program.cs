using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoAlbum defaultPhoto = new PhotoAlbum();
            PhotoAlbum Photo = new PhotoAlbum(24);
            BigPhotoAlbum bigPhoto = new BigPhotoAlbum();

            Console.WriteLine("Default Photo {0}", defaultPhoto.NumberOfPates);
            Console.WriteLine("Photo {0}", Photo.NumberOfPates);
            Console.WriteLine("Big Photo {0}", bigPhoto.NumberOfPates);

            Console.ReadKey();
        }
    }
}
