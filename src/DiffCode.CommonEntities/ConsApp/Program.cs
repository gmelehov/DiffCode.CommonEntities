using DiffCode.CommonEntities;
using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.Enums;
using DiffCode.CommonEntities.Grammars;
using DiffCode.CommonEntities.GrammarServices;
using DiffCode.CommonEntities.GrammarServices.Extensions;
using DiffCode.CommonEntities.Services;
using DiffCode.CommonEntities.Units.Currency;
using DiffCode.CommonEntities.Units.Part;
using DiffCode.CommonEntities.Units.Quantity;
using DiffCode.CommonEntities.Units.Time;
using Microsoft.Extensions.DependencyInjection;
using System.Data;


var scoll = new ServiceCollection()
  .AddAllGrammars()
  ;

var sp = scoll.BuildServiceProvider();

var scope = sp.GetService<IServiceScopeFactory>().CreateScope();



//var insts = new Instances(2).Build(scope);

var psrv = sp.GetRequiredService<IParserService>();
var pnSrv = sp.GetRequiredService<IPersonNameService>();

var fn = sp.GetRequiredService<Func<string, BaseGrammar>>();
var spellFunc = sp.GetRequiredService<Func<int, NumGrammar>>();


var pctsFactory = sp.GetRequiredService<Percents.Factory>();
var partsFactory = sp.GetRequiredService<BasePart.CasesFactory>();

decimal rblval = 135521.83M;
//var rbl = new Roubles().Build(scope) with { Value = rblval };

//var sp1 = spellFunc((int)rbl.WholePart);
//var sp2 = psrv.GetUnitsGrammarsFor((int)rbl.WholePart, rbl.Measure.Full);
//var sp3 = spellFunc((int)rbl.FractionalPart);
//var sp4 = psrv.GetUnitsGrammarsFor((int)rbl.FractionalPart, rbl.Measure.FrUnits.Full);

//var fullspelled = $"{sp1[GCase.GEN].Text} {sp2[0][GCase.GEN].Text} {sp3[GCase.GEN].Text} {sp4[0][GCase.GEN].Text}";

//var digitsFactory = sp.GetRequiredService<DigitsName.GrammarsFactory>();
//var digits = digitsFactory()(31, "сотая");

var prct = pctsFactory(12.31M);
var partsCases = partsFactory()(prct);


//var prct = new Percents(12.31M).Build(scope);

//var spp1 = spellFunc(prct.WholePart);
//var spp2 = psrv.ToDigitsName(prct.WholePart, "целая");
//var spp3 = spellFunc(prct.FractionalPart);
//var spp4 = psrv.ToDigitsName(prct.FractionalPart, "десятитысячная");
//var spp5 = psrv.GetUnitsGrammarsFor(prct.FractionalPart, prct.Measure.Full);

var posname = "первый вице-президент";
var partyname = "доверитель";

//var ress1 = factory.CreatePersonName("Ирина Геннадьевна Волховская");
//var ress2 = new PartyName(partyname).Build(scope);

//rbl.Value = 9352.11M;



var cdaysFactory = sp.GetRequiredService<CalendDays.Factory>();
var ccc = cdaysFactory(19);

var pnameFactory = sp.GetRequiredService<BasePersonName.Factory>();

var pname = pnameFactory("Кузязя Анатольевна Ахметова");


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

//var personName = pnSrv.GetPersonName("Ирина Геннадьевна Волховская");


//var legalname = psrv.ToLegalEntityName("Общество с ограниченной ответственностью «Общество»");
//var partyname = psrv.ToPartyName("доверительный управляющий");
//var positionname = psrv.ToPositionName("старший вице-президент");
//var authname = psrv.ToAuthorityName("Доверенность №2356 от 23 апреля 2020 г.");


//var rbl = 226.38M.Roubles();
//var grammars1 = psrv.GetUnitsGrammarsFor(rbl);
//rbl.Measure.AddCases(grammars1);
//rbl.Kopecks.Measure.AddCases(psrv.GetUnitsGrammarsFor(rbl.Kopecks));

//var cdays = 13.CalendDays();
//var grammars2 = psrv.GetUnitsGrammarsFor(cdays);
//cdays.Measure.AddCases(grammars2);

//var digitsname = psrv.ToDigitsName(rbl, "тысяча");
//var rrrr = psrv.GetSpelledValue(rbl.Value, DiffCode.CommonEntities.Enums.GCase.GEN);

//var currCasesFactory = sp.GetRequiredService<Currency.CasesFactory>();
var currFactory = sp.GetRequiredService<Roubles.Factory>();
var currr = currFactory(rblval);



var instFactory = sp.GetRequiredService<Instances.Factory>();
var instances = instFactory(3);


currr.Value += 34900;



Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");
