namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Единица измерения: неделя.
/// </summary>
internal record Week : TimeUnits
{
  public Week() : base(TimeUnits.Unit.Week, "неделя", "нед.", "нед.")
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
