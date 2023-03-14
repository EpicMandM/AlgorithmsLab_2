# README
This code implements three numerical integration methods - LeftIntegral, RightIntegral, and MiddleIntegral - using the interface IIntegral.

# Installation
This is a C# code and can be compiled and run using a C# compiler.

# Usage
To use the code, you can create an instance of the integration method you want to use and call the `GetIntegral` method. The `GetIntegral` method takes four parameters:

1. `func` - the function to integrate
2. `a` - the lower limit of integration
3. `b` - the upper limit of integration
4. `n` - the number of intervals used in the integration
The GetIntegral method returns the value of the definite integral of the function func over the interval [a, b].

## Integration Methods
LeftIntegral
This method uses the left endpoint of each interval to approximate the area under the curve. It implements the IIntegral interface and the GetIntegral method.

## RightIntegral
This method uses the right endpoint of each interval to approximate the area under the curve. It implements the IIntegral interface and the GetIntegral method.

## MiddleIntegral
This method uses the midpoint of each interval to approximate the area under the curve. It implements the IIntegral interface and the GetIntegral method.
