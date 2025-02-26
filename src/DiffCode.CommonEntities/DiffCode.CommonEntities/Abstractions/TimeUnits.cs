using DiffCode.CommonEntities.Interfaces;
using DiffCode.CommonEntities.Units.Time;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// <para>Время.</para>
/// </summary>
public abstract record TimeUnits : BaseUnits<TimeUnits, TimeMeasure.Unit>
{
  protected TimeUnits(TimeMeasure.Unit units, string name, string shortName, string symbol) : base(units, name)
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
  public override IUnits<TimeUnits, TimeMeasure.Unit> FrUnits => null;

}
