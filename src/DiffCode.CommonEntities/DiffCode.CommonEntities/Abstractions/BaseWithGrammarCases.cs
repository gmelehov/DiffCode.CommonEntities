using DiffCode.CommonEntities.Cases;
using DiffCode.CommonEntities.Enums;
using DiffCode.CommonEntities.Extensions;
using System.Diagnostics;

namespace DiffCode.CommonEntities.Abstractions;

public abstract record BaseWithGrammarCases : IWithGrammarCases
{
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  protected Func<string, IEnumerable<BaseGrammar>> _grammars;




  protected BaseWithGrammarCases()
  {

  }

  protected BaseWithGrammarCases(string name)
  {
    Full = name;
  }

  protected BaseWithGrammarCases(string name, Func<string, IEnumerable<BaseGrammar>> grammars)
  {
    Full = name;
    _grammars = grammars;
  }





  /// <summary>
  /// Индексатор для получения значения в нужном грамматическом падеже.
  /// </summary>
  /// <param name="gCase"></param>
  /// <returns></returns>
  public string this[GCase gCase] => Cases.FirstOrDefault(f => f.GCase.Equals(gCase))?.Text ?? Full;


  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public string Full { get; set; }




  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public List<Case> Cases
  {
    get
    {
      var ret = new List<Case>(6);
      var grammars = _grammars?.Invoke(Full);

      Func<GCase, string> grammarstext = c => string.Join(" ", grammars.Select(s => !string.IsNullOrWhiteSpace(s.Root) ? s[s.Root, c].CapitalizeFirstChar() : s[c].Text));
      Func<GCase, string> remaindertext = c => grammarstext(c).Length <= Full.Length && Category != Category.UnitsName && Category != Category.DigitsName ? Full.Substring(grammarstext(GCase.NOM).Length) : "";
      ret.AddRange(
      new NOM($"{grammarstext(GCase.NOM)}{remaindertext(GCase.NOM)}"),
        new GEN($"{grammarstext(GCase.GEN)}{remaindertext(GCase.GEN)}"),
        new DAT($"{grammarstext(GCase.DAT)}{remaindertext(GCase.DAT)}"),
        new ACC($"{grammarstext(GCase.ACC)}{remaindertext(GCase.ACC)}"),
        new INS($"{grammarstext(GCase.INS)}{remaindertext(GCase.INS)}"),
        new LOC($"{grammarstext(GCase.LOC)}{remaindertext(GCase.LOC)}")
        );

      return ret;
    }
  }


  /// <summary>
  /// Категория сущности.
  /// </summary>
  public abstract Category Category { get; }


  public string Nom => this[GCase.NOM];
  
  public string Gen => this[GCase.GEN];

  public string Dat => this[GCase.DAT];

  public string Acc => this[GCase.ACC];

  public string Ins => this[GCase.INS];

  public string Loc => this[GCase.LOC];

}