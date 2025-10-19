namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Значение в часах.
/// </summary>
public record Hours : BaseTime<int>, IWithGrammarCases
{
  public Hours() : base(new Hour())
  {

  }

  public Hours(int val) : base(new Hour(), val)
  {

  }

  public Hours(int val, CasesFactory casesFactory) : base(new Hour(), val, casesFactory)
  {

  }




  /// <summary>
  /// Фабрика для создания значений с единицей измерения <see cref="TimeUnits.Unit.Hour"/>.
  /// </summary>
  /// <param name="val">Количество единиц измерения.</param>
  /// <returns></returns>
  public delegate Hours Factory(int val);

}
