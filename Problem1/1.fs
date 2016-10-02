let l = [for i in 1..999 do
            if i % 3 = 0 || i % 5 = 0 then
                yield i]

printfn "%d" (List.sum l)
