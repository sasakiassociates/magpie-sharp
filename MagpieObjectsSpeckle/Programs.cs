using Speckle.Core.Kits;
using Speckle.Core.Models;
using System.Collections.Generic;

namespace Sasaki.MagpieObjects.Speckle
{

  public class Programs : MagpieBase
  {
    List<ProgramData> items { get; set; }

    public Programs()
    { }

    [SchemaInfo("Programs", "Create an object for all Program Data", Sasaki.Stratosphere.Tools.MAGPIE, "Collections")]
    public Programs(List<Base> items)
    {
      this.items = new List<ProgramData>();

      foreach(var i in items)
      {
        if(i is ProgramData co) this.items.Add(co);
      }
    }
  }

}
