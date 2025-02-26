using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.Enums;
using System.Diagnostics;

namespace DiffCode.CommonEntities.Persons;

/// <summary>
/// Женское имя.
/// </summary>
public record FFirstPart : BaseFirstNamePart
{
  public FFirstPart(string text) : base(text)
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
