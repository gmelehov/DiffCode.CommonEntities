namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// <para>День/дата.</para>
/// </summary>
public abstract record DateUnits : BaseUnits<DateUnits, DateUnits.Unit>
{
  protected DateUnits(DateUnits.Unit units, string noun) : base(units, noun)
  {

  }






  /// <summary>
  /// <para>Типы дат/дней.</para>
  /// </summary>
  public enum Unit
  {

    /// <summary>
    /// <para>День недели.</para>
    /// </summary>
    DayOfWeek,
    /// <summary>
    /// <para>День (число) месяца.</para>
    /// </summary>
    DayOfMonth,

  }
}
