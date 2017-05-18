[<EntryPoint>]
let main _ =
#if NETCOREAPP1_1
    printfn "NETCOREAPP1_1!"
#else
    printfn "Something else!"
#endif
    0