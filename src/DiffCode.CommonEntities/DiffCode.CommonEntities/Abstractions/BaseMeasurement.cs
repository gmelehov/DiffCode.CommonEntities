using DiffCode.CommonEntities.Interfaces;
using System.Diagnostics;
using System.Numerics;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// <para>Базовая модель значения с единицей измерения.</para>
/// </summary>
/// <typeparam name="T">Тип значения.</typeparam>
/// <typeparam name="U">Тип единицы измерения.</typeparam>
/// <typeparam name="E">Тип перечисления единицы измерения.</typeparam>
[DebuggerDisplay("{DisplayAs}")]
public abstract record BaseMeasurement<T, U, E> : IMeasurement<T, U, E> where T : INumberBase<T> where U : IUnits<U, E> where E : struct, Enum
{
  protected BaseMeasurement(T val, U measure)
  {
    Value = val;
    Measure = measure;
  }



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public T Value { get; }

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public U Measure { get; }

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public virtual string AsString => $"{Value.ToString()}";



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  T IMeasurement<T, U, E>.Value => Value;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  U IMeasurement<T, U, E>.Measure => Measure;


  public override string ToString() => $"{Value} {Measure.Units}";



  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  protected virtual string DisplayAs => $"{Measure.Units}: {Value} {Measure.Short}";


  static IMeasurement<T, U, E> IMeasurement<T, U, E>.operator +(IMeasurement<T, U, E> left, IMeasurement<T, U, E> right) => throw new NotImplementedException();
}
