namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Единица измерения: час.
/// </summary>
internal record Hour : TimeUnits
{
  public Hour() : base(TimeUnits.Unit.Hour, "час", "ч.", "ч.")
  {

  }



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Day Base { get; } = new();

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override decimal? Ratio => 1 / 24;
}
