using System;
using AbstractLearning;
using AbstractLearning2;
using ExcepetionHandlingLearning;
using DerivedLearning;
using InterfaceConflict;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {

      //   Lambo myLambo = new Lambo();
      //   myLambo.Sound();
      //   myLambo.EngineType();
      //   myLambo.Wheels();
      //   myLambo.TireType();

      //   Car myCar = new Car("Toyota");


      // Calculator calc = new Calculator();
      // calc.Divide(1, 4);

      // DerivedClass dc = new DerivedClass();
      // dc.OverridableMethod();
      // dc.NonOverridableMethod();


      // DerivedClass2 dc2 = new DerivedClass2();
      // dc2.OverridableMethod();
      // dc2.NonOverridableMethod();

      // SomeClass sc = new SomeClass();
      // ((IInterface1)sc).DoSomething();
      
      // IInterface2 sc2 = sc;
      // sc2.DoSomething();


      Stack myStack = new Stack();
      myStack.Push("Hey!");
      myStack.Push(4);
      PrintValues(myStack);

      Stack<string> words = new Stack<string>();
      words.Push("1");
      PrintGenericStack(words);
    } 





  
  // stack print
    public static void PrintValues(IEnumerable myStack) {
      foreach(Object obj in myStack) {
        Console.WriteLine(obj);
      }
    }

  //print generic stack

  public static void PrintGenericStack(Stack<string> myStack) {
    foreach(string s in myStack) {
      Console.WriteLine(s);
    }
  }
}
