using System;

namespace HomeWorkTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Group nomresin teyin edin");
            int groupno = int.Parse(Console.ReadLine());
            Console.WriteLine("Group Limitini teyin edin");
            int grouplimit = int.Parse(Console.ReadLine());

            Group newstuden = new Group(groupno, grouplimit);


            AddStuden(groupno, grouplimit);




            


            



        }

        static void AddStuden(int groupno, int grouplimit)
        {
            string[] arr = new string[grouplimit];

            for (int i = 0; i < arr.Length; i++)
            {
                if (0 <= grouplimit)
                {
                    Console.WriteLine("Telebenin name-ni daxil edin");
                    arr[i] =  Console.ReadLine();
                    Console.WriteLine("Telebeinin surname-ini daxil edin");
                    arr[i] =  Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Maxsimum sayda Telebe daxil etmisiniz");
                }
            }


        }

        
    }
}
