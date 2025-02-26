using DiffCode.CommonEntities.Enums;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// Базовая модель фамилии.
/// </summary>
public abstract record BaseLastNamePart : BasePersonNamePart
{
  protected BaseLastNamePart(string text) : base(text)
  {

  }





  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed NamePart Part => NamePart.LAST;
}
