using DiffCode.CommonEntities.Enums;
using DiffCode.CommonEntities.Interfaces;
using System.Diagnostics;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// <para>Базовая модель единицы измерения.</para>
/// </summary>
/// <typeparam name="U">Тип единицы измерения.</typeparam>
/// <typeparam name="E">Тип перечисления единицы измерения.</typeparam>
public abstract record BaseUnits<U, E> : BaseTypedEntity, IUnits<U, E> where E : struct, Enum
{
  protected BaseUnits(E units, string name) : base(name)
  {
    Units = units;
  }




  /// <summary>
  /// <para>Перечисление единицы измерения.</para>
  /// </summary>
  public E Units { get; }

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  public abstract IUnits<U, E> FrUnits { get; }

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  public abstract IUnits<U, E> Base { get; }

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public abstract decimal? Ratio { get; }

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed Category Category => Category.UnitsName;

}
