#r "paket:
nuget Fake.IO.FileSystem
nuget Fake.DotNet.MSBuild
nuget Fake.Core.Target
nuget Fake.DotNet.Cli //"

#if !FAKE
#load "./.fake/build.fsx/intellisense.fsx"
#r "netstandard" // Temp fix for https://github.com/dotnet/fsharp/issues/5216
#endif

open Fake.Core
open Fake.Core.TargetOperators
open Fake.IO
open Fake.IO.Globbing.Operators //enables !! and globbing
open Fake.DotNet

let solutionFile = "PaketAndFakeSample.sln"
let configuration = "Release"
let buildConfiguration = DotNet.Custom <| Environment.environVarOrDefault "configuration" configuration

// Targets
Target.create "Clean" (fun _ ->
    !! "**/**/bin/" |> Shell.cleanDirs    
    ["temp"] |> Shell.cleanDirs
)

Target.create "Build" (fun _ ->
    solutionFile 
    |> DotNet.build (fun p -> 
        { p with
            Configuration = buildConfiguration })
)

"Clean"
    ==> "Build"

// start build
Target.runOrDefaultWithArguments "Build"