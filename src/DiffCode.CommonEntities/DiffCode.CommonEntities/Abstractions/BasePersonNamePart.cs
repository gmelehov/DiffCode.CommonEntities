using DiffCode.CommonEntities.Enums;
using System.Diagnostics;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// Базовая модель части личного имени.
/// </summary>
[DebuggerDisplay("{Part}: {Text}")]
public abstract record BasePersonNamePart
{
  protected BasePersonNamePart(string text)
  {
    Text = text;
    Derived = [];
  }



  /// <summary>
  /// Имя/отчество/фамилия, в единственном числе, в именительном падеже.
  /// </summary>
  public string Text { get; }

  /// <summary>
  /// Гендерное соответствие.
  /// </summary>
  public abstract Gender Gender { get; }

  /// <summary>
  /// Часть имени.
  /// </summary>
  public abstract NamePart Part { get; }

  /// <summary>
  /// Ссылка на базовое имя, производным от которого является эта часть имени.
  /// </summary>
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  public abstract BasePersonNamePart BaseName { get; }

  /// <summary>
  /// Ссылка на грамматику, правилам которой соответствует эта часть имени.
  /// </summary>
  public BaseGrammar Grammar { get; init; }

  /// <summary>
  /// Список частей имени, производных от этой части имени.
  /// </summary>
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  public List<BasePersonNamePart> Derived { get; }

}
