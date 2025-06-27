using DiffCode.CommonEntities.Enums;
using System.Diagnostics;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// Значение с единицей измерения количества.
/// </summary>
public abstract record BaseQuantity : BaseMeasurement<int, QuantityUnits, QuantityUnits.Unit>, IWithGrammarCases
{
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  protected CasesFactory _casesFactory;





  protected BaseQuantity(QuantityUnits measure) : base(measure)
  {

  }

  protected BaseQuantity(QuantityUnits measure, int val) : base(measure, val)
  {

  }

  protected BaseQuantity(QuantityUnits measure, CasesFactory casesFactory) : base(measure)
  {
    _casesFactory = casesFactory;
  }

  protected BaseQuantity(QuantityUnits measure, int val, CasesFactory casesFactory) : base(measure, val)
  {
    _casesFactory = casesFactory;
  }






  /// <summary>
  /// Фабрика для создания вычисляемого списка склонений по падежам.
  /// </summary>
  /// <returns></returns>
  public delegate Func<BaseQuantity, List<Case>> CasesFactory();




  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override List<Case> Cases => _casesFactory()(this);

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Category Category => Category.Measured;

}
