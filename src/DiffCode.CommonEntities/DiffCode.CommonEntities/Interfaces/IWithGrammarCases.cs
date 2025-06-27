using DiffCode.CommonEntities.Enums;

namespace DiffCode.CommonEntities.Interfaces;

/// <summary>
/// Интерфейс объекта, имеющего список склонений своего 
/// текстового содержимого по грамматическим падежам.
/// </summary>
public interface IWithGrammarCases
{


  /// <summary>
  /// Индексатор для получения значения а нужном грамматическом падеже.
  /// </summary>
  /// <param name="gCase"></param>
  /// <returns></returns>
  string this[GCase gCase] { get; }


  /// <summary>
  /// Список склонений по грамматическим падежам.
  /// </summary>
  List<Case> Cases { get; }

  /// <summary>
  /// Категория склоняемой сущности.
  /// </summary>
  Category Category { get; }



  string Nom {  get; }


  string Gen {  get; }


  string Dat {  get; }


  string Acc {  get; }


  string Ins { get; }


  string Loc { get; }

}
