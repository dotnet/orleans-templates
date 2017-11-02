namespace Company.Grains

open Orleans
open System
open System.Threading.Tasks

// 
// In Orleans 2.0 runtime code generation was removed, so to make F# grains work
// the Solution needs to have a C# project which has a reference to the Orleans code 
// generator NuGet package and also references this class library project.
//

type Grain1() = 
    inherit Grain()

    interface IGrain1 with   // Replace grain interface

        // Add implementations of the actual interface methods.
