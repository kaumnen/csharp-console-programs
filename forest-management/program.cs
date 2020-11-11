using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest amazon = new Forest("Amazon");
      Console.WriteLine(amazon.Trees);
      amazon.Grow();
      Console.WriteLine(amazon.Trees);
    }
  }
}
