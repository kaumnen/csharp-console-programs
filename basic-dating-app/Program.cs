using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile(name: "Sam Drakkila", age: 30, city: "New York", country: "USA", pronouns: "he/him");
      
      sam.SetHobbies(new string[] {"listening to audiobooks and podcasts", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice columns"});

      Console.WriteLine(sam.ViewProfile());
    }
  }
}
