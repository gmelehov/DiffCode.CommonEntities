using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.Enums;


namespace DiffCode.CommonEntities.Cases;

/// <summary>
/// Словоформа в предложном падеже.
/// </summary>
public record LOC : Case
{
  public LOC(string text) : base(text)
  {

  }



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed GCase GCase => GCase.LOC;
}
