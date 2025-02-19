# NullReferenceException in C# due to Accessing Disposed Object

This repository demonstrates a common error in C#: accessing a member of an object after it has been disposed of. The example shows how to reproduce the error and provides a solution.

## Description
The `bug.cs` file contains code that attempts to access a member of an object that may have been disposed. This results in a `NullReferenceException` if the object is null.

## Solution
The `bugSolution.cs` file provides a corrected version of the code. The corrected version checks if the object is null before accessing its members.  This prevents the exception from being thrown.

## How to run
1. Clone this repository.
2. Open the solution in Visual Studio.
3. Build and run the application.
4. Observe the output.