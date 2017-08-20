using System;

namespace Head_First_Design_Patterns
{
    class RedheadDuck : Duck
    {
        protected override void display()
        {
            Console.WriteLine("It looks like a redhead");
        }
    }
}
