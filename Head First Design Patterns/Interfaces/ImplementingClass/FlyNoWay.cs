using System;

namespace Head_First_Design_Patterns
{
    public class FlyNoWay : IFlyBehaviour
    {
        // Implementation of flying for all ducks that can't fly
        public void fly(){
            Console.WriteLine("I can't fly.");
        }
    }
}