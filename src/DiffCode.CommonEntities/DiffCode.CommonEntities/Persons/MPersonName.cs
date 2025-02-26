using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.Enums;

namespace DiffCode.CommonEntities.Persons;

/// <summary>
/// Мужское ФИО.
/// </summary>
public record MPersonName : BasePersonName
{
  public MPersonName(MFirstPart firstNamePart, MMidPart midNamePart, MLastPart lastNamePart) : base(firstNamePart, midNamePart, lastNamePart)
  {

  }



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed Gender Gender => Gender.M;
  
}
