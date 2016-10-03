let numsSeq f t =
    seq {
        for x in f..t do
            for y in f..t do
                yield (x*y) }

let rec split s =
    let n = s / 10
    if n = 0 then
        seq {
            yield (s - n * 10) }
    else
        seq {
            yield! split n
            yield (s - n * 10) }

let palindromes f t=
    numsSeq f t
    |> Seq.filter
        (fun x ->
            let reg = Seq.toList (split x)
            let reversed = List.rev reg
            reg = reversed )

let result =
    palindromes 101 999
    |> Seq.toList
    |> List.max

printfn "%A" result
