using System.Diagnostics;


namespace DiffCode.CommonEntities.Units.Currency;

/// <summary>
/// Значение в рублях.
/// </summary>
[DebuggerDisplay("{DisplayAs}")]
public record Roubles : BaseCurrency, IWithGrammarCases
{
  public Roubles() : base(new Rouble())
  {
    
  }

  public Roubles(decimal val) : base(new Rouble(), val)
  {
    
  }

  public Roubles(decimal val, CasesFactory casesFactory) : base(new Rouble(), val, casesFactory)
  {
    
  }



  /// <summary>
  /// Фабрика для создания значений с единицей измерения <see cref="CurrencyUnits.Unit.Rouble"/>.
  /// </summary>
  /// <param name="val">Количество единиц измерения.</param>
  /// <returns></returns>
  public delegate Roubles Factory(decimal val);

}
