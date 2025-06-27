using DiffCode.CommonEntities.Enums;
using System.Diagnostics;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// Значение с единицей измерения частей/долей.
/// </summary>
public abstract record BasePart : BaseMeasurementWholeFractional<decimal, PartUnits, PartUnits.Unit>, IWithGrammarCases
{
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  protected CasesFactory _casesFactory;




  protected BasePart(PartUnits measure) : base(measure)
  {

  }

  protected BasePart(PartUnits measure, decimal val) : base(measure)
  {
    Value = val;
  }

  protected BasePart(PartUnits measure, CasesFactory casesFactory) : base(measure)
  {
    _casesFactory = casesFactory;
  }

  protected BasePart(PartUnits measure, decimal val, CasesFactory casesFactory) : base(measure)
  {
    Value = val;
    _casesFactory = casesFactory;
  }





  /// <summary>
  /// Фабрика для создания вычисляемого списка склонений по падежам.
  /// </summary>
  /// <returns></returns>
  public delegate Func<BasePart, List<Case>> CasesFactory();



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override List<Case> Cases => _casesFactory()(this);

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Category Category => Category.Measured;
}
