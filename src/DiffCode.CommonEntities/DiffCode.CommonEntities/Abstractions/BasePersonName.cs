using DiffCode.CommonEntities.Cases;
using DiffCode.CommonEntities.Enums;
using DiffCode.CommonEntities.Interfaces;
using System.Diagnostics;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// Базовая модель личных данных (ФИО, пол).
/// </summary>
[DebuggerDisplay("{DisplayAs}")]
public abstract record BasePersonName : INamedWithGrammarCases
{
  protected BasePersonName(BaseFirstNamePart firstNamePart, BaseMidNamePart midNamePart, BaseLastNamePart lastNamePart)
  {
    FirstName = firstNamePart;
    MidName = midNamePart;
    LastName = lastNamePart;
  }




  /// <summary>
  /// <para>Возвращает признак корректно сформированных данных.</para>
  /// </summary>
  /// <returns></returns>
  public bool IsCorrect() => 
    FirstName != null && LastName != null && 
    !string.IsNullOrWhiteSpace(FirstName.Text) && !string.IsNullOrWhiteSpace(LastName.Text) && 
    !Gender.Equals(Gender.N) && FirstName.Grammar != null && LastName.Grammar != null;

  /// <summary>
  /// <para>Возвращает фамилию в указанном падеже, согласно соответствующей грамматике.</para>
  /// </summary>
  /// <param name="gCase">Грамматический падеж.</param>
  /// <returns></returns>
  public string GetLastNameCase(GCase gCase) => LastName.Grammar?[LastName.Text, gCase];

  /// <summary>
  /// <para>Возвращает личное имя в указанном падеже, согласно соответствующей грамматике.</para>
  /// </summary>
  /// <param name="gCase">Грамматический падеж.</param>
  /// <returns></returns>
  public string GetFirstNameCase(GCase gCase) => FirstName.Grammar?[FirstName.Text, gCase];

  /// <summary>
  /// <para>Возвращает отчество в указанном падеже, согласно соответствующей грамматике.</para>
  /// </summary>
  /// <param name="gCase">Грамматический падеж.</param>
  /// <returns></returns>
  public string GetMidNameCase(GCase gCase) => MidName.Grammar?[MidName.Text, gCase];

  /// <summary>
  /// Возвращает полное представление имени в указанном падеже.
  /// </summary>
  /// <param name="gCase"></param>
  /// <returns></returns>
  public string GetFullForm(GCase gCase) => PartsOrder switch
  {
    NamePartsOrder.LFM => 
    !string.IsNullOrWhiteSpace(GetMidNameCase(gCase)) 
    ? 
    $"{GetLastNameCase(gCase)} {GetFirstNameCase(gCase)} {GetMidNameCase(gCase)}" 
    : 
    $"{GetLastNameCase(gCase)} {GetFirstNameCase(gCase)}",


    NamePartsOrder.FML => 
    !string.IsNullOrWhiteSpace(GetMidNameCase(gCase)) 
    ? 
    $"{GetFirstNameCase(gCase)} {GetMidNameCase(gCase)} {GetLastNameCase(gCase)}" 
    : 
    $"{GetFirstNameCase(gCase)} {GetLastNameCase(gCase)}",


    _ => 
    !string.IsNullOrWhiteSpace(GetMidNameCase(gCase))
    ?
    $"{GetLastNameCase(gCase)} {GetFirstNameCase(gCase)} {GetMidNameCase(gCase)}"
    :
    $"{GetLastNameCase(gCase)} {GetFirstNameCase(gCase)}",

  };

