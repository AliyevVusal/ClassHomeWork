using System;
namespace HomeWrokClass2
{
    class Product
    {
        public string Name;

        public double Price;

        public int Count;

        public double Totalincom = 1;

      
        public Product(string name)
        {
            Name = name;
           
        }
        
        public Product(string name,double price,int count):this(name)
        {
            Price = price;
            Count = count;
            
        }
     

        public void Sell(int count)
        {
            if (!(count>Count))
            {
                Totalincom = Price * count;
                
                Count = Count - count;

                
            }
            else
            {
                Console.WriteLine("Depoda Qeyd Olunan Maldan Qalmayib");
            }

            
           
        }
        public string Info()
        {


            return $"{Name} Mehsulunun 1 ededi {Price} manatdir {Count} eded var anbarda";
        }
       
    }
}
