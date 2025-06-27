using DiffCode.CommonEntities.Enums;


namespace DiffCode.CommonEntities.Cases;

/// <summary>
/// Словоформа в родительном падеже.
/// </summary>
public record GEN : Case
{
  public GEN(string text) : base(text)
  {

  }


  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed GCase GCase => GCase.GEN;
}
