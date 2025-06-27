namespace DiffCode.CommonEntities.Units.Part;

/// <summary>
/// Значение в процентах.
/// </summary>
public record Percents : BasePart
{
  public Percents() : base(new Percent())
  {

  }

  public Percents(decimal val) : base(new Percent(), val)
  {
    
  }

  public Percents(decimal val, CasesFactory casesFactory) : base(new Percent(), val, casesFactory)
  {
    
  }




  /// <summary>
  /// Фабрика для создания значений с единицей измерения <see cref="PartUnits.Unit.Percent"/>.
  /// </summary>
  /// <param name="val">Количество единиц измерения.</param>
  /// <returns></returns>
  public delegate Percents Factory(decimal val);

}