let odds n =
    seq {2..n-1}

let isPrime n =
    Seq.forall(fun x -> n % x <> 0) (odds n)

let l =
    Seq.initInfinite(fun index -> index + 2)
    |> Seq.filter(fun n -> (isPrime n))

printfn "%A" (Seq.item 10000 l)
