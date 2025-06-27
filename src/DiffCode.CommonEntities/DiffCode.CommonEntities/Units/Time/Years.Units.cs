namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Единица измерения: месяц.
/// </summary>
internal record Year : TimeUnits
{
  public Year() : base(TimeUnits.Unit.Year, "год", "г.", "г.")
  {

  }



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Month Base { get; } = new();

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override decimal? Ratio => 12;
}
