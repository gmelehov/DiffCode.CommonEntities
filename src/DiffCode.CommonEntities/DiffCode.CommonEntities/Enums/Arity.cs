namespace DiffCode.CommonEntities.Enums;

/// <summary>
/// Признак грамматического числа.
/// </summary>
public enum Arity
{
  /// <summary>
  /// Единственное число.
  /// </summary>
  S = 0,
  /// <summary>
  /// Множественное число.
  /// </summary>
  P = 1,
  /// <summary>
  /// Множественное число для числительных на 2,3,4.
  /// </summary>
  PSpec = 2,
}
