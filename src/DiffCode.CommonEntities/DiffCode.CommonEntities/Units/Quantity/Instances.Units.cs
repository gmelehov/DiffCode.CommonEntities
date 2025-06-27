namespace DiffCode.CommonEntities.Units.Quantity;

/// <summary>
/// Единица измерения: экземпляр.
/// </summary>
internal record Instance : QuantityUnits
{
  public Instance() : base(QuantityUnits.Unit.Instance, "экземпляр", "экз.", "экз.")
  {
    
  }



}
