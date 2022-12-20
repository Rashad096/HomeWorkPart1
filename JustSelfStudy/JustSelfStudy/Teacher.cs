using System;
using System.Collections.Generic;
using System.Text;

namespace JustSelfStudy
{
    internal class Teacher:Human
    {
        public Teacher(string name, string surname,string subject) : base(name, surname)
        {
            Subject= subject;   
        }
        public string Subject;
    }



}
