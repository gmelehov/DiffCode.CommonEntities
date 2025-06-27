namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Единица измерения: месяц.
/// </summary>
internal record Month : TimeUnits
{
  public Month() : base(TimeUnits.Unit.Month, "месяц", "мес.", "мес.")
  {

  }



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Month Base { get; }

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override decimal? Ratio => 1;
}
