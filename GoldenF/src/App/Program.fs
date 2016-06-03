open System
open Library

[<EntryPoint>]
let main argv = 
    printfn "Hello World!"
    printfn "%A" (Thing.get 42)
    0 // return an integer exit code
