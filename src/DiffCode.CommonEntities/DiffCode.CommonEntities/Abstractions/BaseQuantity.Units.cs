namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// <para>Количество.</para>
/// </summary>
public abstract record QuantityUnits : BaseUnits<QuantityUnits, QuantityUnits.Unit>
{
  protected QuantityUnits(QuantityUnits.Unit units, string name, string shortName, string symbol) : base(units, name)
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
  public override IUnits<QuantityUnits, QuantityUnits.Unit> FrUnits => null;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override IUnits<QuantityUnits, QuantityUnits.Unit> Base => null;


  public override decimal? Ratio => null;




  /// <summary>
  /// <para>Типы единиц измерения количества.</para>
  /// </summary>
  public enum Unit
  {

    /// <summary>
    /// <para>Экземпляр.</para>
    /// </summary>
    Instance,
    /// <summary>
    /// <para>Штука.</para>
    /// </summary>
    Piece

  }

}
