namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// Значение в календарных днях.
/// </summary>
public record CalendDays : BaseTime<int>, IWithGrammarCases
{
  public CalendDays() : base(new CalendDay())
  {

  }

  public CalendDays(int val) : base(new CalendDay(), val)
  {

  }

  public CalendDays(int val, CasesFactory casesFactory) : base(new CalendDay(), val, casesFactory)
  {

  }




  /// <summary>
  /// Фабрика для создания значений с единицей измерения <see cref="TimeUnits.Unit.CalendDay"/>.
  /// </summary>
  /// <param name="val">Количество единиц измерения.</param>
  /// <returns></returns>
  public delegate CalendDays Factory(int val);

}
