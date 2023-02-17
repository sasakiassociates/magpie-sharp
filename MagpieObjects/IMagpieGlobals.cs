using System.Collections.Generic;

namespace Sasaki.MagpieObjects
{

  public interface IMagpieGlobals
  {
    public string rhinoFileName { get; }
    public string ghFileName { get; }
    public List<string> views { get; }
  }

}