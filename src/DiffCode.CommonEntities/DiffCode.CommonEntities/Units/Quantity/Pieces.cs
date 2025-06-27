using System.Diagnostics;


namespace DiffCode.CommonEntities.Units.Quantity;

/// <summary>
/// Значение в штуках.
/// </summary>
[DebuggerDisplay("{DisplayAs}")]
public record Pieces : Abstractions.BaseQuantity, IWithGrammarCases
{
  public Pieces() : base(new Piece())
  {

  }

  public Pieces(int val) : base(new Piece())
  {
    Value = val;
  }

  public Pieces(int val, CasesFactory casesFactory) : base(new Instance(), val, casesFactory)
  {

  }




  /// <summary>
  /// Фабрика для создания значений с единицей измерения <see cref="QuantityUnits.Unit.Piece"/>.
  /// </summary>
  /// <param name="val">Количество единиц измерения.</param>
  /// <returns></returns>
  public delegate Pieces Factory(int val);



  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  protected override string DisplayAs => $"{Measure.Units}: {Value} {Measure.Short}";
}