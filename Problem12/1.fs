let divisors n =
    seq {1..n}
    |> Seq.filter (fun elem -> n % elem = 0)
    |> Seq.length

let rec triangle_number prev n =
    if divisors prev > 50 then
        printfn "%A" prev
    else
        triangle_number (prev+n) (n+1)

printfn "%A" (divisors 28)
triangle_number 0 1
