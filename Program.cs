using System;
using BookLibrary;

namespace SWE201_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boş constructor ile kitap oluşturma
            Book book1 = new Book();
            book1.Title = "İnce Memed";
            book1.Author = "Yaşar Kemal";
            book1.PageCount = 430;
            book1.ISBN = "9789750801234";

            // Parametreli constructor ile kitap oluşturma
            Book book2 = new Book("Suç ve Ceza", "Fyodor Dostoyevski", 671, "9780140449136");

            Console.WriteLine("Kitap 1: " + book1);
            Console.WriteLine("Kitap 2: " + book2);

            // Property değiştirme
            book2.PageCount = 700;
            Console.WriteLine("Güncellenmiş Kitap 2: " + book2);

            // Ek fonksiyon kullanımı
            Console.WriteLine($"'{book1.Title}' uzun kitap mı? {book1.IsLongBook()}");
        }
    }
}
