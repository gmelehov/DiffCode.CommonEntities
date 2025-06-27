using DiffCode.CommonEntities.Enums;


namespace DiffCode.CommonEntities.Cases;

/// <summary>
/// Словоформа в винительном падеже.
/// </summary>
public record ACC : Case
{
  public ACC(string text) : base(text)
  {

  }


  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed GCase GCase => GCase.ACC;
}
