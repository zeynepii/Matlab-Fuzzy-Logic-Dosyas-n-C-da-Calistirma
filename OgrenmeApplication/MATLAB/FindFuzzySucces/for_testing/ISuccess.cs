using System;

using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
        
namespace ISuccess
{
  public interface ISuccess
  {
    #region Methods

    MWArray FindFuzzySucces();

    MWArray FindFuzzySucces(MWArray ilgi);

    MWArray FindFuzzySucces(MWArray ilgi, MWArray seviye);

    MWArray FindFuzzySucces(MWArray ilgi, MWArray seviye, MWArray sonuc);

    MWArray[] FindFuzzySucces(int numArgsOut);

    MWArray[] FindFuzzySucces(int numArgsOut, MWArray ilgi);

    MWArray[] FindFuzzySucces(int numArgsOut, MWArray ilgi, MWArray seviye);

    MWArray[] FindFuzzySucces(int numArgsOut, MWArray ilgi, MWArray seviye, MWArray 
                              sonuc);

    #endregion Methods
  }
}
