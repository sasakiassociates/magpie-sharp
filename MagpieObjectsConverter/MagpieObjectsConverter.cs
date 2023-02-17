using Speckle.Core.Kits;
using Speckle.Core.Models;
using System;
using System.Collections.Generic;

namespace Sasaki.MagpieObjects.Speckle
{

  /// <summary>
  /// 
  /// </summary>
  public partial class MagpieObjectsConverter : ISpeckleConverter
  {
    public string Description => "A Sasaki Magpie Converter";
    public string Name => nameof(MagpieObjectsConverter);
    public string Author => "Sasaki Strategies";
    public string WebsiteOrEmail => "www.sasaki.com";
    public ProgressReport Report => new ProgressReport();
    public ReceiveMode ReceiveMode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="object"></param>
    /// <returns></returns>
    public Base ConvertToSpeckle(object @object)
    {
      var obj = new Base();
      if(@object == null) return obj;

      switch(@object)
      {
        case IContext o:
          obj = ContextToSpeckle(o);
          break;
        case IParcel o:
          obj = ParcelToSpeckle(o);
          break;
        case IProgramChunk o:
          obj = ProgramChunkToSpeckle(o);
          break;
      }

      return obj;
    }

    public List<Base> ConvertToSpeckle(List<object> objects)
    {
      return null;
    }

    public bool CanConvertToSpeckle(object @object)
    {
      return true;
    }

    public object ConvertToNative(Base @object)
    {
      return null;
    }

    public List<object> ConvertToNative(List<Base> objects)
    {
      return null;
    }

    public bool CanConvertToNative(Base @object)
    {
      return true;
    }

    public IEnumerable<string> GetServicedApplications()
    {
      return new[]
      {
        HostApplications.Grasshopper.GetVersion(HostAppVersion.v6),
        HostApplications.Grasshopper.GetVersion(HostAppVersion.v7),
        HostApplications.Rhino.GetVersion(HostAppVersion.v7),
        HostApplications.Rhino.GetVersion(HostAppVersion.v7),
        HostApplications.NET.GetVersion(HostAppVersion.v)
      };
    }

    public void SetContextDocument(object doc)
    { }

    public void SetContextObjects(List<ApplicationObject> objects)
    { }

    public void SetPreviousContextObjects(List<ApplicationObject> objects)
    { }

    public void SetConverterSettings(object settings)
    { }


  }

}
