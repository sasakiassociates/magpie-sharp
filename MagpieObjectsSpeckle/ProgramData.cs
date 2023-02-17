using Speckle.Core.Kits;
using System.Collections.Generic;

namespace Sasaki.MagpieObjects.Speckle
{

  public class ProgramData : MagpieBase, IMagpieProgramData
  {
    public string name { get; set; }
    public int color { get; set; }
    public int height { get; set; }
    public List<string> tags { get; set; }

    public ProgramData()
    { }

    [SchemaInfo("Program Data", "Create a Magpie Program Data", Sasaki.Stratosphere.Tools.MAGPIE, "Globals")]
    public ProgramData(string name, int color, int height, List<string> tags)
    {
      this.name = name;
      this.color = color;
      this.height = height;
      this.tags = tags;
    }
  }

}
