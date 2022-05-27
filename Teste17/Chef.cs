using System;
using System.Collections.Generic;
using System.Text;

namespace Teste17
{
    internal class Chef { 
        public void MakeChiken()
        {
            Console.WriteLine("The Chef makes chiken");
        }
        public void makeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    
    }
}
