using Speckle.Core.Kits;
using Speckle.Core.Models;
using System.Collections.Generic;

namespace Sasaki.MagpieObjects.Speckle
{

  public class Parcel : MagpieBase, IParcel
  {
    public string parcelId { get; set; }
    public string name { get; set; }
    public int area { get; set; }
    public int color { get; set; }
    [DetachProperty] public List<string> references { get; set; }

    public Parcel()
    { }

    [SchemaInfo("Parcel", "Create new Magpie Parcel object", Stratosphere.Tools.MAGPIE, "Objects")]
    public Parcel(string parcelId, string name, int area, int color, List<string> references)
    {
      this.parcelId = parcelId;
      this.name = name;
      this.area = area;
      this.color = color;
      this.references = references;
    }

  }

}
