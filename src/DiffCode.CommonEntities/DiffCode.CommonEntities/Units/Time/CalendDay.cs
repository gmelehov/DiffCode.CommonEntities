using DiffCode.CommonEntities.Abstractions;
using System.Numerics;


namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Единица измерения: календарный день.
/// </summary>
public record CalendDay : TimeUnits
{
  public CalendDay() : base(TimeMeasure.Unit.CalendDay, "календарный день", "календ. дн.", "календ. дн.")
  {
    
  }



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Day Base { get; } = new();

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override decimal? Ratio => 1;
}











public record CalendDays<T> : Time<T> where T : INumber<T>
{
  public CalendDays(T value) : base(value, new CalendDay())
  {

  }


}