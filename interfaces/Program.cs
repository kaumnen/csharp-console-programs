using System;

namespace LearnInterfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      Sedan s = new Sedan(60);
      Console.WriteLine($"Sedan with license plate {s.LicensePlate} and {s.Wheels} wheels, driving at {s.Speed} km/h.");
      s.SpeedUp();
      Console.WriteLine($"Sedan's faster speed: {s.Speed}");

      Sedan s2 = new Sedan(70);
      Console.WriteLine($"Sedan with license plate {s2.LicensePlate} and {s2.Wheels} wheels, driving at {s2.Speed} km/h.");
      s2.SpeedUp();
      Console.WriteLine($"Sedan's faster speed: {s2.Speed}");
      
      Truck t = new Truck(45, 500);
      Console.WriteLine($"Truck with license plate {t.LicensePlate} and {t.Wheels} wheels, driving at {t.Speed} km/h.");
      t.SpeedUp();
      Console.WriteLine($"Truck's faster speed: {t.Speed}");


    }
  }
}
