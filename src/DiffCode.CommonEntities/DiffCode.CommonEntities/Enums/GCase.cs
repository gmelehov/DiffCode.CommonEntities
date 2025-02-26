using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DiffCode.CommonEntities.Enums;

/// <summary>
/// Грамматический падеж.
/// </summary>
public enum GCase
{

  /// <summary>
  /// Именительный (Nominative)
  /// </summary>
  NOM = 0,
  /// <summary>
  /// Родительный (Genitive)
  /// </summary>
  GEN = 1,
  /// <summary>
  /// Дательный (Dative)
  /// </summary>
  DAT = 2,
  /// <summary>
  /// Винительный (Accusative)
  /// </summary>
  ACC = 3,
  /// <summary>
  /// Творительный (Instrumental)
  /// </summary>
  INS = 4,
  /// <summary>
  /// Предложный (Locative)
  /// </summary>
  LOC = 5

}
