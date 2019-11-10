open Colorful
open System.Drawing
open Library

[<EntryPoint>]
let main argv =
    Console.WriteLine(Message.getNameAsJson, Color.Red)
    0 // return an integer exit code
