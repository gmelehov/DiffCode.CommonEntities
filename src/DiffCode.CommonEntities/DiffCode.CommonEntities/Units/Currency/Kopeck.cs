using System.Diagnostics;


namespace DiffCode.CommonEntities.Units.Currency;

/// <summary>
/// Единица измерения: копейка.
/// </summary>
internal record Kopeck : CurrencyUnits
{
  public Kopeck() : base(CurrencyUnits.Unit.Kopeck, "копейка", "коп.", "коп.")
  {
    
  }




  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override IUnits<CurrencyUnits, CurrencyUnits.Unit> FrUnits => null;

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