#I "packages/FAKE/tools"
#r "NuGet.Core.dll"
#r "FakeLib.dll"
open System
open System.IO
open Fake 

let buildFile = "src/test.fsproj"

Target "Clean" (fun _ ->
    CleanDirs ["bin"; "temp"]
)

Target "Build" (fun _ ->
    !! buildFile
    |> MSBuildReleaseExt "" [ ("DefineConstants", "TEST") ] "Rebuild"
    |> ignore
)

"Clean" ==> "Build"

RunTargetOrDefault "Build"