using DiffCode.CommonEntities.Enums;
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
  protected BaseMeasurement(U measure)
  {
    Measure = measure;
  }

  protected BaseMeasurement(U measure, T val)
  {
    Measure = measure;
    Value = val;
  }




  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  /// <param name="gCase"></param>
  /// <returns></returns>
  public string this[GCase gCase] => Cases.FirstOrDefault(f => f.GCase.Equals(gCase))?.Text;


  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public T Value { get; set; } = default;

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
  public abstract List<Case> Cases { get; }

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public abstract Category Category { get; }


  public string Nom => this[GCase.NOM];
  
  public string Gen => this[GCase.GEN];

  public string Dat => this[GCase.DAT];

  public string Acc => this[GCase.ACC];

  public string Ins => this[GCase.INS];

  public string Loc => this[GCase.LOC];


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
}







public delegate Func<int, BaseGrammar[]> MeasuresFactory(string str);