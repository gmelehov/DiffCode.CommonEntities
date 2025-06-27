namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Значение в месяцах.
/// </summary>
public record Months : BaseTime<int>, IWithGrammarCases
{
  public Months() : base(new Month())
  {

  }

  public Months(int val) : base(new Month(), val)
  {

  }

  public Months(int val, CasesFactory casesFactory) : base(new Month(), val, casesFactory)
  {

  }




  /// <summary>
  /// Фабрика для создания значений с единицей измерения <see cref="TimeUnits.Unit.Month"/>.
  /// </summary>
  /// <param name="val">Количество единиц измерения.</param>
  /// <returns></returns>
  public delegate Months Factory(int val);

}
