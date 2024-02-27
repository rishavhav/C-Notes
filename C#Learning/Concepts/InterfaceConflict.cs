using System;


namespace InterfaceConflict {
  
  public interface IInterface1 {
    public void DoSomething();
  }

  public interface IInterface2 {
    public void DoSomething();
  }

  public class SomeClass : IInterface1, IInterface2 {
      void IInterface1.DoSomething() {
        Console.WriteLine("Hey");
      }

      void IInterface2.DoSomething() {
        Console.WriteLine("Hola");
      }   
  }
}