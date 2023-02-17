using Speckle.Core.Kits;
using Speckle.Core.Models;
using System.Collections.Generic;

namespace Sasaki.MagpieObjects.Speckle
{

  public class Parcels : MagpieBase
  {
    List<Parcel> items { get; set; }

    public Parcels()
    { }

 
    [SchemaInfo("Parcels", "Create an object for all Parcels", Sasaki.Stratosphere.Tools.MAGPIE, "Collections")]
    public Parcels(List<Base> items)
    {
      this.items = new List<Parcel>();

      foreach(var i in items)
      {
        if(i is Parcel co) this.items.Add(co);
      }
    }
  }

}