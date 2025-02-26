namespace DiffCode.CommonEntities.Interfaces;

/// <summary>
/// Интерфейс объекта, имеющего символ.
/// </summary>
public interface IWithSymbol : INamed
{

  /// <summary>
  /// Символ.
  /// </summary>
  string Symbol { get; }

}