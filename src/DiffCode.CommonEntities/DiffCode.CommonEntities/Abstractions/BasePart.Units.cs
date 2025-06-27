namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// <para>Часть/доля.</para>
/// </summary>
public abstract record PartUnits : BaseUnits<PartUnits, PartUnits.Unit>
{
  protected PartUnits(PartUnits.Unit units, string name, string shortName, string symbol) : base(units, name)
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
  public override IUnits<PartUnits, PartUnits.Unit> FrUnits => null;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override IUnits<PartUnits, PartUnits.Unit> Base => null;


  public override decimal? Ratio => null;





  /// <summary>
  /// <para>Типы единиц измерения частей/долей.</para>
  /// </summary>
  public enum Unit
  {

    /// <summary>
    /// <para>Процент.</para>
    /// </summary>
    Percent,
    /// <summary>
    /// <para>Часть/доля.</para>
    /// </summary>
    Fraction

  }

}