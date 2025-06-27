namespace DiffCode.CommonEntities.Enums;

/// <summary>
/// Признак грамматического числа.
/// </summary>
public enum Arity
{
  /// <summary>
  /// Для 0.
  /// </summary>
  N = 0,
  /// <summary>
  /// Единственное число.
  /// </summary>
  S = 1,
  /// <summary>
  /// Множественное число.
  /// </summary>
  P = 2,
  /// <summary>
  /// Множественное число для числительных на 2,3,4.
  /// </summary>
  PSpec = 3,
}
