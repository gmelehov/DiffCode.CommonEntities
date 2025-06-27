using System.Diagnostics;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// <para>Валюта.</para>
/// </summary>
[DebuggerDisplay("{Units}")]
public abstract record CurrencyUnits : BaseUnits<CurrencyUnits, CurrencyUnits.Unit>
{
  protected CurrencyUnits(Unit units, string name, string shortName, string symbol) : base(units, name)
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
  /// <para>Типы валют.</para>
  /// </summary>
  public enum Unit
  {

    /// <summary>
    /// <para>Рубль.</para>
    /// </summary>
    Rouble,
    /// <summary>
    /// <para>Копейка.</para>
    /// </summary>
    Kopeck,
    /// <summary>
    /// <para></para>
    /// </summary>
    Dollar,
    /// <summary>
    /// <para></para>
    /// </summary>
    Euro,

  }
}
