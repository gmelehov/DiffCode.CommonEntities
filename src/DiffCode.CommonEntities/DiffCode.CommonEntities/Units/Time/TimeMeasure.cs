using System.Numerics;

namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// <para>Время.</para>
/// </summary>
public static class TimeMeasure
{


  public static CalendDays<T> CalendDays<T>(this T val) where T : INumber<T> => new(val);



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
