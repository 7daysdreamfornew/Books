using System;

namespace Head_First_Design_Patterns
{
    public class Quack : IQuackBehaviour
    {
        // Implementation of quacks that really quack
        public void quack(){
            Console.WriteLine("I say.. quack quack quack");
        }
    }
}