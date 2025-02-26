using DiffCode.CommonEntities.Units.Date;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// <para>День/дата.</para>
/// </summary>
public abstract record DateUnits : BaseUnits<DateUnits, DateMeasure.Unit>
{
  protected DateUnits(DateMeasure.Unit units, string noun) : base(units, noun)
  {

  }


}
