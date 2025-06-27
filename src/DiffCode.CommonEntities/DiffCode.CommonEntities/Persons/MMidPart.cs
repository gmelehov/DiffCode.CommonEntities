using DiffCode.CommonEntities.Enums;
using System.Diagnostics;


namespace DiffCode.CommonEntities.Persons;

/// <summary>
/// Мужское отчество.
/// </summary>
public record MMidPart : BaseMidNamePart
{
  public MMidPart(MFirstPart baseName, string text) : base(text)
  {
    BaseName = baseName;
  }



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override Gender Gender => Gender.M;

  /// <summary>
  /// Ссылка на базовое мужское имя, производным от которого является это отчество.
  /// </summary>
  /// <remarks>
  /// Пример: для мужского отчества "Алексеевич" здесь должна быть ссылка на мужское имя "Алексей".
  /// </remarks>
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  public override MFirstPart BaseName { get; }
  
}
