using System;

namespace calculator
{
  class Program
  {
    static void Main()
    {
      string x ;
      string y ;

      Console.Write("Enter x: ");
      x = Console.ReadLine();
      int a = Convert.ToInt32(x);
      Console.Write("Enter y: ");
      y = Console.ReadLine();
      int b = Convert.ToInt32(y);
      Calc c = new Calc();
      int ans = c.Add(a, b);
      Console.WriteLine("Answer = " + ans);
      // Wait for user to press the Enter key before shutting down.



      
      Console.ReadLine();
      
    }
  }

  // The C# calculator.
  class Calc
  {
    public int Add(int x, int y)
    { return x + y; }
  }
}
