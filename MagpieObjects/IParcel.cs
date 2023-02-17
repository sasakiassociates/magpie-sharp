namespace Sasaki.MagpieObjects
{

  public interface IParcel : IHaveReferences
  {
    public string parcelId { get; }
    public string name { get; }
    public int area { get; }
    public int color { get; }

  }

}
