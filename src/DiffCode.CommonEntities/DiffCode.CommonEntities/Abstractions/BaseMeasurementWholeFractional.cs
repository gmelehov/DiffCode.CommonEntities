using System.Diagnostics;
using System.Numerics;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// Базовая модель значения с единицей измерения, имеющей целую и дробную части.
/// </summary>
/// <typeparam name="T">Тип значения.</typeparam>
/// <typeparam name="U">Тип единицы измерения.</typeparam>
/// <typeparam name="E">Тип перечисления единицы измерения.</typeparam>
public abstract record BaseMeasurementWholeFractional<T, U, E> : BaseMeasurement<T, U, E>, IMeasurement<T, U, E>
  where T : INumberBase<T> where U : IUnits<U, E> where E : struct, Enum
{
  protected BaseMeasurementWholeFractional(U measure) : base(measure)
  {

  }






  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  public int WholePart => (int)Math.Round(decimal.Parse(Value.ToString()), 0, MidpointRounding.ToZero);


  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  public int FractionalPart => int.Parse((decimal.Parse(Value.ToString()) - WholePart).ToString().Split([',', '.']).LastOrDefault());



  public override string AsString => $"{WholePart.ToString()}";

}