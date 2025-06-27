namespace DiffCode.CommonEntities.Services;


public interface IDeclensionService
{


  /// <summary>
  /// Возвращает грамматики для существительных и прилагательных, используемых
  /// в названиях организационно-правовых форм, соответствующие указанной строке.
  /// </summary>
  /// <param name="input">Строка с названием организационно-правовой формы.</param>
  /// <returns></returns>
  IEnumerable<BaseGrammar> GetLegalEntitiesGrammars(string input);

  /// <summary>
  /// Возвращает грамматики для существительных и прилагательных, используемых
  /// в названиях сторон-подписантов, соответствующие указанной строке.
  /// </summary>
  /// <param name="input">Строка с названием стороны-подписанта.</param>
  /// <returns></returns>
  IEnumerable<BaseGrammar> GetPartiesGrammars(string input);

  /// <summary>
  /// Возвращает грамматики для существительных и прилагательных, используемых
  /// в названиях должностей подписантов, соответствующие указанной строке.
  /// </summary>
  /// <param name="input">Строка с названием должности подписанта.</param>
  /// <returns></returns>
  IEnumerable<BaseGrammar> GetPositionsGrammars(string input);

  /// <summary>
  /// Возвращает грамматики для существительных и прилагательных, используемых
  /// в основаниях полномочий подписантов, соответствующие указанной строке.
  /// </summary>
  /// <param name="input">Строка с основанием полномочий подписанта.</param>
  /// <returns></returns>
  IEnumerable<BaseGrammar> GetAuthoritiesGrammars(string input);
  
}
