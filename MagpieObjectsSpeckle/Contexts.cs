using Speckle.Core.Kits;
using Speckle.Core.Models;
using System.Collections.Generic;

namespace Sasaki.MagpieObjects.Speckle
{

  public class Contexts : MagpieBase
  {
    List<Context> items { get; set; }

    public Contexts()
    { }

    [SchemaInfo("Contexts", "Create an object for all Contexts", Sasaki.Stratosphere.Tools.MAGPIE, "Collections")]
    public Contexts(List<Base> items)
    {
      this.items = new List<Context>();

      foreach(var i in items)
      {
        if(i is Context co) this.items.Add(co);
      }
    }
  }

}
