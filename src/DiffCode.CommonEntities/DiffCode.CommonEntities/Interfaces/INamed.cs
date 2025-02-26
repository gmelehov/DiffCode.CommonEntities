namespace DiffCode.CommonEntities.Interfaces;

/// <summary>
/// Интерфейс объекта, имеющего полное и сокращенное имя/название/наименование.
/// </summary>
public interface INamed
{

  /// <summary>
  /// Полная форма.
  /// </summary>
  string Full { get; }

  /// <summary>
  /// Сокращенная форма.
  /// </summary>
  string Short { get; }

}
