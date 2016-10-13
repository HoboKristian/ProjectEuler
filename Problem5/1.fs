let evenlyDivisible n denominators =
    Seq.forall (fun x -> n % x = 0) denominators

let l =
    Seq.initInfinite (fun index -> index + 1)
    |> Seq.filter (fun x ->
        let den = seq {1..20}
        (evenlyDivisible x den))

printfn "%A" (Seq.head l)
