using Speckle.Core.Models;

namespace Sasaki.MagpieObjects.Speckle
{

  /// <summary>
  /// 
  /// </summary>
  public class MagpieBase : Base
  {
    /// <summary>
    /// </summary>
    public MagpieBase()
    { }

    /// <summary>
    ///   Returns <see cref="MagpieBase" />
    /// </summary>
    public override string speckle_type => GetType().ToString();
  }

}
