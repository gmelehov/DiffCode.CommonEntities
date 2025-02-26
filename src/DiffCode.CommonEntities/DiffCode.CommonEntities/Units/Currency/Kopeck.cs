using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.Interfaces;
using System.Diagnostics;


namespace DiffCode.CommonEntities.Units.Currency;

/// <summary>
/// Единица измерения: копейка.
/// </summary>
public record Kopeck : CurrencyUnits
{
  public Kopeck() : base(CurrencyMeasure.Unit.Kopeck, "копейка", "коп.", "коп.")
  {
    
  }




  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override IUnits<CurrencyUnits, CurrencyMeasure.Unit> FrUnits => null;

  /// <summary>
  /// <inheritdoc />
  /// </summary>
  [DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
  public override Rouble Base { get; }

  /// <summary>
  /// <inheritdoc />
  /// </summary>
  public override decimal? Ratio => 1 / (decimal)100;

}