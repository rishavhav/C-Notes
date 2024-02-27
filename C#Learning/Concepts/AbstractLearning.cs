using System;

// basically in abstract class we have 3 types of method
// abstract method
// virtual method
// deined method which cannot be overriden


// an abstract class cannot be instantiated. It can have access modifiers.

// abstract class is a class that has at least one abstract method

// abstract class can have constructors(see AbstractLearning2)

namespace AbstractLearning {
    public abstract class Vehicle {
        // Abstract method - no implementation, must be overridden in derived non-abstract class
        public abstract void Sound();

        // Implemented method - provides default implementation. To allow overriding, mark as virtual 
        public void EngineType() {
            Console.WriteLine("V8");
        }

        // Virtual method - provides a default implementation and allows overriding in derived     classes but its your choice if you want to override it or not
        public virtual void Wheels() {
            Console.WriteLine("2");
        }

      public virtual void TireType() {
          Console.WriteLine("Rubber");
      }
    } 

    public class Lambo : Vehicle {
        // The abstract method must be implemented in the derived class
        public override void Sound() {
            Console.WriteLine("Vroom");
        }

        // Correctly override the virtual method from the base class
        public override void Wheels() {
            Console.WriteLine("4");
        }
    }
}
