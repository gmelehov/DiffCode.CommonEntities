using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.Enums;

namespace DiffCode.CommonEntities.Persons;

/// <summary>
/// Женское ФИО.
/// </summary>
public record FPersonName : BasePersonName
{
  public FPersonName(FFirstPart firstNamePart, FMidPart midNamePart, FLastPart lastNamePart) : base(firstNamePart, midNamePart, lastNamePart)
  {

  }



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed Gender Gender => Gender.F;

}