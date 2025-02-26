using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.Enums;
using System.Diagnostics;


namespace DiffCode.CommonEntities.Persons;

/// <summary>
/// Женская фамилия.
/// </summary>
public record FLastPart : BaseLastNamePart
{
  public FLastPart(string text) : base(text)
  {

  }




  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Gender Gender => Gender.F;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  public override MFirstPart BaseName => null;

}
