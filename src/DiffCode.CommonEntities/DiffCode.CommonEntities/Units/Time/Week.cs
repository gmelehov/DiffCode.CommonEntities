using DiffCode.CommonEntities.Abstractions;

namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Единица измерения: неделя.
/// </summary>
public record Week : TimeUnits
{
  public Week() : base(TimeMeasure.Unit.Week, "неделя", "нед.", "нед.")
  {

  }



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Day Base { get; } = new();

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override decimal? Ratio => 7;
}
