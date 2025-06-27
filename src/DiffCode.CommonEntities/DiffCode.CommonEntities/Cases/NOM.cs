using DiffCode.CommonEntities.Enums;


namespace DiffCode.CommonEntities.Cases;

/// <summary>
/// Словоформа в именительном падеже.
/// </summary>
public record NOM : Case
{
  public NOM(string text) : base(text)
  {

  }


  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed GCase GCase => GCase.NOM;
}
