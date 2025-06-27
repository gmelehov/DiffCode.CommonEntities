namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Единица измерения: календарный день.
/// </summary>
internal record CalendDay : TimeUnits
{
  public CalendDay() : base(TimeUnits.Unit.CalendDay, "календарный день", "календ. дн.", "календ. дн.")
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
