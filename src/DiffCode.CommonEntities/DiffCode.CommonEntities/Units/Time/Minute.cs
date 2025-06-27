namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Единица измерения: минута.
/// </summary>
internal record Minute : TimeUnits
{
  public Minute() : base(TimeUnits.Unit.Minute, "минута", "мин.", "мин.")
  {

  }



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Day Base { get; } = new();

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override decimal? Ratio => 1 / 24 / 60;
}