using Speckle.Core.Kits;
using Speckle.Core.Models;

namespace Sasaki.MagpieObjects.Speckle
{

  /// <summary>
  /// 
  /// </summary>
  public class Context : MagpieBase, IContext
  {
    /// <summary>
    /// some sort of value passed into speckle
    /// </summary>
    public string value { get; set; }

    public Context()
    { }

    [SchemaInfo("Context", "Create a new Context object", Sasaki.Stratosphere.Tools.MAGPIE, "Objects")]
    public Context(string value)
    {
      this.value = value;
    }
  }

}
