namespace Sasaki.MagpieObjects
{

  public interface IProgramChunk : IHaveReferences
  {
    public string parcelId { get; }
    public string programId { get; }
    public string buildingId { get; }
    public int area { get; }
  }

}