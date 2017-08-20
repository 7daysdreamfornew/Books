using System;

namespace Head_First_Design_Patterns
{
    // RubberDuck doesn't fly or doesn't quack
    class RubberDuck : Duck
    {
        protected override void quack()
        {
            // Overriden to Squeak
            Console.WriteLine("A rubber duck squeak squeak..");
        }
        protected override void display()
        {
            Console.WriteLine("It looks like a rubber duck.");
        }
    }
}
