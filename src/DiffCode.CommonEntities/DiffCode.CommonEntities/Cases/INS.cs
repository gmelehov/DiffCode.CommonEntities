using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.Enums;


namespace DiffCode.CommonEntities.Cases;

/// <summary>
/// Словоформа в творительном падеже.
/// </summary>
public record INS : Case
{
  public INS(string text) : base(text)
  {

  }


  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed GCase GCase => GCase.INS;
}
