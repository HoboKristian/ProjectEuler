let nextNumber n = if n % 2L = 0L then n / 2L else n*3L + 1L

let rec iterate n=
    seq {
        yield n
        match n <> 1L with
        | true -> yield! iterate (nextNumber n)
        | false -> None |> ignore }

let nums = [1L..100L]
let m =
    nums
    |> Seq.maxBy (fun index -> Seq.length (iterate index))

printfn "%A" m
