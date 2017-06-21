using System;

namespace Head_First_Design_Patterns
{
    class Duck
    {
        protected virtual void quack()
        {

        }

        private void swim()
        {

        }

        // Superclass to take care of the implementation
        protected virtual void display()
        {

        }
        // By putting fly() in the superclass, 
        // flying ability is given to all ducks including those that shouldn't
        public void fly()
        {

        }
    }
}
