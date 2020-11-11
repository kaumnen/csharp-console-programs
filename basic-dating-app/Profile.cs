using System;

namespace DatingProfile
{ 
  class Profile
  {
    //fields

    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    //constructors

    public Profile(string name, int age, string city, string country, string pronouns = "they/them")
    {
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      this.hobbies = new string[5];
    }

    //methods

    public string ViewProfile()
    {
      string result = $"Hello {name}. You have {age} ages. Living in {city}, in country {country}. Pronouns as {pronouns}. Your hobbies are: ";
      foreach (string hobbie in this.hobbies)
      {
        result += hobbie + " ";
      }
      return result;
    }

    public void SetHobbies(string[] hobbies)
    {
      this.hobbies = hobbies;
    }

  }
}
