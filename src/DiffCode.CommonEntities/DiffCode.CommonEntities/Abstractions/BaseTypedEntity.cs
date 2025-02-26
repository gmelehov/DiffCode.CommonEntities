using DiffCode.CommonEntities.Cases;
using DiffCode.CommonEntities.Enums;
using DiffCode.CommonEntities.Extensions;
using DiffCode.CommonEntities.Interfaces;
using DiffCode.CommonEntities.Services;
using System.Diagnostics;

namespace DiffCode.CommonEntities.Abstractions;


public abstract record BaseTypedEntity : INamedWithGrammarCases, IWithSymbol
{
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  protected List<Case> _cases = new List<Case>(6);

  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  protected Func<string> _nameFunc;

  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  protected Func<string, IEnumerable<BaseGrammar>> _grammars;



  protected BaseTypedEntity(Func<string, IEnumerable<BaseGrammar>> grammarsFunc, Func<string> func)
  {
    _grammars = grammarsFunc;
    _nameFunc = func;
  }



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  /// <param name="gCase"></param>
  /// <returns></returns>
  public string GetFullForm(GCase gCase) => this[gCase];



  public virtual void AddCases(params BaseGrammar[] grammars)
  {
    _cases.Clear();

    Func<GCase, string> grammarstext = c => string.Join(" ", grammars.Select(s => !string.IsNullOrWhiteSpace(s.Root) ? s[s.Root, c].CapitalizeFirstChar() : s[c].Text));
    Func<GCase, string> remaindertext = c => grammarstext(c).Length <= Full.Length && Category != Category.UnitsName && Category != Category.DigitsName ? Full.Substring(grammarstext(GCase.NOM).Length) : "";

    _cases.AddRange(
      new NOM($"{grammarstext(GCase.NOM)}{remaindertext(GCase.NOM)}"),
      new GEN($"{grammarstext(GCase.GEN)}{remaindertext(GCase.GEN)}"),
      new DAT($"{grammarstext(GCase.DAT)}{remaindertext(GCase.DAT)}"),
      new ACC($"{grammarstext(GCase.ACC)}{remaindertext(GCase.ACC)}"),
      new INS($"{grammarstext(GCase.INS)}{remaindertext(GCase.INS)}"),
      new LOC($"{grammarstext(GCase.LOC)}{remaindertext(GCase.LOC)}")
      );
  }



  public string this[GCase gCase] => Cases.FirstOrDefault(f => f.GCase.Equals(gCase))?.Text ?? Full;



  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public string Full => _nameFunc?.Invoke();

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public abstract string Short { get; }

  /// <summary>
  /// <inheritdoc/>
  /// </summary>
  public abstract string Symbol { get; }

  /// <summary>
  /// Категория сущности.
  /// </summary>
  public abstract Category Category { get; }

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

}
