namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Значение в рабочих днях.
/// </summary>
public record WorkDays : BaseTime<int>, IWithGrammarCases
{
  public WorkDays() : base(new WorkDay())
  {

  }

  public WorkDays(int val) : base(new WorkDay(), val)
  {

  }

  public WorkDays(int val, CasesFactory casesFactory) : base(new WorkDay(), val, casesFactory)
  {

  }




  /// <summary>
  /// Фабрика для создания значений с единицей измерения <see cref="TimeUnits.Unit.WorkDay"/>.
  /// </summary>
  /// <param name="val">Количество единиц измерения.</param>
  /// <returns></returns>
  public delegate WorkDays Factory(int val);

}
