using System.Diagnostics;
using System.Numerics;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// Базовая модель значения с единицей измерения, имеющей производную единицу.
/// </summary>
/// <typeparam name="T">Тип значения.</typeparam>
/// <typeparam name="U">Тип единицы измерения.</typeparam>
/// <typeparam name="E">Тип перечисления единицы измерения.</typeparam>
public abstract record BaseMeasurementWithDerived<T, U, E> : BaseMeasurement<T, U, E>, IMeasurement<T, U, E> 
  where T : INumberBase<T> where U : IUnits<U, E> where E : struct, Enum
{
  protected BaseMeasurementWithDerived(U measure) : base(measure)
  {

  }






  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  public int WholePart => (int)Math.Round(decimal.Parse(Value.ToString()), 0, MidpointRounding.ToZero);


  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  public int FractionalPart => (int)Math.Round(1 / Measure.FrUnits.Ratio.Value * (decimal.Parse(Value.ToString()) - WholePart), 0);



  public override string AsString => $"{WholePart.ToString()}";

}
