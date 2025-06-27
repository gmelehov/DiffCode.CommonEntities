namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Значение в неделях.
/// </summary>
public record Weeks : BaseTime<int>, IWithGrammarCases
{
  public Weeks() : base(new Week())
  {

  }

  public Weeks(int val) : base(new Week(), val)
  {

  }

  public Weeks(int val, CasesFactory casesFactory) : base(new Week(), val, casesFactory)
  {

  }




  /// <summary>
  /// Фабрика для создания значений с единицей измерения <see cref="TimeUnits.Unit.Week"/>.
  /// </summary>
  /// <param name="val">Количество единиц измерения.</param>
  /// <returns></returns>
  public delegate Weeks Factory(int val);

}
