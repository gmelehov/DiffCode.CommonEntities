using DiffCode.CommonEntities.Units.Currency;
using System.Diagnostics;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// <para>Валюта.</para>
/// </summary>
[DebuggerDisplay("{Units}")]
public abstract record CurrencyUnits : BaseUnits<CurrencyUnits, CurrencyMeasure.Unit>
{
  protected CurrencyUnits(CurrencyMeasure.Unit units, string name, string shortName, string symbol) : base(units, name)
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

}
