using DiffCode.CommonEntities.Enums;
using System.Diagnostics;
using System.Numerics;

namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// <para>Значение с единицей измерения времени.</para>
/// </summary>
/// <typeparam name="T">Тип значения.</typeparam>
/// <param name="Value">Значение.</param>
/// <param name="Measure">Единица измерения.</param>
public abstract record BaseTime<T> : BaseMeasurement<T, TimeUnits, TimeUnits.Unit>, IWithGrammarCases where T : INumberBase<T>
{
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  protected CasesFactory _casesFactory;



  protected BaseTime(TimeUnits measure) : base(measure)
  {

  }

  protected BaseTime(TimeUnits measure, T val) : base(measure)
  {
    Value = val;
  }

  protected BaseTime(TimeUnits measure, CasesFactory casesFactory) : base(measure)
  {
    _casesFactory = casesFactory;
  }

  protected BaseTime(TimeUnits measure, T val, CasesFactory casesFactory) : base(measure)
  {
    Value = val;
    _casesFactory = casesFactory;
  }




  /// <summary>
  /// Фабрика для создания вычисляемого списка склонений по падежам.
  /// </summary>
  /// <returns></returns>
  public delegate Func<BaseTime<T>, List<Case>> CasesFactory();




  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override List<Case> Cases => _casesFactory()(this);

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Category Category => Category.Measured;
}
