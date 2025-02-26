using System.Diagnostics;
using System.Numerics;


namespace DiffCode.CommonEntities.Units.Currency;

/// <summary>
/// Значение в копейках.
/// </summary>
[DebuggerDisplay("{DisplayAs}")]
public record Kopecks : Currency<decimal>
{
  public Kopecks(decimal value) : base(value, new Kopeck())
  {

  }

}