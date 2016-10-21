let up n=
    n / 2L

let down n=
    n*3L + 1L

let rec iterate n=
    if n = 1L then
        seq {yield n}
    elif n % 2L = 0L then
        seq {yield n
             yield! iterate (up n)}
    else
        seq {yield n
             yield! iterate (down n)}

let nums = [1L..10000L]
let m =
    nums
    |> Seq.maxBy (fun index -> Seq.length (iterate index))

printfn "%A" m
