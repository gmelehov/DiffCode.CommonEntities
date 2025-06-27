namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Значение в годах.
/// </summary>
public record Years : BaseTime<int>, IWithGrammarCases
{
  public Years() : base(new Year())
  {

  }

  public Years(int val) : base(new Year(), val)
  {

  }

  public Years(int val, CasesFactory casesFactory) : base(new Year(), val, casesFactory)
  {

  }




  /// <summary>
  /// Фабрика для создания значений с единицей измерения <see cref="TimeUnits.Unit.Year"/>.
  /// </summary>
  /// <param name="val">Количество единиц измерения.</param>
  /// <returns></returns>
  public delegate Years Factory(int val);

}