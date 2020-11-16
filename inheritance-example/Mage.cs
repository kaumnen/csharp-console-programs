using System;

namespace MagicalInheritance
{
  class Mage : Pupil
  {
    public Mage(string title) : base(title)
    {}

    public virtual Storm CastRainStorm()
    {
      return new Storm("rain", false, Title);
    }
  }
}
