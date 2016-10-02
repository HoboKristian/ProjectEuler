// This does not currently work with the task on the website.
// The reason for this is because the number is 64bit and the current
// code only supports int32

let num = 13195
let rec l n =
    [2..(n-1)]
    |> List.filter(fun x -> n % x = 0)
    |> List.filter(fun x -> List.length (l x) = 0)

printfn "%A" (List.max (l num))
