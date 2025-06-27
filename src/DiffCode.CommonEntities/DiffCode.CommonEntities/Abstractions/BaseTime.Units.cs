namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// <para>Время.</para>
/// </summary>
public abstract record TimeUnits : BaseUnits<TimeUnits, TimeUnits.Unit>
{
  protected TimeUnits(TimeUnits.Unit units, string name, string shortName, string symbol) : base(units, name)
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
  public override IUnits<TimeUnits, TimeUnits.Unit> FrUnits => null;




  /// <summary>
  /// <para>Типы единиц измерения времени.</para>
  /// </summary>
  public enum Unit
  {
    /// <summary>
    /// Минута.
    /// </summary>
    Minute,
    /// <summary>
    /// Час.
    /// </summary>
    Hour,
    /// <summary>
    /// День.
    /// </summary>
    Day,
    /// <summary>
    /// Рабочий день.
    /// </summary>
    WorkDay,
    /// <summary>
    /// Календарный день.
    /// </summary>
    CalendDay,
    /// <summary>
    /// Неделя.
    /// </summary>
    Week,
    /// <summary>
    /// Месяц.
    /// </summary>
    Month,
    /// <summary>
    /// Квартал.
    /// </summary>
    Quarter,
    /// <summary>
    /// Полугодие.
    /// </summary>
    HalfYear,
    /// <summary>
    /// Год.
    /// </summary>
    Year
  }

}
