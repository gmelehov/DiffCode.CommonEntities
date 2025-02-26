using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.Enums;

namespace DiffCode.CommonEntities.Interfaces;

/// <summary>
/// Интерфейс объекта, имеющего список склонений своего 
/// текстового содержимого по грамматическим падежам.
/// </summary>
public interface IWithGrammarCases
{

  /// <summary>
  /// Список склонений по грамматическим падежам.
  /// </summary>
  List<Case> Cases { get; }

  /// <summary>
  /// Категория склоняемой сущности.
  /// </summary>
  Category Category { get; }

}
