# NullReferenceException in C# Example

This repository demonstrates a common C# error: a `NullReferenceException`.  The error occurs when trying to access a member (property or method) of an object that is currently null. The example showcases this error and provides a solution using null checks.

## Bug Description
The `Bug.cs` file contains a class with a property and a method. When an instance of this class is not properly initialized before accessing its properties, a `NullReferenceException` is thrown.

## Solution
The `BugSolution.cs` file demonstrates a solution using a null check before accessing the `MyProperty` member to prevent this exception.