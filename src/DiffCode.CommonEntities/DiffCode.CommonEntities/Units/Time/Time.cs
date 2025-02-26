using DiffCode.CommonEntities.Abstractions;
using System.Numerics;

namespace DiffCode.CommonEntities.Units.Time;

/// <summary>
/// <para>Значение с единицей измерения времени.</para>
/// </summary>
/// <typeparam name="T">Тип значения.</typeparam>
/// <param name="Value">Значение.</param>
/// <param name="Measure">Единица измерения.</param>
public record Time<T>(T Value, TimeUnits Measure) : BaseMeasurement<T, TimeUnits, TimeMeasure.Unit>(Value, Measure) where T : INumberBase<T>
{

}
