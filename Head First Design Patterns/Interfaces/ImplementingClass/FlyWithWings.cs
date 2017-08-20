using System;

namespace Head_First_Design_Patterns
{
    public class FlyWithWings : IFlyBehaviour
    {
        // Implementation of flying for all ducks with wings
        public void fly(){
            Console.WriteLine("I'm flying with my wings");
        }
    }
}