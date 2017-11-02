Imports Orleans
Imports System
Imports System.Threading.Tasks

Namespace Company.Grains

    ' 
    ' In Orleans 2.0 runtime code generation was removed, so to make VB grains work
    ' the Solution needs to have a C# project which has a reference to the Orleans code 
    ' generator NuGet package and also references this class library project.
    '

    Public Class Grain1
        Inherits Grain
        Implements IGrain1

    End Class

End Namespace
