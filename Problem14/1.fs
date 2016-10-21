let nextNumber n = if n % 2L = 0L then n / 2L else n*3L + 1L

let rec iterate n=
    seq {
        if n = 1L then
            yield n
        else
            yield n
            yield! iterate (nextNumber n) }

let nums = [1L..100L]
let m =
    nums
    |> Seq.maxBy (fun index -> Seq.length (iterate index))

printfn "%A" m
