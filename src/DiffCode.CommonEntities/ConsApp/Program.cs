using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.GrammarServices;
using DiffCode.CommonEntities.GrammarServices.Extensions;
using DiffCode.CommonEntities.Units.Currency;
using DiffCode.CommonEntities.Units.Time;
using Microsoft.Extensions.DependencyInjection;


var scoll = new ServiceCollection()
  .AddAllGrammars()
  ;

var sp = scoll.BuildServiceProvider();

var psrv = sp.GetRequiredService<IParserService>();
var pnSrv = sp.GetRequiredService<IPersonNameService>();

var fn = sp.GetRequiredService<Func<string, BaseGrammar>>();


//var firstGrammar = new FFirst("[бвдеёжзийлмнпрстфхцчшщ]а", NOM("а"), GEN("ы"), DAT("е"), ACC("у"), INS("ой"), LOC("е"));
//var midGrammar = new FMid("[вчш]на", NOM("на"), GEN("ны"), DAT("не"), ACC("ну"), INS("ной"), LOC("не"));
//var lastGrammar = new FLast("кий", NOM("кая"), GEN("кой"), DAT("кой"), ACC("кую"), INS("кой"), LOC("кой"));

//var firstPart = new FFirstPart("Ирина") with { Grammar = firstGrammar };
//var midPart = new FMidPart(new MFirstPart("Геннадий", "Геннадьевич", "Геннадьевна"), "Геннадьевна") with { Grammar = midGrammar };
//var lastPart = new FLastPart("Волховская") with { Grammar = lastGrammar };

//var personName = new FPersonName(firstPart, midPart, lastPart);

//List<string> strings = ["Ирина", "Геннадьевна", "Волховская"];
//var rfff = strings.Select(s => new KeyValuePair<string, BasePersonNamePart>(s, psrv.FPersonNamePartGetter(s))).ToDictionary();
//var flastpart = new FLastPart(rfff.FirstOrDefault(f => f.Value is null).Key);
//flastpart = flastpart with { Grammar = psrv.GrammarForPersonNamePart(flastpart) };
//var fpersonname = new FPersonName((FFirstPart)rfff["Ирина"], (FMidPart)rfff["Геннадьевна"], flastpart);

var personName = pnSrv.GetPersonName("Ирина Геннадьевна Волховская");


//var legalname = psrv.ToLegalEntityName("Общество с ограниченной ответственностью «Общество»");
//var partyname = psrv.ToPartyName("доверительный управляющий");
//var positionname = psrv.ToPositionName("старший вице-президент");
//var authname = psrv.ToAuthorityName("Доверенность №2356 от 23 апреля 2020 г.");


var rbl = 226.38M.Roubles();
var grammars1 = psrv.GetUnitsGrammarsFor(rbl);
rbl.Measure.AddCases(grammars1);
rbl.Kopecks.Measure.AddCases(psrv.GetUnitsGrammarsFor(rbl.Kopecks));

var cdays = 13.CalendDays();
var grammars2 = psrv.GetUnitsGrammarsFor(cdays);
cdays.Measure.AddCases(grammars2);

//var digitsname = psrv.ToDigitsName(rbl, "тысяча");


var rrrr = psrv.GetSpelledValue(rbl.Value, DiffCode.CommonEntities.Enums.GCase.GEN);






Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");
