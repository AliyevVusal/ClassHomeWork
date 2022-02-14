using System;

namespace HomeWrokClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Xos Gelmisiniz");
            //Console.WriteLine("Mehsulun adin daxil edin");
            //string Name = Console.ReadLine();
            //Console.WriteLine("Qiymetin daxil Edin");
            //double.TryParse(Console.ReadLine(), out double price);
            //Console.WriteLine("Malin sayi");
            //int.TryParse(Console.ReadLine(), out int count);
            //Console.WriteLine("Almag istediyiniz miqdar");
            //double.TryParse(Console.ReadLine(), out double volume);
            //Console.WriteLine("Yaglilig miqdarin secin");
            //double.TryParse(Console.ReadLine(), out double fatrate);

            Milk milk = new Milk("pal",3.2,4,3,2);

          
            

            milk.Sell(5);

            Console.WriteLine(milk.Info());

        }
    }
}
