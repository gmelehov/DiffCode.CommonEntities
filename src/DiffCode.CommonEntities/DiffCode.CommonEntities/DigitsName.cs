using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.Enums;
using DiffCode.CommonEntities.Services;
using System.Diagnostics;


namespace DiffCode.CommonEntities;

/// <summary>
/// Типизированное название порядка числительных.
/// </summary>
[DebuggerDisplay("{Full}")]
public record DigitsName : BaseTypedEntity
{
  public DigitsName(Func<string, IEnumerable<BaseGrammar>> grammarsFunc, Func<string> name) : base(grammarsFunc, name)
  {
    
  }



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override string Short { get; }

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override string Symbol { get; }

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Category Category => Category.DigitsName;
}