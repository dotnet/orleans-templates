namespace Company.Grains

open Orleans
open System
open System.Threading.Tasks

type Grain1() = 
    inherit Grain()

    interface IGrain1 with   // Replace grain interface

        // Add implementations of the actual interface methods.
