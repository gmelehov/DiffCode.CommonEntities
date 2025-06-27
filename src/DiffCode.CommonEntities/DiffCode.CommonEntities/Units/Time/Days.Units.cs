namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Единица измерения: день.
/// </summary>
internal record Day : TimeUnits
{
  public Day() : base(TimeUnits.Unit.Day, "день", "дн.", "дн.")
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
