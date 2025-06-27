namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Единица измерения: рабочий день.
/// </summary>
internal record WorkDay : TimeUnits
{
  public WorkDay() : base(TimeUnits.Unit.WorkDay, "рабочий день", "раб. дн.", "раб. дн.")
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
