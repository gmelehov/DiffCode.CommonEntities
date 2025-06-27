namespace DiffCode.CommonEntities.Units.Quantity;

/// <summary>
/// Единица измерения: штука.
/// </summary>
internal record Piece : QuantityUnits
{
  public Piece() : base(QuantityUnits.Unit.Piece, "штука", "шт.", "шт.")
  {
    
  }


}