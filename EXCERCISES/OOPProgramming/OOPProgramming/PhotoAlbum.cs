using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProgramming
{
    class PhotoAlbum
    {
        // Properties
        private int numberOfPages;

        public int NumberOfPates
        {
            get { return numberOfPages; }
            set { numberOfPages = value; }
        }

        // Constructor
        public PhotoAlbum()
        {
            numberOfPages = 16;
        }

        public PhotoAlbum(int p)
        {
            numberOfPages = p;
        }

    }

    class BigPhotoAlbum : PhotoAlbum
    {
        public BigPhotoAlbum()
        {
            NumberOfPates = 64;
        }
    }
}
