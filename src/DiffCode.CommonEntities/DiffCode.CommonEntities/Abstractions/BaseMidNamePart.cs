using DiffCode.CommonEntities.Enums;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// Базовая модель отчества.
/// </summary>
public abstract record BaseMidNamePart : BasePersonNamePart
{
  protected BaseMidNamePart(string text) : base(text)
  {

  }





  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed NamePart Part => NamePart.MID;
}
