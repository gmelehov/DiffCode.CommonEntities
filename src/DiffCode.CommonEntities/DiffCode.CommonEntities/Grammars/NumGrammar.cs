using DiffCode.CommonEntities.Cases;
using DiffCode.CommonEntities.Enums;

namespace DiffCode.CommonEntities.Grammars;

public record NumGrammar : BaseGrammar
{
  public NumGrammar(NOM nom, GEN gen, DAT dat, ACC acc, INS ins, LOC loc) : base("", nom, gen, dat, acc, ins, loc)
  {

  }




  public delegate Func<int, NumGrammar> Factory(Gender gender = Gender.M);




  public override PartOfSpeech PoS => PartOfSpeech.Unknown;


  public override NamePart NamePart => NamePart.NONE;
  
  
  public override Gender Gender { get; }
  
  
  public override Arity Arity { get; }

}