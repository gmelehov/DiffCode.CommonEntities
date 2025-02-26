using DiffCode.CommonEntities.Interfaces;
using DiffCode.CommonEntities.Units.Quantity;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// <para>Количество.</para>
/// </summary>
public abstract record QuantityUnits : BaseUnits<QuantityUnits, QuantityMeasure.Unit>
{
  protected QuantityUnits(QuantityMeasure.Unit units, string name, string shortName, string symbol) : base(units, name)
  {
    Short = shortName;
    Symbol = symbol;
  }




  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override string Short { get; }

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override string Symbol { get; }


  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override IUnits<QuantityUnits, QuantityMeasure.Unit> FrUnits => null;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override IUnits<QuantityUnits, QuantityMeasure.Unit> Base => null;


  public override decimal? Ratio => null;

}