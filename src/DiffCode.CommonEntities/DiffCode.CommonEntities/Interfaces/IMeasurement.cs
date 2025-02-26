using System.Numerics;

namespace DiffCode.CommonEntities.Interfaces;

/// <summary>
/// <para>Интерфейс значения с единицей измерения.</para>
/// </summary>
/// <typeparam name="T">Тип значения.</typeparam>
/// <typeparam name="U">Тип единицы измерения.</typeparam>
/// <typeparam name="E">Тип перечисления единицы измерения.</typeparam>
public interface IMeasurement<T, U, E> where T : INumberBase<T> where U : IUnits<U, E> where E : struct, Enum
{



  /// <summary>
  /// <para>Значение.</para>
  /// </summary>
  T Value { get; }

  /// <summary>
  /// <para>Единица измерения.</para>
  /// </summary>
  U Measure { get; }

  /// <summary>
  /// Текстовое представление значения.
  /// </summary>
  string AsString { get; }


  static abstract IMeasurement<T, U, E> operator +(IMeasurement<T, U, E> left, IMeasurement<T, U, E> right);
}
