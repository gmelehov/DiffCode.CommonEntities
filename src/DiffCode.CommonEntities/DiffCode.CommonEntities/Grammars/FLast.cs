﻿using DiffCode.CommonEntities.Cases;
using DiffCode.CommonEntities.Enums;

namespace DiffCode.CommonEntities.Grammars;

/// <summary>
/// Грамматика для женской фамилии.
/// </summary>
public record FLast : BaseGrammar
{
  public FLast(string end, NOM nom, GEN gen, DAT dat, ACC acc, INS ins, LOC loc) : base(end, nom, gen, dat, acc, ins, loc)
  {

  }


  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed PartOfSpeech PoS => PartOfSpeech.Noun;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed NamePart NamePart => NamePart.LAST;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed Gender Gender => Gender.F;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed Arity Arity => Arity.S;
}
