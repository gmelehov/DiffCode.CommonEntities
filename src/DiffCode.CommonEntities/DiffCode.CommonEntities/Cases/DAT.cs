using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.Enums;


namespace DiffCode.CommonEntities.Cases;

/// <summary>
/// Словоформа в дательном падеже.
/// </summary>
public record DAT : Case
{
  public DAT(string text) : base(text)
  {

  }


  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed GCase GCase => GCase.DAT;
}
