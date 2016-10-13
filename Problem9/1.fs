let nums e =
    Seq.init e (fun index -> index + 1)

let l =
    Seq.initInfinite (fun index -> index + 1)
    |> Seq.filter (fun n ->
        Seq.init n (fun index -> index + n)
        |> Seq.exists (fun b ->
            let c = 1000 - b - n
            if b*b + n*n = c*c  then
                printfn "%d" (c*b*n)
                true
            else false))

printfn "%A" (Seq.head l)
