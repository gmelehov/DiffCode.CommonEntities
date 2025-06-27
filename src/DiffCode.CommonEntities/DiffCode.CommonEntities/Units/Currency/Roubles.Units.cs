using System.Diagnostics;


namespace DiffCode.CommonEntities.Units.Currency;

/// <summary>
/// Единица измерения: рубль.
/// </summary>
internal record Rouble : CurrencyUnits
{
  public Rouble() : base(CurrencyUnits.Unit.Rouble, "рубль", "руб.", "руб.")
  {
    FrUnits = new();
  }





  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  [DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
  public override Kopeck FrUnits { get; }

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  [DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
  public override Rouble Base { get; }

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override decimal? Ratio => 1;
}
