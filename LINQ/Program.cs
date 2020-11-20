using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();

      foreach (Language temp in languages)
      {
        //Console.WriteLine(temp.Prettify());
      }

      var languageString = languages.Select(s => $"{s.Year}, {s.Name}, {s.ChiefDeveloper}");

      foreach (var strr in languageString)
      {
        //Console.WriteLine(strr);
      }

      var cSharpFirstRel = from l in languages
      where l.Name == "C#"
      select l;

      foreach (var strr in cSharpFirstRel)
      {
        //Console.WriteLine(strr.Prettify());
      }

      var microsoftLangs = from l in languages
      where l.ChiefDeveloper.Contains("Microsoft")
      select l;

      foreach (var strr in microsoftLangs)
      {
        //Console.WriteLine(strr.Prettify());
      }

      var lispDescendants = from l in languages
      where l.Predecessors.Contains("Lisp")
      select l;

      foreach (var strr in lispDescendants)
      {
        //Console.WriteLine(strr.Prettify());
      }

      var scripting = from l in languages
      where l.Name.Contains("Script")
      select l.Name;

      foreach (var strr in scripting)
      {
        //Console.WriteLine(strr);
      }

      //Console.WriteLine(languages.Count());

      var from1995To2005 = from l in languages
      where l.Year >= 1995 || l.Year <= 2005
      select $"{l.Name} was invented in {l.Year}";

      foreach (var strr in from1995To2005)
      {
        Console.WriteLine(strr);
      }

      public void PrettyPrintAll(IEnumerable<Language> result)
      {
        foreach (var strr in result)
        {
          Console.WriteLine(strr);
        }
      }
    }
  }
}
