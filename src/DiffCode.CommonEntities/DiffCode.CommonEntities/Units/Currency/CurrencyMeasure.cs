using System.Numerics;

namespace DiffCode.CommonEntities.Units.Currency;

/// <summary>
/// <para>Валюта.</para>
/// </summary>
public static class CurrencyMeasure
{



  public static Roubles Roubles(this decimal number) => new(number);

  public static Kopecks Kopecks(this decimal number) => new(number);



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
