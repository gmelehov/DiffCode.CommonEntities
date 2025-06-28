using DiffCode.CommonEntities;
using DiffCode.CommonEntities.Abstractions;
using DiffCode.CommonEntities.GrammarServices.Extensions;
using DiffCode.CommonEntities.Units.Currency;
using DiffCode.CommonEntities.Units.Part;
using DiffCode.CommonEntities.Units.Quantity;
using DiffCode.CommonEntities.Units.Time;
using Microsoft.Extensions.DependencyInjection;


var scoll = new ServiceCollection()
  .AddAllGrammars()
  ;

var sp = scoll.BuildServiceProvider();


var pctsFactory = sp.GetRequiredService<Percents.Factory>();
var prct = pctsFactory(12.31M);


var positionsFactory = sp.GetRequiredService<PositionName.Factory>();
var posname = positionsFactory("первый вице-президент");


var partyNamesFactory = sp.GetRequiredService<PartyName.Factory>();
var partyname = partyNamesFactory("доверитель");



var cdaysFactory = sp.GetRequiredService<CalendDays.Factory>();
var ccc = cdaysFactory(19);


var pnameFactory = sp.GetRequiredService<BasePersonName.Factory>();
var pname1 = pnameFactory("Кузязя Анатольевна Ахметова");
var pname2 = pnameFactory("Эмомназаров Файзали Хушназарович");


var currFactory = sp.GetRequiredService<Roubles.Factory>();
var currr = currFactory(682351.82M);


var instFactory = sp.GetRequiredService<Instances.Factory>();
var instances = instFactory(3);


//currr.Value += 34900;



Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");
