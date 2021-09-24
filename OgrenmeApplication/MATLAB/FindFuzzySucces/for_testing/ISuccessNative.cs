using System;

namespace ISuccessNative
{
  public interface ISuccessNative
  {
    #region Methods

    Object FindFuzzySucces();

    Object FindFuzzySucces(Object ilgi);

    Object FindFuzzySucces(Object ilgi, Object seviye);

    Object FindFuzzySucces(Object ilgi, Object seviye, Object sonuc);

    Object[] FindFuzzySucces(int numArgsOut);

    Object[] FindFuzzySucces(int numArgsOut, Object ilgi);

    Object[] FindFuzzySucces(int numArgsOut, Object ilgi, Object seviye);

    Object[] FindFuzzySucces(int numArgsOut, Object ilgi, Object seviye, Object sonuc);

    #endregion Methods
  }
}
