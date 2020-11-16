using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Storm s = new Storm("wind", false, "Zul'rajas");
      Console.WriteLine(s.Announce());

      Pupil i = new Pupil("Mezil-kree");
      Storm temp = i.CastWindStorm();
      Console.WriteLine(temp.Announce());

      Mage j = new Mage("Gul'dan");
      Storm temp2 = j.CastRainStorm();
      Console.WriteLine(temp2.Announce());

      Archmage k = new Archmage("Nielas Aran");
      Storm temp3 = k.CastRainStorm();
      Storm temp4 = k.CastLightningStorm();
      Console.WriteLine(temp3.Announce());
      Console.WriteLine(temp4.Announce());
    }
  }
}
