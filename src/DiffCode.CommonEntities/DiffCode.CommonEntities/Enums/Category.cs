namespace DiffCode.CommonEntities.Enums;

/// <summary>
/// Категории склоняемых сущностей.
/// </summary>
public enum Category
{

  /// <summary>
  /// Категория не установлена/не существует/не применима.
  /// </summary>
  None = 0,
  /// <summary>
  /// ФИО.
  /// </summary>
  PersonName = 1,
  /// <summary>
  /// Название стороны-подписанта.
  /// </summary>
  PartyName = 2,
  /// <summary>
  /// Название должности.
  /// </summary>
  PositionName = 3,
  /// <summary>
  /// Название организационно-правовой формы.
  /// </summary>
  LegalEntityName = 4,
  /// <summary>
  /// Основание полномочий подписанта.
  /// </summary>
  AuthorityName = 5,

  UnitsName = 6,

  DigitsName = 7,

}