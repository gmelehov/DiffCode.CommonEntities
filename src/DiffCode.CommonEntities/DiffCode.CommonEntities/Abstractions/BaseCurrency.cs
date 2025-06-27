using DiffCode.CommonEntities.Enums;
using System.Diagnostics;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// <para>Значение с валютой.</para>
/// </summary>
[DebuggerDisplay("{DisplayAs}")]
public abstract record BaseCurrency : BaseMeasurementWithDerived<decimal, CurrencyUnits, CurrencyUnits.Unit>, IWithGrammarCases
{
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  protected CasesFactory _casesFactory;




  protected BaseCurrency(CurrencyUnits measure) : base(measure)
  {
    
  }

  protected BaseCurrency(CurrencyUnits measure, decimal val) : base(measure)
  {
    Value = val;
  }

  protected BaseCurrency(CurrencyUnits measure, CasesFactory casesFactory) : base(measure)
  {
    _casesFactory = casesFactory;
  }

  protected BaseCurrency(CurrencyUnits measure, decimal val, CasesFactory casesFactory) : base(measure)
  {
    Value = val;
    _casesFactory = casesFactory;
  }




  
  /// <summary>
  /// Фабрика для создания вычисляемого списка склонений по падежам.
  /// </summary>
  /// <returns></returns>
  public delegate Func<BaseCurrency, List<Case>> CasesFactory();



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override List<Case> Cases => _casesFactory()(this);
  
  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Category Category => Category.Measured;



  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  protected override string DisplayAs => $"{Measure.Units}: {WholePart} {Measure.Short} {FractionalPart} {Measure.FrUnits.Short}";

}
