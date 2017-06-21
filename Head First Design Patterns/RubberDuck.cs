using System;

namespace Head_First_Design_Patterns
{
    // RubberDuck doesn't fly or doesn't quack
    class RubberDuck : Duck
    {
        protected override void quack()
        {
            // Overriden to Squeak
        }
        protected override void display()
        {
            // Looks like a rubber duck
        }
    }
}
