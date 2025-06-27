namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Значение в днях.
/// </summary>
public record Days : BaseTime<int>, IWithGrammarCases
{
  public Days() : base(new Day())
  {

  }

  public Days(int val) : base(new Day(), val)
  {

  }

  public Days(int val, CasesFactory casesFactory) : base(new Day(), val, casesFactory)
  {

  }




  /// <summary>
  /// Фабрика для создания значений с единицей измерения <see cref="TimeUnits.Unit.Day"/>.
  /// </summary>
  /// <param name="val">Количество единиц измерения.</param>
  /// <returns></returns>
  public delegate Days Factory(int val);

}
