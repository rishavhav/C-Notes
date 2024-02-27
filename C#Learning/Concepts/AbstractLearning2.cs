using System;

// the constructor is initiated in contructor of the derived class

namespace AbstractLearning2 {
  public abstract class Vehicle
  {
      protected string vehicleType;

      // Constructor in the abstract class
      protected Vehicle(string type)
      {
          this.vehicleType = type;
          Console.WriteLine($"{vehicleType} created.");
      }
  }

  public class Car : Vehicle
  {
      private string brand;

      // Constructor in the derived class
      public Car(string brand) : base("Car")
      {
          this.brand = brand;
          Console.WriteLine($"Brand: {brand}");
      }

  } 
}