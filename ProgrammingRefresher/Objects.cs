using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Person Rob = new Person("Rob", 55);
Rob.Greeting();
Rob.Introduce();
Rob.Shout("Arghhhh");
Person Amanda = new Person("Amanda", 22);
Amanda.setAge(22);     
    Console.WriteLine("Amanda is : " + Amanda.getAge());
            */
namespace ProgrammingRefresher
{
    
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Person (string name, int age)
            {
                Name = name;
                Age = age;
            }
            
        public void setAge(int i)
        {
            Age = i;
        }

        public int getAge()
        {
            return Age;
        }
         public void Greeting()
         {
            Console.WriteLine("Hello ");
         } 
        
        public void Shout(string shout)
        {
            Console.WriteLine("Loud voice: " + shout);
        }
        public void Introduce()
        {
            Console.WriteLine("Hello I am " + Name);
        } 

         }
    }

