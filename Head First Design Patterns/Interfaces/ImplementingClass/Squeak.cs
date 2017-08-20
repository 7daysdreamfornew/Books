using System;

namespace Head_First_Design_Patterns
{
    public class Squeak : IQuackBehaviour
    {
        // Implementation of quacks that squeak
        // i.e. rubber ducks
        public void quack(){
            Console.WriteLine("I say.. squeak...");
        }
    }
}