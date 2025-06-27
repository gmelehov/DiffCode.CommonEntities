using DiffCode.CommonEntities.Enums;
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





  public delegate Func<int, string, IEnumerable<BaseGrammar>> GrammarsFactory();




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