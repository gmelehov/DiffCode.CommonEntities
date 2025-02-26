using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.Enums;
using DiffCode.CommonEntities.Services;
using System.Diagnostics;


namespace DiffCode.CommonEntities;

/// <summary>
/// Типизированное название организационно-правовой формы стороны-подписанта.
/// </summary>
[DebuggerDisplay("{Full}")]
public record LegalEntityName : BaseTypedEntity
{
  public LegalEntityName(Func<string, IEnumerable<BaseGrammar>> grammarsFunc, Func<string> name, string shortName = null) : base(grammarsFunc, name)
  {
    Short = shortName;
  }



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override string Short { get; }

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override string Symbol => null;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Category Category => Category.LegalEntityName;
}
