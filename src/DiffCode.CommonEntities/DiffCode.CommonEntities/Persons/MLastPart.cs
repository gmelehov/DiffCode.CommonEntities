using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.Enums;
using System.Diagnostics;


namespace DiffCode.CommonEntities.Persons;

/// <summary>
/// Мужская фамилия.
/// </summary>
public record MLastPart : BaseLastNamePart
{
  public MLastPart(string text) : base(text)
  {

  }




  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Gender Gender => Gender.M;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  public override MFirstPart BaseName => null;

}
