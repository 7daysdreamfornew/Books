using System;

namespace Head_First_Design_Patterns
{
    // What happens when we add wooden decy ducks to the program?
    // They aren't supposed to fly or quack..
    class DecoyDuck : Duck
    {
        protected override void quack(){
            // override to do nothing
            Console.WriteLine("Decoy quack quack quack..");
        }
        protected override void display()
        {
            Console.WriteLine("It looks like a decoy");
        }
    }
}