  /// <summary>
  /// Возвращает сокращенное представление имени в указанном падеже.
  /// </summary>
  /// <param name="gCase"></param>
  /// <returns></returns>
  public string GetShortForm(GCase gCase) => PartsOrder switch
  {
    NamePartsOrder.LFM =>
    !string.IsNullOrWhiteSpace(GetMidNameCase(gCase))
    ?
    $"{GetLastNameCase(gCase)} {GetFirstNameCase(gCase).Substring(0, 1)} {GetMidNameCase(gCase).Substring(0, 1)}"
    :
    $"{GetLastNameCase(gCase)} {GetFirstNameCase(gCase).Substring(0, 1)}",


    NamePartsOrder.FML =>
    !string.IsNullOrWhiteSpace(GetMidNameCase(gCase))
    ?
    $"{GetFirstNameCase(gCase).Substring(0, 1)} {GetMidNameCase(gCase).Substring(0, 1)} {GetLastNameCase(gCase)}"
    :
    $"{GetFirstNameCase(gCase).Substring(0, 1)} {GetLastNameCase(gCase)}",


    _ =>
    !string.IsNullOrWhiteSpace(GetMidNameCase(gCase))
    ?
    $"{GetLastNameCase(gCase)} {GetFirstNameCase(gCase).Substring(0, 1)} {GetMidNameCase(gCase).Substring(0, 1)}"
    :
    $"{GetLastNameCase(gCase)} {GetFirstNameCase(gCase).Substring(0, 1)}",

  };





  /// <summary>
  /// Гендерная принадлежность.
  /// </summary>
  public abstract Gender Gender { get; }

  /// <summary>
  /// Ссылка на имя.
  /// </summary>
  public BaseFirstNamePart FirstName { get; init; }

  /// <summary>
  /// Ссылка на отчество.
  /// </summary>
  public BaseMidNamePart MidName { get; init; }

  /// <summary>
  /// Ссылка на фамилию.
  /// </summary>
  public BaseLastNamePart LastName { get; init; }

  /// <summary>
  /// <para>Порядок следования частей имени в полном имени.</para>
  /// </summary>
  public NamePartsOrder PartsOrder { get; init; } = NamePartsOrder.LFM;

  /// <summary>
  /// Полное представление имени, согласно заданному порядку следования частей, в именительном падеже.
  /// </summary>
  public string Full => PartsOrder switch
  {
    NamePartsOrder.LFM =>
    !string.IsNullOrWhiteSpace(MidName?.Text)
    ?
    $"{LastName.Text} {FirstName.Text} {MidName.Text}"
    :
    $"{LastName.Text} {FirstName.Text}",


    NamePartsOrder.FML =>
    !string.IsNullOrWhiteSpace(MidName?.Text)
    ?
    $"{FirstName.Text} {MidName.Text} {LastName.Text}"
    :
    $"{FirstName.Text} {LastName.Text}",


    _ =>
    !string.IsNullOrWhiteSpace(MidName?.Text)
    ?
    $"{LastName.Text} {FirstName.Text} {MidName.Text}"
    :
    $"{LastName.Text} {FirstName.Text}",

  };

  /// <summary>
  /// Сокращенное представление имени, согласно заданному порядку следования частей, в именительном падеже.
  /// </summary>
  public string Short => PartsOrder switch
  {
    NamePartsOrder.LFM =>
    !string.IsNullOrWhiteSpace(MidName?.Text)
    ?
    $"{LastName.Text} {FirstName.Text.Substring(0, 1)} {MidName.Text.Substring(0, 1)}"
    :
    $"{LastName.Text} {FirstName.Text.Substring(0, 1)}",


    NamePartsOrder.FML =>
    !string.IsNullOrWhiteSpace(MidName?.Text)
    ?
    $"{FirstName.Text.Substring(0, 1)} {MidName.Text.Substring(0, 1)} {LastName.Text}"
    :
    $"{FirstName.Text.Substring(0, 1)} {LastName.Text}",


    _ =>
    !string.IsNullOrWhiteSpace(MidName?.Text)
    ?
    $"{LastName.Text} {FirstName.Text.Substring(0, 1)} {MidName.Text.Substring(0, 1)}"
    :
    $"{LastName.Text} {FirstName.Text.Substring(0, 1)}",
  };


  /// <summary>
  /// Динамически формируемый список склонений полного представления имени по падежам.
  /// </summary>
  public List<Case> Cases => 
    IsCorrect() 
    ? 
    [
      new NOM(GetFullForm(GCase.NOM)),
      new GEN(GetFullForm(GCase.GEN)),
      new DAT(GetFullForm(GCase.DAT)),
      new ACC(GetFullForm(GCase.ACC)),
      new INS(GetFullForm(GCase.INS)),
      new LOC(GetFullForm(GCase.LOC)),
    ] 
    : 
    null;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public Category Category => Category.PersonName;



  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  private string DisplayAs => $"{GetFullForm(GCase.NOM)}";

}