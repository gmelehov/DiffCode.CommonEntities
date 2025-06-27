using DiffCode.CommonEntities.Enums;
using System.Diagnostics;


namespace DiffCode.CommonEntities;

/// <summary>
/// Типизированное название стороны-подписанта.
/// </summary>
[DebuggerDisplay("{Full}")]
public record PartyName : BaseWithGrammarCases
{
  public PartyName() : base()
  {
    
  }

  public PartyName(string name) : base(name)
  {
    
  }

  public PartyName(string name, GrammarsFactory grammarsFactory) : base(name, grammarsFactory())
  {

  }




  /// <summary>
  /// Делегат для создания сущности, регистрируемый в DI.
  /// </summary>
  /// <param name="name"></param>
  public delegate PartyName Factory(string name);

  /// <summary>
  /// Делегат для создания фабрики грамматик для этой сущности, регистрируемый в DI.
  /// </summary>
  /// <returns></returns>
  public delegate Func<string, IEnumerable<BaseGrammar>> GrammarsFactory();



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Category Category => Category.PartyName;

}
