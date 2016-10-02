let rec fib x y =
    let n = x+y
    seq { yield x
          yield! fib y n }

let s =
    (fib 1 2)
    |> Seq.take 50
    |> Seq.filter (fun x -> x < 4000000 && x > 0)

let l =
    s
    |> Seq.toList
    |> List.filter (fun x -> x % 2 = 0)
    |> List.sumBy (fun x -> x)

printfn "%A" s
printfn "%A" l
