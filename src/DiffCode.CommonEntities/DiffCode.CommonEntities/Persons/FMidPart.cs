using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.Enums;
using System.Diagnostics;


namespace DiffCode.CommonEntities.Persons;

/// <summary>
/// Женское отчество.
/// </summary>
public record FMidPart : BaseMidNamePart
{
  public FMidPart(MFirstPart baseName, string text) : base(text)
  {
    BaseName = baseName;
  }


  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Gender Gender => Gender.F;

  /// <summary>
  /// Ссылка на базовое мужское имя, производным от которого является это отчество.
  /// </summary>
  /// <remarks>
  /// Пример: для женского отчества "Алексеевна" здесь должна быть ссылка на мужское имя "Алексей".
  /// </remarks>
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  public override MFirstPart BaseName { get; }

}
