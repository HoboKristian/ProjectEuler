let up n=
    n / 2

let down n=
    n*3 + 1

let rec iterate n=
    if n = 1 then
        n
    elif n % 2 = 0 then
        iterate (up n)
    else
        iterate (down n)

printfn "%A" 13
printfn "%A" (iterate 13)
