using System;
using System.Collections.Generic;
using System.Text;

namespace JustSelfStudy
{
    internal class Human
    {
        public Human(string name) 
        {
            Name= name;
           
        }

        public Human(string name,string surname):this(name)
        {
            
            Surname= surname;
           
        }

      


       
        public string Name;
        public string Surname;
        public int Age=15;
    }
}
