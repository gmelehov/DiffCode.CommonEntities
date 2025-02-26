using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffCode.CommonEntities.Sources;

class Authorities
{


  public static List<string> Nouns => 
  [
    "устав",
    "доверенность",
    "распоряжение",
    "приказ"
  ];


  public static List<string> Patterns =>
  [
    @"устав|доверенность|приказ|распоряжение"
  ];




}
