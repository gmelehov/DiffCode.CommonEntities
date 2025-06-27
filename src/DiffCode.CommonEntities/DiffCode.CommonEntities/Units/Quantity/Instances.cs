using System.Diagnostics;


namespace DiffCode.CommonEntities.Units.Quantity;

/// <summary>
/// Значение в экземплярах.
/// </summary>
[DebuggerDisplay("{DisplayAs}")]
public record Instances : Abstractions.BaseQuantity, IWithGrammarCases
{
  public Instances() : base(new Instance())
  {

  }

  public Instances(int val) : base(new Instance(), val)
  {
    Value = val;
  }

  public Instances(int val, CasesFactory casesFactory) : base(new Instance(), val, casesFactory)
  {

  }




  /// <summary>
  /// Фабрика для создания значений с единицей измерения <see cref="QuantityUnits.Unit.Instance"/>.
  /// </summary>
  /// <param name="val">Количество единиц измерения.</param>
  /// <returns></returns>
  public delegate Instances Factory(int val);



  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  protected override string DisplayAs => $"{Measure.Units}: {Value} {Measure.Short}";
}
