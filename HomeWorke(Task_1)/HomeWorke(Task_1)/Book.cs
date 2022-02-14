using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorke_Task_1_
{
    class Book
    {
        public string BookName;
        public int Pagecount;

        


        public Book(string name,int count)
        {
            while (true)
            {
                if (name.Length > 3)
                {
                    BookName = name;
                    break;
                }
                else
                {
                    Console.WriteLine("Adi Duzgun daxil edin");
                    name = Console.ReadLine();
                }
            }
              while (true)
                {
                    if (count>10)
                    {
                        Pagecount = count;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Seifeniz 10-dan az ola bilmez");
                        int.TryParse(Console.ReadLine(),out count);
                    }

                }
            
            
            
        }
        public string Info()
        {
            return $"{BookName},{Pagecount}";
        }


    }

}