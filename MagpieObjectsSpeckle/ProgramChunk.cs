using Speckle.Core.Kits;
using Speckle.Core.Models;
using System.Collections.Generic;

namespace Sasaki.MagpieObjects.Speckle
{

  public class ProgramChunk : MagpieBase, IProgramChunk
  {
    
    public string parcelId { get; set; }

    public string programId { get; set; }

    public string buildingId { get; set; }

    public int area { get; set; }

    [DetachProperty] public List<string> references { get; set; }

    public ProgramChunk()
    { }

    [SchemaInfo("Program Chunk", "Create a new Program Chunk", Sasaki.Stratosphere.Tools.MAGPIE, "Objects")]
    public ProgramChunk(string parcelId, string programId, string buildingId, int area, List<string> references)
    {
      this.parcelId = parcelId;
      this.programId = programId;
      this.buildingId = buildingId;
      this.area = area;
      this.references = references;
    }
  }

}
