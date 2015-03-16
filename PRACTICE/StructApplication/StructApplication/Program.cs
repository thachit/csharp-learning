using System;

namespace StructApplication
{
    struct Book
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;
    };

    class Bookmanagement
    {
        static void Main(string[] args)
        {
            Book book_1;
            book_1.title = "C# programming";
            book_1.author = "Thach Nguyen";
            book_1.subject = "Teach you coding C#";
            book_1.book_id = 1;

            Book book_2;
            book_2.title = "OpenERP cookbook";
            book_2.author = "Thach Co";
            book_2.subject = "OpenERP specification";
            book_2.book_id = 2;

            Console.WriteLine("============================");
            Console.WriteLine(book_2.title);
            Console.ReadLine();
        }
    }

}