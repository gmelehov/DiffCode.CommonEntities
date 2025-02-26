using DiffCode.CommonEntities.Enums;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// Базовая модель имени.
/// </summary>
public abstract record BaseFirstNamePart : BasePersonNamePart
{
  protected BaseFirstNamePart(string text) : base(text)
  {

  }





  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed NamePart Part => NamePart.FIRST;
}
