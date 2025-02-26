using DiffCode.CommonEntities.Cases;
using DiffCode.CommonEntities.Enums;
using System.Diagnostics;


namespace DiffCode.CommonEntities.Abstractions;

/// <summary>
/// Базовая модель словоформы в определенном грамматическом падеже.
/// </summary>
[DebuggerDisplay("{GCase}: {Text}")]
public abstract record Case
{
  protected Case(string text) => Text = text;


  /// <summary>
  /// Грамматический падеж.
  /// </summary>
  public abstract GCase GCase { get; }

  /// <summary>
  /// Словоформа.
  /// </summary>
  public string Text { get; }






  public static NOM NOM(string text) => new NOM(text);


  public static GEN GEN(string text) => new GEN(text);

  
  public static DAT DAT(string text) => new DAT(text);


  public static ACC ACC(string text) => new ACC(text);
  
  
  public static INS INS(string text) => new INS(text);
  
  
  public static LOC LOC(string text) => new LOC(text);

}
