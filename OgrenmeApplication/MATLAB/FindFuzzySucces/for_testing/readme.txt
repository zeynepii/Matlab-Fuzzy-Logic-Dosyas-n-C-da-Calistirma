Success MATLAB .NET Assembly (.NET Component)

1. Prerequisites for Deployment 

Verify that version 9.4 (R2018a) of the MATLAB Runtime is installed.   
If not, you can run the MATLAB Runtime installer.
To find its location, enter
  
    >>mcrinstaller
      
at the MATLAB prompt.
NOTE: You will need administrator rights to run the MATLAB Runtime installer. 

Alternatively, download and install the Windows version of the MATLAB Runtime for R2018a 
from the following link on the MathWorks website:

    http://www.mathworks.com/products/compiler/mcr/index.html
   
For more information about the MATLAB Runtime and the MATLAB Runtime installer, see 
Package and Distribute in the MATLAB Compiler SDK documentation  
in the MathWorks Documentation Center.

2. Files to Deploy and Package

-Success.dll
   -contains the generated component using MWArray API, which can be 
    used locally or within a remoting server.
-ISuccess.dll
   -contains the generated component interface using MWArray API, which 
    can be used within a remoting client.
-SuccessNative.dll
   -contains the generated component using native API, which can be 
    used locally or within a remoting server.
-ISuccessNative.dll
   -contains the generated component interface using native API, which 
    can be used within a remoting client.
-This readme file

-- If you are installing a remote component using the native API, the  
  client machine does not need the MATLAB Runtime.

-- For remotable components, both the client and the server must make 
  use of the same API (either MWArray API or native API).  
    Note: if end users are unable to download the MATLAB Runtime using the
    instructions in the previous section, include it when building your 
    component by clicking the "Runtime included in package" link in the
    Deployment Tool.
  A client machine using the native API does not need the MATLAB Runtime.


Auto-generated Documentation Templates:

MWArray.xml - This file contains the code comments for the MWArray data conversion 
              classes and their methods. This file can be found in either the component 
              distrib directory or in
              <mcr_root>*\toolbox\dotnetbuilder\bin\win64\v4.0

Success_overview.html - HTML overview documentation file for the generated component. It 
                        contains the requirements for accessing the component and for 
                        generating arguments using the MWArray class hierarchy.

Success.xml - This file contains the code comments for the Success component classes and 
                        methods. Using a third party documentation tool, this file can be 
                        combined with either or both of the previous files to generate 
                        online documentation for the Success component.


3. Resources

To learn more about:               See:
===================================================================
MWArray classes                    <matlab_root>*\help\toolbox\
                                   dotnetbuilder\MWArrayAPI\
                                   MWArrayAPI.chm  
Examples of .NET Web Applications  Web Deployment in the MATLAB   
                                   .NET Assembly documentation in the  
                                   MathWorks Documentation Center


4. Definitions

For information on deployment terminology, go to
http://www.mathworks.com/help and select MATLAB Compiler >
Getting Started > About Application Deployment >
Deployment Product Terms in the MathWorks Documentation
Center.

* NOTE: <mcr_root> is the directory where the MATLAB Runtime is installed on the target 
        machine.
        <matlab_root> is the directory where MATLAB is installed on the target machine.

