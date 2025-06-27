namespace DiffCode.CommonEntities.Interfaces;

/// <summary>
/// <para>Интерфейс единицы измерения.</para>
/// </summary>
/// <typeparam name="U">Тип единицы измерения.</typeparam>
/// <typeparam name="E">Тип перечисления единицы измерения.</typeparam>
public interface IUnits<out U, out E> : INamed, IWithSymbol where E : struct, Enum
{


  

  /// <summary>
  /// <para>Перечисление единицы измерения.</para>
  /// </summary>
  E Units { get; }

  /// <summary>
  /// Дробная единица измерения.
  /// </summary>
  IUnits<U, E> FrUnits { get; }

  /// <summary>
  /// Базовая единица измерения.
  /// </summary>
  IUnits<U, E> Base { get; }

  /// <summary>
  /// Количество базовых единиц измерения в этой единице.
  /// </summary>
  decimal? Ratio { get; }

}
