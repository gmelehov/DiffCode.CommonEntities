﻿using DiffCode.CommonEntities.Cases;
using DiffCode.CommonEntities.Enums;

namespace DiffCode.CommonEntities.Grammars;

/// <summary>
/// Грамматика для женского отчества.
/// </summary>
public record FMid : BaseGrammar
{
  public FMid(string end, NOM nom, GEN gen, DAT dat, ACC acc, INS ins, LOC loc) : base(end, nom, gen, dat, acc, ins, loc)
  {

  }


  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed PartOfSpeech PoS => PartOfSpeech.Noun;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed NamePart NamePart => NamePart.MID;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed Gender Gender => Gender.F;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed Arity Arity => Arity.S;
}
