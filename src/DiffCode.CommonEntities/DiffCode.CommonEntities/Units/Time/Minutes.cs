namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Значение в минутах.
/// </summary>
public record Minutes : BaseTime<int>, IWithGrammarCases
{
  public Minutes() : base(new Minute())
  {

  }

  public Minutes(int val) : base(new Minute(), val)
  {

  }

  public Minutes(int val, CasesFactory casesFactory) : base(new Minute(), val, casesFactory)
  {

  }




  /// <summary>
  /// Фабрика для создания значений с единицей измерения <see cref="TimeUnits.Unit.Minute"/>.
  /// </summary>
  /// <param name="val">Количество единиц измерения.</param>
  /// <returns></returns>
  public delegate Minutes Factory(int val);
}