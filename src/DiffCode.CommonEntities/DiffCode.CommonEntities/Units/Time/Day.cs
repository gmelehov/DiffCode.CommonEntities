using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.Interfaces;

namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Единица измерения: день.
/// </summary>
public record Day : TimeUnits
{
  public Day() : base(TimeMeasure.Unit.Day, "день", "дн.", "дн.")
  {
    
  }




  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Day Base { get; }

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override decimal? Ratio => 1;
}
