using Speckle.Core.Kits;
using Speckle.Core.Models;
using System.Collections.Generic;

namespace Sasaki.MagpieObjects.Speckle
{

  public class ProgramChunks :MagpieBase
  {
    List<ProgramChunk> items { get; set; }

    public ProgramChunks()
    { }

    [SchemaInfo("Programs", "Create an object for all Program Data", Sasaki.Stratosphere.Tools.MAGPIE, "Collections")]
    public ProgramChunks(List<Base> items)
    {
      this.items = new List<ProgramChunk>();

      foreach(var i in items)
      {
        if(i is ProgramChunk co) this.items.Add(co);
      }
    }
  }

}