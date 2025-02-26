using DiffCode.CommonEntities.Cases;
using DiffCode.CommonEntities.Enums;
using System.Diagnostics;

namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// Базовая модель грамматики для указанной части речи/части полного имени, грамматического рода
/// в указанном числе, для указанных грамматических падежей.
/// </summary>
[DebuggerDisplay("{PoS}-{NamePart}-{Gender}: {End}")]
public abstract record BaseGrammar
{
  protected BaseGrammar(string end, NOM nom, GEN gen, DAT dat, ACC acc, INS ins, LOC loc)
  {
    End = end;
    Cases = new List<Case>(6) { nom, gen, dat, acc, ins, loc };
  }
  protected BaseGrammar(string end, bool? isAnim, NOM nom, GEN gen, DAT dat, ACC acc, INS ins, LOC loc)
  {
    End = end;
    IsAnimate = isAnim;
    Cases = new List<Case>(6) { nom, gen, dat, acc, ins, loc };
  }





  public Case this[GCase @case] => Cases.FirstOrDefault(f => f.GCase.Equals(@case));


  public string this[string name, GCase @case] => $@"{name[..^this[GCase.NOM].Text.Length]}{this[@case].Text}";





  /// <summary>
  /// Часть речи.
  /// </summary>
  public abstract PartOfSpeech PoS { get; }

  /// <summary>
  /// Часть полного имени.
  /// </summary>
  public abstract NamePart NamePart { get; }

  /// <summary>
  /// Грамматический род.
  /// </summary>
  public abstract Gender Gender { get; }

  /// <summary>
  /// Грамматическое число.
  /// </summary>
  public abstract Arity Arity { get; }

  /// <summary>
  /// Признак одушевленности/неодушевленности.
  /// </summary>
  public bool? IsAnimate { get; }


  public string End { get; }

  /// <summary>
  /// Базовая неизменяемая часть словоформы.
  /// </summary>
  public string Root { get; init; }

  /// <summary>
  /// Список окончаний для словоформ по грамматическим падежам.
  /// </summary>
  public List<Case> Cases { get; }

}
