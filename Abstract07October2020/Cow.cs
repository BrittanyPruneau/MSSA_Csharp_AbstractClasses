using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract07October2020
{
    class Cow:Mammal
    {

        public void Mooing()
        {
            Console.WriteLine("mooing from cow");
        }
        public void Breath()
        {
            Console.WriteLine("Breathe"); 
        }


        public override void Speak()
        {
            Console.WriteLine("moo"); 
        }


        public override void Live()
        {
            Console.WriteLine("living from the Cow class"); 

        }

        public override void Die()
        {
            Console.WriteLine("Bye bye"); 
        }
    }
}
