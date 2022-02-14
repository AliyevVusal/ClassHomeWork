using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWrokClass2
{
    class Milk:Product
    { 
        public double Volume;
        public double FatRate;

        public Milk(string name, double price, int count, double volume,double fatrate):base(name,price,count)
        {
            Volume = volume;
            FatRate = fatrate;

        }
        public string Info()
        {
            Console.Write(base.Info());
            return $",{Volume} litr hecminde {FatRate} faiz yagliligindadir.";
        }
        


    }
}
