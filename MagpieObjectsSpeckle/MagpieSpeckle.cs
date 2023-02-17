using Speckle.Core.Kits;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Sasaki.MagpieObjects.Speckle
{

  public class MagpieSpeckle : ISpeckleKit
  {

    const string CONVERTER_BASE_NAME = "Sasaki.MagpieObjects.Converter";
    private static string Location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Speckle\\Kits\\Sasaki");

    public ISpeckleConverter LoadConverter(string app)
    {

      var _converters = Directory.EnumerateFiles(Location, CONVERTER_BASE_NAME + ".*").ToList()
        .Select(dllPath => dllPath.Split('.').Reverse().ToList()[1])
        .ToList();

      try
      {
        var path = Path.Combine(Location, CONVERTER_BASE_NAME + ".dll");
        if(File.Exists(path))
        {
          foreach(var t in Assembly.LoadFrom(path).GetTypes())
            foreach(var i in t.GetInterfaces())
            {
              if(i.Name == nameof(ISpeckleConverter)
                 && Activator.CreateInstance(t) is ISpeckleConverter c
                 && c.GetServicedApplications().Contains(app))
              {
                return c;
              }
            }
        }
      }
      catch(Exception e)
      {
        Console.WriteLine(e.Message);
        return null;
      }

      return null;
    }

    /// <summary>
    ///   Returns a list of supported kit types.
    ///   Currently this contains <see cref="MagpieBase" />
    /// </summary>
    public IEnumerable<Type> Types
    {
      get
      {
        var types = new List<Type>();
        types.AddRange(Assembly.GetExecutingAssembly().GetTypes().Where
          (t => t.IsSubclassOf(typeof(MagpieBase)) || !t.IsAbstract));
        return types;
      }
    }
    public IEnumerable<string> Converters => Directory.EnumerateFiles(Location, CONVERTER_BASE_NAME + ".*").ToList()
      .Select(dllPath => dllPath.Split('.').Reverse().ToList()[1])
      .ToList();

    public string Description => "A Sasaki Magpie Object Kit";
    public string Name => nameof(MagpieBase);
    public string Author => "Sasaki Strategies";
    public string WebsiteOrEmail => "www.sasaki.com";
  }

}
