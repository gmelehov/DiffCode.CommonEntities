using DiffCode.CommonEntities.Abstractions;
using System.Diagnostics;
using System.Numerics;


namespace DiffCode.CommonEntities.Units.Currency;

/// <summary>
/// Значение в рублях.
/// </summary>
[DebuggerDisplay("{DisplayAs}")]
public record Roubles : Currency<decimal>
{
  public Roubles(decimal value) : base(value, new Rouble())
  {
    Kopecks = Math.Round(1 / Measure.FrUnits.Ratio.Value * FractionalPart, 0).Kopecks();
  }




  


  public Kopecks Kopecks { get; }


  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  protected override string DisplayAs => $"{Measure.Units}: {WholePart} {Measure.Short} {Kopecks.Value} {Kopecks.Measure.Short}";

}
