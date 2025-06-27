using DiffCode.CommonEntities.Enums;

namespace DiffCode.CommonEntities.Persons;

/// <summary>
/// Женское ФИО.
/// </summary>
public record FPersonName : BasePersonName
{
  public FPersonName(string input, PartsFactory partsFactory) : base(input, partsFactory)
  {

  }

  public FPersonName(FFirstPart firstNamePart, FMidPart midNamePart, FLastPart lastNamePart) : base(firstNamePart, midNamePart, lastNamePart)
  {

  }




  /// <summary>
  /// Фабрика для создания моделей личных данных женщин (ФИО, пол) из указанной строки.
  /// </summary>
  /// <param name="str">Строка с именем, отчеством и фамилией в именительном падеже.</param>
  /// <returns></returns>
  public new delegate FPersonName Factory(string str);



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed Gender Gender => Gender.F;

}