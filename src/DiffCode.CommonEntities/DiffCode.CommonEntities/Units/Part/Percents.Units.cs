namespace DiffCode.CommonEntities.Units.Part;

/// <summary>
/// Единица измерения: процент.
/// </summary>
internal record Percent : PartUnits
{
  public Percent() : base(PartUnits.Unit.Percent, "процент", "проц.", "%")
  {

  }



}
