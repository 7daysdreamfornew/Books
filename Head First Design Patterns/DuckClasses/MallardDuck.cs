using System;

namespace Head_First_Design_Patterns
{
    class MallardDuck : Duck
    {  
        public MallardDuck(){
            IQuackBehaviour quackBehaviour = new Quack();
            IFlyBehaviour flyBehaviour = new FlyWithWings();
        }

        protected override void display()
        {
            Console.WriteLine("It looks like a mallard.");
        }
    
    }
}
