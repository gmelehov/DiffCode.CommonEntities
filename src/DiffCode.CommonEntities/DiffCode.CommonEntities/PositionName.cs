using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.Enums;
using DiffCode.CommonEntities.Services;
using System.Diagnostics;


namespace DiffCode.CommonEntities;

/// <summary>
/// Типизированное название должности подписанта.
/// </summary>
[DebuggerDisplay("{Full}")]
public record PositionName : BaseTypedEntity
{
  public PositionName(Func<string, IEnumerable<BaseGrammar>> grammarsFunc, Func<string> name) : base(grammarsFunc, name)
  {
    
  }




  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override string Short => null;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override string Symbol => null;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Category Category => Category.PositionName;
}
