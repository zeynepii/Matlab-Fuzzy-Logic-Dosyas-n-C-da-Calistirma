/*
* MATLAB Compiler: 6.6 (R2018a)
* Date: Fri Sep 24 14:02:05 2021
* Arguments:
* "-B""macro_default""-W""dotnet:Success,Success,4.0,private,remote""-T""link:lib""-d""C:\
* Users\Zeynep\source\repos\OgrenmeApplication\MATLAB\FindFuzzySucces\for_testing""-v""cla
* ss{Success:C:\Users\Zeynep\source\repos\OgrenmeApplication\MATLAB\FindFuzzySucces.m}""-a
* ""C:\Users\Zeynep\source\repos\OgrenmeApp\MATLAB\app.fis"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using ISuccess;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace Success
{

  /// <summary>
  /// The Success class provides a CLS compliant, MWArray interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\Zeynep\source\repos\OgrenmeApplication\MATLAB\FindFuzzySucces.m
  /// </summary>
  /// <remarks>
  /// @Version 4.0
  /// </remarks>
  public class Success : MarshalByRefObject, ISuccess.ISuccess, IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static Success()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "Success.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Success class.
    /// </summary>
    public Success()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Success()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the FindFuzzySucces MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNT?TLED2 Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray FindFuzzySucces()
    {
      return mcr.EvaluateFunction("FindFuzzySucces", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the FindFuzzySucces MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNT?TLED2 Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="ilgi">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray FindFuzzySucces(MWArray ilgi)
    {
      return mcr.EvaluateFunction("FindFuzzySucces", ilgi);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the FindFuzzySucces MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNT?TLED2 Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="ilgi">Input argument #1</param>
    /// <param name="seviye">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray FindFuzzySucces(MWArray ilgi, MWArray seviye)
    {
      return mcr.EvaluateFunction("FindFuzzySucces", ilgi, seviye);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the FindFuzzySucces MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNT?TLED2 Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="ilgi">Input argument #1</param>
    /// <param name="seviye">Input argument #2</param>
    /// <param name="sonuc">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray FindFuzzySucces(MWArray ilgi, MWArray seviye, MWArray sonuc)
    {
      return mcr.EvaluateFunction("FindFuzzySucces", ilgi, seviye, sonuc);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the FindFuzzySucces MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNT?TLED2 Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] FindFuzzySucces(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "FindFuzzySucces", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the FindFuzzySucces MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNT?TLED2 Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="ilgi">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] FindFuzzySucces(int numArgsOut, MWArray ilgi)
    {
      return mcr.EvaluateFunction(numArgsOut, "FindFuzzySucces", ilgi);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the FindFuzzySucces MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNT?TLED2 Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="ilgi">Input argument #1</param>
    /// <param name="seviye">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] FindFuzzySucces(int numArgsOut, MWArray ilgi, MWArray seviye)
    {
      return mcr.EvaluateFunction(numArgsOut, "FindFuzzySucces", ilgi, seviye);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the FindFuzzySucces MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNT?TLED2 Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="ilgi">Input argument #1</param>
    /// <param name="seviye">Input argument #2</param>
    /// <param name="sonuc">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] FindFuzzySucces(int numArgsOut, MWArray ilgi, MWArray seviye, 
                               MWArray sonuc)
    {
      return mcr.EvaluateFunction(numArgsOut, "FindFuzzySucces", ilgi, seviye, sonuc);
    }


    /// <summary>
    /// Provides an interface for the FindFuzzySucces function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// UNT?TLED2 Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void FindFuzzySucces(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("FindFuzzySucces", numArgsOut, ref argsOut, argsIn);
    }



    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
