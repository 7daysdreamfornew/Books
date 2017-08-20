using System;

namespace Head_First_Design_Patterns
{
    public class Duck
    {
        public Duck()
        {

        }
        // To be deleted once overriden methods are deleted
        protected virtual void quack()
        {
            Console.WriteLine("quack quack quack..");
        }
        // By putting fly() in the superclass, 
        // flying ability is given to all ducks including those that shouldn't
        public void fly()
        {
            Console.WriteLine("I am flying.");
        }

        // Each duck has reference to something that implements the QuackBehaviour interface.
        IQuackBehaviour quackBehaviour;
        IFlyBehaviour flyBehaviour;
        // Replace quack method
        // Rather than handling the quack behaviour itself
        // Duck object delegates that behaviour to the object referenced by IQuackBehaviour.
        public void performQuack(){
            quackBehaviour.quack();
        }
        
        
        private void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        // Superclass to take care of the implementation
        protected virtual void display()
        {
            
        }
        
        public void performFly()
        {
            flyBehaviour.fly();
        }
    }
}
