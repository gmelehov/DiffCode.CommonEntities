﻿using DiffCode.CommonEntities.Cases;
using DiffCode.CommonEntities.Enums;

namespace DiffCode.CommonEntities.Grammars;

/// <summary>
/// Грамматика для прилагательного среднего рода единственного числа.
/// </summary>
public record NAdj : BaseGrammar
{
  public NAdj(string end, NOM nom, GEN gen, DAT dat, ACC acc, INS ins, LOC loc) : base(end, nom, gen, dat, acc, ins, loc)
  {

  }

  public NAdj(string end, bool? isAnim, NOM nom, GEN gen, DAT dat, ACC acc, INS ins, LOC loc) : base(end, isAnim, nom, gen, dat, acc, ins, loc)
  {

  }



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed PartOfSpeech PoS => PartOfSpeech.Adjective;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed NamePart NamePart => NamePart.NONE;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed Gender Gender => Gender.N;

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public override sealed Arity Arity => Arity.S;
}
