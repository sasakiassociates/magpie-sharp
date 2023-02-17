using Speckle.Core.Kits;
using Speckle.Core.Models;

namespace Sasaki.MagpieObjects.Speckle
{

  public class MagpieModel : MagpieBase
  {
    public Parcels parcels { get; set; }
    public ProgramChunks programChunks { get; set; }
    public Contexts contexts { get; set; }
    public Programs programs { get; set; }
    public GlobalData globalData { get; set; }

    public MagpieModel()
    { }

    [SchemaInfo("Model", "Create a Magpie Model", Sasaki.Stratosphere.Tools.MAGPIE, "Objects")]
    public MagpieModel(Base parcels, Base chunks, Base contexts, Base programs, Base globalData)
    {
      if(parcels is Parcels parcelsCast) this.parcels = parcelsCast;
      if(chunks is ProgramChunks chunksCast) this.programChunks = chunksCast;
      if(contexts is Contexts contextCast) this.contexts = contextCast;
      if(programs is Programs programsCast) this.programs = programsCast;
      if(globalData is GlobalData globalDataCasts) this.globalData = globalDataCasts;
    }


  }

}
