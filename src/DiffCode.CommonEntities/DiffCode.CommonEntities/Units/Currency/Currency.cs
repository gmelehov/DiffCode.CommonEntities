using DiffCode.CommonEntities.Abstractions;
using System.Diagnostics;
using System.Numerics;


namespace DiffCode.CommonEntities.Units.Currency;

/// <summary>
/// <para>Значение с валютой.</para>
/// </summary>
/// <typeparam name="T">Тип значения.</typeparam>
public record Currency<T> : BaseMeasurement<T, CurrencyUnits, CurrencyMeasure.Unit> where T : INumber<T>
{
  public Currency(T value, CurrencyUnits measure) : base(value, measure)
  {

  }





  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  protected T WholePart => T.CreateChecked(Math.Round(decimal.Parse(Value.ToString()), 0, MidpointRounding.ToZero));


  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  protected T FractionalPart => Value - T.CreateChecked(WholePart);



  public override string AsString => $"{WholePart.ToString()}";



  public static Currency<T> operator +(Currency<T> left, Currency<T> right)
    => new Currency<T>(left.Value + right.Value, left.Measure);

}
