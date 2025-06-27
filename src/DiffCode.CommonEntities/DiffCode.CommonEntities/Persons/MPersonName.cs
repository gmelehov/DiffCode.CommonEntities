using DiffCode.CommonEntities.Enums;

namespace DiffCode.CommonEntities.Persons;

/// <summary>
/// Мужское ФИО.
/// </summary>
public record MPersonName : BasePersonName
{
  public MPersonName(string input, PartsFactory partsFactory) : base(input, partsFactory)
  {

  }

  public MPersonName(MFirstPart firstNamePart, MMidPart midNamePart, MLastPart lastNamePart) : base(firstNamePart, midNamePart, lastNamePart)
  {
    
  }




  /// <summary>
  /// Фабрика для создания моделей личных данных мужчин (ФИО, пол) из указанной строки.
  /// </summary>
  /// <param name="str">Строка с именем, отчеством и фамилией в именительном падеже.</param>
  /// <returns></returns>
  public new delegate MPersonName Factory(string str);



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed Gender Gender => Gender.M;
  
}
