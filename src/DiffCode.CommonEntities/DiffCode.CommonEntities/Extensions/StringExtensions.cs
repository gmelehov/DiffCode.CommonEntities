namespace DiffCode.CommonEntities.Extensions;

public static class StringExtensions
{



  public static string CapitalizeFirstChar(this string str) => !string.IsNullOrWhiteSpace(str) ? $"{str[0].ToString().ToUpper()}{str.Substring(1)}" : str;


  public static string DecapitalizeFirstChar(this string str) => !string.IsNullOrWhiteSpace(str) ? $"{str[0].ToString().ToLower()}{str.Substring(1)}" : str;


}
