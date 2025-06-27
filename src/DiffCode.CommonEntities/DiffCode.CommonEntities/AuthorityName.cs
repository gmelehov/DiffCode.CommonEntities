using DiffCode.CommonEntities.Enums;
using System.Diagnostics;


namespace DiffCode.CommonEntities;

/// <summary>
/// Типизированное название полномочий подписанта.
/// </summary>
[DebuggerDisplay("{Full}")]
public record AuthorityName : BaseWithGrammarCases, IWithGrammarCases
{
  public AuthorityName() : base()
  {

  }

  public AuthorityName(string name) : base(name)
  {

  }

  public AuthorityName(string name, GrammarsFactory func) : base(name, func())
  {

  }

 




  /// <summary>
  /// Делегат для создания сущности, регистрируемый в DI.
  /// </summary>
  /// <param name="name"></param>
  public delegate AuthorityName Factory(string name);

  /// <summary>
  /// Делегат для создания фабрики грамматик для этой сущности, регистрируемый в DI.
  /// </summary>
  /// <returns></returns>
  public delegate Func<string, IEnumerable<BaseGrammar>> GrammarsFactory();




  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Category Category => Category.AuthorityName;

}