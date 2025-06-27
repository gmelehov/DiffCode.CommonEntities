using DiffCode.CommonEntities.Enums;
using System.Diagnostics;


namespace DiffCode.CommonEntities;

/// <summary>
/// Типизированное название должности подписанта.
/// </summary>
[DebuggerDisplay("{Full}")]
public record PositionName : BaseWithGrammarCases
{
  public PositionName() : base()
  {
    
  }

  public PositionName(string name) : base(name)
  {

  }

  public PositionName(string name, GrammarsFactory func) : base(name, func())
  {

  }

  


  /// <summary>
  /// Делегат для создания сущности, регистрируемый в DI.
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  public delegate PositionName Factory(string name);

  /// <summary>
  /// Делегат для создания фабрики грамматик для этой сущности, регистрируемый в DI.
  /// </summary>
  /// <returns></returns>
  public delegate Func<string, IEnumerable<BaseGrammar>> GrammarsFactory();


  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Category Category => Category.PositionName;
}
