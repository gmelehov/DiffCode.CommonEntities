using DiffCode.CommonEntities.Enums;
using System.Diagnostics;


namespace DiffCode.CommonEntities;

/// <summary>
/// Типизированное название организационно-правовой формы стороны-подписанта.
/// </summary>
[DebuggerDisplay("{Full}")]
public record LegalEntityName : BaseWithGrammarCases, INamed
{
  public LegalEntityName() : base()
  {
    
  }

  public LegalEntityName(string name, string shortName = null) : base(name)
  {
    Short = shortName;
  }

  public LegalEntityName(string name, string shortName, GrammarsFactory func) : base(name, func())
  {
    Short = shortName;
  }




  /// <summary>
  /// Делегат для создания сущности, регистрируемый в DI.
  /// </summary>
  /// <param name="name"></param>
  /// <param name="shortName"></param>
  /// <returns></returns>
  public delegate LegalEntityName Factory(string name, string shortName);

  /// <summary>
  /// Делегат для создания фабрики грамматик для этой сущности, регистрируемый в DI.
  /// </summary>
  /// <returns></returns>
  public delegate Func<string, IEnumerable<BaseGrammar>> GrammarsFactory();


  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public string Short { get; }


  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Category Category => Category.LegalEntityName;

}
