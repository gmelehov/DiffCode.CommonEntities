using DiffCode.CommonEntities.Abstractions;

namespace DiffCode.CommonEntities.Units.Quantity;

/// <summary>
/// Единица измерения: штука.
/// </summary>
public record Piece : QuantityUnits
{
  public Piece() : base(QuantityMeasure.Unit.Piece, "штука", "шт.", "шт.")
  {
    
  }


}