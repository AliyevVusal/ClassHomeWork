using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkTask4
{
    class Student 
    {
        public string Name;
        public string Surname;

        public Student()
        {
            Console.WriteLine("Telebenin adin daxil edin");
        }
        public Student(string name,string surname) :this()
        {
            Name = name;
            Surname = surname;

        }
        static void GetStudent(string arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


        }





    }
}
