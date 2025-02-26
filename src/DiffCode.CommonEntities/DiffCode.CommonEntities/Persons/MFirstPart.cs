using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.Enums;
using System.Diagnostics;


namespace DiffCode.CommonEntities.Persons;

/// <summary>
/// Мужское имя.
/// </summary>
public record MFirstPart : BaseFirstNamePart
{
  public MFirstPart(string text, string mDerivedText, string fDerivedText) : base(text)
  {
    Derived.AddRange(new MMidPart(this, mDerivedText), new FMidPart(this, fDerivedText));
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
