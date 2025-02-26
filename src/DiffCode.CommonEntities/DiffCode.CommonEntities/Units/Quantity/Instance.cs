using DiffCode.CommonEntities.Abstractions;

namespace DiffCode.CommonEntities.Units.Quantity;

/// <summary>
/// Единица измерения: экземпляр.
/// </summary>
public record Instance : QuantityUnits
{
  public Instance() : base(QuantityMeasure.Unit.Instance, "экземпляр", "экз.", "экз.")
  {
    
  }



}
