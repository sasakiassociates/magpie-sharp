using NUnit.Framework;
using Sasaki.MagpieObjects.Speckle;
using Speckle.Core.Kits;
using System;
using System.Linq;

namespace Sasaki.MagpieObjects.Tests
{

  public class KitTest
  {

    [Test]
    public void ReadMagpieKit()
    {
      var kits = KitManager.Kits;
      foreach(var kit in kits)
      {
        Console.WriteLine(kit.Name);
        if(kit is MagpieSpeckle mp)
        {
          Console.WriteLine("Found kit!");
          var c = mp.LoadConverter(HostApplications.Rhino.GetVersion(HostAppVersion.v7));
          Console.WriteLine(c);
          foreach(var apps in c.GetServicedApplications())
          {
            Console.WriteLine(apps);
            
          }
          Console.WriteLine(mp.Types.Count());
          foreach(var t in mp.Types)
          {
            Console.WriteLine(t);
          }
        }
      }
    }
  }

}
