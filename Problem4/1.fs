let nums f t =
    seq {
        for x in f..t do
            for y in f..t do
                yield (x*y) }
    |> Seq.toList

let rec reverse ls =
    if List.length ls > 0 then
        seq {
            yield! reverse (List.tail ls)
            yield List.head ls }
    else
        Seq.empty

let r l =
    reverse l
    |> Seq.toList

let rec spl s =
    let n = s / 10
    if n = 0 then
        seq {
            yield (s - n * 10) }
    else
        seq {
            yield! spl n
            yield (s - n * 10) }

let split s =
    spl s
    |> Seq.toList

let palindromes f t=
    nums f t
    |> List.filter (fun x -> (split x) = (r (split x)))

let result =
    palindromes 101 999
    |> List.max

printfn "%A" result
