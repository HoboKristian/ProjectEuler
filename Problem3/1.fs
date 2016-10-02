let num = 13195
let rec l n =
    [2..(n-1)]
    |> List.filter(fun x -> n % x = 0)
    |> List.filter(fun x -> List.length (l x) = 0)

printfn "%A" (List.max (l num))
