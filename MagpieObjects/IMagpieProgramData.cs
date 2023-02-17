using System.Collections.Generic;

namespace Sasaki.MagpieObjects
{

  public interface IMagpieProgramData
  {
    public string id { get; }
    public string name { get; }
    public int color { get; }
    public int height { get; }
    public List<string> tags { get; }
  }

}