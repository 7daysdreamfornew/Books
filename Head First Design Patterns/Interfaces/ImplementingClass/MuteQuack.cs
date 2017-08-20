using System;

namespace Head_First_Design_Patterns
{
    public class MuteQuack : IQuackBehaviour
    {
        // Implementation of quacks can't make noise
        public void quack(){
            Console.WriteLine("I can't quack!");
        }
    }
}