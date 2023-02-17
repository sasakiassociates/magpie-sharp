using Speckle.Core.Models;
using System;

namespace Sasaki.MagpieObjects.Speckle
{

  public partial class MagpieObjectsConverter
  {
    Base ProgramChunkToSpeckle(IProgramChunk programChunk)
    {
      throw new NotImplementedException();
    }

    Base ParcelToSpeckle(IParcel parcel)
    {
      throw new NotImplementedException();
    }

    Base ContextToSpeckle(IContext context)
    {
      return new Context();
    }
  }

}
