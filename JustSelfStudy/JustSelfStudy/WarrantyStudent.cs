using System;
using System.Collections.Generic;
using System.Text;

namespace JustSelfStudy
{
    internal class WarrantyStudent:Student

    {
        public WarrantyStudent(string name,string surname,string prevGroupNo):base(name) 
        {
            PrevGroupNo = prevGroupNo;
        }





        public string PrevGroupNo;
    }
}
