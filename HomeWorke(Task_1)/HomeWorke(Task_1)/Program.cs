using System;

namespace HomeWorke_Task_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Book[] books = new Book[2];
          

            for (int i = 0; i <books.Length; i++)
            {

                Console.WriteLine("Kitabin Adin Daxil Edin");
                string name = Console.ReadLine();
                Console.WriteLine("Seife sayin daxil edin");
                int.TryParse(Console.ReadLine(), out int count);
                Book test = new Book(name,count);
                books[i] = test;
            }
            foreach (var item in books)
            {
                Console.WriteLine($"{item.Info()}");
            }
        }
    }
}
