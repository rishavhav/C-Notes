using System;

namespace ExcepetionHandlingLearning
{

  // custom exception
    public class MyCustomException: Exception {
      public MyCustomException(string message) : base(message) {
        Console.WriteLine("in Constructor " + message);
        }
    }


  
    public class Calculator
    {
        public void Divide(int x, int y)
        {
            try
            {
                int result = x / y;
                Console.WriteLine(result);
                if(y > x) {
                  throw new MyCustomException("this is an exception");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
          catch (MyCustomException ex)
          {
              Console.WriteLine(ex.Message);
          }

          //general exception should be handled at the end
          catch (Exception ex) 
          {
            Console.WriteLine(ex.Message);
          }
          finally {
            Console.WriteLine("In the End");
          }
        }
    }
}
