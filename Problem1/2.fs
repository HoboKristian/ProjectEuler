let l =
    [1..999]
    |> List.filter(fun x -> x % 3 = 0 || x % 5 = 0)
    |> List.sumBy(fun x -> x)

printfn "%A" l
