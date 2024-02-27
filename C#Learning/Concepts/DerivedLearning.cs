using System;

namespace DerivedLearning {
  public class BaseClass {
    public void NonOverridableMethod() {
      Console.WriteLine("Here");
    }

    public virtual void OverridableMethod() {   // only virtual methods are overridden
      Console.WriteLine("Opps!");
    }
  }

  public class DerivedClass : BaseClass {
  
    
    // use sealed to stop override at this level
    public sealed override void OverridableMethod()     {
      Console.WriteLine("Sheesh!");
    }
  }

  public class DerivedClass2: DerivedClass {
    // public override void OverridableMethod()     {
    //   Console.WriteLine("Sheesh2!");
    // }
  }
  
}