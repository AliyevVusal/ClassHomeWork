using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UserName-niz 8 simvoldan kicik olmamlidir!");
            Console.Write("UserName-inizi Daxil Edin : ");
            string user = Console.ReadLine();

            Console.WriteLine("Passeword-nuzda 8 simvoldan kicik olmamlidir,1 Boyuk herif,1 Reqem olmalidir!");
            Console.Write("Passeword-unuzu Daxil Edin : ");
            string password = Console.ReadLine();


            User user1 = new User(user,password);
            Console.WriteLine(user1.UserName);
            Console.WriteLine(user1.Password);
        }
    }
}
