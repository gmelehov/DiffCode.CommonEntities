using DiffCode.CommonEntities.Enums;

namespace DiffCode.CommonEntities.Interfaces;

/// <summary>
/// Интерфейс объекта, имеющего список склонений своего полного имени/названия/наименования
/// по грамматическим падежам.
/// </summary>
public interface INamedWithGrammarCases : INamed, IWithGrammarCases
{


  /// <summary>
  /// Возвращает полное представление имени/названия/наименования 
  /// в указанном грамматическом падеже.
  /// </summary>
  /// <param name="gCase">Грамматический падеж.</param>
  /// <returns></returns>
  string GetFullForm(GCase gCase);

}