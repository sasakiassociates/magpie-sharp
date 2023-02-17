using Speckle.Core.Kits;
using Speckle.Core.Models;
using System.Collections.Generic;

namespace Sasaki.MagpieObjects.Speckle
{

  public class GlobalData : MagpieBase, IMagpieGlobals
  {
    public string rhinoFileName { get; set; }
    public string ghFileName { get; set; }
    public List<string> views { get; set; }

    public GlobalData()
    { }

    [SchemaInfo("Document Data", "Create a Magpie Global Document Data", Sasaki.Stratosphere.Tools.MAGPIE, "Globals")]
    public GlobalData(string rhinoFileName, string ghFileName, List<string> views)
    {
      this.rhinoFileName = rhinoFileName;
      this.ghFileName = ghFileName;
      this.views = views;
    }
  }

}
